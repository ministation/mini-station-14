using Robust.Shared.Configuration;
using Content.Shared.Atmos;
using Robust.Shared;

namespace Content.Shared.ADT.CCVar;

[CVarDefs]
public sealed class ADTCCVars
{

    /// <summary>
    /// Кол-во предыдущих карт, которые будут исключены из голосования.
    /// </summary>
    public static readonly CVarDef<int> MapVoteRecentBanDepth =
        CVarDef.Create("game.map_vote_recent_ban_depth", 3, CVar.SERVER | CVar.ARCHIVE);
}

