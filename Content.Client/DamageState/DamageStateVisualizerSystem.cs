// SPDX-FileCopyrightText: 2022 CrudeWax <75271456+CrudeWax@users.noreply.github.com>
// SPDX-FileCopyrightText: 2022 metalgearsloth <comedian_vs_clown@hotmail.com>
// SPDX-FileCopyrightText: 2022 metalgearsloth <metalgearsloth@gmail.com>
// SPDX-FileCopyrightText: 2022 mirrorcult <lunarautomaton6@gmail.com>
// SPDX-FileCopyrightText: 2023 ArthurMousatov <57199800+ArthurMousatov@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 DrSmugleaf <drsmugleaf@gmail.com>
// SPDX-FileCopyrightText: 2023 Jezithyr <jezithyr@gmail.com>
// SPDX-FileCopyrightText: 2023 Visne <39844191+Visne@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 metalgearsloth <31366439+metalgearsloth@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Aiden <28298836+Aidenkrz@users.noreply.github.com>
//
// SPDX-License-Identifier: MIT

using Content.Shared.Mobs;
using Robust.Client.GameObjects;
using DrawDepth = Content.Shared.DrawDepth.DrawDepth;

namespace Content.Client.DamageState;

public sealed class DamageStateVisualizerSystem : VisualizerSystem<DamageStateVisualsComponent>
{
    [Dependency] private readonly SpriteSystem _sprite = default!;

    protected override void OnAppearanceChange(EntityUid uid, DamageStateVisualsComponent component, ref AppearanceChangeEvent args)
    {
        var sprite = args.Sprite;

        if (sprite == null || !AppearanceSystem.TryGetData<MobState>(uid, MobStateVisuals.State, out var data, args.Component))
        {
            return;
        }

        if (!component.States.TryGetValue(data, out var layers))
        {
            return;
        }

        // Brain no worky rn so this was just easier.
        foreach (var key in new[] { DamageStateVisualLayers.Base, DamageStateVisualLayers.BaseUnshaded })
        {
<<<<<<< HEAD
            if (!SpriteSystem.LayerMapTryGet((uid, sprite), key, out _, false)) continue;

            SpriteSystem.LayerSetVisible((uid, sprite), key, false);
=======
            if (!_sprite.LayerMapTryGet((uid, sprite), key, out _, false)) continue;

            _sprite.LayerSetVisible((uid, sprite), key, false);
>>>>>>> goob
        }

        foreach (var (key, state) in layers)
        {
            // Inheritance moment.
<<<<<<< HEAD
            if (!SpriteSystem.LayerMapTryGet((uid, sprite), key, out _, false)) continue;

            SpriteSystem.LayerSetVisible((uid, sprite), key, true);
            SpriteSystem.LayerSetRsiState((uid, sprite), key, state);
=======
            if (!_sprite.LayerMapTryGet((uid, sprite), key, out _, false)) continue;

            _sprite.LayerSetVisible((uid, sprite), key, true);
            _sprite.LayerSetRsiState((uid, sprite), key, state);
>>>>>>> goob
        }

        // So they don't draw over mobs anymore
        if (data == MobState.Dead)
        {
            if (sprite.DrawDepth > (int)DrawDepth.DeadMobs)
            {
                component.OriginalDrawDepth = sprite.DrawDepth;
<<<<<<< HEAD
                SpriteSystem.SetDrawDepth((uid, sprite), (int)DrawDepth.DeadMobs);
=======
                _sprite.SetDrawDepth((uid, sprite), (int)DrawDepth.DeadMobs);
>>>>>>> goob
            }
        }
        else if (component.OriginalDrawDepth != null)
        {
<<<<<<< HEAD
            SpriteSystem.SetDrawDepth((uid, sprite), component.OriginalDrawDepth.Value);
=======
            _sprite.SetDrawDepth((uid, sprite), component.OriginalDrawDepth.Value);
>>>>>>> goob
            component.OriginalDrawDepth = null;
        }
    }
}