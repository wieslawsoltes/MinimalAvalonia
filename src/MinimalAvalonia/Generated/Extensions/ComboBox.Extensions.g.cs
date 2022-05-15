// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class ComboBoxExtensions
{
    // IsDropDownOpenProperty

    public static T IsDropDownOpen<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.ComboBox
    {
        obj[Avalonia.Controls.ComboBox.IsDropDownOpenProperty] = value;
        return obj;
    }

    public static T IsDropDownOpen<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ComboBox
    {
        obj[Avalonia.Controls.ComboBox.IsDropDownOpenProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T IsDropDownOpen<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ComboBox
    {
        obj[Avalonia.Controls.ComboBox.IsDropDownOpenProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindIsDropDownOpen(this Avalonia.Controls.ComboBox obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.ComboBox.IsDropDownOpenProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveIsDropDownOpen(this Avalonia.Controls.ComboBox obj)
    {
        return obj.GetObservable(Avalonia.Controls.ComboBox.IsDropDownOpenProperty);
    }

    public static T OnIsDropDownOpen<T>(this T obj, Action<Avalonia.Controls.ComboBox, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.ComboBox
    {
        var observable = obj.GetObservable(Avalonia.Controls.ComboBox.IsDropDownOpenProperty);
        handler(obj, observable);
        return obj;
    }

    // MaxDropDownHeightProperty

    public static T MaxDropDownHeight<T>(this T obj, System.Double value) where T : Avalonia.Controls.ComboBox
    {
        obj[Avalonia.Controls.ComboBox.MaxDropDownHeightProperty] = value;
        return obj;
    }

    public static T MaxDropDownHeight<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ComboBox
    {
        obj[Avalonia.Controls.ComboBox.MaxDropDownHeightProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T MaxDropDownHeight<T>(this T obj, IObservable<System.Double> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ComboBox
    {
        obj[Avalonia.Controls.ComboBox.MaxDropDownHeightProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindMaxDropDownHeight(this Avalonia.Controls.ComboBox obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.ComboBox.MaxDropDownHeightProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Double> ObserveMaxDropDownHeight(this Avalonia.Controls.ComboBox obj)
    {
        return obj.GetObservable(Avalonia.Controls.ComboBox.MaxDropDownHeightProperty);
    }

    public static T OnMaxDropDownHeight<T>(this T obj, Action<Avalonia.Controls.ComboBox, IObservable<System.Double>> handler) where T : Avalonia.Controls.ComboBox
    {
        var observable = obj.GetObservable(Avalonia.Controls.ComboBox.MaxDropDownHeightProperty);
        handler(obj, observable);
        return obj;
    }

    // SelectionBoxItemProperty

    public static Avalonia.Data.IBinding BindSelectionBoxItem(this Avalonia.Controls.ComboBox obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay)
    {
        return obj[Avalonia.Controls.ComboBox.SelectionBoxItemProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Object> ObserveSelectionBoxItem(this Avalonia.Controls.ComboBox obj)
    {
        return obj.GetObservable(Avalonia.Controls.ComboBox.SelectionBoxItemProperty);
    }

    public static Avalonia.Controls.ComboBox OnSelectionBoxItem(this Avalonia.Controls.ComboBox obj, Action<Avalonia.Controls.ComboBox, IObservable<System.Object>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.ComboBox.SelectionBoxItemProperty);
        handler(obj, observable);
        return obj;
    }

    // VirtualizationModeProperty

    public static T VirtualizationMode<T>(this T obj, Avalonia.Controls.ItemVirtualizationMode value) where T : Avalonia.Controls.ComboBox
    {
        obj[Avalonia.Controls.ComboBox.VirtualizationModeProperty] = value;
        return obj;
    }

    public static T VirtualizationMode<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ComboBox
    {
        obj[Avalonia.Controls.ComboBox.VirtualizationModeProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T VirtualizationMode<T>(this T obj, IObservable<Avalonia.Controls.ItemVirtualizationMode> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ComboBox
    {
        obj[Avalonia.Controls.ComboBox.VirtualizationModeProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindVirtualizationMode(this Avalonia.Controls.ComboBox obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.ComboBox.VirtualizationModeProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.ItemVirtualizationMode> ObserveVirtualizationMode(this Avalonia.Controls.ComboBox obj)
    {
        return obj.GetObservable(Avalonia.Controls.ComboBox.VirtualizationModeProperty);
    }

    public static T OnVirtualizationMode<T>(this T obj, Action<Avalonia.Controls.ComboBox, IObservable<Avalonia.Controls.ItemVirtualizationMode>> handler) where T : Avalonia.Controls.ComboBox
    {
        var observable = obj.GetObservable(Avalonia.Controls.ComboBox.VirtualizationModeProperty);
        handler(obj, observable);
        return obj;
    }

    public static T VirtualizationModeNone<T>(this T obj) where T : Avalonia.Controls.ComboBox
    {
        obj[Avalonia.Controls.ComboBox.VirtualizationModeProperty] = Avalonia.Controls.ItemVirtualizationMode.None;
        return obj;
    }

    public static T VirtualizationModeSimple<T>(this T obj) where T : Avalonia.Controls.ComboBox
    {
        obj[Avalonia.Controls.ComboBox.VirtualizationModeProperty] = Avalonia.Controls.ItemVirtualizationMode.Simple;
        return obj;
    }

    // PlaceholderTextProperty

    public static T PlaceholderText<T>(this T obj, System.String value) where T : Avalonia.Controls.ComboBox
    {
        obj[Avalonia.Controls.ComboBox.PlaceholderTextProperty] = value;
        return obj;
    }

    public static T PlaceholderText<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ComboBox
    {
        obj[Avalonia.Controls.ComboBox.PlaceholderTextProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T PlaceholderText<T>(this T obj, IObservable<System.String> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ComboBox
    {
        obj[Avalonia.Controls.ComboBox.PlaceholderTextProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindPlaceholderText(this Avalonia.Controls.ComboBox obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.ComboBox.PlaceholderTextProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.String> ObservePlaceholderText(this Avalonia.Controls.ComboBox obj)
    {
        return obj.GetObservable(Avalonia.Controls.ComboBox.PlaceholderTextProperty);
    }

    public static T OnPlaceholderText<T>(this T obj, Action<Avalonia.Controls.ComboBox, IObservable<System.String>> handler) where T : Avalonia.Controls.ComboBox
    {
        var observable = obj.GetObservable(Avalonia.Controls.ComboBox.PlaceholderTextProperty);
        handler(obj, observable);
        return obj;
    }

    // PlaceholderForegroundProperty

    public static T PlaceholderForeground<T>(this T obj, Avalonia.Media.IBrush value) where T : Avalonia.Controls.ComboBox
    {
        obj[Avalonia.Controls.ComboBox.PlaceholderForegroundProperty] = value;
        return obj;
    }

    public static T PlaceholderForeground<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ComboBox
    {
        obj[Avalonia.Controls.ComboBox.PlaceholderForegroundProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T PlaceholderForeground<T>(this T obj, IObservable<Avalonia.Media.IBrush> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ComboBox
    {
        obj[Avalonia.Controls.ComboBox.PlaceholderForegroundProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindPlaceholderForeground(this Avalonia.Controls.ComboBox obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.ComboBox.PlaceholderForegroundProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.IBrush> ObservePlaceholderForeground(this Avalonia.Controls.ComboBox obj)
    {
        return obj.GetObservable(Avalonia.Controls.ComboBox.PlaceholderForegroundProperty);
    }

    public static T OnPlaceholderForeground<T>(this T obj, Action<Avalonia.Controls.ComboBox, IObservable<Avalonia.Media.IBrush>> handler) where T : Avalonia.Controls.ComboBox
    {
        var observable = obj.GetObservable(Avalonia.Controls.ComboBox.PlaceholderForegroundProperty);
        handler(obj, observable);
        return obj;
    }

    // HorizontalContentAlignmentProperty

    public static T HorizontalContentAlignment<T>(this T obj, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.ComboBox
    {
        obj[Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty] = value;
        return obj;
    }

    public static T HorizontalContentAlignment<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ComboBox
    {
        obj[Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T HorizontalContentAlignment<T>(this T obj, IObservable<Avalonia.Layout.HorizontalAlignment> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ComboBox
    {
        obj[Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindHorizontalContentAlignment(this Avalonia.Controls.ComboBox obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Layout.HorizontalAlignment> ObserveHorizontalContentAlignment(this Avalonia.Controls.ComboBox obj)
    {
        return obj.GetObservable(Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty);
    }

    public static T OnHorizontalContentAlignment<T>(this T obj, Action<Avalonia.Controls.ComboBox, IObservable<Avalonia.Layout.HorizontalAlignment>> handler) where T : Avalonia.Controls.ComboBox
    {
        var observable = obj.GetObservable(Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty);
        handler(obj, observable);
        return obj;
    }

    public static T HorizontalContentAlignmentStretch<T>(this T obj) where T : Avalonia.Controls.ComboBox
    {
        obj[Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty] = Avalonia.Layout.HorizontalAlignment.Stretch;
        return obj;
    }

    public static T HorizontalContentAlignmentLeft<T>(this T obj) where T : Avalonia.Controls.ComboBox
    {
        obj[Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty] = Avalonia.Layout.HorizontalAlignment.Left;
        return obj;
    }

    public static T HorizontalContentAlignmentCenter<T>(this T obj) where T : Avalonia.Controls.ComboBox
    {
        obj[Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty] = Avalonia.Layout.HorizontalAlignment.Center;
        return obj;
    }

    public static T HorizontalContentAlignmentRight<T>(this T obj) where T : Avalonia.Controls.ComboBox
    {
        obj[Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty] = Avalonia.Layout.HorizontalAlignment.Right;
        return obj;
    }

    // VerticalContentAlignmentProperty

    public static T VerticalContentAlignment<T>(this T obj, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.ComboBox
    {
        obj[Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty] = value;
        return obj;
    }

    public static T VerticalContentAlignment<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ComboBox
    {
        obj[Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T VerticalContentAlignment<T>(this T obj, IObservable<Avalonia.Layout.VerticalAlignment> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ComboBox
    {
        obj[Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindVerticalContentAlignment(this Avalonia.Controls.ComboBox obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Layout.VerticalAlignment> ObserveVerticalContentAlignment(this Avalonia.Controls.ComboBox obj)
    {
        return obj.GetObservable(Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty);
    }

    public static T OnVerticalContentAlignment<T>(this T obj, Action<Avalonia.Controls.ComboBox, IObservable<Avalonia.Layout.VerticalAlignment>> handler) where T : Avalonia.Controls.ComboBox
    {
        var observable = obj.GetObservable(Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty);
        handler(obj, observable);
        return obj;
    }

    public static T VerticalContentAlignmentStretch<T>(this T obj) where T : Avalonia.Controls.ComboBox
    {
        obj[Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty] = Avalonia.Layout.VerticalAlignment.Stretch;
        return obj;
    }

    public static T VerticalContentAlignmentTop<T>(this T obj) where T : Avalonia.Controls.ComboBox
    {
        obj[Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty] = Avalonia.Layout.VerticalAlignment.Top;
        return obj;
    }

    public static T VerticalContentAlignmentCenter<T>(this T obj) where T : Avalonia.Controls.ComboBox
    {
        obj[Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty] = Avalonia.Layout.VerticalAlignment.Center;
        return obj;
    }

    public static T VerticalContentAlignmentBottom<T>(this T obj) where T : Avalonia.Controls.ComboBox
    {
        obj[Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty] = Avalonia.Layout.VerticalAlignment.Bottom;
        return obj;
    }
}
