using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype.Array;
using Robust.Shared.Utility;

namespace Content.Shared.Silicons.StationAi;

/// <summary>
/// Holds data for customizing the appearance of station AIs.
/// </summary>
[Prototype]
public sealed partial class StationAiCustomizationPrototype : IPrototype, IInheritingPrototype
{
    [IdDataField]
<<<<<<< HEAD
    public string ID { get; } = string.Empty;
=======
    public string ID { get; private set; } = string.Empty;
>>>>>>> goob

    /// <summary>
    /// The (unlocalized) name of the customization.
    /// </summary>
    [DataField(required: true)]
    public LocId Name;

    /// <summary>
    /// Stores the data which is used to modify the appearance of the station AI.
    /// </summary>
    [DataField(required: true)]
    public Dictionary<string, PrototypeLayerData> LayerData = new();

    /// <summary>
    /// Key used to index the prototype layer data and extract a preview of the customization (for menus, etc)
    /// </summary>
    [DataField]
    public string PreviewKey = string.Empty;

    /// <summary>
    /// Specifies a background to use for previewing the customization (for menus, etc)
    /// </summary>
    [DataField]
    public SpriteSpecifier? PreviewBackground;

    /// <summary>
    /// The prototype we inherit from.
    /// </summary>
    [ViewVariables]
    [ParentDataFieldAttribute(typeof(AbstractPrototypeIdArraySerializer<StationAiCustomizationPrototype>))]
<<<<<<< HEAD
    public string[]? Parents { get; }
=======
    public string[]? Parents { get; private set; }
>>>>>>> goob

    /// <summary>
    /// Specifies whether the prototype is abstract.
    /// </summary>
    [ViewVariables]
    [NeverPushInheritance]
    [AbstractDataField]
<<<<<<< HEAD
    public bool Abstract { get; }
=======
    public bool Abstract { get; private set; }
>>>>>>> goob
}
