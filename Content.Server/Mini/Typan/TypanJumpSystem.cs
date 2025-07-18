// Content.Server/Mini/Typan/TypanJumpSystem.cs
using Content.Server.Shuttles.Systems;
using Content.Shared.Shuttles.Components;

namespace Content.Server.Mini.Typan;

public sealed class TypanJumpSystem : EntitySystem
{
    [Dependency] private readonly ShuttleSystem _shuttle = default!;

    public override void Initialize()
    {
        base.Initialize();
        SubscribeLocalEvent<TypanMapComponent, FTLAttemptEvent>(OnFTLAttempt);
    }

    private void OnFTLAttempt(EntityUid uid, TypanMapComponent comp, ref FTLAttemptEvent args)
    {
        if (args.Cancelled)
            return;

        var hasDisk = false;
        var query = EntityQueryEnumerator<TypanAccessDiskComponent, TransformComponent>();

        while (query.MoveNext(out _, out var xform))
        {
            if (xform.GridUid == args.Shuttle)
            {
                hasDisk = true;
                break;
            }
        }

        if (!hasDisk)
        {
            args.Cancelled = true;
            args.Reason = Loc.GetString("typan-access-denied");
        }
    }
}
