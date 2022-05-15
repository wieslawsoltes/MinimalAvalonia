// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class HeaderedContentControlExtensions
{
    // HeaderProperty

    public static T Header<T>(this T obj, System.Object value) where T : Avalonia.Controls.Primitives.HeaderedContentControl
    {
        obj[Avalonia.Controls.Primitives.HeaderedContentControl.HeaderProperty] = value;
        return obj;
    }

    public static T Header<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.HeaderedContentControl
    {
        obj[Avalonia.Controls.Primitives.HeaderedContentControl.HeaderProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Header<T>(this T obj, IObservable<System.Object> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.HeaderedContentControl
    {
        obj[Avalonia.Controls.Primitives.HeaderedContentControl.HeaderProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindHeader(this Avalonia.Controls.Primitives.HeaderedContentControl obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.HeaderedContentControl.HeaderProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Object> ObserveHeader(this Avalonia.Controls.Primitives.HeaderedContentControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.HeaderedContentControl.HeaderProperty);
    }

    public static T OnHeader<T>(this T obj, Action<Avalonia.Controls.Primitives.HeaderedContentControl, IObservable<System.Object>> handler) where T : Avalonia.Controls.Primitives.HeaderedContentControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.HeaderedContentControl.HeaderProperty);
        handler(obj, observable);
        return obj;
    }

    // HeaderTemplateProperty

    public static T HeaderTemplate<T>(this T obj, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.Primitives.HeaderedContentControl
    {
        obj[Avalonia.Controls.Primitives.HeaderedContentControl.HeaderTemplateProperty] = value;
        return obj;
    }

    public static T HeaderTemplate<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.HeaderedContentControl
    {
        obj[Avalonia.Controls.Primitives.HeaderedContentControl.HeaderTemplateProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T HeaderTemplate<T>(this T obj, IObservable<Avalonia.Controls.Templates.IDataTemplate> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.HeaderedContentControl
    {
        obj[Avalonia.Controls.Primitives.HeaderedContentControl.HeaderTemplateProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindHeaderTemplate(this Avalonia.Controls.Primitives.HeaderedContentControl obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.HeaderedContentControl.HeaderTemplateProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.Templates.IDataTemplate> ObserveHeaderTemplate(this Avalonia.Controls.Primitives.HeaderedContentControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.HeaderedContentControl.HeaderTemplateProperty);
    }

    public static T OnHeaderTemplate<T>(this T obj, Action<Avalonia.Controls.Primitives.HeaderedContentControl, IObservable<Avalonia.Controls.Templates.IDataTemplate>> handler) where T : Avalonia.Controls.Primitives.HeaderedContentControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.HeaderedContentControl.HeaderTemplateProperty);
        handler(obj, observable);
        return obj;
    }
}
