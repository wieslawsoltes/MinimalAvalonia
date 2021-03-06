// <auto-generated />
namespace MinimalAvalonia.Extensions;

/// <summary>
/// The minimal avalonia <see cref="Avalonia.Media.PathFigure"/> class property extension methods.
/// </summary>
public static partial class PathFigureExtensions
{
    // Avalonia.Media.PathFigure.IsClosedProperty

    public static Avalonia.Media.PathFigure IsClosed(this Avalonia.Media.PathFigure obj, System.Boolean value)
    {
        obj[Avalonia.Media.PathFigure.IsClosedProperty] = value;
        return obj;
    }

    public static Avalonia.Media.PathFigure IsClosed(
        this Avalonia.Media.PathFigure obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.PathFigure.IsClosedProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    public static Avalonia.Media.PathFigure IsClosed(
        this Avalonia.Media.PathFigure obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.PathFigure.IsClosedProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindIsClosed(
        this Avalonia.Media.PathFigure obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.PathFigure.IsClosedProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    public static IObservable<System.Boolean> ObserveIsClosed(this Avalonia.Media.PathFigure obj)
    {
        return obj.GetObservable(Avalonia.Media.PathFigure.IsClosedProperty);
    }

    public static Avalonia.Media.PathFigure OnIsClosed(this Avalonia.Media.PathFigure obj, Action<Avalonia.Media.PathFigure, IObservable<System.Boolean>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.PathFigure.IsClosedProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Media.PathFigure.IsFilledProperty

    public static Avalonia.Media.PathFigure IsFilled(this Avalonia.Media.PathFigure obj, System.Boolean value)
    {
        obj[Avalonia.Media.PathFigure.IsFilledProperty] = value;
        return obj;
    }

    public static Avalonia.Media.PathFigure IsFilled(
        this Avalonia.Media.PathFigure obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.PathFigure.IsFilledProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    public static Avalonia.Media.PathFigure IsFilled(
        this Avalonia.Media.PathFigure obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.PathFigure.IsFilledProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindIsFilled(
        this Avalonia.Media.PathFigure obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.PathFigure.IsFilledProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    public static IObservable<System.Boolean> ObserveIsFilled(this Avalonia.Media.PathFigure obj)
    {
        return obj.GetObservable(Avalonia.Media.PathFigure.IsFilledProperty);
    }

    public static Avalonia.Media.PathFigure OnIsFilled(this Avalonia.Media.PathFigure obj, Action<Avalonia.Media.PathFigure, IObservable<System.Boolean>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.PathFigure.IsFilledProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Media.PathFigure.SegmentsProperty

    public static Avalonia.Media.PathFigure Segments(this Avalonia.Media.PathFigure obj, Avalonia.Media.PathSegments value)
    {
        obj[Avalonia.Media.PathFigure.SegmentsProperty] = value;
        return obj;
    }

    public static Avalonia.Media.PathFigure Segments(
        this Avalonia.Media.PathFigure obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.PathFigure.SegmentsProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    public static Avalonia.Media.PathFigure Segments(
        this Avalonia.Media.PathFigure obj,
        IObservable<Avalonia.Media.PathSegments> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.PathFigure.SegmentsProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindSegments(
        this Avalonia.Media.PathFigure obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.PathFigure.SegmentsProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    public static IObservable<Avalonia.Media.PathSegments> ObserveSegments(this Avalonia.Media.PathFigure obj)
    {
        return obj.GetObservable(Avalonia.Media.PathFigure.SegmentsProperty);
    }

    public static Avalonia.Media.PathFigure OnSegments(this Avalonia.Media.PathFigure obj, Action<Avalonia.Media.PathFigure, IObservable<Avalonia.Media.PathSegments>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.PathFigure.SegmentsProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Media.PathFigure.StartPointProperty

    public static Avalonia.Media.PathFigure StartPoint(this Avalonia.Media.PathFigure obj, Avalonia.Point value)
    {
        obj[Avalonia.Media.PathFigure.StartPointProperty] = value;
        return obj;
    }

    public static Avalonia.Media.PathFigure StartPoint(
        this Avalonia.Media.PathFigure obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.PathFigure.StartPointProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    public static Avalonia.Media.PathFigure StartPoint(
        this Avalonia.Media.PathFigure obj,
        IObservable<Avalonia.Point> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.PathFigure.StartPointProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindStartPoint(
        this Avalonia.Media.PathFigure obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Media.PathFigure.StartPointProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    public static IObservable<Avalonia.Point> ObserveStartPoint(this Avalonia.Media.PathFigure obj)
    {
        return obj.GetObservable(Avalonia.Media.PathFigure.StartPointProperty);
    }

    public static Avalonia.Media.PathFigure OnStartPoint(this Avalonia.Media.PathFigure obj, Action<Avalonia.Media.PathFigure, IObservable<Avalonia.Point>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Media.PathFigure.StartPointProperty);
        handler(obj, observable);
        return obj;
    }
}
