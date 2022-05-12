// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class ToolTipExtensions
{
    // TipProperty

    public static T Tip<T>(this T obj, System.Object value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.ToolTip.TipProperty] = value;
        return obj;
    }

    public static T Tip<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.ToolTip.TipProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding Tip(this Avalonia.Controls.Control obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.ToolTip.TipProperty.Bind().WithMode(mode)];
    }

    // IsOpenProperty

    public static T IsOpen<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.ToolTip.IsOpenProperty] = value;
        return obj;
    }

    public static T IsOpen<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.ToolTip.IsOpenProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding IsOpen(this Avalonia.Controls.Control obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.ToolTip.IsOpenProperty.Bind().WithMode(mode)];
    }

    // PlacementProperty

    public static T Placement<T>(this T obj, Avalonia.Controls.PlacementMode value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.ToolTip.PlacementProperty] = value;
        return obj;
    }

    public static T Placement<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.ToolTip.PlacementProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding Placement(this Avalonia.Controls.Control obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.ToolTip.PlacementProperty.Bind().WithMode(mode)];
    }

    public static T PlacementPointer<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.ToolTip.PlacementProperty] = Avalonia.Controls.PlacementMode.Pointer;
        return obj;
    }

    public static T PlacementBottom<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.ToolTip.PlacementProperty] = Avalonia.Controls.PlacementMode.Bottom;
        return obj;
    }

    public static T PlacementRight<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.ToolTip.PlacementProperty] = Avalonia.Controls.PlacementMode.Right;
        return obj;
    }

    public static T PlacementLeft<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.ToolTip.PlacementProperty] = Avalonia.Controls.PlacementMode.Left;
        return obj;
    }

    public static T PlacementTop<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.ToolTip.PlacementProperty] = Avalonia.Controls.PlacementMode.Top;
        return obj;
    }

    public static T PlacementAnchorAndGravity<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.ToolTip.PlacementProperty] = Avalonia.Controls.PlacementMode.AnchorAndGravity;
        return obj;
    }

    // HorizontalOffsetProperty

    public static T HorizontalOffset<T>(this T obj, System.Double value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.ToolTip.HorizontalOffsetProperty] = value;
        return obj;
    }

    public static T HorizontalOffset<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.ToolTip.HorizontalOffsetProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding HorizontalOffset(this Avalonia.Controls.Control obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.ToolTip.HorizontalOffsetProperty.Bind().WithMode(mode)];
    }

    // VerticalOffsetProperty

    public static T VerticalOffset<T>(this T obj, System.Double value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.ToolTip.VerticalOffsetProperty] = value;
        return obj;
    }

    public static T VerticalOffset<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.ToolTip.VerticalOffsetProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding VerticalOffset(this Avalonia.Controls.Control obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.ToolTip.VerticalOffsetProperty.Bind().WithMode(mode)];
    }

    // ShowDelayProperty

    public static T ShowDelay<T>(this T obj, System.Int32 value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.ToolTip.ShowDelayProperty] = value;
        return obj;
    }

    public static T ShowDelay<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.ToolTip.ShowDelayProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding ShowDelay(this Avalonia.Controls.Control obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.ToolTip.ShowDelayProperty.Bind().WithMode(mode)];
    }
}