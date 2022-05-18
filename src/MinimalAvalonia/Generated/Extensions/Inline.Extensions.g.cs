// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class InlineExtensions
{
    // TextDecorationsProperty

    public static T TextDecorations<T>(this T obj, Avalonia.Media.TextDecorationCollection value) where T : Avalonia.Controls.Documents.Inline
    {
        obj[Avalonia.Controls.Documents.Inline.TextDecorationsProperty] = value;
        return obj;
    }

    public static T TextDecorations<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Documents.Inline
    {
        obj[Avalonia.Controls.Documents.Inline.TextDecorationsProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T TextDecorations<T>(this T obj, IObservable<Avalonia.Media.TextDecorationCollection> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Documents.Inline
    {
        obj[Avalonia.Controls.Documents.Inline.TextDecorationsProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindTextDecorations(this Avalonia.Controls.Documents.Inline obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Documents.Inline.TextDecorationsProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.TextDecorationCollection> ObserveTextDecorations(this Avalonia.Controls.Documents.Inline obj)
    {
        return obj.GetObservable(Avalonia.Controls.Documents.Inline.TextDecorationsProperty);
    }

    public static T OnTextDecorations<T>(this T obj, Action<Avalonia.Controls.Documents.Inline, IObservable<Avalonia.Media.TextDecorationCollection>> handler) where T : Avalonia.Controls.Documents.Inline
    {
        var observable = obj.GetObservable(Avalonia.Controls.Documents.Inline.TextDecorationsProperty);
        handler(obj, observable);
        return obj;
    }

    // BaselineAlignmentProperty

    public static T BaselineAlignment<T>(this T obj, Avalonia.Media.BaselineAlignment value) where T : Avalonia.Controls.Documents.Inline
    {
        obj[Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty] = value;
        return obj;
    }

    public static T BaselineAlignment<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Documents.Inline
    {
        obj[Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T BaselineAlignment<T>(this T obj, IObservable<Avalonia.Media.BaselineAlignment> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Documents.Inline
    {
        obj[Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindBaselineAlignment(this Avalonia.Controls.Documents.Inline obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Media.BaselineAlignment> ObserveBaselineAlignment(this Avalonia.Controls.Documents.Inline obj)
    {
        return obj.GetObservable(Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty);
    }

    public static T OnBaselineAlignment<T>(this T obj, Action<Avalonia.Controls.Documents.Inline, IObservable<Avalonia.Media.BaselineAlignment>> handler) where T : Avalonia.Controls.Documents.Inline
    {
        var observable = obj.GetObservable(Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty);
        handler(obj, observable);
        return obj;
    }

    public static T BaselineAlignmentTop<T>(this T obj) where T : Avalonia.Controls.Documents.Inline
    {
        obj[Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty] = Avalonia.Media.BaselineAlignment.Top;
        return obj;
    }

    public static T BaselineAlignmentCenter<T>(this T obj) where T : Avalonia.Controls.Documents.Inline
    {
        obj[Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty] = Avalonia.Media.BaselineAlignment.Center;
        return obj;
    }

    public static T BaselineAlignmentBottom<T>(this T obj) where T : Avalonia.Controls.Documents.Inline
    {
        obj[Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty] = Avalonia.Media.BaselineAlignment.Bottom;
        return obj;
    }

    public static T BaselineAlignmentBaseline<T>(this T obj) where T : Avalonia.Controls.Documents.Inline
    {
        obj[Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty] = Avalonia.Media.BaselineAlignment.Baseline;
        return obj;
    }

    public static T BaselineAlignmentTextTop<T>(this T obj) where T : Avalonia.Controls.Documents.Inline
    {
        obj[Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty] = Avalonia.Media.BaselineAlignment.TextTop;
        return obj;
    }

    public static T BaselineAlignmentTextBottom<T>(this T obj) where T : Avalonia.Controls.Documents.Inline
    {
        obj[Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty] = Avalonia.Media.BaselineAlignment.TextBottom;
        return obj;
    }

    public static T BaselineAlignmentSubscript<T>(this T obj) where T : Avalonia.Controls.Documents.Inline
    {
        obj[Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty] = Avalonia.Media.BaselineAlignment.Subscript;
        return obj;
    }

    public static T BaselineAlignmentSuperscript<T>(this T obj) where T : Avalonia.Controls.Documents.Inline
    {
        obj[Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty] = Avalonia.Media.BaselineAlignment.Superscript;
        return obj;
    }
}