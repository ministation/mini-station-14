<<<<<<< HEAD
=======
// SPDX-FileCopyrightText: 2025 Aiden <28298836+Aidenkrz@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Aviu00 <93730715+Aviu00@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Spatison <137375981+Spatison@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 gluesniffler <159397573+gluesniffler@users.noreply.github.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

>>>>>>> goob
using System.Numerics;
using Robust.Shared.Audio;
using Robust.Shared.GameStates;
using Robust.Shared.Serialization;

namespace Content.Shared._White.Blink;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class BlinkComponent : Component
{
<<<<<<< HEAD
    [DataField]
=======
    [DataField, AutoNetworkedField]
>>>>>>> goob
    public float Distance = 5f;

    [DataField, AutoNetworkedField]
    public bool IsActive = true;

    [DataField]
    public string BlinkDelay = "blink";

<<<<<<< HEAD
    [DataField]
    public TimeSpan KnockdownTime = TimeSpan.FromSeconds(0.1);
=======
    [DataField, AutoNetworkedField]
    public TimeSpan KnockdownTime = TimeSpan.Zero;

    [DataField, AutoNetworkedField]
    public float KnockdownRadius = 0.3f;
>>>>>>> goob

    [DataField]
    public SoundSpecifier BlinkSound = new SoundPathSpecifier("/Audio/Magic/blink.ogg");
}

[Serializable, NetSerializable]
public sealed class BlinkEvent(NetEntity weapon, Vector2 direction) : EntityEventArgs
{
    public readonly NetEntity Weapon = weapon;
    public readonly Vector2 Direction = direction;
<<<<<<< HEAD
}
=======
}
>>>>>>> goob
