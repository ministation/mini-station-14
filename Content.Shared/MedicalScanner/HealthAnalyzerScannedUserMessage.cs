<<<<<<< HEAD
using Content.Shared._CorvaxNext.Targeting;
using Content.Shared.Body.Components;
=======
// SPDX-FileCopyrightText: 2023 DrSmugleaf <DrSmugleaf@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 metalgearsloth <31366439+metalgearsloth@users.noreply.github.com>
// SPDX-FileCopyrightText: 2024 Rainfey <rainfey0+github@gmail.com>
// SPDX-FileCopyrightText: 2024 Saphire Lattice <lattice@saphi.re>
// SPDX-FileCopyrightText: 2024 Whisper <121047731+QuietlyWhisper@users.noreply.github.com>
// SPDX-FileCopyrightText: 2024 gluesniffler <159397573+gluesniffler@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Aiden <28298836+Aidenkrz@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 gluesniffler <linebarrelerenthusiast@gmail.com>
// SPDX-FileCopyrightText: 2025 Spatison <137375981+Spatison@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 kurokoTurbo <92106367+kurokoTurbo@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Trest <144359854+trest100@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Roudenn <romabond091@gmail.com>
// SPDX-FileCopyrightText: 2025 Kayzel <43700376+KayzelW@users.noreply.github.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

using Content.Shared._Shitmed.Medical.Surgery.Wounds; // Shitmed Change
using Content.Shared._Shitmed.Targeting; // Shitmed Change
>>>>>>> goob
using Robust.Shared.Serialization;

namespace Content.Shared.MedicalScanner;

/// <summary>
///     On interacting with an entity retrieves the entity UID for use with getting the current damage of the mob.
/// </summary>
[Serializable, NetSerializable]
public sealed class HealthAnalyzerScannedUserMessage : BoundUserInterfaceMessage
{
    public readonly NetEntity? TargetEntity;
    public float Temperature;
    public float BloodLevel;
    public bool? ScanMode;
    public bool? Bleeding;
    public bool? Unrevivable;
<<<<<<< HEAD
    public Dictionary<TargetBodyPart, TargetIntegrity>? Body; // CorvaxNext: surgery
    public NetEntity? Part; // CorvaxNext: surgery

    public HealthAnalyzerScannedUserMessage(NetEntity? targetEntity, float temperature, float bloodLevel, bool? scanMode, bool? bleeding, bool? unrevivable, Dictionary<TargetBodyPart, TargetIntegrity>? body, NetEntity? part = null)
=======
    public Dictionary<TargetBodyPart, WoundableSeverity>? Body; // Shitmed Change
    public NetEntity? Part; // Shitmed Change
    public HealthAnalyzerScannedUserMessage(NetEntity? targetEntity, float temperature, float bloodLevel, bool? scanMode, bool? bleeding, bool? unrevivable, Dictionary<TargetBodyPart, WoundableSeverity>? body, NetEntity? part = null) // Shitmed Change
>>>>>>> goob
    {
        TargetEntity = targetEntity;
        Temperature = temperature;
        BloodLevel = bloodLevel;
        ScanMode = scanMode;
        Bleeding = bleeding;
        Body = body; // Shitmed Change
        Part = part; // Shitmed Change
        Unrevivable = unrevivable;
        Body = body; // CorvaxNext: surgery
        Part = part; // CorvaxNext: surgery
    }
}

<<<<<<< HEAD
// start-_CorvaxNext: surgery
=======
// Shitmed Change Start
>>>>>>> goob
[Serializable, NetSerializable]
public sealed class HealthAnalyzerPartMessage(NetEntity? owner, TargetBodyPart? bodyPart) : BoundUserInterfaceMessage
{
    public readonly NetEntity? Owner = owner;
    public readonly TargetBodyPart? BodyPart = bodyPart;

}
<<<<<<< HEAD
// end-_CorvaxNext: surgery
=======
// Shitmed Change End
>>>>>>> goob
