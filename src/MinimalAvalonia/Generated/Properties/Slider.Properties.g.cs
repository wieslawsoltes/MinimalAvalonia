namespace MinimalAvalonia;

/// <summary>
/// The minimal avalonia properties.
/// </summary>
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "InconsistentNaming")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("ReSharper", "RedundantNameQualifier")]
public static partial class MinimalAvaloniaProperties
{
    public static Avalonia.StyledProperty<Avalonia.Layout.Orientation> SliderOrientation => Avalonia.Controls.Slider.OrientationProperty;

    public static Avalonia.StyledProperty<System.Boolean> SliderIsDirectionReversed => Avalonia.Controls.Slider.IsDirectionReversedProperty;

    public static Avalonia.StyledProperty<System.Boolean> SliderIsSnapToTickEnabled => Avalonia.Controls.Slider.IsSnapToTickEnabledProperty;

    public static Avalonia.StyledProperty<System.Double> SliderTickFrequency => Avalonia.Controls.Slider.TickFrequencyProperty;

    public static Avalonia.StyledProperty<Avalonia.Controls.TickPlacement> SliderTickPlacement => Avalonia.Controls.Slider.TickPlacementProperty;

    public static Avalonia.StyledProperty<Avalonia.Collections.AvaloniaList<System.Double>> SliderTicks => Avalonia.Controls.Slider.TicksProperty;
}
