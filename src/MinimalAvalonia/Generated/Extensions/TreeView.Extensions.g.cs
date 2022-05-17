// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class TreeViewExtensions
{
    // AutoScrollToSelectedItemProperty

    public static T AutoScrollToSelectedItem<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.TreeView
    {
        obj[Avalonia.Controls.TreeView.AutoScrollToSelectedItemProperty] = value;
        return obj;
    }

    public static T AutoScrollToSelectedItem<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TreeView
    {
        obj[Avalonia.Controls.TreeView.AutoScrollToSelectedItemProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T AutoScrollToSelectedItem<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TreeView
    {
        obj[Avalonia.Controls.TreeView.AutoScrollToSelectedItemProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindAutoScrollToSelectedItem(this Avalonia.Controls.TreeView obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TreeView.AutoScrollToSelectedItemProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveAutoScrollToSelectedItem(this Avalonia.Controls.TreeView obj)
    {
        return obj.GetObservable(Avalonia.Controls.TreeView.AutoScrollToSelectedItemProperty);
    }

    public static T OnAutoScrollToSelectedItem<T>(this T obj, Action<Avalonia.Controls.TreeView, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.TreeView
    {
        var observable = obj.GetObservable(Avalonia.Controls.TreeView.AutoScrollToSelectedItemProperty);
        handler(obj, observable);
        return obj;
    }

    // SelectedItemProperty

    public static T SelectedItem<T>(this T obj, System.Object value) where T : Avalonia.Controls.TreeView
    {
        obj[Avalonia.Controls.TreeView.SelectedItemProperty] = value;
        return obj;
    }

    public static T SelectedItem<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TreeView
    {
        obj[Avalonia.Controls.TreeView.SelectedItemProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T SelectedItem<T>(this T obj, IObservable<System.Object> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TreeView
    {
        obj[Avalonia.Controls.TreeView.SelectedItemProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindSelectedItem(this Avalonia.Controls.TreeView obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TreeView.SelectedItemProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Object> ObserveSelectedItem(this Avalonia.Controls.TreeView obj)
    {
        return obj.GetObservable(Avalonia.Controls.TreeView.SelectedItemProperty);
    }

    public static T OnSelectedItem<T>(this T obj, Action<Avalonia.Controls.TreeView, IObservable<System.Object>> handler) where T : Avalonia.Controls.TreeView
    {
        var observable = obj.GetObservable(Avalonia.Controls.TreeView.SelectedItemProperty);
        handler(obj, observable);
        return obj;
    }

    // SelectedItemsProperty

    public static T SelectedItems<T>(this T obj, System.Collections.IList value) where T : Avalonia.Controls.TreeView
    {
        obj[Avalonia.Controls.TreeView.SelectedItemsProperty] = value;
        return obj;
    }

    public static T SelectedItems<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TreeView
    {
        obj[Avalonia.Controls.TreeView.SelectedItemsProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T SelectedItems<T>(this T obj, IObservable<System.Collections.IList> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TreeView
    {
        obj[Avalonia.Controls.TreeView.SelectedItemsProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindSelectedItems(this Avalonia.Controls.TreeView obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TreeView.SelectedItemsProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Collections.IList> ObserveSelectedItems(this Avalonia.Controls.TreeView obj)
    {
        return obj.GetObservable(Avalonia.Controls.TreeView.SelectedItemsProperty);
    }

    public static T OnSelectedItems<T>(this T obj, Action<Avalonia.Controls.TreeView, IObservable<System.Collections.IList>> handler) where T : Avalonia.Controls.TreeView
    {
        var observable = obj.GetObservable(Avalonia.Controls.TreeView.SelectedItemsProperty);
        handler(obj, observable);
        return obj;
    }

    // SelectionModeProperty

    public static T SelectionMode<T>(this T obj, Avalonia.Controls.SelectionMode value) where T : Avalonia.Controls.TreeView
    {
        obj[Avalonia.Controls.TreeView.SelectionModeProperty] = value;
        return obj;
    }

    public static T SelectionMode<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TreeView
    {
        obj[Avalonia.Controls.TreeView.SelectionModeProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T SelectionMode<T>(this T obj, IObservable<Avalonia.Controls.SelectionMode> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.TreeView
    {
        obj[Avalonia.Controls.TreeView.SelectionModeProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindSelectionMode(this Avalonia.Controls.TreeView obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.TreeView.SelectionModeProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.SelectionMode> ObserveSelectionMode(this Avalonia.Controls.TreeView obj)
    {
        return obj.GetObservable(Avalonia.Controls.TreeView.SelectionModeProperty);
    }

    public static T OnSelectionMode<T>(this T obj, Action<Avalonia.Controls.TreeView, IObservable<Avalonia.Controls.SelectionMode>> handler) where T : Avalonia.Controls.TreeView
    {
        var observable = obj.GetObservable(Avalonia.Controls.TreeView.SelectionModeProperty);
        handler(obj, observable);
        return obj;
    }

    public static T SelectionModeSingle<T>(this T obj) where T : Avalonia.Controls.TreeView
    {
        obj[Avalonia.Controls.TreeView.SelectionModeProperty] = Avalonia.Controls.SelectionMode.Single;
        return obj;
    }

    public static T SelectionModeMultiple<T>(this T obj) where T : Avalonia.Controls.TreeView
    {
        obj[Avalonia.Controls.TreeView.SelectionModeProperty] = Avalonia.Controls.SelectionMode.Multiple;
        return obj;
    }

    public static T SelectionModeToggle<T>(this T obj) where T : Avalonia.Controls.TreeView
    {
        obj[Avalonia.Controls.TreeView.SelectionModeProperty] = Avalonia.Controls.SelectionMode.Toggle;
        return obj;
    }

    public static T SelectionModeAlwaysSelected<T>(this T obj) where T : Avalonia.Controls.TreeView
    {
        obj[Avalonia.Controls.TreeView.SelectionModeProperty] = Avalonia.Controls.SelectionMode.AlwaysSelected;
        return obj;
    }
}