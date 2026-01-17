// SPDX-FileCopyrightText: 2021 20kdc <asdd2808@gmail.com>
// SPDX-FileCopyrightText: 2021 Vera Aguilera Puerto <gradientvera@outlook.com>
// SPDX-FileCopyrightText: 2022 Jezithyr <Jezithyr@gmail.com>
// SPDX-FileCopyrightText: 2022 mirrorcult <lunarautomaton6@gmail.com>
// SPDX-FileCopyrightText: 2022 wrexbe <81056464+wrexbe@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 DrSmugleaf <DrSmugleaf@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 Jezithyr <jezithyr@gmail.com>
// SPDX-FileCopyrightText: 2023 Leon Friedrich <60421075+ElectroJr@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 Nemanja <98561806+EmoGarbage404@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 ShadowCommander <10494922+ShadowCommander@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 metalgearsloth <31366439+metalgearsloth@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 metalgearsloth <comedian_vs_clown@hotmail.com>
// SPDX-FileCopyrightText: 2024 0x6273 <0x40@keemail.me>
// SPDX-FileCopyrightText: 2024 Krunklehorn <42424291+Krunklehorn@users.noreply.github.com>
// SPDX-FileCopyrightText: 2024 Piras314 <p1r4s@proton.me>
// SPDX-FileCopyrightText: 2024 gluesniffler <159397573+gluesniffler@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Aiden <28298836+Aidenkrz@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 GoobBot <uristmchands@proton.me>
// SPDX-FileCopyrightText: 2025 gluesniffler <linebarrelerenthusiast@gmail.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

using Content.Server.Body.Components;
using Content.Server.Ghost.Components;
using Content.Shared._CorvaxNext.Surgery.Body;
using Content.Shared.Body.Components;
using Content.Shared.Body.Systems;
using Content.Shared.Body.Events;
using Content.Server._CorvaxNext.DelayedDeath;
using Content.Shared._CorvaxNext.Surgery.Body.Organs;
using Content.Shared.Mind;
using Content.Shared.Mind.Components;
using Content.Shared.Pointing;

// Shitmed Change
using Content.Shared._Shitmed.Body.Organ;
using Content.Shared.Body.Systems;
using Content.Goobstation.Shared.Changeling.Components;


namespace Content.Server.Body.Systems
{
    public sealed class BrainSystem : EntitySystem
    {
        [Dependency] private readonly SharedMindSystem _mindSystem = default!;
<<<<<<< HEAD
        [Dependency] private readonly SharedBodySystem _bodySystem = default!;

=======
        [Dependency] private readonly SharedBodySystem _bodySystem = default!; // Shitmed Change
>>>>>>> goob
        public override void Initialize()
        {
            base.Initialize();

            SubscribeLocalEvent<BrainComponent, OrganAddedToBodyEvent>(HandleAddition);
<<<<<<< HEAD
=======
        // Shitmed Change Start
>>>>>>> goob
            SubscribeLocalEvent<BrainComponent, OrganRemovedFromBodyEvent>(HandleRemoval);
            SubscribeLocalEvent<BrainComponent, PointAttemptEvent>(OnPointAttempt);
        }

<<<<<<< HEAD
        // start-_CorvaxNext: surgery
        private void HandleRemoval(EntityUid uid, BrainComponent brain, ref OrganRemovedFromBodyEvent args)
        {
            if (TerminatingOrDeleted(uid) || TerminatingOrDeleted(args.OldBody))
=======
        private void HandleRemoval(EntityUid uid, BrainComponent brain, ref OrganRemovedFromBodyEvent args)
        {
            if (TerminatingOrDeleted(uid)
                || TerminatingOrDeleted(args.OldBody)
                || HasComp<ChangelingIdentityComponent>(args.OldBody))
>>>>>>> goob
                return;

            brain.Active = false;
            if (!CheckOtherBrains(args.OldBody))
            {
                // Prevents revival, should kill the user within a given timespan too.
                EnsureComp<DebrainedComponent>(args.OldBody);
<<<<<<< HEAD
                EnsureComp<DelayedDeathComponent>(args.OldBody);
=======
>>>>>>> goob
                HandleMind(uid, args.OldBody);
            }
        }

        private void HandleAddition(EntityUid uid, BrainComponent brain, ref OrganAddedToBodyEvent args)
        {
<<<<<<< HEAD
            if (TerminatingOrDeleted(uid) || TerminatingOrDeleted(args.Body))
=======
            if (TerminatingOrDeleted(uid)
                || TerminatingOrDeleted(args.Body)
                || HasComp<ChangelingIdentityComponent>(args.Body))
>>>>>>> goob
                return;

            if (!CheckOtherBrains(args.Body))
            {
                RemComp<DebrainedComponent>(args.Body);
<<<<<<< HEAD
                if (_bodySystem.TryGetBodyOrganEntityComps<HeartComponent>(args.Body, out var _))
                    RemComp<DelayedDeathComponent>(args.Body);
                HandleMind(args.Body, uid);
            }
        }
        // end-_CorvaxNext: surgery

        // CorvaxNext: surgery
=======
                HandleMind(args.Body, uid, brain);
            }
        }


>>>>>>> goob
        private void HandleMind(EntityUid newEntity, EntityUid oldEntity, BrainComponent? brain = null)
        {
            if (TerminatingOrDeleted(newEntity) || TerminatingOrDeleted(oldEntity))
                return;

            EnsureComp<MindContainerComponent>(newEntity);
            EnsureComp<MindContainerComponent>(oldEntity);

            var ghostOnMove = EnsureComp<GhostOnMoveComponent>(newEntity);
            if (HasComp<BodyComponent>(newEntity))
                ghostOnMove.MustBeDead = true;

            if (!_mindSystem.TryGetMind(oldEntity, out var mindId, out var mind))
                return;

            _mindSystem.TransferTo(mindId, newEntity, mind: mind);
<<<<<<< HEAD
            if (brain != null) // CorvaxNext: surgery
                brain.Active = true; // CorvaxNext: surgery
        }

        // start-_CorvaxNext: surgery
=======
            if (brain != null)
                brain.Active = true;
        }

>>>>>>> goob
        private bool CheckOtherBrains(EntityUid entity)
        {
            var hasOtherBrains = false;
            if (TryComp<BodyComponent>(entity, out var body))
            {
                if (TryComp<BrainComponent>(entity, out var bodyBrain))
                    hasOtherBrains = true;
                else
                {
                    foreach (var (organ, _) in _bodySystem.GetBodyOrgans(entity, body))
                    {
                        if (TryComp<BrainComponent>(organ, out var brain) && brain.Active)
                        {
                            hasOtherBrains = true;
                            break;
                        }
                    }
                }
            }

            return hasOtherBrains;
        }

<<<<<<< HEAD
        // end-_CorvaxNext: surgery
=======
        // Shitmed Change End
>>>>>>> goob
        private void OnPointAttempt(Entity<BrainComponent> ent, ref PointAttemptEvent args)
        {
            args.Cancel();
        }
    }
}
