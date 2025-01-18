using Robust.Shared.Configuration;

namespace Content.Shared._CorvaxNext.NextVars;

/// <summary>
///     Corvax modules console variables
/// </summary>
[CVarDefs]
// ReSharper disable once InconsistentNaming
public sealed class NextVars
{
    /**
    * Auto cryo sleep
    */

    public static readonly CVarDef<bool> AutoCryoSleepEnabled =
        CVarDef.Create("auto_cryo_sleep.enabled", true, CVar.SERVER);

    public static readonly CVarDef<int> AutoCryoSleepTime =
        CVarDef.Create("auto_cryo_sleep.time", 1200, CVar.SERVER);

    public static readonly CVarDef<int> AutoCryoSleepUpdateTime =
        CVarDef.Create("auto_cryo_sleep.update_time", 120, CVar.SERVER);

    /// <summary>
    /// Offer item.
    /// </summary>
    public static readonly CVarDef<bool> OfferModeIndicatorsPointShow =
        CVarDef.Create("hud.offer_mode_indicators_point_show", true, CVar.ARCHIVE | CVar.CLIENTONLY);

    /*
     * _CorvaxNext Bind Standing and Laying System
     */

    public static readonly CVarDef<bool> AutoGetUp =
        CVarDef.Create("laying.auto_get_up", true, CVar.CLIENT | CVar.ARCHIVE | CVar.REPLICATED);

    /// <summary>
    ///     When true, entities that fall to the ground will be able to crawl under tables and
    ///     plastic flaps, allowing them to take cover from gunshots.
    /// </summary>
    public static readonly CVarDef<bool> CrawlUnderTables =
        CVarDef.Create("laying.crawlundertables", false, CVar.REPLICATED);

    // public static readonly CVarDef<bool> OfferModeIndicatorsPointShow =
    //     CVarDef.Create("hud.offer_mode_indicators_point_show", true, CVar.ARCHIVE | CVar.CLIENTONLY);
}
