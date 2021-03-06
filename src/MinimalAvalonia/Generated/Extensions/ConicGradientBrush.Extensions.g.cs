// <auto-generated />
namespace MinimalAvalonia.Extensions;

/// <summary>
/// The minimal avalonia <see cref="Avalonia.Media.ConicGradientBrush"/> class property extension methods.
/// </summary>
public static partial class ConicGradientBrushExtensions
{
    // Avalonia.Media.ConicGradientBrush.CenterProperty

    public static Avalonia.Media.ConicGradientBrush Center(this Avalonia.Media.ConicGradientBrush obj, Avalonia.RelativePoint value)
    {
        obj[Avalonia.Media.ConicGradientBrush.CenterProperty] = value;
        return obj;
    }

    public static Avalonia.Media.ConicGradientBrush Center(
        this Avalonia.Media.ConicGradientBrush obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.ConicGradientBrush.CenterProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    public static Avalonia.Media.ConicGradientBrush Center(
        this Avalonia.Media.ConicGradientBrush obj,
        IObservable<Avalonia.RelativePoint> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.ConicGradientBrush.CenterProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindCenter(
        this Avalonia.Media.ConicGradientBrush obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.ConicGradientBrush.CenterProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    public static IObservable<Avalonia.RelativePoint> ObserveCenter(this Avalonia.Media.ConicGradientBrush obj)
    {
        return obj.GetObservable(Avalonia.Media.ConicGradientBrush.CenterProperty);
    }

    public static Avalonia.Media.ConicGradientBrush OnCenter(this Avalonia.Media.ConicGradientBrush obj, Action<Avalonia.Media.ConicGradientBrush, IObservable<Avalonia.RelativePoint>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.ConicGradientBrush.CenterProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Media.ConicGradientBrush.AngleProperty

    public static Avalonia.Media.ConicGradientBrush Angle(this Avalonia.Media.ConicGradientBrush obj, System.Double value)
    {
        obj[Avalonia.Media.ConicGradientBrush.AngleProperty] = value;
        return obj;
    }

    public static Avalonia.Media.ConicGradientBrush Angle(
        this Avalonia.Media.ConicGradientBrush obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.ConicGradientBrush.AngleProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    public static Avalonia.Media.ConicGradientBrush Angle(
        this Avalonia.Media.ConicGradientBrush obj,
        IObservable<System.Double> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.ConicGradientBrush.AngleProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindAngle(
        this Avalonia.Media.ConicGradientBrush obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.ConicGradientBrush.AngleProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    public static IObservable<System.Double> ObserveAngle(this Avalonia.Media.ConicGradientBrush obj)
    {
        return obj.GetObservable(Avalonia.Media.ConicGradientBrush.AngleProperty);
    }

    public static Avalonia.Media.ConicGradientBrush OnAngle(this Avalonia.Media.ConicGradientBrush obj, Action<Avalonia.Media.ConicGradientBrush, IObservable<System.Double>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.ConicGradientBrush.AngleProperty);
        handler(obj, observable);
        return obj;
    }
}
