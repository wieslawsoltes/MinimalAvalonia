// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class TextBlockExtensions
{
    // BaselineOffsetProperty

    public static T BaselineOffset<T>(this T obj, System.Double value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.BaselineOffsetProperty] = value;
        return obj;
    }

    public static T BaselineOffset<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.BaselineOffsetProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding BaselineOffset(this Avalonia.Controls.Control obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBlock.BaselineOffsetProperty.Bind().WithMode(mode)];
    }

    // LineHeightProperty

    public static T LineHeight<T>(this T obj, System.Double value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.LineHeightProperty] = value;
        return obj;
    }

    public static T LineHeight<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.LineHeightProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding LineHeight(this Avalonia.Controls.Control obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBlock.LineHeightProperty.Bind().WithMode(mode)];
    }

    // MaxLinesProperty

    public static T MaxLines<T>(this T obj, System.Int32 value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.MaxLinesProperty] = value;
        return obj;
    }

    public static T MaxLines<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.MaxLinesProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding MaxLines(this Avalonia.Controls.Control obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBlock.MaxLinesProperty.Bind().WithMode(mode)];
    }

    // TextProperty

    public static T Text<T>(this T obj, System.String value) where T : Avalonia.Controls.TextBlock
    {
        obj[Avalonia.Controls.TextBlock.TextProperty] = value;
        return obj;
    }

    public static T Text<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TextBlock
    {
        obj[Avalonia.Controls.TextBlock.TextProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding Text(this Avalonia.Controls.TextBlock obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBlock.TextProperty.Bind().WithMode(mode)];
    }

    // InlinesProperty

    public static Avalonia.Data.IBinding Inlines(this Avalonia.Controls.TextBlock obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay)
    {
        return obj[Avalonia.Controls.TextBlock.InlinesProperty.Bind().WithMode(mode)];
    }

    // TextAlignmentProperty

    public static T TextAlignment<T>(this T obj, Avalonia.Media.TextAlignment value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.TextAlignmentProperty] = value;
        return obj;
    }

    public static T TextAlignment<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.TextAlignmentProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding TextAlignment(this Avalonia.Controls.Control obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBlock.TextAlignmentProperty.Bind().WithMode(mode)];
    }

    public static T TextAlignmentLeft<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.TextAlignmentProperty] = Avalonia.Media.TextAlignment.Left;
        return obj;
    }

    public static T TextAlignmentCenter<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.TextAlignmentProperty] = Avalonia.Media.TextAlignment.Center;
        return obj;
    }

    public static T TextAlignmentRight<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.TextAlignmentProperty] = Avalonia.Media.TextAlignment.Right;
        return obj;
    }

    // TextWrappingProperty

    public static T TextWrapping<T>(this T obj, Avalonia.Media.TextWrapping value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.TextWrappingProperty] = value;
        return obj;
    }

    public static T TextWrapping<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.TextWrappingProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding TextWrapping(this Avalonia.Controls.Control obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBlock.TextWrappingProperty.Bind().WithMode(mode)];
    }

    public static T TextWrappingNoWrap<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.TextWrappingProperty] = Avalonia.Media.TextWrapping.NoWrap;
        return obj;
    }

    public static T TextWrappingWrap<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.TextWrappingProperty] = Avalonia.Media.TextWrapping.Wrap;
        return obj;
    }

    public static T TextWrappingWrapWithOverflow<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.TextWrappingProperty] = Avalonia.Media.TextWrapping.WrapWithOverflow;
        return obj;
    }

    // TextTrimmingProperty

    public static T TextTrimming<T>(this T obj, Avalonia.Media.TextTrimming value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.TextTrimmingProperty] = value;
        return obj;
    }

    public static T TextTrimming<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.TextTrimmingProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding TextTrimming(this Avalonia.Controls.Control obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBlock.TextTrimmingProperty.Bind().WithMode(mode)];
    }

    // TextDecorationsProperty

    public static T TextDecorations<T>(this T obj, Avalonia.Media.TextDecorationCollection value) where T : Avalonia.Controls.TextBlock
    {
        obj[Avalonia.Controls.TextBlock.TextDecorationsProperty] = value;
        return obj;
    }

    public static T TextDecorations<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TextBlock
    {
        obj[Avalonia.Controls.TextBlock.TextDecorationsProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding TextDecorations(this Avalonia.Controls.TextBlock obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBlock.TextDecorationsProperty.Bind().WithMode(mode)];
    }
}