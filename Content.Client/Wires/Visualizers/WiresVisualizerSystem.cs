// SPDX-FileCopyrightText: 2022 Andreas Kämper <andreas@kaemper.tech>
// SPDX-FileCopyrightText: 2025 Aiden <28298836+Aidenkrz@users.noreply.github.com>
//
// SPDX-License-Identifier: MIT

using Content.Shared.Wires;
using Robust.Client.GameObjects;

namespace Content.Client.Wires.Visualizers
{
    public sealed class WiresVisualizerSystem : VisualizerSystem<WiresVisualsComponent>
    {
        [Dependency] private readonly SpriteSystem _sprite = default!;

        protected override void OnAppearanceChange(EntityUid uid, WiresVisualsComponent component, ref AppearanceChangeEvent args)
        {
            if (args.Sprite == null)
                return;

<<<<<<< HEAD
            var layer = SpriteSystem.LayerMapReserve((uid, args.Sprite), WiresVisualLayers.MaintenancePanel);
=======
            var layer = _sprite.LayerMapReserve((uid, args.Sprite), WiresVisualLayers.MaintenancePanel);
>>>>>>> goob

            if (args.AppearanceData.TryGetValue(WiresVisuals.MaintenancePanelState, out var panelStateObject) &&
                panelStateObject is bool panelState)
            {
<<<<<<< HEAD
                SpriteSystem.LayerSetVisible((uid, args.Sprite), layer, panelState);
=======
                _sprite.LayerSetVisible((uid, args.Sprite), layer, panelState);
>>>>>>> goob
            }
            else
            {
                //Mainly for spawn window
<<<<<<< HEAD
                SpriteSystem.LayerSetVisible((uid, args.Sprite), layer, false);
=======
                _sprite.LayerSetVisible((uid, args.Sprite), layer, false);
>>>>>>> goob
            }
        }
    }

    public enum WiresVisualLayers : byte
    {
        MaintenancePanel
    }
}