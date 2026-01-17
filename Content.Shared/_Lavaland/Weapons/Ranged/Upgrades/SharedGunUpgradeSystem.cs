<<<<<<< HEAD
=======
// SPDX-FileCopyrightText: 2025 Aiden <28298836+Aidenkrz@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Aidenkrz <aiden@djkraz.com>
// SPDX-FileCopyrightText: 2025 Aineias1 <dmitri.s.kiselev@gmail.com>
// SPDX-FileCopyrightText: 2025 FaDeOkno <143940725+FaDeOkno@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 GoobBot <uristmchands@proton.me>
// SPDX-FileCopyrightText: 2025 Ilya246 <57039557+Ilya246@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 McBosserson <148172569+McBosserson@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Milon <plmilonpl@gmail.com>
// SPDX-FileCopyrightText: 2025 Misandry <mary@thughunt.ing>
// SPDX-FileCopyrightText: 2025 Piras314 <p1r4s@proton.me>
// SPDX-FileCopyrightText: 2025 Rouden <149893554+Roudenn@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 SX-7 <92227810+SX-7@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Ted Lukin <66275205+pheenty@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 TheBorzoiMustConsume <197824988+TheBorzoiMustConsume@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Unlumination <144041835+Unlumy@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 coderabbitai[bot] <136622811+coderabbitai[bot]@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 deltanedas <39013340+deltanedas@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 deltanedas <@deltanedas:kde.org>
// SPDX-FileCopyrightText: 2025 gluesniffler <159397573+gluesniffler@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 gluesniffler <linebarrelerenthusiast@gmail.com>
// SPDX-FileCopyrightText: 2025 gus <august.eymann@gmail.com>
// SPDX-FileCopyrightText: 2025 pheenty <fedorlukin2006@gmail.com>
// SPDX-FileCopyrightText: 2025 username <113782077+whateverusername0@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 whateverusername0 <whateveremail>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

>>>>>>> goob
using Content.Shared._Lavaland.Weapons.Ranged.Upgrades.Components;
using Content.Shared._Lavaland.Weapons.Ranged.Events;
using Content.Shared.CCVar;
using Content.Shared.Containers.ItemSlots;
using Content.Shared.Damage;
using Content.Shared.Examine;
using Content.Shared.Interaction;
using Content.Shared.Mobs.Components;
<<<<<<< HEAD
using Content.Shared.Popups;
using Content.Shared.Projectiles;
using Content.Shared.Tag;
using Content.Shared.Weapons.Ranged.Events;
using Content.Shared.Weapons.Ranged.Systems;
using Content.Shared.Whitelist;
using Robust.Shared.Audio.Systems;
using Robust.Shared.Containers;
using Robust.Shared.Prototypes;
using Robust.Shared.Configuration;
using System.Linq;

namespace Content.Shared._Lavaland.Weapons.Ranged.Upgrades;

public abstract partial class SharedGunUpgradeSystem : EntitySystem
=======
using Content.Shared.Projectiles;
using Content.Shared.Weapons.Ranged.Events;
using Content.Shared.Weapons.Ranged.Systems;
using Content.Shared.Whitelist;
using Robust.Shared.Configuration;
using System.Linq;
using Content.Shared._Goobstation.Weapons.Ranged;

namespace Content.Shared._Lavaland.Weapons.Ranged.Upgrades;

