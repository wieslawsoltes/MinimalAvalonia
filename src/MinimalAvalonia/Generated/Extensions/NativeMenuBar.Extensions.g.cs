// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class NativeMenuBarExtensions
{
    // EnableMenuItemClickForwardingProperty

    public static T EnableMenuItemClickForwarding<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.MenuItem
    {
        obj[Avalonia.Controls.NativeMenuBar.EnableMenuItemClickForwardingProperty] = value;
        return obj;
    }

    public static T EnableMenuItemClickForwarding<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.MenuItem
    {
        obj[Avalonia.Controls.NativeMenuBar.EnableMenuItemClickForwardingProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T EnableMenuItemClickForwarding<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.MenuItem
    {
        obj[Avalonia.Controls.NativeMenuBar.EnableMenuItemClickForwardingProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindEnableMenuItemClickForwarding(this Avalonia.Controls.MenuItem obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.NativeMenuBar.EnableMenuItemClickForwardingProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveEnableMenuItemClickForwarding(this Avalonia.Controls.MenuItem obj)
    {
        return obj.GetObservable(Avalonia.Controls.NativeMenuBar.EnableMenuItemClickForwardingProperty);
    }

    public static T OnEnableMenuItemClickForwarding<T>(this T obj, Action<Avalonia.Controls.MenuItem, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.MenuItem
    {
        var observable = obj.GetObservable(Avalonia.Controls.NativeMenuBar.EnableMenuItemClickForwardingProperty);
        handler(obj, observable);
        return obj;
    }
}