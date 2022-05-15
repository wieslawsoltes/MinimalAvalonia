// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class GradientStopExtensions
{
    // OffsetProperty

    public static Avalonia.Media.GradientStop Offset(this Avalonia.Media.GradientStop obj, System.Double value)
    {
        obj[Avalonia.Media.GradientStop.OffsetProperty] = value;
        return obj;
    }

    public static Avalonia.Media.GradientStop Offset(this Avalonia.Media.GradientStop obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        obj[Avalonia.Media.GradientStop.OffsetProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Media.GradientStop Offset(this Avalonia.Media.GradientStop obj, IObservable<System.Double> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        obj[Avalonia.Media.GradientStop.OffsetProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindOffset(this Avalonia.Media.GradientStop obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Media.GradientStop.OffsetProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Double> ObserveOffset(this Avalonia.Media.GradientStop obj)
    {
        return obj.GetObservable(Avalonia.Media.GradientStop.OffsetProperty);
    }

    public static Avalonia.Media.GradientStop OnOffset(this Avalonia.Media.GradientStop obj, Action<Avalonia.Media.GradientStop, IObservable<System.Double>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.GradientStop.OffsetProperty);
        handler(obj, observable);
        return obj;
    }

    // ColorProperty

    public static Avalonia.Media.GradientStop Color(this Avalonia.Media.GradientStop obj, Avalonia.Media.Color value)
    {
        obj[Avalonia.Media.GradientStop.ColorProperty] = value;
        return obj;
    }

    public static Avalonia.Media.GradientStop Color(this Avalonia.Media.GradientStop obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        obj[Avalonia.Media.GradientStop.ColorProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Media.GradientStop Color(this Avalonia.Media.GradientStop obj, IObservable<Avalonia.Media.Color> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        obj[Avalonia.Media.GradientStop.ColorProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindColor(this Avalonia.Media.GradientStop obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Media.GradientStop.ColorProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.Color> ObserveColor(this Avalonia.Media.GradientStop obj)
    {
        return obj.GetObservable(Avalonia.Media.GradientStop.ColorProperty);
    }

    public static Avalonia.Media.GradientStop OnColor(this Avalonia.Media.GradientStop obj, Action<Avalonia.Media.GradientStop, IObservable<Avalonia.Media.Color>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.GradientStop.ColorProperty);
        handler(obj, observable);
        return obj;
    }
}
