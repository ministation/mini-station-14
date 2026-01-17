<<<<<<< HEAD
=======
// SPDX-FileCopyrightText: 2025 Aiden <28298836+Aidenkrz@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Aidenkrz <aiden@djkraz.com>
// SPDX-FileCopyrightText: 2025 Aineias1 <dmitri.s.kiselev@gmail.com>
// SPDX-FileCopyrightText: 2025 FaDeOkno <143940725+FaDeOkno@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 GoobBot <uristmchands@proton.me>
// SPDX-FileCopyrightText: 2025 McBosserson <148172569+McBosserson@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Milon <plmilonpl@gmail.com>
// SPDX-FileCopyrightText: 2025 Piras314 <p1r4s@proton.me>
// SPDX-FileCopyrightText: 2025 Rouden <149893554+Roudenn@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Ted Lukin <66275205+pheenty@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 TheBorzoiMustConsume <197824988+TheBorzoiMustConsume@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Unlumination <144041835+Unlumy@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 coderabbitai[bot] <136622811+coderabbitai[bot]@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 deltanedas <39013340+deltanedas@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 deltanedas <@deltanedas:kde.org>
// SPDX-FileCopyrightText: 2025 gluesniffler <159397573+gluesniffler@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 gluesniffler <linebarrelerenthusiast@gmail.com>
// SPDX-FileCopyrightText: 2025 pheenty <fedorlukin2006@gmail.com>
// SPDX-FileCopyrightText: 2025 username <113782077+whateverusername0@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 whateverusername0 <whateveremail>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

>>>>>>> goob
using Content.Server._Lavaland.Pressure;
using Content.Shared._Lavaland.Weapons.Ranged.Events;
using Content.Shared._Lavaland.Weapons.Ranged.Upgrades;
using Content.Shared._Lavaland.Weapons.Ranged.Upgrades.Components;
using Content.Shared.Projectiles;
using Content.Shared.Weapons.Ranged.Systems;
<<<<<<< HEAD
=======
using Robust.Shared.Containers;
>>>>>>> goob

namespace Content.Server._Lavaland.Weapons.Ranged.Upgrades;

public sealed class GunUpgradeSystem : SharedGunUpgradeSystem
{
    [Dependency] private readonly PressureEfficiencyChangeSystem _pressure = default!;
<<<<<<< HEAD
    private const float PelletPenalty = 0.5f; // How much of the damage boost is penalized by virtue of being a multi-projectile weapon.
=======
>>>>>>> goob
    public override void Initialize()
    {
        base.Initialize();

<<<<<<< HEAD
        SubscribeLocalEvent<LavalandGunUpgradeDamageComponent, GunShotEvent>(OnDamageGunShot);
        SubscribeLocalEvent<LavalandGunUpgradeDamageComponent, ProjectileShotEvent>(OnProjectileShot);
    }

    private void OnDamageGunShot(Entity<LavalandGunUpgradeDamageComponent> ent, ref GunShotEvent args)
=======
        SubscribeLocalEvent<GunUpgradeDamageComponent, GunShotEvent>(OnDamageGunShot);
        SubscribeLocalEvent<GunUpgradeDamageComponent, ProjectileShotEvent>(OnProjectileShot);
        SubscribeLocalEvent<GunUpgradePressureComponent, EntGotInsertedIntoContainerMessage>(OnPressureUpgradeInserted);
        SubscribeLocalEvent<GunUpgradePressureComponent, EntGotRemovedFromContainerMessage>(OnPressureUpgradeRemoved);
    }

    private void OnDamageGunShot(Entity<GunUpgradeDamageComponent> ent, ref GunShotEvent args)
>>>>>>> goob
    {
        foreach (var (ammo, _) in args.Ammo)
        {
            var multiplier = 1f;

            if (TryComp<PressureDamageChangeComponent>(Transform(ent).ParentUid, out var pressure)
<<<<<<< HEAD
                && _pressure.ApplyModifier((Transform(ent).ParentUid, pressure)))
=======
                && _pressure.ApplyModifier((Transform(ent).ParentUid, pressure))
                && pressure.ApplyToProjectiles)
>>>>>>> goob
                multiplier = pressure.AppliedModifier;

            if (TryComp<ProjectileComponent>(ammo, out var proj))
                proj.Damage += ent.Comp.Damage * multiplier;
        }
    }

<<<<<<< HEAD
    private void OnProjectileShot(Entity<LavalandGunUpgradeDamageComponent> ent, ref ProjectileShotEvent args)
=======
    private void OnProjectileShot(Entity<GunUpgradeDamageComponent> ent, ref ProjectileShotEvent args)
>>>>>>> goob
    {
        if (!TryComp<ProjectileComponent>(args.FiredProjectile, out var projectile))
            return;

        var multiplier = 1f;

        if (TryComp<PressureDamageChangeComponent>(Transform(ent).ParentUid, out var pressure)
<<<<<<< HEAD
            && _pressure.ApplyModifier((Transform(ent).ParentUid, pressure)))
            multiplier = pressure.AppliedModifier;

        projectile.Damage += ent.Comp.Damage * multiplier * PelletPenalty;
    }

=======
            && _pressure.ApplyModifier((Transform(ent).ParentUid, pressure))
            && pressure.ApplyToProjectiles)
            multiplier = pressure.AppliedModifier;

        projectile.Damage += ent.Comp.Damage * multiplier * ent.Comp.PelletModifier;
    }

    private void OnPressureUpgradeInserted(Entity<GunUpgradePressureComponent> ent, ref EntGotInsertedIntoContainerMessage args)
    {
        if (TryComp<PressureDamageChangeComponent>(args.Container.Owner, out var pdc))
            pdc.Enabled = false;
    }

    private void OnPressureUpgradeRemoved(Entity<GunUpgradePressureComponent> ent, ref EntGotRemovedFromContainerMessage args)
    {
        if (TryComp<PressureDamageChangeComponent>(args.Container.Owner, out var pdc))
            pdc.Enabled = true;
    }
>>>>>>> goob
}
