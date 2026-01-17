<<<<<<< HEAD:Content.Shared/Nutrition/Components/FlavorProfileComponent.cs
using Robust.Shared.GameStates;
=======
// SPDX-FileCopyrightText: 2022 Flipp Syder <76629141+vulppine@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 DrSmugleaf <DrSmugleaf@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Aiden <28298836+Aidenkrz@users.noreply.github.com>
//
// SPDX-License-Identifier: MIT

namespace Content.Server.Nutrition.Components;
>>>>>>> goob:Content.Server/Nutrition/Components/FlavorProfileComponent.cs

namespace Content.Shared.Nutrition.Components;

[RegisterComponent, NetworkedComponent]
public sealed partial class FlavorProfileComponent : Component
{
    /// <summary>
    ///     Localized string containing the base flavor of this entity.
    /// </summary>
    [DataField]
    public HashSet<string> Flavors { get; private set; } = new();

    /// <summary>
    ///     Reagent IDs to ignore when processing this flavor profile. Defaults to nutriment.
    /// </summary>
    [DataField]
    public HashSet<string> IgnoreReagents { get; private set; } = new()
    {
        "Nutriment",
        "Vitamin",
        "Protein",
    };
}