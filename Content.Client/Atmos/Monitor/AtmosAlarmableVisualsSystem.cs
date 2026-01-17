// SPDX-FileCopyrightText: 2022 vulppine <vulppine@gmail.com>
// SPDX-FileCopyrightText: 2024 MilenVolf <63782763+MilenVolf@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Aiden <28298836+Aidenkrz@users.noreply.github.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

using Content.Shared.Atmos.Monitor;
using Content.Shared.Power;
using Robust.Client.GameObjects;
using Robust.Client.Graphics;

namespace Content.Client.Atmos.Monitor;

public sealed class AtmosAlarmableVisualsSystem : VisualizerSystem<AtmosAlarmableVisualsComponent>
{
    [Dependency] private readonly SpriteSystem _sprite = default!;

    protected override void OnAppearanceChange(EntityUid uid, AtmosAlarmableVisualsComponent component, ref AppearanceChangeEvent args)
    {
<<<<<<< HEAD
        if (args.Sprite == null || !SpriteSystem.LayerMapTryGet((uid, args.Sprite), component.LayerMap, out var layer, false))
=======
        if (args.Sprite == null || !_sprite.LayerMapTryGet((uid, args.Sprite), component.LayerMap, out var layer, false))
>>>>>>> goob
            return;

        if (!args.AppearanceData.TryGetValue(PowerDeviceVisuals.Powered, out var poweredObject) ||
            poweredObject is not bool powered)
        {
            return;
        }

        if (component.HideOnDepowered != null)
        {
            foreach (var visLayer in component.HideOnDepowered)
            {
<<<<<<< HEAD
                if (SpriteSystem.LayerMapTryGet((uid, args.Sprite), visLayer, out var powerVisibilityLayer, false))
                    SpriteSystem.LayerSetVisible((uid, args.Sprite), powerVisibilityLayer, powered);
=======
                if (_sprite.LayerMapTryGet((uid, args.Sprite), visLayer, out var powerVisibilityLayer, false))
                    _sprite.LayerSetVisible((uid, args.Sprite), powerVisibilityLayer, powered);
>>>>>>> goob
            }
        }

        if (component.SetOnDepowered != null && !powered)
        {
            foreach (var (setLayer, powerState) in component.SetOnDepowered)
            {
<<<<<<< HEAD
                if (SpriteSystem.LayerMapTryGet((uid, args.Sprite), setLayer, out var setStateLayer, false))
                    SpriteSystem.LayerSetRsiState((uid, args.Sprite), setStateLayer, new RSI.StateId(powerState));
=======
                if (_sprite.LayerMapTryGet((uid, args.Sprite), setLayer, out var setStateLayer, false))
                    _sprite.LayerSetRsiState((uid, args.Sprite), setStateLayer, new RSI.StateId(powerState));
>>>>>>> goob
            }
        }

        if (args.AppearanceData.TryGetValue(AtmosMonitorVisuals.AlarmType, out var alarmTypeObject)
            && alarmTypeObject is AtmosAlarmType alarmType
            && powered
            && component.AlarmStates.TryGetValue(alarmType, out var state))
        {
<<<<<<< HEAD
            SpriteSystem.LayerSetRsiState((uid, args.Sprite), layer, new RSI.StateId(state));
=======
            _sprite.LayerSetRsiState((uid, args.Sprite), layer, new RSI.StateId(state));
>>>>>>> goob
        }
    }
}