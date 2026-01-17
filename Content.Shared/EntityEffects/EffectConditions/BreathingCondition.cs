<<<<<<< HEAD:Content.Shared/EntityEffects/EffectConditions/BreathingCondition.cs
using Robust.Shared.Prototypes;

namespace Content.Shared.EntityEffects.EffectConditions;
=======
using Content.Server.Body.Components;
using Content.Server.Body.Systems;
using Content.Shared.EntityEffects;
using Robust.Shared.Prototypes;

namespace Content.Server.EntityEffects.EffectConditions;
>>>>>>> goob:Content.Server/EntityEffects/EffectConditions/BreathingCondition.cs

/// <summary>
///     Condition for if the entity is successfully breathing.
/// </summary>
<<<<<<< HEAD:Content.Shared/EntityEffects/EffectConditions/BreathingCondition.cs
public sealed partial class Breathing : EventEntityEffectCondition<Breathing>
=======
public sealed partial class Breathing : EntityEffectCondition
>>>>>>> goob:Content.Server/EntityEffects/EffectConditions/BreathingCondition.cs
{
    /// <summary>
    ///     If true, the entity must not have trouble breathing to pass.
    /// </summary>
    [DataField]
    public bool IsBreathing = true;

<<<<<<< HEAD:Content.Shared/EntityEffects/EffectConditions/BreathingCondition.cs
=======
    public override bool Condition(EntityEffectBaseArgs args)
    {
        if (!args.EntityManager.TryGetComponent(args.TargetEntity, out RespiratorComponent? respiratorComp))
            return !IsBreathing; // They do not breathe.

        var breathingState = args.EntityManager.System<RespiratorSystem>().IsBreathing((args.TargetEntity, respiratorComp));
        return IsBreathing == breathingState;
    }

>>>>>>> goob:Content.Server/EntityEffects/EffectConditions/BreathingCondition.cs
    public override string GuidebookExplanation(IPrototypeManager prototype)
    {
        return Loc.GetString("reagent-effect-condition-guidebook-breathing",
                            ("isBreathing", IsBreathing));
    }
}
