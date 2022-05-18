// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class NotificationCardExtensions
{
    // IsClosingProperty

    public static Avalonia.Data.IBinding BindIsClosing(this Avalonia.Controls.Notifications.NotificationCard obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay)
    {
        return obj[Avalonia.Controls.Notifications.NotificationCard.IsClosingProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveIsClosing(this Avalonia.Controls.Notifications.NotificationCard obj)
    {
        return obj.GetObservable(Avalonia.Controls.Notifications.NotificationCard.IsClosingProperty);
    }

    public static Avalonia.Controls.Notifications.NotificationCard OnIsClosing(this Avalonia.Controls.Notifications.NotificationCard obj, Action<Avalonia.Controls.Notifications.NotificationCard, IObservable<System.Boolean>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.Notifications.NotificationCard.IsClosingProperty);
        handler(obj, observable);
        return obj;
    }

    // IsClosedProperty

    public static T IsClosed<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Notifications.NotificationCard
    {
        obj[Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty] = value;
        return obj;
    }

    public static T IsClosed<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Notifications.NotificationCard
    {
        obj[Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T IsClosed<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Notifications.NotificationCard
    {
        obj[Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindIsClosed(this Avalonia.Controls.Notifications.NotificationCard obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveIsClosed(this Avalonia.Controls.Notifications.NotificationCard obj)
    {
        return obj.GetObservable(Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty);
    }

    public static T OnIsClosed<T>(this T obj, Action<Avalonia.Controls.Notifications.NotificationCard, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.Notifications.NotificationCard
    {
        var observable = obj.GetObservable(Avalonia.Controls.Notifications.NotificationCard.IsClosedProperty);
        handler(obj, observable);
        return obj;
    }

    // CloseOnClickProperty

    public static T CloseOnClick<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Button
    {
        obj[Avalonia.Controls.Notifications.NotificationCard.CloseOnClickProperty] = value;
        return obj;
    }

    public static T CloseOnClick<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Button
    {
        obj[Avalonia.Controls.Notifications.NotificationCard.CloseOnClickProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T CloseOnClick<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Button
    {
        obj[Avalonia.Controls.Notifications.NotificationCard.CloseOnClickProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindCloseOnClick(this Avalonia.Controls.Button obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Notifications.NotificationCard.CloseOnClickProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveCloseOnClick(this Avalonia.Controls.Button obj)
    {
        return obj.GetObservable(Avalonia.Controls.Notifications.NotificationCard.CloseOnClickProperty);
    }

    public static T OnCloseOnClick<T>(this T obj, Action<Avalonia.Controls.Button, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.Button
    {
        var observable = obj.GetObservable(Avalonia.Controls.Notifications.NotificationCard.CloseOnClickProperty);
        handler(obj, observable);
        return obj;
    }

    // NotificationClosedEvent

    public static T OnNotificationClosedHandler<T>(this T obj, Action<T, Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Notifications.NotificationCard
    {
        obj.AddHandler((Avalonia.Interactivity.RoutedEvent<Avalonia.Interactivity.RoutedEventArgs>)Avalonia.Controls.Notifications.NotificationCard.NotificationClosedEvent, (_, args) => action(obj, args), routes);
        return obj;
    }

    public static T OnNotificationClosed<T>(this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler,  Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Notifications.NotificationCard
    {
        var observable = obj.GetObservable((Avalonia.Interactivity.RoutedEvent<Avalonia.Interactivity.RoutedEventArgs>)Avalonia.Controls.Notifications.NotificationCard.NotificationClosedEvent, routes);
        handler(obj, observable);
        return obj;
    }

    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnNotificationClosed(this Avalonia.Controls.Notifications.NotificationCard obj,  Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble)
    {
        return obj.GetObservable((Avalonia.Interactivity.RoutedEvent<Avalonia.Interactivity.RoutedEventArgs>)Avalonia.Controls.Notifications.NotificationCard.NotificationClosedEvent, routes);
    }

    // NotificationClosed

    public static T OnNotificationClosedEvent<T>(this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler) where T : Avalonia.Controls.Notifications.NotificationCard
    {
        var observable = Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.NotificationClosed += h, 
                h => obj.NotificationClosed -= h)
            .Select(x => x.EventArgs);
        handler(obj, observable);
        return obj;
    }

    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnNotificationClosedEvent(this Avalonia.Controls.Notifications.NotificationCard obj)
    {
        return Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.NotificationClosed += h, 
                h => obj.NotificationClosed -= h)
            .Select(x => x.EventArgs);
    }
}
