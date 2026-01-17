// SPDX-FileCopyrightText: 2023 TemporalOroboros <TemporalOroboros@gmail.com>
// SPDX-FileCopyrightText: 2023 daerSeebaer <61566539+daerSeebaer@users.noreply.github.com>
// SPDX-FileCopyrightText: 2023 metalgearsloth <31366439+metalgearsloth@users.noreply.github.com>
// SPDX-FileCopyrightText: 2024 Piras314 <p1r4s@proton.me>
// SPDX-FileCopyrightText: 2025 Aiden <28298836+Aidenkrz@users.noreply.github.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

using Content.Shared.APC;
using Robust.Client.GameObjects;

namespace Content.Client.Power.APC;

public sealed class ApcVisualizerSystem : VisualizerSystem<ApcVisualsComponent>
{
    [Dependency] private readonly SharedPointLightSystem _lights = default!;
    [Dependency] private readonly SpriteSystem _sprite = default!;

    protected override void OnAppearanceChange(EntityUid uid, ApcVisualsComponent comp, ref AppearanceChangeEvent args)
    {
        if (args.Sprite == null)
            return;

        // get the mapped layer index of the first lock layer and the first channel layer
<<<<<<< HEAD
        var lockIndicatorOverlayStart = SpriteSystem.LayerMapGet((uid, args.Sprite), ApcVisualLayers.InterfaceLock);
        var channelIndicatorOverlayStart = SpriteSystem.LayerMapGet((uid, args.Sprite), ApcVisualLayers.Equipment);
=======
        var lockIndicatorOverlayStart = _sprite.LayerMapGet((uid, args.Sprite), ApcVisualLayers.InterfaceLock);
        var channelIndicatorOverlayStart = _sprite.LayerMapGet((uid, args.Sprite), ApcVisualLayers.Equipment);
>>>>>>> goob

        // Handle APC screen overlay:
        if (!AppearanceSystem.TryGetData<ApcChargeState>(uid, ApcVisuals.ChargeState, out var chargeState, args.Component))
            chargeState = ApcChargeState.Lack;

        if (chargeState >= 0 && chargeState < ApcChargeState.NumStates)
        {
<<<<<<< HEAD
            SpriteSystem.LayerSetRsiState((uid, args.Sprite), ApcVisualLayers.ChargeState, $"{comp.ScreenPrefix}-{comp.ScreenSuffixes[(sbyte)chargeState]}");
=======
            _sprite.LayerSetRsiState((uid, args.Sprite), ApcVisualLayers.ChargeState, $"{comp.ScreenPrefix}-{comp.ScreenSuffixes[(sbyte)chargeState]}");
>>>>>>> goob

            // LockState does nothing currently. The backend doesn't exist.
            if (AppearanceSystem.TryGetData<byte>(uid, ApcVisuals.LockState, out var lockStates, args.Component))
            {
                for (var i = 0; i < comp.LockIndicators; ++i)
                {
                    var layer = (byte)lockIndicatorOverlayStart + i;
                    var lockState = (sbyte)((lockStates >> (i << (sbyte)ApcLockState.LogWidth)) & (sbyte)ApcLockState.All);
<<<<<<< HEAD
                    SpriteSystem.LayerSetRsiState((uid, args.Sprite), layer, $"{comp.LockPrefix}{i}-{comp.LockSuffixes[lockState]}");
                    SpriteSystem.LayerSetVisible((uid, args.Sprite), layer, true);
=======
                    _sprite.LayerSetRsiState((uid, args.Sprite), layer, $"{comp.LockPrefix}{i}-{comp.LockSuffixes[lockState]}");
                    _sprite.LayerSetVisible((uid, args.Sprite), layer, true);
>>>>>>> goob
                }
            }

            // ChannelState does nothing currently. The backend doesn't exist.
            if (AppearanceSystem.TryGetData<byte>(uid, ApcVisuals.ChannelState, out var channelStates, args.Component))
            {
                for (var i = 0; i < comp.ChannelIndicators; ++i)
                {
                    var layer = (byte)channelIndicatorOverlayStart + i;
                    var channelState = (sbyte)((channelStates >> (i << (sbyte)ApcChannelState.LogWidth)) & (sbyte)ApcChannelState.All);
<<<<<<< HEAD
                    SpriteSystem.LayerSetRsiState((uid, args.Sprite), layer, $"{comp.ChannelPrefix}{i}-{comp.ChannelSuffixes[channelState]}");
                    SpriteSystem.LayerSetVisible((uid, args.Sprite), layer, true);
=======
                    _sprite.LayerSetRsiState((uid, args.Sprite), layer, $"{comp.ChannelPrefix}{i}-{comp.ChannelSuffixes[channelState]}");
                    _sprite.LayerSetVisible((uid, args.Sprite), layer, true);
>>>>>>> goob
                }
            }

            if (TryComp<PointLightComponent>(uid, out var light))
            {
                _lights.SetColor(uid, comp.ScreenColors[(sbyte)chargeState], light);
            }
        }
        else
        {
            /// Overrides all of the lock and channel indicators.
<<<<<<< HEAD
            SpriteSystem.LayerSetRsiState((uid, args.Sprite), ApcVisualLayers.ChargeState, comp.EmaggedScreenState);
            for (var i = 0; i < comp.LockIndicators; ++i)
            {
                var layer = (byte)lockIndicatorOverlayStart + i;
                SpriteSystem.LayerSetVisible((uid, args.Sprite), layer, false);
=======
            _sprite.LayerSetRsiState((uid, args.Sprite), ApcVisualLayers.ChargeState, comp.EmaggedScreenState);
            for (var i = 0; i < comp.LockIndicators; ++i)
            {
                var layer = (byte)lockIndicatorOverlayStart + i;
                _sprite.LayerSetVisible((uid, args.Sprite), layer, false);
>>>>>>> goob
            }
            for (var i = 0; i < comp.ChannelIndicators; ++i)
            {
                var layer = (byte)channelIndicatorOverlayStart + i;
<<<<<<< HEAD
                SpriteSystem.LayerSetVisible((uid, args.Sprite), layer, false);
=======
                _sprite.LayerSetVisible((uid, args.Sprite), layer, false);
>>>>>>> goob
            }

            if (TryComp<PointLightComponent>(uid, out var light))
            {
                _lights.SetColor(uid, comp.EmaggedScreenColor, light);
            }
        }
    }
}

public enum ApcVisualLayers : byte
{
    /// <summary>
    /// The sprite layer used for the interface lock indicator light overlay.
    /// </summary>
    InterfaceLock,
    /// <summary>
    /// The sprite layer used for the panel lock indicator light overlay.
    /// </summary>
    PanelLock,

    /// <summary>
    /// The sprite layer used for the equipment channel indicator light overlay.
    /// </summary>
    Equipment,
    /// <summary>
    /// The sprite layer used for the lighting channel indicator light overlay.
    /// </summary>
    Lighting,
    /// <summary>
    /// The sprite layer used for the environment channel indicator light overlay.
    /// </summary>
    Environment,

    /// <summary>
    /// The sprite layer used for the APC screen overlay.
    /// </summary>
    ChargeState,
}