public abstract class SharedGunUpgradeSystem : EntitySystem
>>>>>>> goob
{
    [Dependency] private readonly SharedGunSystem _gun = default!;
    [Dependency] private readonly EntityWhitelistSystem _entityWhitelist = default!;
    [Dependency] private readonly DamageableSystem _damage = default!;
    [Dependency] private readonly ItemSlotsSystem _itemSlots = default!;
    [Dependency] private readonly IConfigurationManager _config = default!;

    /// <inheritdoc/>
    public override void Initialize()
    {
<<<<<<< HEAD
        SubscribeLocalEvent<LavalandUpgradeableGunComponent, InteractUsingEvent>(OnInteractUsing);
        SubscribeLocalEvent<LavalandUpgradeableGunComponent, ItemSlotInsertAttemptEvent>(OnItemSlotInsertAttemptEvent);
        SubscribeLocalEvent<LavalandUpgradeableGunComponent, ExaminedEvent>(OnExamine);
        SubscribeLocalEvent<LavalandUpgradeableGunComponent, MapInitEvent>(OnMapInit);
        SubscribeLocalEvent<LavalandUpgradeableGunComponent, GunRefreshModifiersEvent>(RelayEvent);
        SubscribeLocalEvent<LavalandUpgradeableGunComponent, GunShotEvent>(RelayEvent);
        SubscribeLocalEvent<LavalandUpgradeableGunComponent, ProjectileShotEvent>(RelayEvent);
        SubscribeLocalEvent<LavalandGunUpgradeComponent, ExaminedEvent>(OnUpgradeExamine);
        SubscribeLocalEvent<LavalandGunUpgradeFireRateComponent, GunRefreshModifiersEvent>(OnFireRateRefresh);
        SubscribeLocalEvent<LavalandGunComponentUpgradeComponent, GunRefreshModifiersEvent>(OnCompsRefresh);
        SubscribeLocalEvent<LavalandGunUpgradeSpeedComponent, GunRefreshModifiersEvent>(OnSpeedRefresh);
        SubscribeLocalEvent<LavalandGunUpgradeComponentsComponent, GunShotEvent>(OnDamageGunShotComps);
        SubscribeLocalEvent<LavalandGunUpgradeVampirismComponent, GunShotEvent>(OnVampirismGunShot);
        SubscribeLocalEvent<LavalandProjectileVampirismComponent, ProjectileHitEvent>(OnVampirismProjectileHit);
    }

    private void OnMapInit(EntityUid uid, LavalandUpgradeableGunComponent component, MapInitEvent args)
=======
        SubscribeLocalEvent<UpgradeableGunComponent, InteractUsingEvent>(OnInteractUsing);
        SubscribeLocalEvent<UpgradeableGunComponent, ItemSlotInsertAttemptEvent>(OnItemSlotInsertAttemptEvent);
        SubscribeLocalEvent<UpgradeableGunComponent, ExaminedEvent>(OnExamine);
        SubscribeLocalEvent<UpgradeableGunComponent, MapInitEvent>(OnMapInit);
        SubscribeLocalEvent<UpgradeableGunComponent, GunRefreshModifiersEvent>(RelayEvent);
        SubscribeLocalEvent<UpgradeableGunComponent, RechargeBasicEntityAmmoGetCooldownModifiersEvent>(RelayEvent);
        SubscribeLocalEvent<UpgradeableGunComponent, GunShotEvent>(RelayEvent);
        SubscribeLocalEvent<UpgradeableGunComponent, ProjectileShotEvent>(RelayEvent);
        SubscribeLocalEvent<GunUpgradeComponent, ExaminedEvent>(OnUpgradeExamine);
        SubscribeLocalEvent<GunUpgradeFireRateComponent, GunRefreshModifiersEvent>(OnFireRateRefresh);
        SubscribeLocalEvent<GunUpgradeFireRateComponent, RechargeBasicEntityAmmoGetCooldownModifiersEvent>(OnFireRateRefreshRecharge);
        SubscribeLocalEvent<GunComponentUpgradeComponent, GunRefreshModifiersEvent>(OnCompsRefresh);
        SubscribeLocalEvent<GunUpgradeSpeedComponent, GunRefreshModifiersEvent>(OnSpeedRefresh);
        SubscribeLocalEvent<GunUpgradeComponentsComponent, GunShotEvent>(OnDamageGunShotComps);
        SubscribeLocalEvent<GunUpgradeVampirismComponent, GunShotEvent>(OnVampirismGunShot);
        SubscribeLocalEvent<ProjectileVampirismComponent, ProjectileHitEvent>(OnVampirismProjectileHit);
    }

    private void OnMapInit(EntityUid uid, UpgradeableGunComponent component, MapInitEvent args)
>>>>>>> goob
    {
        var itemSlots = EnsureComp<ItemSlotsComponent>(uid);
        CreateNewSlot(uid, component, itemSlots);
    }

<<<<<<< HEAD
    private void CreateNewSlot(EntityUid uid, LavalandUpgradeableGunComponent component, ItemSlotsComponent? slotComp = null)
