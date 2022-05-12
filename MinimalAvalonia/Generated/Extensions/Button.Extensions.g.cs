// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class ButtonExtensions
{
    // ClickModeProperty

    public static T ClickMode<T>(this T obj, Avalonia.Controls.ClickMode value) where T : Avalonia.Controls.Button
    {
        obj[Avalonia.Controls.Button.ClickModeProperty] = value;
        return obj;
    }

    public static T ClickMode<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Button
    {
        obj[Avalonia.Controls.Button.ClickModeProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding ClickMode(this Avalonia.Controls.Button obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Button.ClickModeProperty.Bind().WithMode(mode)];
    }

    public static T ClickModeRelease<T>(this T obj) where T : Avalonia.Controls.Button
    {
        obj[Avalonia.Controls.Button.ClickModeProperty] = Avalonia.Controls.ClickMode.Release;
        return obj;
    }

    public static T ClickModePress<T>(this T obj) where T : Avalonia.Controls.Button
    {
        obj[Avalonia.Controls.Button.ClickModeProperty] = Avalonia.Controls.ClickMode.Press;
        return obj;
    }

    // CommandProperty

    public static T Command<T>(this T obj, System.Windows.Input.ICommand value) where T : Avalonia.Controls.Button
    {
        obj[Avalonia.Controls.Button.CommandProperty] = value;
        return obj;
    }

    public static T Command<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Button
    {
        obj[Avalonia.Controls.Button.CommandProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding Command(this Avalonia.Controls.Button obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Button.CommandProperty.Bind().WithMode(mode)];
    }

    // CommandParameterProperty

    public static T CommandParameter<T>(this T obj, System.Object value) where T : Avalonia.Controls.Button
    {
        obj[Avalonia.Controls.Button.CommandParameterProperty] = value;
        return obj;
    }

    public static T CommandParameter<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Button
    {
        obj[Avalonia.Controls.Button.CommandParameterProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding CommandParameter(this Avalonia.Controls.Button obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Button.CommandParameterProperty.Bind().WithMode(mode)];
    }

    // IsDefaultProperty

    public static T IsDefault<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Button
    {
        obj[Avalonia.Controls.Button.IsDefaultProperty] = value;
        return obj;
    }

    public static T IsDefault<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Button
    {
        obj[Avalonia.Controls.Button.IsDefaultProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding IsDefault(this Avalonia.Controls.Button obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Button.IsDefaultProperty.Bind().WithMode(mode)];
    }

    // IsCancelProperty

    public static T IsCancel<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Button
    {
        obj[Avalonia.Controls.Button.IsCancelProperty] = value;
        return obj;
    }

    public static T IsCancel<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Button
    {
        obj[Avalonia.Controls.Button.IsCancelProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding IsCancel(this Avalonia.Controls.Button obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Button.IsCancelProperty.Bind().WithMode(mode)];
    }

    // IsPressedProperty

    public static T IsPressed<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Button
    {
        obj[Avalonia.Controls.Button.IsPressedProperty] = value;
        return obj;
    }

    public static T IsPressed<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Button
    {
        obj[Avalonia.Controls.Button.IsPressedProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding IsPressed(this Avalonia.Controls.Button obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Button.IsPressedProperty.Bind().WithMode(mode)];
    }

    // FlyoutProperty

    public static T Flyout<T>(this T obj, Avalonia.Controls.Primitives.FlyoutBase value) where T : Avalonia.Controls.Button
    {
        obj[Avalonia.Controls.Button.FlyoutProperty] = value;
        return obj;
    }

    public static T Flyout<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Button
    {
        obj[Avalonia.Controls.Button.FlyoutProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding Flyout(this Avalonia.Controls.Button obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Button.FlyoutProperty.Bind().WithMode(mode)];
    }
}