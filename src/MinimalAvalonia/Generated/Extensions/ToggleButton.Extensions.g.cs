// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class ToggleButtonExtensions
{
    // IsCheckedProperty

    public static T IsChecked<T>(this T obj, System.Nullable<System.Boolean> value) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        obj[Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty] = value;
        return obj;
    }

    public static T IsChecked<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        obj[Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T IsChecked<T>(this T obj, IObservable<System.Nullable<System.Boolean>> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        obj[Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindIsChecked(this Avalonia.Controls.Primitives.ToggleButton obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Nullable<System.Boolean>> ObserveIsChecked(this Avalonia.Controls.Primitives.ToggleButton obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty);
    }

    public static T OnIsChecked<T>(this T obj, Action<Avalonia.Controls.Primitives.ToggleButton, IObservable<System.Nullable<System.Boolean>>> handler) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty);
        handler(obj, observable);
        return obj;
    }

    // IsThreeStateProperty

    public static T IsThreeState<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        obj[Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty] = value;
        return obj;
    }

    public static T IsThreeState<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        obj[Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T IsThreeState<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        obj[Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindIsThreeState(this Avalonia.Controls.Primitives.ToggleButton obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveIsThreeState(this Avalonia.Controls.Primitives.ToggleButton obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty);
    }

    public static T OnIsThreeState<T>(this T obj, Action<Avalonia.Controls.Primitives.ToggleButton, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty);
        handler(obj, observable);
        return obj;
    }

    // CheckedEvent

    public static T OnCheckedHandler<T>(this T obj, Action<T, Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        obj.AddHandler((Avalonia.Interactivity.RoutedEvent<Avalonia.Interactivity.RoutedEventArgs>)Avalonia.Controls.Primitives.ToggleButton.CheckedEvent, (_, args) => action(obj, args), routes);
        return obj;
    }

    public static T OnChecked<T>(this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler,  Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        var observable = obj.GetObservable((Avalonia.Interactivity.RoutedEvent<Avalonia.Interactivity.RoutedEventArgs>)Avalonia.Controls.Primitives.ToggleButton.CheckedEvent, routes);
        handler(obj, observable);
        return obj;
    }

    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnChecked(this Avalonia.Controls.Primitives.ToggleButton obj,  Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble)
    {
        return obj.GetObservable((Avalonia.Interactivity.RoutedEvent<Avalonia.Interactivity.RoutedEventArgs>)Avalonia.Controls.Primitives.ToggleButton.CheckedEvent, routes);
    }

    // UncheckedEvent

    public static T OnUncheckedHandler<T>(this T obj, Action<T, Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        obj.AddHandler((Avalonia.Interactivity.RoutedEvent<Avalonia.Interactivity.RoutedEventArgs>)Avalonia.Controls.Primitives.ToggleButton.UncheckedEvent, (_, args) => action(obj, args), routes);
        return obj;
    }

    public static T OnUnchecked<T>(this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler,  Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        var observable = obj.GetObservable((Avalonia.Interactivity.RoutedEvent<Avalonia.Interactivity.RoutedEventArgs>)Avalonia.Controls.Primitives.ToggleButton.UncheckedEvent, routes);
        handler(obj, observable);
        return obj;
    }

    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnUnchecked(this Avalonia.Controls.Primitives.ToggleButton obj,  Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble)
    {
        return obj.GetObservable((Avalonia.Interactivity.RoutedEvent<Avalonia.Interactivity.RoutedEventArgs>)Avalonia.Controls.Primitives.ToggleButton.UncheckedEvent, routes);
    }

    // IndeterminateEvent

    public static T OnIndeterminateHandler<T>(this T obj, Action<T, Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        obj.AddHandler((Avalonia.Interactivity.RoutedEvent<Avalonia.Interactivity.RoutedEventArgs>)Avalonia.Controls.Primitives.ToggleButton.IndeterminateEvent, (_, args) => action(obj, args), routes);
        return obj;
    }

    public static T OnIndeterminate<T>(this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler,  Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        var observable = obj.GetObservable((Avalonia.Interactivity.RoutedEvent<Avalonia.Interactivity.RoutedEventArgs>)Avalonia.Controls.Primitives.ToggleButton.IndeterminateEvent, routes);
        handler(obj, observable);
        return obj;
    }

    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnIndeterminate(this Avalonia.Controls.Primitives.ToggleButton obj,  Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble)
    {
        return obj.GetObservable((Avalonia.Interactivity.RoutedEvent<Avalonia.Interactivity.RoutedEventArgs>)Avalonia.Controls.Primitives.ToggleButton.IndeterminateEvent, routes);
    }

    // Checked

    public static T OnCheckedEvent<T>(this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        var observable = Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.Checked += h, 
                h => obj.Checked -= h)
            .Select(x => x.EventArgs);
        handler(obj, observable);
        return obj;
    }

    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnCheckedEvent(this Avalonia.Controls.Primitives.ToggleButton obj)
    {
        return Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.Checked += h, 
                h => obj.Checked -= h)
            .Select(x => x.EventArgs);
    }

    // Unchecked

    public static T OnUncheckedEvent<T>(this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        var observable = Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.Unchecked += h, 
                h => obj.Unchecked -= h)
            .Select(x => x.EventArgs);
        handler(obj, observable);
        return obj;
    }

    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnUncheckedEvent(this Avalonia.Controls.Primitives.ToggleButton obj)
    {
        return Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.Unchecked += h, 
                h => obj.Unchecked -= h)
            .Select(x => x.EventArgs);
    }

    // Indeterminate

    public static T OnIndeterminateEvent<T>(this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler) where T : Avalonia.Controls.Primitives.ToggleButton
    {
        var observable = Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.Indeterminate += h, 
                h => obj.Indeterminate -= h)
            .Select(x => x.EventArgs);
        handler(obj, observable);
        return obj;
    }

    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnIndeterminateEvent(this Avalonia.Controls.Primitives.ToggleButton obj)
    {
        return Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.Indeterminate += h, 
                h => obj.Indeterminate -= h)
            .Select(x => x.EventArgs);
    }
}
