// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class TopLevelExtensions
{
    // ClientSizeProperty

    public static Avalonia.Data.IBinding BindClientSize(this Avalonia.Controls.TopLevel obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay)
    {
        return obj[Avalonia.Controls.TopLevel.ClientSizeProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Size> ObserveClientSize(this Avalonia.Controls.TopLevel obj)
    {
        return obj.GetObservable(Avalonia.Controls.TopLevel.ClientSizeProperty);
    }

    public static Avalonia.Controls.TopLevel OnClientSize(this Avalonia.Controls.TopLevel obj, Action<Avalonia.Controls.TopLevel, IObservable<Avalonia.Size>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.TopLevel.ClientSizeProperty);
        handler(obj, observable);
        return obj;
    }

    // FrameSizeProperty

    public static Avalonia.Data.IBinding BindFrameSize(this Avalonia.Controls.TopLevel obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay)
    {
        return obj[Avalonia.Controls.TopLevel.FrameSizeProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Nullable<Avalonia.Size>> ObserveFrameSize(this Avalonia.Controls.TopLevel obj)
    {
        return obj.GetObservable(Avalonia.Controls.TopLevel.FrameSizeProperty);
    }

    public static Avalonia.Controls.TopLevel OnFrameSize(this Avalonia.Controls.TopLevel obj, Action<Avalonia.Controls.TopLevel, IObservable<System.Nullable<Avalonia.Size>>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.TopLevel.FrameSizeProperty);
        handler(obj, observable);
        return obj;
    }

    // PointerOverElementProperty

    public static T PointerOverElement<T>(this T obj, Avalonia.Input.IInputElement value) where T : Avalonia.Controls.TopLevel
    {
        obj[Avalonia.Controls.TopLevel.PointerOverElementProperty] = value;
        return obj;
    }

    public static T PointerOverElement<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TopLevel
    {
        obj[Avalonia.Controls.TopLevel.PointerOverElementProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T PointerOverElement<T>(this T obj, IObservable<Avalonia.Input.IInputElement> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TopLevel
    {
        obj[Avalonia.Controls.TopLevel.PointerOverElementProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindPointerOverElement(this Avalonia.Controls.TopLevel obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TopLevel.PointerOverElementProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Input.IInputElement> ObservePointerOverElement(this Avalonia.Controls.TopLevel obj)
    {
        return obj.GetObservable(Avalonia.Controls.TopLevel.PointerOverElementProperty);
    }

    public static T OnPointerOverElement<T>(this T obj, Action<Avalonia.Controls.TopLevel, IObservable<Avalonia.Input.IInputElement>> handler) where T : Avalonia.Controls.TopLevel
    {
        var observable = obj.GetObservable(Avalonia.Controls.TopLevel.PointerOverElementProperty);
        handler(obj, observable);
        return obj;
    }

    // TransparencyLevelHintProperty

    public static T TransparencyLevelHint<T>(this T obj, Avalonia.Controls.WindowTransparencyLevel value) where T : Avalonia.Controls.TopLevel
    {
        obj[Avalonia.Controls.TopLevel.TransparencyLevelHintProperty] = value;
        return obj;
    }

    public static T TransparencyLevelHint<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TopLevel
    {
        obj[Avalonia.Controls.TopLevel.TransparencyLevelHintProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T TransparencyLevelHint<T>(this T obj, IObservable<Avalonia.Controls.WindowTransparencyLevel> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TopLevel
    {
        obj[Avalonia.Controls.TopLevel.TransparencyLevelHintProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindTransparencyLevelHint(this Avalonia.Controls.TopLevel obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TopLevel.TransparencyLevelHintProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.WindowTransparencyLevel> ObserveTransparencyLevelHint(this Avalonia.Controls.TopLevel obj)
    {
        return obj.GetObservable(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty);
    }

    public static T OnTransparencyLevelHint<T>(this T obj, Action<Avalonia.Controls.TopLevel, IObservable<Avalonia.Controls.WindowTransparencyLevel>> handler) where T : Avalonia.Controls.TopLevel
    {
        var observable = obj.GetObservable(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty);
        handler(obj, observable);
        return obj;
    }

    public static T TransparencyLevelHintNone<T>(this T obj) where T : Avalonia.Controls.TopLevel
    {
        obj[Avalonia.Controls.TopLevel.TransparencyLevelHintProperty] = Avalonia.Controls.WindowTransparencyLevel.None;
        return obj;
    }

    public static T TransparencyLevelHintTransparent<T>(this T obj) where T : Avalonia.Controls.TopLevel
    {
        obj[Avalonia.Controls.TopLevel.TransparencyLevelHintProperty] = Avalonia.Controls.WindowTransparencyLevel.Transparent;
        return obj;
    }

    public static T TransparencyLevelHintBlur<T>(this T obj) where T : Avalonia.Controls.TopLevel
    {
        obj[Avalonia.Controls.TopLevel.TransparencyLevelHintProperty] = Avalonia.Controls.WindowTransparencyLevel.Blur;
        return obj;
    }

    public static T TransparencyLevelHintAcrylicBlur<T>(this T obj) where T : Avalonia.Controls.TopLevel
    {
        obj[Avalonia.Controls.TopLevel.TransparencyLevelHintProperty] = Avalonia.Controls.WindowTransparencyLevel.AcrylicBlur;
        return obj;
    }

    public static T TransparencyLevelHintMica<T>(this T obj) where T : Avalonia.Controls.TopLevel
    {
        obj[Avalonia.Controls.TopLevel.TransparencyLevelHintProperty] = Avalonia.Controls.WindowTransparencyLevel.Mica;
        return obj;
    }

    // ActualTransparencyLevelProperty

    public static Avalonia.Data.IBinding BindActualTransparencyLevel(this Avalonia.Controls.TopLevel obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay)
    {
        return obj[Avalonia.Controls.TopLevel.ActualTransparencyLevelProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.WindowTransparencyLevel> ObserveActualTransparencyLevel(this Avalonia.Controls.TopLevel obj)
    {
        return obj.GetObservable(Avalonia.Controls.TopLevel.ActualTransparencyLevelProperty);
    }

    public static Avalonia.Controls.TopLevel OnActualTransparencyLevel(this Avalonia.Controls.TopLevel obj, Action<Avalonia.Controls.TopLevel, IObservable<Avalonia.Controls.WindowTransparencyLevel>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.TopLevel.ActualTransparencyLevelProperty);
        handler(obj, observable);
        return obj;
    }

    // TransparencyBackgroundFallbackProperty

    public static T TransparencyBackgroundFallback<T>(this T obj, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TopLevel
    {
        obj[Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty] = value;
        return obj;
    }

    public static T TransparencyBackgroundFallback<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TopLevel
    {
        obj[Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T TransparencyBackgroundFallback<T>(this T obj, IObservable<Avalonia.Media.IBrush> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TopLevel
    {
        obj[Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindTransparencyBackgroundFallback(this Avalonia.Controls.TopLevel obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.IBrush> ObserveTransparencyBackgroundFallback(this Avalonia.Controls.TopLevel obj)
    {
        return obj.GetObservable(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty);
    }

    public static T OnTransparencyBackgroundFallback<T>(this T obj, Action<Avalonia.Controls.TopLevel, IObservable<Avalonia.Media.IBrush>> handler) where T : Avalonia.Controls.TopLevel
    {
        var observable = obj.GetObservable(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty);
        handler(obj, observable);
        return obj;
    }
}