=======
    private void CreateNewSlot(EntityUid uid, UpgradeableGunComponent component, ItemSlotsComponent? slotComp = null)
>>>>>>> goob
    {
        if (!Resolve(uid, ref slotComp))
            return;

        var slotCount = slotComp.Slots.Keys.Count(slotId => slotId.StartsWith(component.UpgradesContainerId));
        var slotId = $"{component.UpgradesContainerId}-{slotCount + 1}";
        var slot = new ItemSlot
        {
            Whitelist = component.Whitelist,
            Swap = false,
            EjectOnBreak = true,
<<<<<<< HEAD
            Name = Loc.GetString("lavaland-upgradeable-gun-slot-name", ("value", slotCount + 1))
=======
            Name = Loc.GetString("upgradeable-gun-slot-name", ("value", slotCount + 1))
>>>>>>> goob
        };

        _itemSlots.AddItemSlot(uid, slotId, slot, slotComp);
    }

<<<<<<< HEAD
    private void RelayEvent<T>(Entity<LavalandUpgradeableGunComponent> ent, ref T args) where T : notnull
=======
    private void RelayEvent<T>(Entity<UpgradeableGunComponent> ent, ref T args) where T : notnull
>>>>>>> goob
    {
        foreach (var upgrade in GetCurrentUpgrades(ent))
        {
            RaiseLocalEvent(upgrade, ref args);
        }
    }

