<<<<<<< HEAD
﻿using Content.Shared._CorvaxNext.Surgery.Tools;
using Content.Shared._CorvaxNext.Targeting;
using Content.Shared.Body.Components;
=======
// SPDX-FileCopyrightText: 2022 Jezithyr <Jezithyr@gmail.com>
// SPDX-FileCopyrightText: 2023 DrSmugleaf <DrSmugleaf@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 Jezithyr <jezithyr@gmail.com>
// SPDX-FileCopyrightText: 2023 Leon Friedrich <60421075+ElectroJr@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 metalgearsloth <comedian_vs_clown@hotmail.com>
// SPDX-FileCopyrightText: 2024 Aviu00 <93730715+Aviu00@users.noreply.github.com>
// SPDX-FileCopyrightText: 2024 Piras314 <p1r4s@proton.me>
// SPDX-FileCopyrightText: 2024 username <113782077+whateverusername0@users.noreply.github.com>
// SPDX-FileCopyrightText: 2024 whateverusername0 <whateveremail>
// SPDX-FileCopyrightText: 2025 Aiden <28298836+Aidenkrz@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 GoobBot <uristmchands@proton.me>
// SPDX-FileCopyrightText: 2025 Kayzel <43700376+KayzelW@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Roudenn <romabond091@gmail.com>
// SPDX-FileCopyrightText: 2025 Spatison <137375981+Spatison@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Trest <144359854+trest100@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 deltanedas <39013340+deltanedas@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 deltanedas <@deltanedas:kde.org>
// SPDX-FileCopyrightText: 2025 gluesniffler <159397573+gluesniffler@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 gluesniffler <linebarrelerenthusiast@gmail.com>
// SPDX-FileCopyrightText: 2025 gus <august.eymann@gmail.com>
// SPDX-FileCopyrightText: 2025 kurokoTurbo <92106367+kurokoTurbo@users.noreply.github.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

>>>>>>> goob
using Content.Shared.Body.Systems;
using Content.Shared.Containers.ItemSlots;
using Content.Shared.FixedPoint;
using Robust.Shared.Containers;
using Robust.Shared.GameStates;
using Robust.Shared.Serialization;
using Robust.Shared.Prototypes;

