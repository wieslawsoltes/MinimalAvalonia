// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class MaskedTextBoxExtensions
{
    // AsciiOnlyProperty

    public static T AsciiOnly<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.MaskedTextBox
    {
        obj[Avalonia.Controls.MaskedTextBox.AsciiOnlyProperty] = value;
        return obj;
    }

    public static T AsciiOnly<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.MaskedTextBox
    {
        obj[Avalonia.Controls.MaskedTextBox.AsciiOnlyProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T AsciiOnly<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.MaskedTextBox
    {
        obj[Avalonia.Controls.MaskedTextBox.AsciiOnlyProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindAsciiOnly(this Avalonia.Controls.MaskedTextBox obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.MaskedTextBox.AsciiOnlyProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveAsciiOnly(this Avalonia.Controls.MaskedTextBox obj)
    {
        return obj.GetObservable(Avalonia.Controls.MaskedTextBox.AsciiOnlyProperty);
    }

    public static T OnAsciiOnly<T>(this T obj, Action<Avalonia.Controls.MaskedTextBox, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.MaskedTextBox
    {
        var observable = obj.GetObservable(Avalonia.Controls.MaskedTextBox.AsciiOnlyProperty);
        handler(obj, observable);
        return obj;
    }

    // CultureProperty

    public static T Culture<T>(this T obj, System.Globalization.CultureInfo value) where T : Avalonia.Controls.MaskedTextBox
    {
        obj[Avalonia.Controls.MaskedTextBox.CultureProperty] = value;
        return obj;
    }

    public static T Culture<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.MaskedTextBox
    {
        obj[Avalonia.Controls.MaskedTextBox.CultureProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Culture<T>(this T obj, IObservable<System.Globalization.CultureInfo> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.MaskedTextBox
    {
        obj[Avalonia.Controls.MaskedTextBox.CultureProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindCulture(this Avalonia.Controls.MaskedTextBox obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.MaskedTextBox.CultureProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Globalization.CultureInfo> ObserveCulture(this Avalonia.Controls.MaskedTextBox obj)
    {
        return obj.GetObservable(Avalonia.Controls.MaskedTextBox.CultureProperty);
    }

    public static T OnCulture<T>(this T obj, Action<Avalonia.Controls.MaskedTextBox, IObservable<System.Globalization.CultureInfo>> handler) where T : Avalonia.Controls.MaskedTextBox
    {
        var observable = obj.GetObservable(Avalonia.Controls.MaskedTextBox.CultureProperty);
        handler(obj, observable);
        return obj;
    }

    // HidePromptOnLeaveProperty

    public static T HidePromptOnLeave<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.MaskedTextBox
    {
        obj[Avalonia.Controls.MaskedTextBox.HidePromptOnLeaveProperty] = value;
        return obj;
    }

    public static T HidePromptOnLeave<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.MaskedTextBox
    {
        obj[Avalonia.Controls.MaskedTextBox.HidePromptOnLeaveProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T HidePromptOnLeave<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.MaskedTextBox
    {
        obj[Avalonia.Controls.MaskedTextBox.HidePromptOnLeaveProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindHidePromptOnLeave(this Avalonia.Controls.MaskedTextBox obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.MaskedTextBox.HidePromptOnLeaveProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveHidePromptOnLeave(this Avalonia.Controls.MaskedTextBox obj)
    {
        return obj.GetObservable(Avalonia.Controls.MaskedTextBox.HidePromptOnLeaveProperty);
    }

    public static T OnHidePromptOnLeave<T>(this T obj, Action<Avalonia.Controls.MaskedTextBox, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.MaskedTextBox
    {
        var observable = obj.GetObservable(Avalonia.Controls.MaskedTextBox.HidePromptOnLeaveProperty);
        handler(obj, observable);
        return obj;
    }

    // MaskCompletedProperty

    public static Avalonia.Data.IBinding BindMaskCompleted(this Avalonia.Controls.MaskedTextBox obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay)
    {
        return obj[Avalonia.Controls.MaskedTextBox.MaskCompletedProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Nullable<System.Boolean>> ObserveMaskCompleted(this Avalonia.Controls.MaskedTextBox obj)
    {
        return obj.GetObservable(Avalonia.Controls.MaskedTextBox.MaskCompletedProperty);
    }

    public static Avalonia.Controls.MaskedTextBox OnMaskCompleted(this Avalonia.Controls.MaskedTextBox obj, Action<Avalonia.Controls.MaskedTextBox, IObservable<System.Nullable<System.Boolean>>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.MaskedTextBox.MaskCompletedProperty);
        handler(obj, observable);
        return obj;
    }

    // MaskFullProperty

    public static Avalonia.Data.IBinding BindMaskFull(this Avalonia.Controls.MaskedTextBox obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay)
    {
        return obj[Avalonia.Controls.MaskedTextBox.MaskFullProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Nullable<System.Boolean>> ObserveMaskFull(this Avalonia.Controls.MaskedTextBox obj)
    {
        return obj.GetObservable(Avalonia.Controls.MaskedTextBox.MaskFullProperty);
    }

    public static Avalonia.Controls.MaskedTextBox OnMaskFull(this Avalonia.Controls.MaskedTextBox obj, Action<Avalonia.Controls.MaskedTextBox, IObservable<System.Nullable<System.Boolean>>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.MaskedTextBox.MaskFullProperty);
        handler(obj, observable);
        return obj;
    }

    // PromptCharProperty

    public static T PromptChar<T>(this T obj, System.Char value) where T : Avalonia.Controls.MaskedTextBox
    {
        obj[Avalonia.Controls.MaskedTextBox.PromptCharProperty] = value;
        return obj;
    }

    public static T PromptChar<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.MaskedTextBox
    {
        obj[Avalonia.Controls.MaskedTextBox.PromptCharProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T PromptChar<T>(this T obj, IObservable<System.Char> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.MaskedTextBox
    {
        obj[Avalonia.Controls.MaskedTextBox.PromptCharProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindPromptChar(this Avalonia.Controls.MaskedTextBox obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.MaskedTextBox.PromptCharProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Char> ObservePromptChar(this Avalonia.Controls.MaskedTextBox obj)
    {
        return obj.GetObservable(Avalonia.Controls.MaskedTextBox.PromptCharProperty);
    }

    public static T OnPromptChar<T>(this T obj, Action<Avalonia.Controls.MaskedTextBox, IObservable<System.Char>> handler) where T : Avalonia.Controls.MaskedTextBox
    {
        var observable = obj.GetObservable(Avalonia.Controls.MaskedTextBox.PromptCharProperty);
        handler(obj, observable);
        return obj;
    }

    // ResetOnPromptProperty

    public static T ResetOnPrompt<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.MaskedTextBox
    {
        obj[Avalonia.Controls.MaskedTextBox.ResetOnPromptProperty] = value;
        return obj;
    }

    public static T ResetOnPrompt<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.MaskedTextBox
    {
        obj[Avalonia.Controls.MaskedTextBox.ResetOnPromptProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T ResetOnPrompt<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.MaskedTextBox
    {
        obj[Avalonia.Controls.MaskedTextBox.ResetOnPromptProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindResetOnPrompt(this Avalonia.Controls.MaskedTextBox obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.MaskedTextBox.ResetOnPromptProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveResetOnPrompt(this Avalonia.Controls.MaskedTextBox obj)
    {
        return obj.GetObservable(Avalonia.Controls.MaskedTextBox.ResetOnPromptProperty);
    }

    public static T OnResetOnPrompt<T>(this T obj, Action<Avalonia.Controls.MaskedTextBox, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.MaskedTextBox
    {
        var observable = obj.GetObservable(Avalonia.Controls.MaskedTextBox.ResetOnPromptProperty);
        handler(obj, observable);
        return obj;
    }

    // ResetOnSpaceProperty

    public static T ResetOnSpace<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.MaskedTextBox
    {
        obj[Avalonia.Controls.MaskedTextBox.ResetOnSpaceProperty] = value;
        return obj;
    }

    public static T ResetOnSpace<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.MaskedTextBox
    {
        obj[Avalonia.Controls.MaskedTextBox.ResetOnSpaceProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T ResetOnSpace<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.MaskedTextBox
    {
        obj[Avalonia.Controls.MaskedTextBox.ResetOnSpaceProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindResetOnSpace(this Avalonia.Controls.MaskedTextBox obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.MaskedTextBox.ResetOnSpaceProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveResetOnSpace(this Avalonia.Controls.MaskedTextBox obj)
    {
        return obj.GetObservable(Avalonia.Controls.MaskedTextBox.ResetOnSpaceProperty);
    }

    public static T OnResetOnSpace<T>(this T obj, Action<Avalonia.Controls.MaskedTextBox, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.MaskedTextBox
    {
        var observable = obj.GetObservable(Avalonia.Controls.MaskedTextBox.ResetOnSpaceProperty);
        handler(obj, observable);
        return obj;
    }
}
