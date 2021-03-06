// <auto-generated />
namespace MinimalAvalonia.Extensions;

/// <summary>
/// The minimal avalonia <see cref="Avalonia.Controls.ToggleSplitButton"/> class property extension methods.
/// </summary>
public static partial class ToggleSplitButtonExtensions
{
    // Avalonia.Controls.ToggleSplitButton.IsCheckedProperty

    /// <summary>
    /// Sets a <see cref="Avalonia.Controls.ToggleSplitButton.IsCheckedProperty"/> value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsChecked<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.ToggleSplitButton
    {
        obj[Avalonia.Controls.ToggleSplitButton.IsCheckedProperty] = value;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ToggleSplitButton.IsCheckedProperty"/> with binding source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="binding">The source binding.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsChecked<T>(
        this T obj,
        Avalonia.Data.IBinding binding,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ToggleSplitButton
    {
        var descriptor = Avalonia.Controls.ToggleSplitButton.IsCheckedProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = binding;
        return obj;
    }

    /// <summary>
    /// Sets a binding to <see cref="Avalonia.Controls.ToggleSplitButton.IsCheckedProperty"/> with observable source value.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="observable">The source observable.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T IsChecked<T>(
        this T obj,
        IObservable<System.Boolean> observable,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue) where T : Avalonia.Controls.ToggleSplitButton
    {
        var descriptor = Avalonia.Controls.ToggleSplitButton.IsCheckedProperty.Bind().WithMode(mode).WithPriority(priority);
        obj[descriptor] = observable.ToBinding();
        return obj;
    }

    /// <summary>
    /// Makes a <see cref="Avalonia.Controls.ToggleSplitButton.IsCheckedProperty"/> binding.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="mode">The target binding mode.</param>
    /// <param name="priority">The target binding priority.</param>
    /// <returns>A <see cref="Avalonia.Controls.ToggleSplitButton.IsCheckedProperty"/> binding.</returns>
    public static Avalonia.Data.IBinding BindIsChecked(
        this Avalonia.Controls.ToggleSplitButton obj,
        Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay,
        Avalonia.Data.BindingPriority priority = Avalonia.Data.BindingPriority.LocalValue)
    {
        var descriptor = Avalonia.Controls.ToggleSplitButton.IsCheckedProperty.Bind().WithMode(mode).WithPriority(priority);
        return obj[descriptor];
    }

    /// <summary>
    /// Gets an observable for an <see cref="Avalonia.Controls.ToggleSplitButton.IsCheckedProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <returns>
    /// An observable which fires immediately with the current value of the property on the
    /// object and subsequently each time the property value changes.
    /// </returns>
    public static IObservable<System.Boolean> ObserveIsChecked(this Avalonia.Controls.ToggleSplitButton obj)
    {
        return obj.GetObservable(Avalonia.Controls.ToggleSplitButton.IsCheckedProperty);
    }

    /// <summary>
    /// Sets a handler with an observable for an <see cref="Avalonia.Controls.ToggleSplitButton.IsCheckedProperty"/>.
    /// </summary>
    /// <param name="obj">The target object.</param>
    /// <param name="handler">The handler with target object and observable with the current value of the property.</param>
    /// <typeparam name="T">The type of the target object.</typeparam>
    /// <returns>The target object reference.</returns>
    public static T OnIsChecked<T>(this T obj, Action<Avalonia.Controls.ToggleSplitButton, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.ToggleSplitButton
    {
        var observable = obj.GetObservable(Avalonia.Controls.ToggleSplitButton.IsCheckedProperty);
        handler(obj, observable);
        return obj;
    }

    // Avalonia.Controls.ToggleSplitButton.IsCheckedChangedEvent

    public static T OnIsCheckedChangedHandler<T>(
        this T obj,
        Action<T, Avalonia.Interactivity.RoutedEventArgs> action,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.ToggleSplitButton
    {
        obj.AddHandler(Avalonia.Controls.ToggleSplitButton.IsCheckedChangedEvent, (_, args) => action(obj, args), routes);
        return obj;
    }

    public static T OnIsCheckedChanged<T>(
        this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.ToggleSplitButton
    {
        var observable = obj.GetObservable(Avalonia.Controls.ToggleSplitButton.IsCheckedChangedEvent, routes);
        handler(obj, observable);
        return obj;
    }

    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnIsCheckedChanged(
        this Avalonia.Controls.ToggleSplitButton obj,
        Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble)
    {
        return obj.GetObservable(Avalonia.Controls.ToggleSplitButton.IsCheckedChangedEvent, routes);
    }

    // Avalonia.Controls.ToggleSplitButton.IsCheckedChanged

    public static T OnIsCheckedChangedEvent<T>(this T obj, Action<T, IObservable<Avalonia.Interactivity.RoutedEventArgs>> handler) where T : Avalonia.Controls.ToggleSplitButton
    {
        var observable = Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.IsCheckedChanged += h, 
                h => obj.IsCheckedChanged -= h)
            .Select(x => x.EventArgs);
        handler(obj, observable);
        return obj;
    }

    public static IObservable<Avalonia.Interactivity.RoutedEventArgs> ObserveOnIsCheckedChangedEvent(this Avalonia.Controls.ToggleSplitButton obj)
    {
        return Observable
            .FromEventPattern<EventHandler<Avalonia.Interactivity.RoutedEventArgs>, Avalonia.Interactivity.RoutedEventArgs>(
                h => obj.IsCheckedChanged += h, 
                h => obj.IsCheckedChanged -= h)
            .Select(x => x.EventArgs);
    }
}
