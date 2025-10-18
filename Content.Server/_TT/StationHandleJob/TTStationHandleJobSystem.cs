using Content.Server.GameTicking;
using Content.Server.Shuttles.Systems;
using Content.Server.Spawners.Components;
using Content.Server.Spawners.EntitySystems;
using Content.Server.Station.Systems;
using Content.Shared.Roles;
using Robust.Server.Containers;
using Robust.Shared.Containers;
using Robust.Shared.Map;
using Robust.Shared.Prototypes;
using Robust.Shared.Random;

namespace Content.Server._TT.StationHandleJob;

public sealed class TTStationHandleJobSystem : EntitySystem
{
    [Dependency] private readonly IRobustRandom _random = default!;
    [Dependency] private readonly GameTicker _gameTicker = default!;
    [Dependency] private readonly StationSpawningSystem _stationSpawning = default!;
    [Dependency] private readonly StationSystem _station = default!;
    [Dependency] private readonly ContainerSystem _container = default!;

    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<PlayerSpawningEvent>(OnPlayerSpawning, before: [typeof(ArrivalsSystem), typeof(ContainerSpawnPointSystem), typeof(SpawnPointSystem)]);
    }

  private void OnPlayerSpawning(PlayerSpawningEvent ev)
    {
        if (ev.SpawnResult is not null)
        {
            Log.Error("The spawn result has already been received");
            return;
        }

        if (ev.Job is not { } job)
        {
            Log.Debug("The job does not exist");
            return;
        }

        if (GetStation(job) is not {} stationUid)
            return;

        var query = EntityQueryEnumerator<SpawnPointComponent, TransformComponent>();
        var possiblePositions = new List<EntityCoordinates>();

        while (query.MoveNext(out var uid, out var spawnPoint, out var xform))
        {
            if (_station.GetOwningStation(uid, xform) != stationUid)
                continue;

            if (spawnPoint.Job != job)
                continue;

            if (_gameTicker.RunLevel == GameRunLevel.InRound && spawnPoint.SpawnType == SpawnPointType.LateJoin)
                possiblePositions.Add(xform.Coordinates);

            if (_gameTicker.RunLevel != GameRunLevel.InRound && spawnPoint.SpawnType == SpawnPointType.Job)
                possiblePositions.Add(xform.Coordinates);
        }

        if (possiblePositions.Count == 0)
        {
            Log.Error("No spawn points found for role spawn");
            return;
        }

        var spawnLoc = _random.Pick(possiblePositions);
        ev.SpawnResult = _stationSpawning.SpawnPlayerMob(
            spawnLoc,
            job,
            ev.HumanoidCharacterProfile,
            stationUid);
    }

    private EntityUid? GetStation(ProtoId<JobPrototype> job)
    {
        var query = EntityQueryEnumerator<TTStationHandleJobComponent>();
        while (query.MoveNext(out var uid, out var component))
        {
            if (!component.Jobs.Contains(job))
                continue;

            return uid;
        }

        return null;
    }
}
