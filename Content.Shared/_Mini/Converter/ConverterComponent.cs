using Robust.Shared.Audio;

namespace Content.Shared._Mini.Converter;

[RegisterComponent]
public sealed partial class ConverterComponent : Component
{
    [DataField]
    public SoundSpecifier? InsertSound = new SoundPathSpecifier("/Audio/_Mini/Misc/convert.ogg");
}
