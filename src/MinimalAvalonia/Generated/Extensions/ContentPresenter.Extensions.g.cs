// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class ContentPresenterExtensions
{
    // BackgroundProperty

    public static T Background<T>(this T obj, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.BackgroundProperty] = value;
        return obj;
    }

    public static T Background<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.BackgroundProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Background<T>(this T obj, IObservable<Avalonia.Media.IBrush> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.BackgroundProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindBackground(this Avalonia.Controls.Presenters.ContentPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Presenters.ContentPresenter.BackgroundProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.IBrush> ObserveBackground(this Avalonia.Controls.Presenters.ContentPresenter obj)
    {
        return obj.GetObservable(Avalonia.Controls.Presenters.ContentPresenter.BackgroundProperty);
    }

    public static T OnBackground<T>(this T obj, Action<Avalonia.Controls.Presenters.ContentPresenter, IObservable<Avalonia.Media.IBrush>> handler) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        var observable = obj.GetObservable(Avalonia.Controls.Presenters.ContentPresenter.BackgroundProperty);
        handler(obj, observable);
        return obj;
    }

    // BorderBrushProperty

    public static T BorderBrush<T>(this T obj, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.BorderBrushProperty] = value;
        return obj;
    }

    public static T BorderBrush<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.BorderBrushProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T BorderBrush<T>(this T obj, IObservable<Avalonia.Media.IBrush> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.BorderBrushProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindBorderBrush(this Avalonia.Controls.Presenters.ContentPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Presenters.ContentPresenter.BorderBrushProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.IBrush> ObserveBorderBrush(this Avalonia.Controls.Presenters.ContentPresenter obj)
    {
        return obj.GetObservable(Avalonia.Controls.Presenters.ContentPresenter.BorderBrushProperty);
    }

    public static T OnBorderBrush<T>(this T obj, Action<Avalonia.Controls.Presenters.ContentPresenter, IObservable<Avalonia.Media.IBrush>> handler) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        var observable = obj.GetObservable(Avalonia.Controls.Presenters.ContentPresenter.BorderBrushProperty);
        handler(obj, observable);
        return obj;
    }

    // BorderThicknessProperty

    public static T BorderThickness<T>(this T obj, Avalonia.Thickness value) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty] = value;
        return obj;
    }

    public static T BorderThickness<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T BorderThickness<T>(this T obj, IObservable<Avalonia.Thickness> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindBorderThickness(this Avalonia.Controls.Presenters.ContentPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Thickness> ObserveBorderThickness(this Avalonia.Controls.Presenters.ContentPresenter obj)
    {
        return obj.GetObservable(Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty);
    }

    public static T OnBorderThickness<T>(this T obj, Action<Avalonia.Controls.Presenters.ContentPresenter, IObservable<Avalonia.Thickness>> handler) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        var observable = obj.GetObservable(Avalonia.Controls.Presenters.ContentPresenter.BorderThicknessProperty);
        handler(obj, observable);
        return obj;
    }

    // CornerRadiusProperty

    public static T CornerRadius<T>(this T obj, Avalonia.CornerRadius value) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty] = value;
        return obj;
    }

    public static T CornerRadius<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T CornerRadius<T>(this T obj, IObservable<Avalonia.CornerRadius> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindCornerRadius(this Avalonia.Controls.Presenters.ContentPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.CornerRadius> ObserveCornerRadius(this Avalonia.Controls.Presenters.ContentPresenter obj)
    {
        return obj.GetObservable(Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty);
    }

    public static T OnCornerRadius<T>(this T obj, Action<Avalonia.Controls.Presenters.ContentPresenter, IObservable<Avalonia.CornerRadius>> handler) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        var observable = obj.GetObservable(Avalonia.Controls.Presenters.ContentPresenter.CornerRadiusProperty);
        handler(obj, observable);
        return obj;
    }

    // BoxShadowProperty

    public static T BoxShadow<T>(this T obj, Avalonia.Media.BoxShadows value) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty] = value;
        return obj;
    }

    public static T BoxShadow<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T BoxShadow<T>(this T obj, IObservable<Avalonia.Media.BoxShadows> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindBoxShadow(this Avalonia.Controls.Presenters.ContentPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.BoxShadows> ObserveBoxShadow(this Avalonia.Controls.Presenters.ContentPresenter obj)
    {
        return obj.GetObservable(Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty);
    }

    public static T OnBoxShadow<T>(this T obj, Action<Avalonia.Controls.Presenters.ContentPresenter, IObservable<Avalonia.Media.BoxShadows>> handler) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        var observable = obj.GetObservable(Avalonia.Controls.Presenters.ContentPresenter.BoxShadowProperty);
        handler(obj, observable);
        return obj;
    }

    // ChildProperty

    public static Avalonia.Data.IBinding BindChild(this Avalonia.Controls.Presenters.ContentPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay)
    {
        return obj[Avalonia.Controls.Presenters.ContentPresenter.ChildProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.IControl> ObserveChild(this Avalonia.Controls.Presenters.ContentPresenter obj)
    {
        return obj.GetObservable(Avalonia.Controls.Presenters.ContentPresenter.ChildProperty);
    }

    public static Avalonia.Controls.Presenters.ContentPresenter OnChild(this Avalonia.Controls.Presenters.ContentPresenter obj, Action<Avalonia.Controls.Presenters.ContentPresenter, IObservable<Avalonia.Controls.IControl>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.Presenters.ContentPresenter.ChildProperty);
        handler(obj, observable);
        return obj;
    }

    // ContentProperty

    public static T Content<T>(this T obj, System.Object value) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.ContentProperty] = value;
        return obj;
    }

    public static T Content<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.ContentProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Content<T>(this T obj, IObservable<System.Object> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.ContentProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindContent(this Avalonia.Controls.Presenters.ContentPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Presenters.ContentPresenter.ContentProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Object> ObserveContent(this Avalonia.Controls.Presenters.ContentPresenter obj)
    {
        return obj.GetObservable(Avalonia.Controls.Presenters.ContentPresenter.ContentProperty);
    }

    public static T OnContent<T>(this T obj, Action<Avalonia.Controls.Presenters.ContentPresenter, IObservable<System.Object>> handler) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        var observable = obj.GetObservable(Avalonia.Controls.Presenters.ContentPresenter.ContentProperty);
        handler(obj, observable);
        return obj;
    }

    // ContentTemplateProperty

    public static T ContentTemplate<T>(this T obj, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.ContentTemplateProperty] = value;
        return obj;
    }

    public static T ContentTemplate<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.ContentTemplateProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T ContentTemplate<T>(this T obj, IObservable<Avalonia.Controls.Templates.IDataTemplate> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.ContentTemplateProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindContentTemplate(this Avalonia.Controls.Presenters.ContentPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Presenters.ContentPresenter.ContentTemplateProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.Templates.IDataTemplate> ObserveContentTemplate(this Avalonia.Controls.Presenters.ContentPresenter obj)
    {
        return obj.GetObservable(Avalonia.Controls.Presenters.ContentPresenter.ContentTemplateProperty);
    }

    public static T OnContentTemplate<T>(this T obj, Action<Avalonia.Controls.Presenters.ContentPresenter, IObservable<Avalonia.Controls.Templates.IDataTemplate>> handler) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        var observable = obj.GetObservable(Avalonia.Controls.Presenters.ContentPresenter.ContentTemplateProperty);
        handler(obj, observable);
        return obj;
    }

    // HorizontalContentAlignmentProperty

    public static T HorizontalContentAlignment<T>(this T obj, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.HorizontalContentAlignmentProperty] = value;
        return obj;
    }

    public static T HorizontalContentAlignment<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.HorizontalContentAlignmentProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T HorizontalContentAlignment<T>(this T obj, IObservable<Avalonia.Layout.HorizontalAlignment> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.HorizontalContentAlignmentProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindHorizontalContentAlignment(this Avalonia.Controls.Presenters.ContentPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Presenters.ContentPresenter.HorizontalContentAlignmentProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Layout.HorizontalAlignment> ObserveHorizontalContentAlignment(this Avalonia.Controls.Presenters.ContentPresenter obj)
    {
        return obj.GetObservable(Avalonia.Controls.Presenters.ContentPresenter.HorizontalContentAlignmentProperty);
    }

    public static T OnHorizontalContentAlignment<T>(this T obj, Action<Avalonia.Controls.Presenters.ContentPresenter, IObservable<Avalonia.Layout.HorizontalAlignment>> handler) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        var observable = obj.GetObservable(Avalonia.Controls.Presenters.ContentPresenter.HorizontalContentAlignmentProperty);
        handler(obj, observable);
        return obj;
    }

    public static T HorizontalContentAlignmentStretch<T>(this T obj) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.HorizontalContentAlignmentProperty] = Avalonia.Layout.HorizontalAlignment.Stretch;
        return obj;
    }

    public static T HorizontalContentAlignmentLeft<T>(this T obj) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.HorizontalContentAlignmentProperty] = Avalonia.Layout.HorizontalAlignment.Left;
        return obj;
    }

    public static T HorizontalContentAlignmentCenter<T>(this T obj) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.HorizontalContentAlignmentProperty] = Avalonia.Layout.HorizontalAlignment.Center;
        return obj;
    }

    public static T HorizontalContentAlignmentRight<T>(this T obj) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.HorizontalContentAlignmentProperty] = Avalonia.Layout.HorizontalAlignment.Right;
        return obj;
    }

    // VerticalContentAlignmentProperty

    public static T VerticalContentAlignment<T>(this T obj, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.VerticalContentAlignmentProperty] = value;
        return obj;
    }

    public static T VerticalContentAlignment<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.VerticalContentAlignmentProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T VerticalContentAlignment<T>(this T obj, IObservable<Avalonia.Layout.VerticalAlignment> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.VerticalContentAlignmentProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindVerticalContentAlignment(this Avalonia.Controls.Presenters.ContentPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Presenters.ContentPresenter.VerticalContentAlignmentProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Layout.VerticalAlignment> ObserveVerticalContentAlignment(this Avalonia.Controls.Presenters.ContentPresenter obj)
    {
        return obj.GetObservable(Avalonia.Controls.Presenters.ContentPresenter.VerticalContentAlignmentProperty);
    }

    public static T OnVerticalContentAlignment<T>(this T obj, Action<Avalonia.Controls.Presenters.ContentPresenter, IObservable<Avalonia.Layout.VerticalAlignment>> handler) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        var observable = obj.GetObservable(Avalonia.Controls.Presenters.ContentPresenter.VerticalContentAlignmentProperty);
        handler(obj, observable);
        return obj;
    }

    public static T VerticalContentAlignmentStretch<T>(this T obj) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.VerticalContentAlignmentProperty] = Avalonia.Layout.VerticalAlignment.Stretch;
        return obj;
    }

    public static T VerticalContentAlignmentTop<T>(this T obj) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.VerticalContentAlignmentProperty] = Avalonia.Layout.VerticalAlignment.Top;
        return obj;
    }

    public static T VerticalContentAlignmentCenter<T>(this T obj) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.VerticalContentAlignmentProperty] = Avalonia.Layout.VerticalAlignment.Center;
        return obj;
    }

    public static T VerticalContentAlignmentBottom<T>(this T obj) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.VerticalContentAlignmentProperty] = Avalonia.Layout.VerticalAlignment.Bottom;
        return obj;
    }

    // PaddingProperty

    public static T Padding<T>(this T obj, Avalonia.Thickness value) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty] = value;
        return obj;
    }

    public static T Padding<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Padding<T>(this T obj, IObservable<Avalonia.Thickness> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindPadding(this Avalonia.Controls.Presenters.ContentPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Thickness> ObservePadding(this Avalonia.Controls.Presenters.ContentPresenter obj)
    {
        return obj.GetObservable(Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty);
    }

    public static T OnPadding<T>(this T obj, Action<Avalonia.Controls.Presenters.ContentPresenter, IObservable<Avalonia.Thickness>> handler) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        var observable = obj.GetObservable(Avalonia.Controls.Presenters.ContentPresenter.PaddingProperty);
        handler(obj, observable);
        return obj;
    }

    // RecognizesAccessKeyProperty

    public static T RecognizesAccessKey<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.RecognizesAccessKeyProperty] = value;
        return obj;
    }

    public static T RecognizesAccessKey<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.RecognizesAccessKeyProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T RecognizesAccessKey<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        obj[Avalonia.Controls.Presenters.ContentPresenter.RecognizesAccessKeyProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindRecognizesAccessKey(this Avalonia.Controls.Presenters.ContentPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Presenters.ContentPresenter.RecognizesAccessKeyProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveRecognizesAccessKey(this Avalonia.Controls.Presenters.ContentPresenter obj)
    {
        return obj.GetObservable(Avalonia.Controls.Presenters.ContentPresenter.RecognizesAccessKeyProperty);
    }

    public static T OnRecognizesAccessKey<T>(this T obj, Action<Avalonia.Controls.Presenters.ContentPresenter, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.Presenters.ContentPresenter
    {
        var observable = obj.GetObservable(Avalonia.Controls.Presenters.ContentPresenter.RecognizesAccessKeyProperty);
        handler(obj, observable);
        return obj;
    }
}