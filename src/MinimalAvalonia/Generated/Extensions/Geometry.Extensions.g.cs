// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class GeometryExtensions
{
    // TransformProperty

    public static T Transform<T>(this T obj, Avalonia.Media.Transform value) where T : Avalonia.Media.Geometry
    {
        obj[Avalonia.Media.Geometry.TransformProperty] = value;
        return obj;
    }

    public static T Transform<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.Geometry
    {
        obj[Avalonia.Media.Geometry.TransformProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Transform<T>(this T obj, IObservable<Avalonia.Media.Transform> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.Geometry
    {
        obj[Avalonia.Media.Geometry.TransformProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindTransform(this Avalonia.Media.Geometry obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Media.Geometry.TransformProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.Transform> ObserveTransform(this Avalonia.Media.Geometry obj)
    {
        return obj.GetObservable(Avalonia.Media.Geometry.TransformProperty);
    }

    public static T OnTransform<T>(this T obj, Action<Avalonia.Media.Geometry, IObservable<Avalonia.Media.Transform>> handler) where T : Avalonia.Media.Geometry
    {
        var observable = obj.GetObservable(Avalonia.Media.Geometry.TransformProperty);
        handler(obj, observable);
        return obj;
    }
}
