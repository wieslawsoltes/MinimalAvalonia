// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class SplitViewExtensions
{
    // CompactPaneLengthProperty

    public static T CompactPaneLength<T>(this T obj, System.Double value) where T : Avalonia.Controls.SplitView
    {
        obj[Avalonia.Controls.SplitView.CompactPaneLengthProperty] = value;
        return obj;
    }

    public static T CompactPaneLength<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.SplitView
    {
        obj[Avalonia.Controls.SplitView.CompactPaneLengthProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding CompactPaneLength(this Avalonia.Controls.SplitView obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.SplitView.CompactPaneLengthProperty.Bind().WithMode(mode)];
    }

    // DisplayModeProperty

    public static T DisplayMode<T>(this T obj, Avalonia.Controls.SplitViewDisplayMode value) where T : Avalonia.Controls.SplitView
    {
        obj[Avalonia.Controls.SplitView.DisplayModeProperty] = value;
        return obj;
    }

    public static T DisplayMode<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.SplitView
    {
        obj[Avalonia.Controls.SplitView.DisplayModeProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding DisplayMode(this Avalonia.Controls.SplitView obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.SplitView.DisplayModeProperty.Bind().WithMode(mode)];
    }

    public static T DisplayModeInline<T>(this T obj) where T : Avalonia.Controls.SplitView
    {
        obj[Avalonia.Controls.SplitView.DisplayModeProperty] = Avalonia.Controls.SplitViewDisplayMode.Inline;
        return obj;
    }

    public static T DisplayModeCompactInline<T>(this T obj) where T : Avalonia.Controls.SplitView
    {
        obj[Avalonia.Controls.SplitView.DisplayModeProperty] = Avalonia.Controls.SplitViewDisplayMode.CompactInline;
        return obj;
    }

    public static T DisplayModeOverlay<T>(this T obj) where T : Avalonia.Controls.SplitView
    {
        obj[Avalonia.Controls.SplitView.DisplayModeProperty] = Avalonia.Controls.SplitViewDisplayMode.Overlay;
        return obj;
    }

    public static T DisplayModeCompactOverlay<T>(this T obj) where T : Avalonia.Controls.SplitView
    {
        obj[Avalonia.Controls.SplitView.DisplayModeProperty] = Avalonia.Controls.SplitViewDisplayMode.CompactOverlay;
        return obj;
    }

    // IsPaneOpenProperty

    public static T IsPaneOpen<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.SplitView
    {
        obj[Avalonia.Controls.SplitView.IsPaneOpenProperty] = value;
        return obj;
    }

    public static T IsPaneOpen<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.SplitView
    {
        obj[Avalonia.Controls.SplitView.IsPaneOpenProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding IsPaneOpen(this Avalonia.Controls.SplitView obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.SplitView.IsPaneOpenProperty.Bind().WithMode(mode)];
    }

    // OpenPaneLengthProperty

    public static T OpenPaneLength<T>(this T obj, System.Double value) where T : Avalonia.Controls.SplitView
    {
        obj[Avalonia.Controls.SplitView.OpenPaneLengthProperty] = value;
        return obj;
    }

    public static T OpenPaneLength<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.SplitView
    {
        obj[Avalonia.Controls.SplitView.OpenPaneLengthProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding OpenPaneLength(this Avalonia.Controls.SplitView obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.SplitView.OpenPaneLengthProperty.Bind().WithMode(mode)];
    }

    // PaneBackgroundProperty

    public static T PaneBackground<T>(this T obj, Avalonia.Media.IBrush value) where T : Avalonia.Controls.SplitView
    {
        obj[Avalonia.Controls.SplitView.PaneBackgroundProperty] = value;
        return obj;
    }

    public static T PaneBackground<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.SplitView
    {
        obj[Avalonia.Controls.SplitView.PaneBackgroundProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding PaneBackground(this Avalonia.Controls.SplitView obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.SplitView.PaneBackgroundProperty.Bind().WithMode(mode)];
    }

    // PanePlacementProperty

    public static T PanePlacement<T>(this T obj, Avalonia.Controls.SplitViewPanePlacement value) where T : Avalonia.Controls.SplitView
    {
        obj[Avalonia.Controls.SplitView.PanePlacementProperty] = value;
        return obj;
    }

    public static T PanePlacement<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.SplitView
    {
        obj[Avalonia.Controls.SplitView.PanePlacementProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding PanePlacement(this Avalonia.Controls.SplitView obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.SplitView.PanePlacementProperty.Bind().WithMode(mode)];
    }

    public static T PanePlacementLeft<T>(this T obj) where T : Avalonia.Controls.SplitView
    {
        obj[Avalonia.Controls.SplitView.PanePlacementProperty] = Avalonia.Controls.SplitViewPanePlacement.Left;
        return obj;
    }

    public static T PanePlacementRight<T>(this T obj) where T : Avalonia.Controls.SplitView
    {
        obj[Avalonia.Controls.SplitView.PanePlacementProperty] = Avalonia.Controls.SplitViewPanePlacement.Right;
        return obj;
    }

    // PaneProperty

    public static T Pane<T>(this T obj, System.Object value) where T : Avalonia.Controls.SplitView
    {
        obj[Avalonia.Controls.SplitView.PaneProperty] = value;
        return obj;
    }

    public static T Pane<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.SplitView
    {
        obj[Avalonia.Controls.SplitView.PaneProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding Pane(this Avalonia.Controls.SplitView obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.SplitView.PaneProperty.Bind().WithMode(mode)];
    }

    // PaneTemplateProperty

    public static T PaneTemplate<T>(this T obj, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.SplitView
    {
        obj[Avalonia.Controls.SplitView.PaneTemplateProperty] = value;
        return obj;
    }

    public static T PaneTemplate<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.SplitView
    {
        obj[Avalonia.Controls.SplitView.PaneTemplateProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding PaneTemplate(this Avalonia.Controls.SplitView obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.SplitView.PaneTemplateProperty.Bind().WithMode(mode)];
    }

    // UseLightDismissOverlayModeProperty

    public static T UseLightDismissOverlayMode<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.SplitView
    {
        obj[Avalonia.Controls.SplitView.UseLightDismissOverlayModeProperty] = value;
        return obj;
    }

    public static T UseLightDismissOverlayMode<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.SplitView
    {
        obj[Avalonia.Controls.SplitView.UseLightDismissOverlayModeProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding UseLightDismissOverlayMode(this Avalonia.Controls.SplitView obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.SplitView.UseLightDismissOverlayModeProperty.Bind().WithMode(mode)];
    }

    // TemplateSettingsProperty

    public static T TemplateSettings<T>(this T obj, Avalonia.Controls.SplitViewTemplateSettings value) where T : Avalonia.Controls.SplitView
    {
        obj[Avalonia.Controls.SplitView.TemplateSettingsProperty] = value;
        return obj;
    }

    public static T TemplateSettings<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.SplitView
    {
        obj[Avalonia.Controls.SplitView.TemplateSettingsProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding TemplateSettings(this Avalonia.Controls.SplitView obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.SplitView.TemplateSettingsProperty.Bind().WithMode(mode)];
    }
}