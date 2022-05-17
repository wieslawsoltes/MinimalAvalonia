// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class TemplatedControlExtensions
{
    // BackgroundProperty

    public static T Background<T>(this T obj, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Primitives.TemplatedControl
    {
        obj[Avalonia.Controls.Primitives.TemplatedControl.BackgroundProperty] = value;
        return obj;
    }

    public static T Background<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.TemplatedControl
    {
        obj[Avalonia.Controls.Primitives.TemplatedControl.BackgroundProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Background<T>(this T obj, IObservable<Avalonia.Media.IBrush> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.TemplatedControl
    {
        obj[Avalonia.Controls.Primitives.TemplatedControl.BackgroundProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindBackground(this Avalonia.Controls.Primitives.TemplatedControl obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.TemplatedControl.BackgroundProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.IBrush> ObserveBackground(this Avalonia.Controls.Primitives.TemplatedControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.TemplatedControl.BackgroundProperty);
    }

    public static T OnBackground<T>(this T obj, Action<Avalonia.Controls.Primitives.TemplatedControl, IObservable<Avalonia.Media.IBrush>> handler) where T : Avalonia.Controls.Primitives.TemplatedControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.TemplatedControl.BackgroundProperty);
        handler(obj, observable);
        return obj;
    }

    // BorderBrushProperty

    public static T BorderBrush<T>(this T obj, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Primitives.TemplatedControl
    {
        obj[Avalonia.Controls.Primitives.TemplatedControl.BorderBrushProperty] = value;
        return obj;
    }

    public static T BorderBrush<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.TemplatedControl
    {
        obj[Avalonia.Controls.Primitives.TemplatedControl.BorderBrushProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T BorderBrush<T>(this T obj, IObservable<Avalonia.Media.IBrush> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.TemplatedControl
    {
        obj[Avalonia.Controls.Primitives.TemplatedControl.BorderBrushProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindBorderBrush(this Avalonia.Controls.Primitives.TemplatedControl obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.TemplatedControl.BorderBrushProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.IBrush> ObserveBorderBrush(this Avalonia.Controls.Primitives.TemplatedControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.TemplatedControl.BorderBrushProperty);
    }

    public static T OnBorderBrush<T>(this T obj, Action<Avalonia.Controls.Primitives.TemplatedControl, IObservable<Avalonia.Media.IBrush>> handler) where T : Avalonia.Controls.Primitives.TemplatedControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.TemplatedControl.BorderBrushProperty);
        handler(obj, observable);
        return obj;
    }

    // BorderThicknessProperty

    public static T BorderThickness<T>(this T obj, Avalonia.Thickness value) where T : Avalonia.Controls.Primitives.TemplatedControl
    {
        obj[Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty] = value;
        return obj;
    }

    public static T BorderThickness<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.TemplatedControl
    {
        obj[Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T BorderThickness<T>(this T obj, IObservable<Avalonia.Thickness> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.TemplatedControl
    {
        obj[Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindBorderThickness(this Avalonia.Controls.Primitives.TemplatedControl obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Thickness> ObserveBorderThickness(this Avalonia.Controls.Primitives.TemplatedControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty);
    }

    public static T OnBorderThickness<T>(this T obj, Action<Avalonia.Controls.Primitives.TemplatedControl, IObservable<Avalonia.Thickness>> handler) where T : Avalonia.Controls.Primitives.TemplatedControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.TemplatedControl.BorderThicknessProperty);
        handler(obj, observable);
        return obj;
    }

    // CornerRadiusProperty

    public static T CornerRadius<T>(this T obj, Avalonia.CornerRadius value) where T : Avalonia.Controls.Primitives.TemplatedControl
    {
        obj[Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty] = value;
        return obj;
    }

    public static T CornerRadius<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.TemplatedControl
    {
        obj[Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T CornerRadius<T>(this T obj, IObservable<Avalonia.CornerRadius> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.TemplatedControl
    {
        obj[Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindCornerRadius(this Avalonia.Controls.Primitives.TemplatedControl obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.CornerRadius> ObserveCornerRadius(this Avalonia.Controls.Primitives.TemplatedControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty);
    }

    public static T OnCornerRadius<T>(this T obj, Action<Avalonia.Controls.Primitives.TemplatedControl, IObservable<Avalonia.CornerRadius>> handler) where T : Avalonia.Controls.Primitives.TemplatedControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.TemplatedControl.CornerRadiusProperty);
        handler(obj, observable);
        return obj;
    }

    // PaddingProperty

    public static T Padding<T>(this T obj, Avalonia.Thickness value) where T : Avalonia.Controls.Primitives.TemplatedControl
    {
        obj[Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty] = value;
        return obj;
    }

    public static T Padding<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.TemplatedControl
    {
        obj[Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Padding<T>(this T obj, IObservable<Avalonia.Thickness> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.TemplatedControl
    {
        obj[Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindPadding(this Avalonia.Controls.Primitives.TemplatedControl obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Thickness> ObservePadding(this Avalonia.Controls.Primitives.TemplatedControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty);
    }

    public static T OnPadding<T>(this T obj, Action<Avalonia.Controls.Primitives.TemplatedControl, IObservable<Avalonia.Thickness>> handler) where T : Avalonia.Controls.Primitives.TemplatedControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.TemplatedControl.PaddingProperty);
        handler(obj, observable);
        return obj;
    }

    // TemplateProperty

    public static T Template<T>(this T obj, Avalonia.Controls.Templates.IControlTemplate value) where T : Avalonia.Controls.Primitives.TemplatedControl
    {
        obj[Avalonia.Controls.Primitives.TemplatedControl.TemplateProperty] = value;
        return obj;
    }

    public static T Template<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.TemplatedControl
    {
        obj[Avalonia.Controls.Primitives.TemplatedControl.TemplateProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Template<T>(this T obj, IObservable<Avalonia.Controls.Templates.IControlTemplate> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Primitives.TemplatedControl
    {
        obj[Avalonia.Controls.Primitives.TemplatedControl.TemplateProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindTemplate(this Avalonia.Controls.Primitives.TemplatedControl obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.TemplatedControl.TemplateProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.Templates.IControlTemplate> ObserveTemplate(this Avalonia.Controls.Primitives.TemplatedControl obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.TemplatedControl.TemplateProperty);
    }

    public static T OnTemplate<T>(this T obj, Action<Avalonia.Controls.Primitives.TemplatedControl, IObservable<Avalonia.Controls.Templates.IControlTemplate>> handler) where T : Avalonia.Controls.Primitives.TemplatedControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.TemplatedControl.TemplateProperty);
        handler(obj, observable);
        return obj;
    }

    // IsTemplateFocusTargetProperty

    public static T IsTemplateFocusTarget<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.Primitives.TemplatedControl.IsTemplateFocusTargetProperty] = value;
        return obj;
    }

    public static T IsTemplateFocusTarget<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.Primitives.TemplatedControl.IsTemplateFocusTargetProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T IsTemplateFocusTarget<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Control
    {
        obj[Avalonia.Controls.Primitives.TemplatedControl.IsTemplateFocusTargetProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindIsTemplateFocusTarget(this Avalonia.Controls.Control obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Primitives.TemplatedControl.IsTemplateFocusTargetProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveIsTemplateFocusTarget(this Avalonia.Controls.Control obj)
    {
        return obj.GetObservable(Avalonia.Controls.Primitives.TemplatedControl.IsTemplateFocusTargetProperty);
    }

    public static T OnIsTemplateFocusTarget<T>(this T obj, Action<Avalonia.Controls.Control, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.Control
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.TemplatedControl.IsTemplateFocusTargetProperty);
        handler(obj, observable);
        return obj;
    }

    // TemplateAppliedEvent

    public static T OnTemplateAppliedHandler<T>(this T obj, Action<T, Avalonia.Controls.Primitives.TemplateAppliedEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Direct) where T : Avalonia.Controls.Primitives.TemplatedControl
    {
        obj.AddHandler(Avalonia.Controls.Primitives.TemplatedControl.TemplateAppliedEvent, (_, args) => action(obj, args), routes);
        return obj;
    }

    public static T OnTemplateApplied<T>(this T obj, Action<T, IObservable<Avalonia.Controls.Primitives.TemplateAppliedEventArgs>> handler,  Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Direct) where T : Avalonia.Controls.Primitives.TemplatedControl
    {
        var observable = obj.GetObservable(Avalonia.Controls.Primitives.TemplatedControl.TemplateAppliedEvent, routes);
        handler(obj, observable);
        return obj;
    }

    public static IObservable<Avalonia.Controls.Primitives.TemplateAppliedEventArgs> ObserveOnTemplateApplied(this Avalonia.Controls.Primitives.TemplatedControl obj)
    {
        return Observable
            .FromEventPattern<EventHandler<Avalonia.Controls.Primitives.TemplateAppliedEventArgs>, Avalonia.Controls.Primitives.TemplateAppliedEventArgs>(
                h => obj.TemplateApplied += h, 
                h => obj.TemplateApplied -= h)
            .Select(x => x.EventArgs);
    }
}