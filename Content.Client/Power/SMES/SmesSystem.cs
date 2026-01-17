// SPDX-FileCopyrightText: 2023 TemporalOroboros <TemporalOroboros@gmail.com>
// SPDX-FileCopyrightText: 2023 metalgearsloth <comedian_vs_clown@hotmail.com>
// SPDX-FileCopyrightText: 2025 Aiden <28298836+Aidenkrz@users.noreply.github.com>
//
// SPDX-License-Identifier: MIT

using Content.Shared.Power;
using Content.Shared.SMES;
using Robust.Client.GameObjects;

namespace Content.Client.Power.SMES;

public sealed class SmesVisualizerSystem : VisualizerSystem<SmesComponent>
{
    [Dependency] private readonly SpriteSystem _sprite = default!;

    protected override void OnAppearanceChange(EntityUid uid, SmesComponent comp, ref AppearanceChangeEvent args)
    {
        if (args.Sprite == null)
            return;

        if (!AppearanceSystem.TryGetData<int>(uid, SmesVisuals.LastChargeLevel, out var level, args.Component) || level == 0)
        {
<<<<<<< HEAD
            SpriteSystem.LayerSetVisible((uid, args.Sprite), SmesVisualLayers.Charge, false);
        }
        else
        {
            SpriteSystem.LayerSetVisible((uid, args.Sprite), SmesVisualLayers.Charge, true);
            SpriteSystem.LayerSetRsiState((uid, args.Sprite), SmesVisualLayers.Charge, $"{comp.ChargeOverlayPrefix}{level}");
=======
            _sprite.LayerSetVisible((uid, args.Sprite), SmesVisualLayers.Charge, false);
        }
        else
        {
            _sprite.LayerSetVisible((uid, args.Sprite), SmesVisualLayers.Charge, true);
            _sprite.LayerSetRsiState((uid, args.Sprite), SmesVisualLayers.Charge, $"{comp.ChargeOverlayPrefix}{level}");
>>>>>>> goob
        }

        if (!AppearanceSystem.TryGetData<ChargeState>(uid, SmesVisuals.LastChargeState, out var state, args.Component))
            state = ChargeState.Still;

        switch (state)
        {
            case ChargeState.Still:
<<<<<<< HEAD
                SpriteSystem.LayerSetRsiState((uid, args.Sprite), SmesVisualLayers.Input, $"{comp.InputOverlayPrefix}0");
                SpriteSystem.LayerSetRsiState((uid, args.Sprite), SmesVisualLayers.Output, $"{comp.OutputOverlayPrefix}1");
                break;
            case ChargeState.Charging:
                SpriteSystem.LayerSetRsiState((uid, args.Sprite), SmesVisualLayers.Input, $"{comp.InputOverlayPrefix}1");
                SpriteSystem.LayerSetRsiState((uid, args.Sprite), SmesVisualLayers.Output, $"{comp.OutputOverlayPrefix}1");
                break;
            case ChargeState.Discharging:
                SpriteSystem.LayerSetRsiState((uid, args.Sprite), SmesVisualLayers.Input, $"{comp.InputOverlayPrefix}0");
                SpriteSystem.LayerSetRsiState((uid, args.Sprite), SmesVisualLayers.Output, $"{comp.OutputOverlayPrefix}2");
=======
                _sprite.LayerSetRsiState((uid, args.Sprite), SmesVisualLayers.Input, $"{comp.InputOverlayPrefix}0");
                _sprite.LayerSetRsiState((uid, args.Sprite), SmesVisualLayers.Output, $"{comp.OutputOverlayPrefix}1");
                break;
            case ChargeState.Charging:
                _sprite.LayerSetRsiState((uid, args.Sprite), SmesVisualLayers.Input, $"{comp.InputOverlayPrefix}1");
                _sprite.LayerSetRsiState((uid, args.Sprite), SmesVisualLayers.Output, $"{comp.OutputOverlayPrefix}1");
                break;
            case ChargeState.Discharging:
                _sprite.LayerSetRsiState((uid, args.Sprite), SmesVisualLayers.Input, $"{comp.InputOverlayPrefix}0");
                _sprite.LayerSetRsiState((uid, args.Sprite), SmesVisualLayers.Output, $"{comp.OutputOverlayPrefix}2");
>>>>>>> goob
                break;
        }
    }
}

public enum SmesVisualLayers : byte
{
    Input,
    Charge,
    Output,
}