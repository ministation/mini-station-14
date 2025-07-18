using Robust.Shared.GameStates;

namespace Content.Server.Shuttles.Components;

[RegisterComponent, NetworkedComponent]
public sealed partial class TypanAccessDiskComponent : Component
{
    [DataField("description")]
    public string Description = "Содержит координаты секретной станции 'Тайпан'";
}
