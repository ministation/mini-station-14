using Content.Shared.Roles;
using Robust.Shared.Prototypes;

namespace Content.Server._TT.StationHandleJob;

[RegisterComponent]
public sealed partial class TTStationHandleJobComponent : Component
{
    [DataField]
    public List<ProtoId<JobPrototype>> Jobs = new();
}
