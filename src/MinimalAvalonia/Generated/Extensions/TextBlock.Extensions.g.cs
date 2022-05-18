// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class TextBlockExtensions
{
    // BackgroundProperty

    public static T Background<T>(this T obj, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TextBlock
    {
        obj[Avalonia.Controls.TextBlock.BackgroundProperty] = value;
        return obj;
    }

    public static T Background<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TextBlock
    {
        obj[Avalonia.Controls.TextBlock.BackgroundProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Background<T>(this T obj, IObservable<Avalonia.Media.IBrush> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TextBlock
    {
        obj[Avalonia.Controls.TextBlock.BackgroundProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindBackground(this Avalonia.Controls.TextBlock obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBlock.BackgroundProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.IBrush> ObserveBackground(this Avalonia.Controls.TextBlock obj)
    {
        return obj.GetObservable(Avalonia.Controls.TextBlock.BackgroundProperty);
    }

    public static T OnBackground<T>(this T obj, Action<Avalonia.Controls.TextBlock, IObservable<Avalonia.Media.IBrush>> handler) where T : Avalonia.Controls.TextBlock
    {
        var observable = obj.GetObservable(Avalonia.Controls.TextBlock.BackgroundProperty);
        handler(obj, observable);
        return obj;
    }

    // PaddingProperty

    public static T Padding<T>(this T obj, Avalonia.Thickness value) where T : Avalonia.Controls.TextBlock
    {
        obj[Avalonia.Controls.TextBlock.PaddingProperty] = value;
        return obj;
    }

    public static T Padding<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TextBlock
    {
        obj[Avalonia.Controls.TextBlock.PaddingProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Padding<T>(this T obj, IObservable<Avalonia.Thickness> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TextBlock
    {
        obj[Avalonia.Controls.TextBlock.PaddingProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindPadding(this Avalonia.Controls.TextBlock obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBlock.PaddingProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Thickness> ObservePadding(this Avalonia.Controls.TextBlock obj)
    {
        return obj.GetObservable(Avalonia.Controls.TextBlock.PaddingProperty);
    }

    public static T OnPadding<T>(this T obj, Action<Avalonia.Controls.TextBlock, IObservable<Avalonia.Thickness>> handler) where T : Avalonia.Controls.TextBlock
    {
        var observable = obj.GetObservable(Avalonia.Controls.TextBlock.PaddingProperty);
        handler(obj, observable);
        return obj;
    }

    // FontFamilyProperty

    public static T FontFamily<T>(this T obj, Avalonia.Media.FontFamily value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.FontFamilyProperty] = value;
        return obj;
    }

    public static T FontFamily<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.FontFamilyProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T FontFamily<T>(this T obj, IObservable<Avalonia.Media.FontFamily> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.FontFamilyProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindFontFamily(this Avalonia.Controls.Control obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBlock.FontFamilyProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.FontFamily> ObserveFontFamily(this Avalonia.Controls.Control obj)
    {
        return obj.GetObservable(Avalonia.Controls.TextBlock.FontFamilyProperty);
    }

    public static T OnFontFamily<T>(this T obj, Action<Avalonia.Controls.Control, IObservable<Avalonia.Media.FontFamily>> handler) where T : Avalonia.Controls.Control
    {
        var observable = obj.GetObservable(Avalonia.Controls.TextBlock.FontFamilyProperty);
        handler(obj, observable);
        return obj;
    }

    // FontSizeProperty

    public static T FontSize<T>(this T obj, System.Double value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.FontSizeProperty] = value;
        return obj;
    }

    public static T FontSize<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.FontSizeProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T FontSize<T>(this T obj, IObservable<System.Double> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.FontSizeProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindFontSize(this Avalonia.Controls.Control obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBlock.FontSizeProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Double> ObserveFontSize(this Avalonia.Controls.Control obj)
    {
        return obj.GetObservable(Avalonia.Controls.TextBlock.FontSizeProperty);
    }

    public static T OnFontSize<T>(this T obj, Action<Avalonia.Controls.Control, IObservable<System.Double>> handler) where T : Avalonia.Controls.Control
    {
        var observable = obj.GetObservable(Avalonia.Controls.TextBlock.FontSizeProperty);
        handler(obj, observable);
        return obj;
    }

    // FontStyleProperty

    public static T FontStyle<T>(this T obj, Avalonia.Media.FontStyle value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.FontStyleProperty] = value;
        return obj;
    }

    public static T FontStyle<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.FontStyleProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T FontStyle<T>(this T obj, IObservable<Avalonia.Media.FontStyle> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.FontStyleProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindFontStyle(this Avalonia.Controls.Control obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBlock.FontStyleProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.FontStyle> ObserveFontStyle(this Avalonia.Controls.Control obj)
    {
        return obj.GetObservable(Avalonia.Controls.TextBlock.FontStyleProperty);
    }

    public static T OnFontStyle<T>(this T obj, Action<Avalonia.Controls.Control, IObservable<Avalonia.Media.FontStyle>> handler) where T : Avalonia.Controls.Control
    {
        var observable = obj.GetObservable(Avalonia.Controls.TextBlock.FontStyleProperty);
        handler(obj, observable);
        return obj;
    }

    public static T FontStyleNormal<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.FontStyleProperty] = Avalonia.Media.FontStyle.Normal;
        return obj;
    }

    public static T FontStyleItalic<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.FontStyleProperty] = Avalonia.Media.FontStyle.Italic;
        return obj;
    }

    public static T FontStyleOblique<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.FontStyleProperty] = Avalonia.Media.FontStyle.Oblique;
        return obj;
    }

    // FontWeightProperty

    public static T FontWeight<T>(this T obj, Avalonia.Media.FontWeight value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.FontWeightProperty] = value;
        return obj;
    }

    public static T FontWeight<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.FontWeightProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T FontWeight<T>(this T obj, IObservable<Avalonia.Media.FontWeight> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.FontWeightProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindFontWeight(this Avalonia.Controls.Control obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBlock.FontWeightProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.FontWeight> ObserveFontWeight(this Avalonia.Controls.Control obj)
    {
        return obj.GetObservable(Avalonia.Controls.TextBlock.FontWeightProperty);
    }

    public static T OnFontWeight<T>(this T obj, Action<Avalonia.Controls.Control, IObservable<Avalonia.Media.FontWeight>> handler) where T : Avalonia.Controls.Control
    {
        var observable = obj.GetObservable(Avalonia.Controls.TextBlock.FontWeightProperty);
        handler(obj, observable);
        return obj;
    }

    public static T FontWeightThin<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.FontWeightProperty] = Avalonia.Media.FontWeight.Thin;
        return obj;
    }

    public static T FontWeightExtraLight<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.FontWeightProperty] = Avalonia.Media.FontWeight.ExtraLight;
        return obj;
    }

    public static T FontWeightUltraLight<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.FontWeightProperty] = Avalonia.Media.FontWeight.UltraLight;
        return obj;
    }

    public static T FontWeightLight<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.FontWeightProperty] = Avalonia.Media.FontWeight.Light;
        return obj;
    }

    public static T FontWeightSemiLight<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.FontWeightProperty] = Avalonia.Media.FontWeight.SemiLight;
        return obj;
    }

    public static T FontWeightNormal<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.FontWeightProperty] = Avalonia.Media.FontWeight.Normal;
        return obj;
    }

    public static T FontWeightRegular<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.FontWeightProperty] = Avalonia.Media.FontWeight.Regular;
        return obj;
    }

    public static T FontWeightMedium<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.FontWeightProperty] = Avalonia.Media.FontWeight.Medium;
        return obj;
    }

    public static T FontWeightDemiBold<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.FontWeightProperty] = Avalonia.Media.FontWeight.DemiBold;
        return obj;
    }

    public static T FontWeightSemiBold<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.FontWeightProperty] = Avalonia.Media.FontWeight.SemiBold;
        return obj;
    }

    public static T FontWeightBold<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.FontWeightProperty] = Avalonia.Media.FontWeight.Bold;
        return obj;
    }

    public static T FontWeightExtraBold<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.FontWeightProperty] = Avalonia.Media.FontWeight.ExtraBold;
        return obj;
    }

    public static T FontWeightUltraBold<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.FontWeightProperty] = Avalonia.Media.FontWeight.UltraBold;
        return obj;
    }

    public static T FontWeightBlack<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.FontWeightProperty] = Avalonia.Media.FontWeight.Black;
        return obj;
    }

    public static T FontWeightHeavy<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.FontWeightProperty] = Avalonia.Media.FontWeight.Heavy;
        return obj;
    }

    public static T FontWeightExtraBlack<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.FontWeightProperty] = Avalonia.Media.FontWeight.ExtraBlack;
        return obj;
    }

    public static T FontWeightUltraBlack<T>(this T obj) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.FontWeightProperty] = Avalonia.Media.FontWeight.UltraBlack;
        return obj;
    }

    // ForegroundProperty

    public static T Foreground<T>(this T obj, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.ForegroundProperty] = value;
        return obj;
    }

    public static T Foreground<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.ForegroundProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Foreground<T>(this T obj, IObservable<Avalonia.Media.IBrush> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.TextBlock.ForegroundProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindForeground(this Avalonia.Controls.Control obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBlock.ForegroundProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.IBrush> ObserveForeground(this Avalonia.Controls.Control obj)
    {
        return obj.GetObservable(Avalonia.Controls.TextBlock.ForegroundProperty);
    }

    public static T OnForeground<T>(this T obj, Action<Avalonia.Controls.Control, IObservable<Avalonia.Media.IBrush>> handler) where T : Avalonia.Controls.Control
    {
        var observable = obj.GetObservable(Avalonia.Controls.TextBlock.ForegroundProperty);
        handler(obj, observable);
        return obj;
    }

    // LineHeightProperty

    public static T LineHeight<T>(this T obj, System.Double value) where T : Avalonia.Controls.TextBlock
    {
        obj[Avalonia.Controls.TextBlock.LineHeightProperty] = value;
        return obj;
    }

    public static T LineHeight<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TextBlock
    {
        obj[Avalonia.Controls.TextBlock.LineHeightProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T LineHeight<T>(this T obj, IObservable<System.Double> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TextBlock
    {
        obj[Avalonia.Controls.TextBlock.LineHeightProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindLineHeight(this Avalonia.Controls.TextBlock obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBlock.LineHeightProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Double> ObserveLineHeight(this Avalonia.Controls.TextBlock obj)
    {
        return obj.GetObservable(Avalonia.Controls.TextBlock.LineHeightProperty);
    }

    public static T OnLineHeight<T>(this T obj, Action<Avalonia.Controls.TextBlock, IObservable<System.Double>> handler) where T : Avalonia.Controls.TextBlock
    {
        var observable = obj.GetObservable(Avalonia.Controls.TextBlock.LineHeightProperty);
        handler(obj, observable);
        return obj;
    }

    // MaxLinesProperty

    public static T MaxLines<T>(this T obj, System.Int32 value) where T : Avalonia.Controls.TextBlock
    {
        obj[Avalonia.Controls.TextBlock.MaxLinesProperty] = value;
        return obj;
    }

    public static T MaxLines<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TextBlock
    {
        obj[Avalonia.Controls.TextBlock.MaxLinesProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T MaxLines<T>(this T obj, IObservable<System.Int32> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TextBlock
    {
        obj[Avalonia.Controls.TextBlock.MaxLinesProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindMaxLines(this Avalonia.Controls.TextBlock obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBlock.MaxLinesProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Int32> ObserveMaxLines(this Avalonia.Controls.TextBlock obj)
    {
        return obj.GetObservable(Avalonia.Controls.TextBlock.MaxLinesProperty);
    }

    public static T OnMaxLines<T>(this T obj, Action<Avalonia.Controls.TextBlock, IObservable<System.Int32>> handler) where T : Avalonia.Controls.TextBlock
    {
        var observable = obj.GetObservable(Avalonia.Controls.TextBlock.MaxLinesProperty);
        handler(obj, observable);
        return obj;
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

    public static T Text<T>(this T obj, IObservable<System.String> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TextBlock
    {
        obj[Avalonia.Controls.TextBlock.TextProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindText(this Avalonia.Controls.TextBlock obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBlock.TextProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.String> ObserveText(this Avalonia.Controls.TextBlock obj)
    {
        return obj.GetObservable(Avalonia.Controls.TextBlock.TextProperty);
    }

    public static T OnText<T>(this T obj, Action<Avalonia.Controls.TextBlock, IObservable<System.String>> handler) where T : Avalonia.Controls.TextBlock
    {
        var observable = obj.GetObservable(Avalonia.Controls.TextBlock.TextProperty);
        handler(obj, observable);
        return obj;
    }

    // TextAlignmentProperty

    public static T TextAlignment<T>(this T obj, Avalonia.Media.TextAlignment value) where T : Avalonia.Controls.TextBlock
    {
        obj[Avalonia.Controls.TextBlock.TextAlignmentProperty] = value;
        return obj;
    }

    public static T TextAlignment<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TextBlock
    {
        obj[Avalonia.Controls.TextBlock.TextAlignmentProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T TextAlignment<T>(this T obj, IObservable<Avalonia.Media.TextAlignment> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TextBlock
    {
        obj[Avalonia.Controls.TextBlock.TextAlignmentProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindTextAlignment(this Avalonia.Controls.TextBlock obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBlock.TextAlignmentProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.TextAlignment> ObserveTextAlignment(this Avalonia.Controls.TextBlock obj)
    {
        return obj.GetObservable(Avalonia.Controls.TextBlock.TextAlignmentProperty);
    }

    public static T OnTextAlignment<T>(this T obj, Action<Avalonia.Controls.TextBlock, IObservable<Avalonia.Media.TextAlignment>> handler) where T : Avalonia.Controls.TextBlock
    {
        var observable = obj.GetObservable(Avalonia.Controls.TextBlock.TextAlignmentProperty);
        handler(obj, observable);
        return obj;
    }

    public static T TextAlignmentLeft<T>(this T obj) where T : Avalonia.Controls.TextBlock
    {
        obj[Avalonia.Controls.TextBlock.TextAlignmentProperty] = Avalonia.Media.TextAlignment.Left;
        return obj;
    }

    public static T TextAlignmentCenter<T>(this T obj) where T : Avalonia.Controls.TextBlock
    {
        obj[Avalonia.Controls.TextBlock.TextAlignmentProperty] = Avalonia.Media.TextAlignment.Center;
        return obj;
    }

    public static T TextAlignmentRight<T>(this T obj) where T : Avalonia.Controls.TextBlock
    {
        obj[Avalonia.Controls.TextBlock.TextAlignmentProperty] = Avalonia.Media.TextAlignment.Right;
        return obj;
    }

    // TextWrappingProperty

    public static T TextWrapping<T>(this T obj, Avalonia.Media.TextWrapping value) where T : Avalonia.Controls.TextBlock
    {
        obj[Avalonia.Controls.TextBlock.TextWrappingProperty] = value;
        return obj;
    }

    public static T TextWrapping<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TextBlock
    {
        obj[Avalonia.Controls.TextBlock.TextWrappingProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T TextWrapping<T>(this T obj, IObservable<Avalonia.Media.TextWrapping> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TextBlock
    {
        obj[Avalonia.Controls.TextBlock.TextWrappingProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindTextWrapping(this Avalonia.Controls.TextBlock obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBlock.TextWrappingProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.TextWrapping> ObserveTextWrapping(this Avalonia.Controls.TextBlock obj)
    {
        return obj.GetObservable(Avalonia.Controls.TextBlock.TextWrappingProperty);
    }

    public static T OnTextWrapping<T>(this T obj, Action<Avalonia.Controls.TextBlock, IObservable<Avalonia.Media.TextWrapping>> handler) where T : Avalonia.Controls.TextBlock
    {
        var observable = obj.GetObservable(Avalonia.Controls.TextBlock.TextWrappingProperty);
        handler(obj, observable);
        return obj;
    }

    public static T TextWrappingNoWrap<T>(this T obj) where T : Avalonia.Controls.TextBlock
    {
        obj[Avalonia.Controls.TextBlock.TextWrappingProperty] = Avalonia.Media.TextWrapping.NoWrap;
        return obj;
    }

    public static T TextWrappingWrap<T>(this T obj) where T : Avalonia.Controls.TextBlock
    {
        obj[Avalonia.Controls.TextBlock.TextWrappingProperty] = Avalonia.Media.TextWrapping.Wrap;
        return obj;
    }

    public static T TextWrappingWrapWithOverflow<T>(this T obj) where T : Avalonia.Controls.TextBlock
    {
        obj[Avalonia.Controls.TextBlock.TextWrappingProperty] = Avalonia.Media.TextWrapping.WrapWithOverflow;
        return obj;
    }

    // TextTrimmingProperty

    public static T TextTrimming<T>(this T obj, Avalonia.Media.TextTrimming value) where T : Avalonia.Controls.TextBlock
    {
        obj[Avalonia.Controls.TextBlock.TextTrimmingProperty] = value;
        return obj;
    }

    public static T TextTrimming<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TextBlock
    {
        obj[Avalonia.Controls.TextBlock.TextTrimmingProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T TextTrimming<T>(this T obj, IObservable<Avalonia.Media.TextTrimming> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TextBlock
    {
        obj[Avalonia.Controls.TextBlock.TextTrimmingProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindTextTrimming(this Avalonia.Controls.TextBlock obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBlock.TextTrimmingProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.TextTrimming> ObserveTextTrimming(this Avalonia.Controls.TextBlock obj)
    {
        return obj.GetObservable(Avalonia.Controls.TextBlock.TextTrimmingProperty);
    }

    public static T OnTextTrimming<T>(this T obj, Action<Avalonia.Controls.TextBlock, IObservable<Avalonia.Media.TextTrimming>> handler) where T : Avalonia.Controls.TextBlock
    {
        var observable = obj.GetObservable(Avalonia.Controls.TextBlock.TextTrimmingProperty);
        handler(obj, observable);
        return obj;
    }

    public static T TextTrimmingNone<T>(this T obj) where T : Avalonia.Controls.TextBlock
    {
        obj[Avalonia.Controls.TextBlock.TextTrimmingProperty] = Avalonia.Media.TextTrimming.None;
        return obj;
    }

    public static T TextTrimmingCharacterEllipsis<T>(this T obj) where T : Avalonia.Controls.TextBlock
    {
        obj[Avalonia.Controls.TextBlock.TextTrimmingProperty] = Avalonia.Media.TextTrimming.CharacterEllipsis;
        return obj;
    }

    public static T TextTrimmingWordEllipsis<T>(this T obj) where T : Avalonia.Controls.TextBlock
    {
        obj[Avalonia.Controls.TextBlock.TextTrimmingProperty] = Avalonia.Media.TextTrimming.WordEllipsis;
        return obj;
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

    public static T TextDecorations<T>(this T obj, IObservable<Avalonia.Media.TextDecorationCollection> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TextBlock
    {
        obj[Avalonia.Controls.TextBlock.TextDecorationsProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindTextDecorations(this Avalonia.Controls.TextBlock obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TextBlock.TextDecorationsProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.TextDecorationCollection> ObserveTextDecorations(this Avalonia.Controls.TextBlock obj)
    {
        return obj.GetObservable(Avalonia.Controls.TextBlock.TextDecorationsProperty);
    }

    public static T OnTextDecorations<T>(this T obj, Action<Avalonia.Controls.TextBlock, IObservable<Avalonia.Media.TextDecorationCollection>> handler) where T : Avalonia.Controls.TextBlock
    {
        var observable = obj.GetObservable(Avalonia.Controls.TextBlock.TextDecorationsProperty);
        handler(obj, observable);
        return obj;
    }
}
