// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class DatePickerPresenterExtensions
{
    // DateProperty

    public static T Date<T>(this T obj, System.DateTimeOffset value) where T : Avalonia.Controls.DatePickerPresenter
    {
        obj[Avalonia.Controls.DatePickerPresenter.DateProperty] = value;
        return obj;
    }

    public static T Date<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePickerPresenter
    {
        obj[Avalonia.Controls.DatePickerPresenter.DateProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Date<T>(this T obj, IObservable<System.DateTimeOffset> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePickerPresenter
    {
        obj[Avalonia.Controls.DatePickerPresenter.DateProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindDate(this Avalonia.Controls.DatePickerPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.DatePickerPresenter.DateProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.DateTimeOffset> ObserveDate(this Avalonia.Controls.DatePickerPresenter obj)
    {
        return obj.GetObservable(Avalonia.Controls.DatePickerPresenter.DateProperty);
    }

    public static T OnDate<T>(this T obj, Action<Avalonia.Controls.DatePickerPresenter, IObservable<System.DateTimeOffset>> handler) where T : Avalonia.Controls.DatePickerPresenter
    {
        var observable = obj.GetObservable(Avalonia.Controls.DatePickerPresenter.DateProperty);
        handler(obj, observable);
        return obj;
    }

    // DayFormatProperty

    public static T DayFormat<T>(this T obj, System.String value) where T : Avalonia.Controls.DatePickerPresenter
    {
        obj[Avalonia.Controls.DatePickerPresenter.DayFormatProperty] = value;
        return obj;
    }

    public static T DayFormat<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePickerPresenter
    {
        obj[Avalonia.Controls.DatePickerPresenter.DayFormatProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T DayFormat<T>(this T obj, IObservable<System.String> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePickerPresenter
    {
        obj[Avalonia.Controls.DatePickerPresenter.DayFormatProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindDayFormat(this Avalonia.Controls.DatePickerPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.DatePickerPresenter.DayFormatProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.String> ObserveDayFormat(this Avalonia.Controls.DatePickerPresenter obj)
    {
        return obj.GetObservable(Avalonia.Controls.DatePickerPresenter.DayFormatProperty);
    }

    public static T OnDayFormat<T>(this T obj, Action<Avalonia.Controls.DatePickerPresenter, IObservable<System.String>> handler) where T : Avalonia.Controls.DatePickerPresenter
    {
        var observable = obj.GetObservable(Avalonia.Controls.DatePickerPresenter.DayFormatProperty);
        handler(obj, observable);
        return obj;
    }

    // DayVisibleProperty

    public static T DayVisible<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.DatePickerPresenter
    {
        obj[Avalonia.Controls.DatePickerPresenter.DayVisibleProperty] = value;
        return obj;
    }

    public static T DayVisible<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePickerPresenter
    {
        obj[Avalonia.Controls.DatePickerPresenter.DayVisibleProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T DayVisible<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePickerPresenter
    {
        obj[Avalonia.Controls.DatePickerPresenter.DayVisibleProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindDayVisible(this Avalonia.Controls.DatePickerPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.DatePickerPresenter.DayVisibleProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveDayVisible(this Avalonia.Controls.DatePickerPresenter obj)
    {
        return obj.GetObservable(Avalonia.Controls.DatePickerPresenter.DayVisibleProperty);
    }

    public static T OnDayVisible<T>(this T obj, Action<Avalonia.Controls.DatePickerPresenter, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.DatePickerPresenter
    {
        var observable = obj.GetObservable(Avalonia.Controls.DatePickerPresenter.DayVisibleProperty);
        handler(obj, observable);
        return obj;
    }

    // MaxYearProperty

    public static T MaxYear<T>(this T obj, System.DateTimeOffset value) where T : Avalonia.Controls.DatePickerPresenter
    {
        obj[Avalonia.Controls.DatePickerPresenter.MaxYearProperty] = value;
        return obj;
    }

    public static T MaxYear<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePickerPresenter
    {
        obj[Avalonia.Controls.DatePickerPresenter.MaxYearProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T MaxYear<T>(this T obj, IObservable<System.DateTimeOffset> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePickerPresenter
    {
        obj[Avalonia.Controls.DatePickerPresenter.MaxYearProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindMaxYear(this Avalonia.Controls.DatePickerPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.DatePickerPresenter.MaxYearProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.DateTimeOffset> ObserveMaxYear(this Avalonia.Controls.DatePickerPresenter obj)
    {
        return obj.GetObservable(Avalonia.Controls.DatePickerPresenter.MaxYearProperty);
    }

    public static T OnMaxYear<T>(this T obj, Action<Avalonia.Controls.DatePickerPresenter, IObservable<System.DateTimeOffset>> handler) where T : Avalonia.Controls.DatePickerPresenter
    {
        var observable = obj.GetObservable(Avalonia.Controls.DatePickerPresenter.MaxYearProperty);
        handler(obj, observable);
        return obj;
    }

    // MinYearProperty

    public static T MinYear<T>(this T obj, System.DateTimeOffset value) where T : Avalonia.Controls.DatePickerPresenter
    {
        obj[Avalonia.Controls.DatePickerPresenter.MinYearProperty] = value;
        return obj;
    }

    public static T MinYear<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePickerPresenter
    {
        obj[Avalonia.Controls.DatePickerPresenter.MinYearProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T MinYear<T>(this T obj, IObservable<System.DateTimeOffset> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePickerPresenter
    {
        obj[Avalonia.Controls.DatePickerPresenter.MinYearProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindMinYear(this Avalonia.Controls.DatePickerPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.DatePickerPresenter.MinYearProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.DateTimeOffset> ObserveMinYear(this Avalonia.Controls.DatePickerPresenter obj)
    {
        return obj.GetObservable(Avalonia.Controls.DatePickerPresenter.MinYearProperty);
    }

    public static T OnMinYear<T>(this T obj, Action<Avalonia.Controls.DatePickerPresenter, IObservable<System.DateTimeOffset>> handler) where T : Avalonia.Controls.DatePickerPresenter
    {
        var observable = obj.GetObservable(Avalonia.Controls.DatePickerPresenter.MinYearProperty);
        handler(obj, observable);
        return obj;
    }

    // MonthFormatProperty

    public static T MonthFormat<T>(this T obj, System.String value) where T : Avalonia.Controls.DatePickerPresenter
    {
        obj[Avalonia.Controls.DatePickerPresenter.MonthFormatProperty] = value;
        return obj;
    }

    public static T MonthFormat<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePickerPresenter
    {
        obj[Avalonia.Controls.DatePickerPresenter.MonthFormatProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T MonthFormat<T>(this T obj, IObservable<System.String> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePickerPresenter
    {
        obj[Avalonia.Controls.DatePickerPresenter.MonthFormatProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindMonthFormat(this Avalonia.Controls.DatePickerPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.DatePickerPresenter.MonthFormatProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.String> ObserveMonthFormat(this Avalonia.Controls.DatePickerPresenter obj)
    {
        return obj.GetObservable(Avalonia.Controls.DatePickerPresenter.MonthFormatProperty);
    }

    public static T OnMonthFormat<T>(this T obj, Action<Avalonia.Controls.DatePickerPresenter, IObservable<System.String>> handler) where T : Avalonia.Controls.DatePickerPresenter
    {
        var observable = obj.GetObservable(Avalonia.Controls.DatePickerPresenter.MonthFormatProperty);
        handler(obj, observable);
        return obj;
    }

    // MonthVisibleProperty

    public static T MonthVisible<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.DatePickerPresenter
    {
        obj[Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty] = value;
        return obj;
    }

    public static T MonthVisible<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePickerPresenter
    {
        obj[Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T MonthVisible<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePickerPresenter
    {
        obj[Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindMonthVisible(this Avalonia.Controls.DatePickerPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveMonthVisible(this Avalonia.Controls.DatePickerPresenter obj)
    {
        return obj.GetObservable(Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty);
    }

    public static T OnMonthVisible<T>(this T obj, Action<Avalonia.Controls.DatePickerPresenter, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.DatePickerPresenter
    {
        var observable = obj.GetObservable(Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty);
        handler(obj, observable);
        return obj;
    }

    // YearFormatProperty

    public static T YearFormat<T>(this T obj, System.String value) where T : Avalonia.Controls.DatePickerPresenter
    {
        obj[Avalonia.Controls.DatePickerPresenter.YearFormatProperty] = value;
        return obj;
    }

    public static T YearFormat<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePickerPresenter
    {
        obj[Avalonia.Controls.DatePickerPresenter.YearFormatProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T YearFormat<T>(this T obj, IObservable<System.String> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePickerPresenter
    {
        obj[Avalonia.Controls.DatePickerPresenter.YearFormatProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindYearFormat(this Avalonia.Controls.DatePickerPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.DatePickerPresenter.YearFormatProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.String> ObserveYearFormat(this Avalonia.Controls.DatePickerPresenter obj)
    {
        return obj.GetObservable(Avalonia.Controls.DatePickerPresenter.YearFormatProperty);
    }

    public static T OnYearFormat<T>(this T obj, Action<Avalonia.Controls.DatePickerPresenter, IObservable<System.String>> handler) where T : Avalonia.Controls.DatePickerPresenter
    {
        var observable = obj.GetObservable(Avalonia.Controls.DatePickerPresenter.YearFormatProperty);
        handler(obj, observable);
        return obj;
    }

    // YearVisibleProperty

    public static T YearVisible<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.DatePickerPresenter
    {
        obj[Avalonia.Controls.DatePickerPresenter.YearVisibleProperty] = value;
        return obj;
    }

    public static T YearVisible<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePickerPresenter
    {
        obj[Avalonia.Controls.DatePickerPresenter.YearVisibleProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T YearVisible<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.DatePickerPresenter
    {
        obj[Avalonia.Controls.DatePickerPresenter.YearVisibleProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindYearVisible(this Avalonia.Controls.DatePickerPresenter obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.DatePickerPresenter.YearVisibleProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveYearVisible(this Avalonia.Controls.DatePickerPresenter obj)
    {
        return obj.GetObservable(Avalonia.Controls.DatePickerPresenter.YearVisibleProperty);
    }

    public static T OnYearVisible<T>(this T obj, Action<Avalonia.Controls.DatePickerPresenter, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.DatePickerPresenter
    {
        var observable = obj.GetObservable(Avalonia.Controls.DatePickerPresenter.YearVisibleProperty);
        handler(obj, observable);
        return obj;
    }
}