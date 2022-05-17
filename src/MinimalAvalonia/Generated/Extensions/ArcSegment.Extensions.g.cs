// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class ArcSegmentExtensions
{
    // IsLargeArcProperty

    public static Avalonia.Media.ArcSegment IsLargeArc(this Avalonia.Media.ArcSegment obj, System.Boolean value)
    {
        obj[Avalonia.Media.ArcSegment.IsLargeArcProperty] = value;
        return obj;
    }

    public static Avalonia.Media.ArcSegment IsLargeArc(this Avalonia.Media.ArcSegment obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        obj[Avalonia.Media.ArcSegment.IsLargeArcProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Media.ArcSegment IsLargeArc(this Avalonia.Media.ArcSegment obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        obj[Avalonia.Media.ArcSegment.IsLargeArcProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindIsLargeArc(this Avalonia.Media.ArcSegment obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Media.ArcSegment.IsLargeArcProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveIsLargeArc(this Avalonia.Media.ArcSegment obj)
    {
        return obj.GetObservable(Avalonia.Media.ArcSegment.IsLargeArcProperty);
    }

    public static Avalonia.Media.ArcSegment OnIsLargeArc(this Avalonia.Media.ArcSegment obj, Action<Avalonia.Media.ArcSegment, IObservable<System.Boolean>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.ArcSegment.IsLargeArcProperty);
        handler(obj, observable);
        return obj;
    }

    // PointProperty

    public static Avalonia.Media.ArcSegment Point(this Avalonia.Media.ArcSegment obj, Avalonia.Point value)
    {
        obj[Avalonia.Media.ArcSegment.PointProperty] = value;
        return obj;
    }

    public static Avalonia.Media.ArcSegment Point(this Avalonia.Media.ArcSegment obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        obj[Avalonia.Media.ArcSegment.PointProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Media.ArcSegment Point(this Avalonia.Media.ArcSegment obj, IObservable<Avalonia.Point> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        obj[Avalonia.Media.ArcSegment.PointProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindPoint(this Avalonia.Media.ArcSegment obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Media.ArcSegment.PointProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Point> ObservePoint(this Avalonia.Media.ArcSegment obj)
    {
        return obj.GetObservable(Avalonia.Media.ArcSegment.PointProperty);
    }

    public static Avalonia.Media.ArcSegment OnPoint(this Avalonia.Media.ArcSegment obj, Action<Avalonia.Media.ArcSegment, IObservable<Avalonia.Point>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.ArcSegment.PointProperty);
        handler(obj, observable);
        return obj;
    }

    // RotationAngleProperty

    public static Avalonia.Media.ArcSegment RotationAngle(this Avalonia.Media.ArcSegment obj, System.Double value)
    {
        obj[Avalonia.Media.ArcSegment.RotationAngleProperty] = value;
        return obj;
    }

    public static Avalonia.Media.ArcSegment RotationAngle(this Avalonia.Media.ArcSegment obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        obj[Avalonia.Media.ArcSegment.RotationAngleProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Media.ArcSegment RotationAngle(this Avalonia.Media.ArcSegment obj, IObservable<System.Double> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        obj[Avalonia.Media.ArcSegment.RotationAngleProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindRotationAngle(this Avalonia.Media.ArcSegment obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Media.ArcSegment.RotationAngleProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Double> ObserveRotationAngle(this Avalonia.Media.ArcSegment obj)
    {
        return obj.GetObservable(Avalonia.Media.ArcSegment.RotationAngleProperty);
    }

    public static Avalonia.Media.ArcSegment OnRotationAngle(this Avalonia.Media.ArcSegment obj, Action<Avalonia.Media.ArcSegment, IObservable<System.Double>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.ArcSegment.RotationAngleProperty);
        handler(obj, observable);
        return obj;
    }

    // SizeProperty

    public static Avalonia.Media.ArcSegment Size(this Avalonia.Media.ArcSegment obj, Avalonia.Size value)
    {
        obj[Avalonia.Media.ArcSegment.SizeProperty] = value;
        return obj;
    }

    public static Avalonia.Media.ArcSegment Size(this Avalonia.Media.ArcSegment obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        obj[Avalonia.Media.ArcSegment.SizeProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Media.ArcSegment Size(this Avalonia.Media.ArcSegment obj, IObservable<Avalonia.Size> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        obj[Avalonia.Media.ArcSegment.SizeProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindSize(this Avalonia.Media.ArcSegment obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Media.ArcSegment.SizeProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Size> ObserveSize(this Avalonia.Media.ArcSegment obj)
    {
        return obj.GetObservable(Avalonia.Media.ArcSegment.SizeProperty);
    }

    public static Avalonia.Media.ArcSegment OnSize(this Avalonia.Media.ArcSegment obj, Action<Avalonia.Media.ArcSegment, IObservable<Avalonia.Size>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.ArcSegment.SizeProperty);
        handler(obj, observable);
        return obj;
    }

    // SweepDirectionProperty

    public static Avalonia.Media.ArcSegment SweepDirection(this Avalonia.Media.ArcSegment obj, Avalonia.Media.SweepDirection value)
    {
        obj[Avalonia.Media.ArcSegment.SweepDirectionProperty] = value;
        return obj;
    }

    public static Avalonia.Media.ArcSegment SweepDirection(this Avalonia.Media.ArcSegment obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        obj[Avalonia.Media.ArcSegment.SweepDirectionProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Media.ArcSegment SweepDirection(this Avalonia.Media.ArcSegment obj, IObservable<Avalonia.Media.SweepDirection> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        obj[Avalonia.Media.ArcSegment.SweepDirectionProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindSweepDirection(this Avalonia.Media.ArcSegment obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Media.ArcSegment.SweepDirectionProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.SweepDirection> ObserveSweepDirection(this Avalonia.Media.ArcSegment obj)
    {
        return obj.GetObservable(Avalonia.Media.ArcSegment.SweepDirectionProperty);
    }

    public static Avalonia.Media.ArcSegment OnSweepDirection(this Avalonia.Media.ArcSegment obj, Action<Avalonia.Media.ArcSegment, IObservable<Avalonia.Media.SweepDirection>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.ArcSegment.SweepDirectionProperty);
        handler(obj, observable);
        return obj;
    }

    public static Avalonia.Media.ArcSegment SweepDirectionCounterClockwise(this Avalonia.Media.ArcSegment obj)
    {
        obj[Avalonia.Media.ArcSegment.SweepDirectionProperty] = Avalonia.Media.SweepDirection.CounterClockwise;
        return obj;
    }

    public static Avalonia.Media.ArcSegment SweepDirectionClockwise(this Avalonia.Media.ArcSegment obj)
    {
        obj[Avalonia.Media.ArcSegment.SweepDirectionProperty] = Avalonia.Media.SweepDirection.Clockwise;
        return obj;
    }
}