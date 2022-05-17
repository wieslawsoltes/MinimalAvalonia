// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class MatrixTransformExtensions
{
    // MatrixProperty

    public static T Matrix<T>(this T obj, Avalonia.Matrix value) where T : Avalonia.Media.MatrixTransform
    {
        obj[Avalonia.Media.MatrixTransform.MatrixProperty] = value;
        return obj;
    }

    public static T Matrix<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.MatrixTransform
    {
        obj[Avalonia.Media.MatrixTransform.MatrixProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Matrix<T>(this T obj, IObservable<Avalonia.Matrix> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Media.MatrixTransform
    {
        obj[Avalonia.Media.MatrixTransform.MatrixProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindMatrix(this Avalonia.Media.MatrixTransform obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Media.MatrixTransform.MatrixProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Matrix> ObserveMatrix(this Avalonia.Media.MatrixTransform obj)
    {
        return obj.GetObservable(Avalonia.Media.MatrixTransform.MatrixProperty);
    }

    public static T OnMatrix<T>(this T obj, Action<Avalonia.Media.MatrixTransform, IObservable<Avalonia.Matrix>> handler) where T : Avalonia.Media.MatrixTransform
    {
        var observable = obj.GetObservable(Avalonia.Media.MatrixTransform.MatrixProperty);
        handler(obj, observable);
        return obj;
    }
}