<<<<<<< HEAD
    private void OnExamine(Entity<LavalandUpgradeableGunComponent> ent, ref ExaminedEvent args)
    {
        int usedCapacity = 0;
        using (args.PushGroup(nameof(LavalandUpgradeableGunComponent)))
        {
            foreach (var upgrade in GetCurrentUpgrades(ent))
            {
                usedCapacity += upgrade.Comp.CapacityCost;

                if (upgrade.Comp.ExamineText is null)
                    continue;

                args.PushMarkup(Loc.GetString(upgrade.Comp.ExamineText));
            }
            args.PushMarkup(Loc.GetString("lavaland-upgradeable-gun-total-remaining-capacity", ("value", ent.Comp.MaxUpgradeCapacity - usedCapacity)));
        }
    }

    private void OnUpgradeExamine(Entity<LavalandGunUpgradeComponent> ent, ref ExaminedEvent args)
    {
        if (ent.Comp.ExamineText is not null)
            args.PushMarkup(Loc.GetString(ent.Comp.ExamineText));

        args.PushMarkup(Loc.GetString("lavaland-gun-upgrade-examine-text-capacity-cost", ("value", ent.Comp.CapacityCost)));
    }

    private void OnInteractUsing(Entity<LavalandUpgradeableGunComponent> ent, ref InteractUsingEvent args)
    {
        if (args.Handled
            || !HasComp<LavalandGunUpgradeComponent>(args.Used)
=======
    private void OnExamine(Entity<UpgradeableGunComponent> ent, ref ExaminedEvent args)
    {
        var usedCapacity = 0;
        using (args.PushGroup(nameof(UpgradeableGunComponent)))
        {
            foreach (var upgrade in GetCurrentUpgrades(ent))
            {
                args.PushMarkup(Loc.GetString(upgrade.Comp.ExamineText));
                usedCapacity += upgrade.Comp.CapacityCost;
            }
            args.PushMarkup(Loc.GetString("upgradeable-gun-total-remaining-capacity", ("value", ent.Comp.MaxUpgradeCapacity - usedCapacity)));
        }
    }

    private void OnUpgradeExamine(Entity<GunUpgradeComponent> ent, ref ExaminedEvent args)
    {
        args.PushMarkup(Loc.GetString(ent.Comp.ExamineText));
        args.PushMarkup(Loc.GetString("gun-upgrade-examine-text-capacity-cost", ("value", ent.Comp.CapacityCost)));
    }

    private void OnInteractUsing(Entity<UpgradeableGunComponent> ent, ref InteractUsingEvent args)
    {
        if (args.Handled
            || !HasComp<GunUpgradeComponent>(args.Used)
>>>>>>> goob
            || !TryComp<ItemSlotsComponent>(ent, out var itemSlots)
            || _entityWhitelist.IsWhitelistFail(ent.Comp.Whitelist, args.Used))
            return;

        var currentUpgrades = GetCurrentUpgrades(ent, itemSlots);

        // Create a new slot if all current slots are filled
        if (currentUpgrades.Count + 1 > itemSlots.Slots.Keys.Count(slotId =>
            slotId.StartsWith(ent.Comp.UpgradesContainerId)))
            CreateNewSlot(ent, ent.Comp);

        if (_itemSlots.TryInsertEmpty((ent.Owner, itemSlots), args.Used, args.User, true))
            _gun.RefreshModifiers(ent.Owner);

        args.Handled = true;
    }

<<<<<<< HEAD
    private void OnItemSlotInsertAttemptEvent(Entity<LavalandUpgradeableGunComponent> ent, ref ItemSlotInsertAttemptEvent args)
    {
        // TODO: Figure out how to kill the interaction verbs bypassing checks, yet also allowing
        // for non-duplicate popups to the user when they interact without having to do all of this crap twice.
        if (!TryComp<LavalandGunUpgradeComponent>(args.Item, out var upgradeComp)
=======
    private void OnItemSlotInsertAttemptEvent(Entity<UpgradeableGunComponent> ent, ref ItemSlotInsertAttemptEvent args)
    {
        // TODO: Figure out how to kill the interaction verbs bypassing checks, yet also allowing
        // for non-duplicate popups to the user when they interact without having to do all of this crap twice.
        if (!TryComp<GunUpgradeComponent>(args.Item, out var upgradeComp)
>>>>>>> goob
            || !TryComp<ItemSlotsComponent>(ent, out var itemSlots))
            return;

        var currentUpgrades = GetCurrentUpgrades(ent, itemSlots);
        var totalCapacityCost = currentUpgrades.Sum(upgrade => upgrade.Comp.CapacityCost);
        if (totalCapacityCost + upgradeComp.CapacityCost > ent.Comp.MaxUpgradeCapacity)
        {
            args.Cancelled = true;
            return;
        }

<<<<<<< HEAD
        var allowDupes = _config.GetCVar(CCVars.AllowDuplicatePkaModules);
        var itemProto = MetaData(args.Item).EntityPrototype?.ID;
        foreach (var itemSlot in itemSlots.Slots.Values)
        {
            if (itemSlot.HasItem
                && itemSlot.Item is { } existingItem
                && MetaData(existingItem).EntityPrototype?.ID == itemProto
                && !allowDupes)
            {
                args.Cancelled = true;
                break;
            }
        }
    }

    private void OnFireRateRefresh(Entity<LavalandGunUpgradeFireRateComponent> ent, ref GunRefreshModifiersEvent args)
    {
        args.FireRate *= ent.Comp.Coefficient;
    }

    private void OnCompsRefresh(Entity<LavalandGunComponentUpgradeComponent> ent, ref GunRefreshModifiersEvent args)
=======
        var allowDupes = _config.GetCVar(CCVars.AllowDuplicatePkaModules) && !upgradeComp.Unique;
        var itemProto = MetaData(args.Item).EntityPrototype?.ID;
        foreach (var itemSlot in itemSlots.Slots.Values)
        {
            if (itemSlot is not { HasItem: true, Item: { } existingItem }
                || MetaData(existingItem).EntityPrototype?.ID != itemProto
                || allowDupes)
                continue;

            args.Cancelled = true;
            break;
        }
    }

    private void OnFireRateRefresh(Entity<GunUpgradeFireRateComponent> ent, ref GunRefreshModifiersEvent args)
    {
        args.FireRate *= ent.Comp.Coefficient;
        args.BurstFireRate *= ent.Comp.Coefficient;
        args.BurstCooldown /= ent.Comp.Coefficient;
    }

    private void OnFireRateRefreshRecharge(Entity<GunUpgradeFireRateComponent> ent, ref RechargeBasicEntityAmmoGetCooldownModifiersEvent args)
    {
        args.Multiplier /= ent.Comp.Coefficient;
    }

    private void OnCompsRefresh(Entity<GunComponentUpgradeComponent> ent, ref GunRefreshModifiersEvent args)
>>>>>>> goob
    {
        EntityManager.AddComponents(args.Gun, ent.Comp.Components);
    }

<<<<<<< HEAD
    private void OnSpeedRefresh(Entity<LavalandGunUpgradeSpeedComponent> ent, ref GunRefreshModifiersEvent args)
=======
    private void OnSpeedRefresh(Entity<GunUpgradeSpeedComponent> ent, ref GunRefreshModifiersEvent args)
>>>>>>> goob
    {
        args.ProjectileSpeed *= ent.Comp.Coefficient;
    }

<<<<<<< HEAD
    private void OnDamageGunShotComps(Entity<LavalandGunUpgradeComponentsComponent> ent, ref GunShotEvent args)
=======
    private void OnDamageGunShotComps(Entity<GunUpgradeComponentsComponent> ent, ref GunShotEvent args)
>>>>>>> goob
    {
        foreach (var (ammo, _) in args.Ammo)
        {
            if (HasComp<ProjectileComponent>(ammo))
                EntityManager.AddComponents(ammo.Value, ent.Comp.Components);
        }
    }

<<<<<<< HEAD
    private void OnVampirismGunShot(Entity<LavalandGunUpgradeVampirismComponent> ent, ref GunShotEvent args)
=======
    private void OnVampirismGunShot(Entity<GunUpgradeVampirismComponent> ent, ref GunShotEvent args)
>>>>>>> goob
    {
        foreach (var (ammo, _) in args.Ammo)
        {
            if (!HasComp<ProjectileComponent>(ammo))
                continue;

<<<<<<< HEAD
            var comp = EnsureComp<LavalandProjectileVampirismComponent>(ammo.Value);
=======
            var comp = EnsureComp<ProjectileVampirismComponent>(ammo.Value);
>>>>>>> goob
            comp.DamageOnHit = ent.Comp.DamageOnHit;
        }
    }

<<<<<<< HEAD
    private void OnVampirismProjectileHit(Entity<LavalandProjectileVampirismComponent> ent, ref ProjectileHitEvent args)
=======
    private void OnVampirismProjectileHit(Entity<ProjectileVampirismComponent> ent, ref ProjectileHitEvent args)
>>>>>>> goob
    {
        if (!HasComp<MobStateComponent>(args.Target))
            return;
        _damage.TryChangeDamage(args.Shooter, ent.Comp.DamageOnHit);
    }

<<<<<<< HEAD
    public HashSet<Entity<LavalandGunUpgradeComponent>> GetCurrentUpgrades(Entity<LavalandUpgradeableGunComponent> ent, ItemSlotsComponent? itemSlots = null)
    {
        if (!Resolve(ent, ref itemSlots))
            return new HashSet<Entity<LavalandGunUpgradeComponent>>();

        var upgrades = new HashSet<Entity<LavalandGunUpgradeComponent>>();

        foreach (var itemSlot in itemSlots.Slots.Values)
        {
            if (itemSlot.HasItem
                && itemSlot.Item is { } item
                && TryComp<LavalandGunUpgradeComponent>(item, out var upgradeComp))
=======
    public HashSet<Entity<GunUpgradeComponent>> GetCurrentUpgrades(Entity<UpgradeableGunComponent> ent, ItemSlotsComponent? itemSlots = null)
    {
        if (!Resolve(ent, ref itemSlots))
            return [];

        var upgrades = new HashSet<Entity<GunUpgradeComponent>>();

        foreach (var itemSlot in itemSlots.Slots.Values)
        {
            if (itemSlot is { HasItem: true, Item: { } item }
                && TryComp<GunUpgradeComponent>(item, out var upgradeComp))
>>>>>>> goob
                upgrades.Add((item, upgradeComp));
        }

        return upgrades;
    }
<<<<<<< HEAD

    public IEnumerable<ProtoId<TagPrototype>> GetCurrentUpgradeTags(Entity<LavalandUpgradeableGunComponent> ent)
    {
        foreach (var upgrade in GetCurrentUpgrades(ent))
        {
            foreach (var tag in upgrade.Comp.Tags)
            {
                yield return tag;
            }
        }
    }
=======
>>>>>>> goob
}