// Shitmed Change
using Content.Shared._Shitmed.Body.Part;
using Content.Shared._Shitmed.Medical.Surgery.Tools;
using Content.Shared._Shitmed.Medical.Surgery.Wounds;
using Content.Shared.Containers.ItemSlots;
using Robust.Shared.Prototypes;
namespace Content.Shared.Body.Part;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
<<<<<<< HEAD
//[Access(typeof(SharedBodySystem))]
public sealed partial class BodyPartComponent : Component, ISurgeryToolComponent
=======
//[Access(typeof(SharedBodySystem))] // goob edit - all access :godo:
public sealed partial class BodyPartComponent : Component, ISurgeryToolComponent // Shitmed Change
>>>>>>> goob
{
    // Need to set this on container changes as it may be several transform parents up the hierarchy.
    /// <summary>
    /// Parent body for this part.
    /// </summary>
    [DataField, AutoNetworkedField]
    public EntityUid? Body;

<<<<<<< HEAD
    // start-_CorvaxNext: surgery
=======
    // Shitmed Change Start

    [DataField, AutoNetworkedField]
    public BodyPartSlot? ParentSlot;

    [DataField]
    public string ToolName { get; set; } = "A body part";

    [DataField]
    public string SlotId = string.Empty;

    [DataField, AutoNetworkedField]
    public bool? Used { get; set; } = null;

    [DataField]
    public float Speed { get; set; } = 1f;

    /// <summary>
    ///     Shitmed Change: What composition does this body part classify as
    /// </summary>
    [DataField]
    public BodyPartComposition PartComposition = BodyPartComposition.Organic;

    /// <summary>
    ///     Shitmed Change: Whether this body part is enabled or not.
    /// </summary>
    [DataField, AutoNetworkedField]
    public bool Enabled = true;

    /// <summary>
    ///     Shitmed Change: Whether this body part can be enabled or not. Used for non-functional prosthetics.
    /// </summary>
    [DataField, AutoNetworkedField]
    public bool CanEnable = true;

    /// <summary>
    /// Whether this body part can attach children or not.
    /// </summary>
    [DataField]
    public bool CanAttachChildren = true;

    /// <summary>
    ///     Shitmed Change: The name of the container for this body part. Used in insertion surgeries.
    /// </summary>
    [DataField]
    public string ContainerName { get; set; } = "part_slot";

    /// <summary>
    ///     Shitmed Change: The slot for item insertion.
    /// </summary>
    [DataField, AutoNetworkedField]
    public ItemSlot ItemInsertionSlot = new();


    /// <summary>
    ///     Shitmed Change: Current species. Dictates things like body part sprites.
    /// </summary>
    [DataField, AutoNetworkedField]
    public string Species { get; set; } = "";

    /// <summary>
    ///     Shitmed Change: The ID of the base layer for this body part.
    /// </summary>
    [DataField, AutoNetworkedField]
    public string? BaseLayerId;

    /// <summary>
    ///     Shitmed Change: On what WoundableSeverity we should re-enable the part.
    /// </summary>
    [DataField, AutoNetworkedField]
    public WoundableSeverity EnableIntegrity = WoundableSeverity.Severe;

>>>>>>> goob
    [DataField, AutoNetworkedField]
    public BodyPartSlot? ParentSlot;
    // end-_CorvaxNext: surgery

    // start-_CorvaxNext: surgery
    /// <summary>
    /// Shitmed Change: Bleeding stacks to give when this body part is severed.
    /// Doubled for <see cref="IsVital"/>. parts.
    /// </summary>
    [DataField]
    public float SeverBleeding = 4f;

    // start-_CorvaxNext: surgery
    [DataField, AlwaysPushInheritance]
    public string ToolName { get; set; } = "A body part";

    [DataField, AlwaysPushInheritance]
    public string SlotId { get; set; } = "";

    [DataField, AutoNetworkedField]
    public bool? Used { get; set; } = null;

    [DataField, AlwaysPushInheritance]
    public float Speed { get; set; } = 1f;

    /// <summary>
    /// CorvaxNext Change: What's the max health this body part can have?
    /// </summary>
    [DataField]
    public float MinIntegrity;

    /// <summary>
    /// Whether this body part can be severed or not
    /// </summary>
    [DataField, AutoNetworkedField]
    public bool CanSever = true;

    /// <summary>
    ///     CorvaxNext Change: Whether this body part is enabled or not.
    /// </summary>
    [DataField, AutoNetworkedField]
    public bool Enabled = true;

    /// <summary>
    ///     CorvaxNext Change: Whether this body part can be enabled or not. Used for non-functional prosthetics.
    /// </summary>
    [DataField]
    public bool CanEnable = true;

    /// <summary>
    /// Whether this body part can attach children or not.
    /// </summary>
    [DataField]
    public bool CanAttachChildren = true;

    /// <summary>
    ///     CorvaxNext Change: How long it takes to run another self heal tick on the body part.
    /// </summary>
    [DataField]
    public float HealingTime = 30;

    /// <summary>
    ///     CorvaxNext Change: How long it has been since the last self heal tick on the body part.
    /// </summary>
    public float HealingTimer;

    /// <summary>
    ///     CorvaxNext Change: How much health to heal on the body part per tick.
    /// </summary>
    [DataField]
    public float SelfHealingAmount = 5;

    /// <summary>
    ///     CorvaxNext Change: The name of the container for this body part. Used in insertion surgeries.
    /// </summary>
    [DataField]
    public string ContainerName { get; set; } = "part_slot";

    /// <summary>
    ///     CorvaxNext Change: The slot for item insertion.
    /// </summary>
    [DataField, AutoNetworkedField]
    public ItemSlot ItemInsertionSlot = new();


    /// <summary>
    ///     CorvaxNext Change: Current species. Dictates things like body part sprites.
    /// </summary>
    [DataField, AutoNetworkedField]
    public string Species { get; set; } = "";

    /// <summary>
    ///     CorvaxNext Change: The total damage that has to be dealt to a body part
    ///     to make possible severing it.
    /// </summary>
    [DataField, AutoNetworkedField]
    public float SeverIntegrity = 90;

    /// <summary>
    ///     CorvaxNext Change: The ID of the base layer for this body part.
    /// </summary>
    [DataField, AutoNetworkedField, AlwaysPushInheritance]
    public string? BaseLayerId;

    /// <summary>
    ///     CorvaxNext Change: On what TargetIntegrity we should re-enable the part.
    /// </summary>
    [DataField, AutoNetworkedField]
    public TargetIntegrity EnableIntegrity = TargetIntegrity.ModeratelyWounded;

    [DataField, AutoNetworkedField]
    public Dictionary<TargetIntegrity, float> IntegrityThresholds = new()
    {
        { TargetIntegrity.CriticallyWounded, 75 },
        { TargetIntegrity.HeavilyWounded, 60 },
        { TargetIntegrity.ModeratelyWounded, 50 },
        { TargetIntegrity.SomewhatWounded, 35 },
        { TargetIntegrity.LightlyWounded, 20 },
        { TargetIntegrity.Healthy, 10 },
    };

    [DataField, AutoNetworkedField, AlwaysPushInheritance]
    public BodyPartType PartType = BodyPartType.Other;

<<<<<<< HEAD

    // TODO BODY Replace with a simulation of organs
    /// <summary>
    ///     Whether or not the owning <see cref="Body"/> will die if all
    ///     <see cref="BodyComponent"/>s of this type are removed from it.
    /// </summary>
    [DataField("vital"), AutoNetworkedField]
    public bool IsVital;

=======
>>>>>>> goob
    [DataField, AutoNetworkedField]
    public BodyPartSymmetry Symmetry { get; set; } = BodyPartSymmetry.None;

    /// <summary>
    ///     When attached, the part will ensure these components on the entity, and delete them on removal.
    /// </summary>
    [DataField, AlwaysPushInheritance]
    public ComponentRegistry? OnAdd;

    /// <summary>
    ///     When removed, the part will ensure these components on the entity, and add them on removal.
    /// </summary>
    [DataField, AlwaysPushInheritance]
    public ComponentRegistry? OnRemove;

    /// <summary>
    ///     When attached, the part will ensure these components on the entity, and delete them on removal.
    /// </summary>
    [DataField, AlwaysPushInheritance]
    public ComponentRegistry? OnAdd;

    /// <summary>
    ///     When removed, the part will ensure these components on the entity, and add them on removal.
    /// </summary>
    [DataField, AlwaysPushInheritance]
    public ComponentRegistry? OnRemove;

    // Shitmed Change End

    /// <summary>
    /// Child body parts attached to this body part.
    /// </summary>
    [DataField, AutoNetworkedField]
    public Dictionary<string, BodyPartSlot> Children = new();

    /// <summary>
    /// Organs attached to this body part.
    /// </summary>
    [DataField, AutoNetworkedField]
    public Dictionary<string, OrganSlot> Organs = new();

    // end-_CorvaxNext: surgery Change End

    /// <summary>
    /// These are only for VV/Debug do not use these for gameplay/systems
    /// </summary>
    [ViewVariables]
    private List<ContainerSlot> BodyPartSlotsVV
    {
        get
        {
            List<ContainerSlot> temp = new();
            var containerSystem = IoCManager.Resolve<IEntityManager>().System<SharedContainerSystem>();

            foreach (var slotId in Children.Keys)
            {
                temp.Add((ContainerSlot)containerSystem.GetContainer(Owner, SharedBodySystem.PartSlotContainerIdPrefix + slotId));
            }

            return temp;
        }
    }

    [ViewVariables]
    private List<ContainerSlot> OrganSlotsVV
    {
        get
        {
            List<ContainerSlot> temp = new();
            var containerSystem = IoCManager.Resolve<IEntityManager>().System<SharedContainerSystem>();

            foreach (var slotId in Organs.Keys)
            {
                temp.Add((ContainerSlot)containerSystem.GetContainer(Owner, SharedBodySystem.OrganSlotContainerIdPrefix + slotId));
            }

            return temp;
        }
    }
}

/// <summary>
/// Contains metadata about a body part in relation to its slot.
/// </summary>
[NetSerializable, Serializable]
[DataRecord]
public partial struct BodyPartSlot
{
    public string Id;
    public BodyPartType Type;
    public BodyPartSymmetry Symmetry; // Shitmed Change - Adds Symmetry to BodyPartSlot
    public BodyPartSlot(string id, BodyPartType type, BodyPartSymmetry symmetry)
    {
        Id = id;
        Type = type;
        Symmetry = symmetry;
    }
};

/// <summary>
/// Contains metadata about an organ part in relation to its slot.
/// </summary>
[NetSerializable, Serializable]
[DataRecord]
public partial struct OrganSlot
{
    public string Id;

    public OrganSlot(string id)
    {
        Id = id;
    }
};
