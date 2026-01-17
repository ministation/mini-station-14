using Content.Shared.Body.Components;
<<<<<<< HEAD:Content.Shared/EntityEffects/EffectConditions/InternalsCondition.cs
using Robust.Shared.Prototypes;

namespace Content.Shared.EntityEffects.EffectConditions;
=======
using Content.Shared.EntityEffects;
using Robust.Shared.Prototypes;

namespace Content.Server.EntityEffects.EffectConditions;
>>>>>>> goob:Content.Server/EntityEffects/EffectConditions/InternalsCondition.cs

/// <summary>
///     Condition for if the entity is or isn't wearing internals.
/// </summary>
public sealed partial class Internals : EntityEffectCondition
{
    /// <summary>
    ///     To pass, the entity's internals must have this same state.
    /// </summary>
    [DataField]
    public bool UsingInternals = true;

    public override bool Condition(EntityEffectBaseArgs args)
    {
        if (!args.EntityManager.TryGetComponent(args.TargetEntity, out InternalsComponent? internalsComp))
            return !UsingInternals; // They have no internals to wear.

<<<<<<< HEAD:Content.Shared/EntityEffects/EffectConditions/InternalsCondition.cs
        var internalsState = internalsComp.GasTankEntity == null;
=======
        var internalsState = internalsComp.GasTankEntity != null; // If gas tank is not null, they are wearing internals
>>>>>>> goob:Content.Server/EntityEffects/EffectConditions/InternalsCondition.cs
        return UsingInternals == internalsState;
    }

    public override string GuidebookExplanation(IPrototypeManager prototype)
    {
        return Loc.GetString("reagent-effect-condition-guidebook-internals", ("usingInternals", UsingInternals));
    }
}
