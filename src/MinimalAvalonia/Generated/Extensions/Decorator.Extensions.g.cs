// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class DecoratorExtensions
{
    // ChildProperty

    public static T Child<T>(this T obj, Avalonia.Controls.IControl value) where T : Avalonia.Controls.Decorator
    {
        obj[Avalonia.Controls.Decorator.ChildProperty] = value;
        return obj;
    }

    public static T Child<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Decorator
    {
        obj[Avalonia.Controls.Decorator.ChildProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Child<T>(this T obj, IObservable<Avalonia.Controls.IControl> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Decorator
    {
        obj[Avalonia.Controls.Decorator.ChildProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindChild(this Avalonia.Controls.Decorator obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Decorator.ChildProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.IControl> ObserveChild(this Avalonia.Controls.Decorator obj)
    {
        return obj.GetObservable(Avalonia.Controls.Decorator.ChildProperty);
    }

    public static T OnChild<T>(this T obj, Action<Avalonia.Controls.Decorator, IObservable<Avalonia.Controls.IControl>> handler) where T : Avalonia.Controls.Decorator
    {
        var observable = obj.GetObservable(Avalonia.Controls.Decorator.ChildProperty);
        handler(obj, observable);
        return obj;
    }

    // PaddingProperty

    public static T Padding<T>(this T obj, Avalonia.Thickness value) where T : Avalonia.Controls.Decorator
    {
        obj[Avalonia.Controls.Decorator.PaddingProperty] = value;
        return obj;
    }

    public static T Padding<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Decorator
    {
        obj[Avalonia.Controls.Decorator.PaddingProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Padding<T>(this T obj, IObservable<Avalonia.Thickness> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Decorator
    {
        obj[Avalonia.Controls.Decorator.PaddingProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindPadding(this Avalonia.Controls.Decorator obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Decorator.PaddingProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Thickness> ObservePadding(this Avalonia.Controls.Decorator obj)
    {
        return obj.GetObservable(Avalonia.Controls.Decorator.PaddingProperty);
    }

    public static T OnPadding<T>(this T obj, Action<Avalonia.Controls.Decorator, IObservable<Avalonia.Thickness>> handler) where T : Avalonia.Controls.Decorator
    {
        var observable = obj.GetObservable(Avalonia.Controls.Decorator.PaddingProperty);
        handler(obj, observable);
        return obj;
    }
}
