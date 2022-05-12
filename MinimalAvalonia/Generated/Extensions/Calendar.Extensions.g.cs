// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class CalendarExtensions
{
    // FirstDayOfWeekProperty

    public static T FirstDayOfWeek<T>(this T obj, System.DayOfWeek value) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.FirstDayOfWeekProperty] = value;
        return obj;
    }

    public static T FirstDayOfWeek<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.FirstDayOfWeekProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding FirstDayOfWeek(this Avalonia.Controls.Calendar obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Calendar.FirstDayOfWeekProperty.Bind().WithMode(mode)];
    }

    public static T FirstDayOfWeekSunday<T>(this T obj) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.FirstDayOfWeekProperty] = System.DayOfWeek.Sunday;
        return obj;
    }

    public static T FirstDayOfWeekMonday<T>(this T obj) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.FirstDayOfWeekProperty] = System.DayOfWeek.Monday;
        return obj;
    }

    public static T FirstDayOfWeekTuesday<T>(this T obj) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.FirstDayOfWeekProperty] = System.DayOfWeek.Tuesday;
        return obj;
    }

    public static T FirstDayOfWeekWednesday<T>(this T obj) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.FirstDayOfWeekProperty] = System.DayOfWeek.Wednesday;
        return obj;
    }

    public static T FirstDayOfWeekThursday<T>(this T obj) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.FirstDayOfWeekProperty] = System.DayOfWeek.Thursday;
        return obj;
    }

    public static T FirstDayOfWeekFriday<T>(this T obj) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.FirstDayOfWeekProperty] = System.DayOfWeek.Friday;
        return obj;
    }

    public static T FirstDayOfWeekSaturday<T>(this T obj) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.FirstDayOfWeekProperty] = System.DayOfWeek.Saturday;
        return obj;
    }

    // IsTodayHighlightedProperty

    public static T IsTodayHighlighted<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.IsTodayHighlightedProperty] = value;
        return obj;
    }

    public static T IsTodayHighlighted<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.IsTodayHighlightedProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding IsTodayHighlighted(this Avalonia.Controls.Calendar obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Calendar.IsTodayHighlightedProperty.Bind().WithMode(mode)];
    }

    // HeaderBackgroundProperty

    public static T HeaderBackground<T>(this T obj, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.HeaderBackgroundProperty] = value;
        return obj;
    }

    public static T HeaderBackground<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.HeaderBackgroundProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding HeaderBackground(this Avalonia.Controls.Calendar obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Calendar.HeaderBackgroundProperty.Bind().WithMode(mode)];
    }

    // DisplayModeProperty

    public static T DisplayMode<T>(this T obj, Avalonia.Controls.CalendarMode value) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.DisplayModeProperty] = value;
        return obj;
    }

    public static T DisplayMode<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.DisplayModeProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding DisplayMode(this Avalonia.Controls.Calendar obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Calendar.DisplayModeProperty.Bind().WithMode(mode)];
    }

    public static T DisplayModeMonth<T>(this T obj) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.DisplayModeProperty] = Avalonia.Controls.CalendarMode.Month;
        return obj;
    }

    public static T DisplayModeYear<T>(this T obj) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.DisplayModeProperty] = Avalonia.Controls.CalendarMode.Year;
        return obj;
    }

    public static T DisplayModeDecade<T>(this T obj) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.DisplayModeProperty] = Avalonia.Controls.CalendarMode.Decade;
        return obj;
    }

    // SelectionModeProperty

    public static T SelectionMode<T>(this T obj, Avalonia.Controls.CalendarSelectionMode value) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.SelectionModeProperty] = value;
        return obj;
    }

    public static T SelectionMode<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.SelectionModeProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding SelectionMode(this Avalonia.Controls.Calendar obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Calendar.SelectionModeProperty.Bind().WithMode(mode)];
    }

    public static T SelectionModeSingleDate<T>(this T obj) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.SelectionModeProperty] = Avalonia.Controls.CalendarSelectionMode.SingleDate;
        return obj;
    }

    public static T SelectionModeSingleRange<T>(this T obj) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.SelectionModeProperty] = Avalonia.Controls.CalendarSelectionMode.SingleRange;
        return obj;
    }

    public static T SelectionModeMultipleRange<T>(this T obj) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.SelectionModeProperty] = Avalonia.Controls.CalendarSelectionMode.MultipleRange;
        return obj;
    }

    public static T SelectionModeNone<T>(this T obj) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.SelectionModeProperty] = Avalonia.Controls.CalendarSelectionMode.None;
        return obj;
    }

    // SelectedDateProperty

    public static T SelectedDate<T>(this T obj, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.SelectedDateProperty] = value;
        return obj;
    }

    public static T SelectedDate<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.SelectedDateProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding SelectedDate(this Avalonia.Controls.Calendar obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Calendar.SelectedDateProperty.Bind().WithMode(mode)];
    }

    // DisplayDateProperty

    public static T DisplayDate<T>(this T obj, System.DateTime value) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.DisplayDateProperty] = value;
        return obj;
    }

    public static T DisplayDate<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.DisplayDateProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding DisplayDate(this Avalonia.Controls.Calendar obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Calendar.DisplayDateProperty.Bind().WithMode(mode)];
    }

    // DisplayDateStartProperty

    public static T DisplayDateStart<T>(this T obj, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.DisplayDateStartProperty] = value;
        return obj;
    }

    public static T DisplayDateStart<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.DisplayDateStartProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding DisplayDateStart(this Avalonia.Controls.Calendar obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Calendar.DisplayDateStartProperty.Bind().WithMode(mode)];
    }

    // DisplayDateEndProperty

    public static T DisplayDateEnd<T>(this T obj, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.DisplayDateEndProperty] = value;
        return obj;
    }

    public static T DisplayDateEnd<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.Calendar
    {
        obj[Avalonia.Controls.Calendar.DisplayDateEndProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding DisplayDateEnd(this Avalonia.Controls.Calendar obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.Calendar.DisplayDateEndProperty.Bind().WithMode(mode)];
    }
}