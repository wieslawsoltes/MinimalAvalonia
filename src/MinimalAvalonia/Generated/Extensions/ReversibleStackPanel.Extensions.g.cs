// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class ReversibleStackPanelExtensions
{
    // ReverseOrderProperty

    public static T ReverseOrder<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.ReversibleStackPanel
    {
        obj[Avalonia.Controls.ReversibleStackPanel.ReverseOrderProperty] = value;
        return obj;
    }

    public static T ReverseOrder<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ReversibleStackPanel
    {
        obj[Avalonia.Controls.ReversibleStackPanel.ReverseOrderProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T ReverseOrder<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.ReversibleStackPanel
    {
        obj[Avalonia.Controls.ReversibleStackPanel.ReverseOrderProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindReverseOrder(this Avalonia.Controls.ReversibleStackPanel obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.ReversibleStackPanel.ReverseOrderProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveReverseOrder(this Avalonia.Controls.ReversibleStackPanel obj)
    {
        return obj.GetObservable(Avalonia.Controls.ReversibleStackPanel.ReverseOrderProperty);
    }

    public static T OnReverseOrder<T>(this T obj, Action<Avalonia.Controls.ReversibleStackPanel, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.ReversibleStackPanel
    {
        var observable = obj.GetObservable(Avalonia.Controls.ReversibleStackPanel.ReverseOrderProperty);
        handler(obj, observable);
        return obj;
    }
}
