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

    public static Avalonia.Data.IBinding EnableMenuItemClickForwarding(this Avalonia.Controls.MenuItem obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.NativeMenuBar.EnableMenuItemClickForwardingProperty.Bind().WithMode(mode)];
    }
}