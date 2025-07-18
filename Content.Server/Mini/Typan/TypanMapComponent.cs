using Robust.Shared.GameStates;

namespace Content.Server.Shuttles.Components;

[RegisterComponent, NetworkedComponent]
public sealed partial class TypanMapComponent : Component
{
    [DataField("mapName")]
    public string MapName = "Тайпан";
}
