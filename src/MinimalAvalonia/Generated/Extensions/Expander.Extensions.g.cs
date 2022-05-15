// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class ExpanderExtensions
{
    // ContentTransitionProperty

    public static T ContentTransition<T>(this T obj, Avalonia.Animation.IPageTransition value) where T : Avalonia.Controls.Expander
    {
        obj[Avalonia.Controls.Expander.ContentTransitionProperty] = value;
        return obj;
    }

    public static T ContentTransition<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Expander
    {
        obj[Avalonia.Controls.Expander.ContentTransitionProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T ContentTransition<T>(this T obj, IObservable<Avalonia.Animation.IPageTransition> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Expander
    {
        obj[Avalonia.Controls.Expander.ContentTransitionProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindContentTransition(this Avalonia.Controls.Expander obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Expander.ContentTransitionProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Animation.IPageTransition> ObserveContentTransition(this Avalonia.Controls.Expander obj)
    {
        return obj.GetObservable(Avalonia.Controls.Expander.ContentTransitionProperty);
    }

    public static T OnContentTransition<T>(this T obj, Action<Avalonia.Controls.Expander, IObservable<Avalonia.Animation.IPageTransition>> handler) where T : Avalonia.Controls.Expander
    {
        var observable = obj.GetObservable(Avalonia.Controls.Expander.ContentTransitionProperty);
        handler(obj, observable);
        return obj;
    }

    // ExpandDirectionProperty

    public static T ExpandDirection<T>(this T obj, Avalonia.Controls.ExpandDirection value) where T : Avalonia.Controls.Expander
    {
        obj[Avalonia.Controls.Expander.ExpandDirectionProperty] = value;
        return obj;
    }

    public static T ExpandDirection<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Expander
    {
        obj[Avalonia.Controls.Expander.ExpandDirectionProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T ExpandDirection<T>(this T obj, IObservable<Avalonia.Controls.ExpandDirection> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Expander
    {
        obj[Avalonia.Controls.Expander.ExpandDirectionProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindExpandDirection(this Avalonia.Controls.Expander obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Expander.ExpandDirectionProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.ExpandDirection> ObserveExpandDirection(this Avalonia.Controls.Expander obj)
    {
        return obj.GetObservable(Avalonia.Controls.Expander.ExpandDirectionProperty);
    }

    public static T OnExpandDirection<T>(this T obj, Action<Avalonia.Controls.Expander, IObservable<Avalonia.Controls.ExpandDirection>> handler) where T : Avalonia.Controls.Expander
    {
        var observable = obj.GetObservable(Avalonia.Controls.Expander.ExpandDirectionProperty);
        handler(obj, observable);
        return obj;
    }

    public static T ExpandDirectionDown<T>(this T obj) where T : Avalonia.Controls.Expander
    {
        obj[Avalonia.Controls.Expander.ExpandDirectionProperty] = Avalonia.Controls.ExpandDirection.Down;
        return obj;
    }

    public static T ExpandDirectionUp<T>(this T obj) where T : Avalonia.Controls.Expander
    {
        obj[Avalonia.Controls.Expander.ExpandDirectionProperty] = Avalonia.Controls.ExpandDirection.Up;
        return obj;
    }

    public static T ExpandDirectionLeft<T>(this T obj) where T : Avalonia.Controls.Expander
    {
        obj[Avalonia.Controls.Expander.ExpandDirectionProperty] = Avalonia.Controls.ExpandDirection.Left;
        return obj;
    }

    public static T ExpandDirectionRight<T>(this T obj) where T : Avalonia.Controls.Expander
    {
        obj[Avalonia.Controls.Expander.ExpandDirectionProperty] = Avalonia.Controls.ExpandDirection.Right;
        return obj;
    }

    // IsExpandedProperty

    public static T IsExpanded<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Expander
    {
        obj[Avalonia.Controls.Expander.IsExpandedProperty] = value;
        return obj;
    }

    public static T IsExpanded<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Expander
    {
        obj[Avalonia.Controls.Expander.IsExpandedProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T IsExpanded<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Expander
    {
        obj[Avalonia.Controls.Expander.IsExpandedProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindIsExpanded(this Avalonia.Controls.Expander obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Expander.IsExpandedProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveIsExpanded(this Avalonia.Controls.Expander obj)
    {
        return obj.GetObservable(Avalonia.Controls.Expander.IsExpandedProperty);
    }

    public static T OnIsExpanded<T>(this T obj, Action<Avalonia.Controls.Expander, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.Expander
    {
        var observable = obj.GetObservable(Avalonia.Controls.Expander.IsExpandedProperty);
        handler(obj, observable);
        return obj;
    }
}
