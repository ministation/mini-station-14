using Content.Shared._Mini.Ghost;
using Content.Shared.Zombies;

namespace Content.Server._Mini.Ghost;

/// <summary>
/// Система, динамически выдающая <see cref="GhostPanelAntagonistMarkerComponent"/>
/// Некоторые антагонисты должны начать отображаться только в определенный момент, чтобы исключить лишнюю мета-информацию для игроков
/// </summary>
public sealed class GhostPanelAntagonistMarkerPinSystem : EntitySystem
{
    public override void Initialize()
    {
        base.Initialize();

        #region Zombie

        SubscribeLocalEvent<MetaDataComponent, EntityZombifiedEvent>(OnZombify);

        #endregion



    }

    #region Zombie

    private void OnZombify(Entity<MetaDataComponent> ent, ref EntityZombifiedEvent args)
    {
        var marker = EnsureComp<GhostPanelAntagonistMarkerComponent>(ent);

        marker.Name = "ghost-panel-antagonist-zombie-name";
        marker.Description = "ghost-panel-antagonist-zombie-description";
        marker.Priority = 50;

        Dirty(ent.Owner, marker);
    }

    #endregion
}
