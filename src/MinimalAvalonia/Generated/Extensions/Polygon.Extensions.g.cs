// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class PolygonExtensions
{
    // PointsProperty

    public static T Points<T>(this T obj, System.Collections.Generic.IList<Avalonia.Point> value) where T : Avalonia.Controls.Shapes.Polygon
    {
        obj[Avalonia.Controls.Shapes.Polygon.PointsProperty] = value;
        return obj;
    }

    public static T Points<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Shapes.Polygon
    {
        obj[Avalonia.Controls.Shapes.Polygon.PointsProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Points<T>(this T obj, IObservable<System.Collections.Generic.IList<Avalonia.Point>> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Shapes.Polygon
    {
        obj[Avalonia.Controls.Shapes.Polygon.PointsProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindPoints(this Avalonia.Controls.Shapes.Polygon obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Shapes.Polygon.PointsProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Collections.Generic.IList<Avalonia.Point>> ObservePoints(this Avalonia.Controls.Shapes.Polygon obj)
    {
        return obj.GetObservable(Avalonia.Controls.Shapes.Polygon.PointsProperty);
    }

    public static T OnPoints<T>(this T obj, Action<Avalonia.Controls.Shapes.Polygon, IObservable<System.Collections.Generic.IList<Avalonia.Point>>> handler) where T : Avalonia.Controls.Shapes.Polygon
    {
        var observable = obj.GetObservable(Avalonia.Controls.Shapes.Polygon.PointsProperty);
        handler(obj, observable);
        return obj;
    }
}
