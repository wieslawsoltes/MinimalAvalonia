// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class AutoCompleteBoxExtensions
{
    // WatermarkProperty

    public static T Watermark<T>(this T obj, System.String value) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.WatermarkProperty] = value;
        return obj;
    }

    public static T Watermark<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.WatermarkProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Watermark<T>(this T obj, IObservable<System.String> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.WatermarkProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindWatermark(this Avalonia.Controls.AutoCompleteBox obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.AutoCompleteBox.WatermarkProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.String> ObserveWatermark(this Avalonia.Controls.AutoCompleteBox obj)
    {
        return obj.GetObservable(Avalonia.Controls.AutoCompleteBox.WatermarkProperty);
    }

    public static T OnWatermark<T>(this T obj, Action<Avalonia.Controls.AutoCompleteBox, IObservable<System.String>> handler) where T : Avalonia.Controls.AutoCompleteBox
    {
        var observable = obj.GetObservable(Avalonia.Controls.AutoCompleteBox.WatermarkProperty);
        handler(obj, observable);
        return obj;
    }

    // MinimumPrefixLengthProperty

    public static T MinimumPrefixLength<T>(this T obj, System.Int32 value) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.MinimumPrefixLengthProperty] = value;
        return obj;
    }

    public static T MinimumPrefixLength<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.MinimumPrefixLengthProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T MinimumPrefixLength<T>(this T obj, IObservable<System.Int32> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.MinimumPrefixLengthProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindMinimumPrefixLength(this Avalonia.Controls.AutoCompleteBox obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.AutoCompleteBox.MinimumPrefixLengthProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Int32> ObserveMinimumPrefixLength(this Avalonia.Controls.AutoCompleteBox obj)
    {
        return obj.GetObservable(Avalonia.Controls.AutoCompleteBox.MinimumPrefixLengthProperty);
    }

    public static T OnMinimumPrefixLength<T>(this T obj, Action<Avalonia.Controls.AutoCompleteBox, IObservable<System.Int32>> handler) where T : Avalonia.Controls.AutoCompleteBox
    {
        var observable = obj.GetObservable(Avalonia.Controls.AutoCompleteBox.MinimumPrefixLengthProperty);
        handler(obj, observable);
        return obj;
    }

    // MinimumPopulateDelayProperty

    public static T MinimumPopulateDelay<T>(this T obj, System.TimeSpan value) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.MinimumPopulateDelayProperty] = value;
        return obj;
    }

    public static T MinimumPopulateDelay<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.MinimumPopulateDelayProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T MinimumPopulateDelay<T>(this T obj, IObservable<System.TimeSpan> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.MinimumPopulateDelayProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindMinimumPopulateDelay(this Avalonia.Controls.AutoCompleteBox obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.AutoCompleteBox.MinimumPopulateDelayProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.TimeSpan> ObserveMinimumPopulateDelay(this Avalonia.Controls.AutoCompleteBox obj)
    {
        return obj.GetObservable(Avalonia.Controls.AutoCompleteBox.MinimumPopulateDelayProperty);
    }

    public static T OnMinimumPopulateDelay<T>(this T obj, Action<Avalonia.Controls.AutoCompleteBox, IObservable<System.TimeSpan>> handler) where T : Avalonia.Controls.AutoCompleteBox
    {
        var observable = obj.GetObservable(Avalonia.Controls.AutoCompleteBox.MinimumPopulateDelayProperty);
        handler(obj, observable);
        return obj;
    }

    // MaxDropDownHeightProperty

    public static T MaxDropDownHeight<T>(this T obj, System.Double value) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.MaxDropDownHeightProperty] = value;
        return obj;
    }

    public static T MaxDropDownHeight<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.MaxDropDownHeightProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T MaxDropDownHeight<T>(this T obj, IObservable<System.Double> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.MaxDropDownHeightProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindMaxDropDownHeight(this Avalonia.Controls.AutoCompleteBox obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.AutoCompleteBox.MaxDropDownHeightProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Double> ObserveMaxDropDownHeight(this Avalonia.Controls.AutoCompleteBox obj)
    {
        return obj.GetObservable(Avalonia.Controls.AutoCompleteBox.MaxDropDownHeightProperty);
    }

    public static T OnMaxDropDownHeight<T>(this T obj, Action<Avalonia.Controls.AutoCompleteBox, IObservable<System.Double>> handler) where T : Avalonia.Controls.AutoCompleteBox
    {
        var observable = obj.GetObservable(Avalonia.Controls.AutoCompleteBox.MaxDropDownHeightProperty);
        handler(obj, observable);
        return obj;
    }

    // IsTextCompletionEnabledProperty

    public static T IsTextCompletionEnabled<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.IsTextCompletionEnabledProperty] = value;
        return obj;
    }

    public static T IsTextCompletionEnabled<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.IsTextCompletionEnabledProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T IsTextCompletionEnabled<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.IsTextCompletionEnabledProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindIsTextCompletionEnabled(this Avalonia.Controls.AutoCompleteBox obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.AutoCompleteBox.IsTextCompletionEnabledProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveIsTextCompletionEnabled(this Avalonia.Controls.AutoCompleteBox obj)
    {
        return obj.GetObservable(Avalonia.Controls.AutoCompleteBox.IsTextCompletionEnabledProperty);
    }

    public static T OnIsTextCompletionEnabled<T>(this T obj, Action<Avalonia.Controls.AutoCompleteBox, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.AutoCompleteBox
    {
        var observable = obj.GetObservable(Avalonia.Controls.AutoCompleteBox.IsTextCompletionEnabledProperty);
        handler(obj, observable);
        return obj;
    }

    // ItemTemplateProperty

    public static T ItemTemplate<T>(this T obj, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.ItemTemplateProperty] = value;
        return obj;
    }

    public static T ItemTemplate<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.ItemTemplateProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T ItemTemplate<T>(this T obj, IObservable<Avalonia.Controls.Templates.IDataTemplate> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.ItemTemplateProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindItemTemplate(this Avalonia.Controls.AutoCompleteBox obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.AutoCompleteBox.ItemTemplateProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.Templates.IDataTemplate> ObserveItemTemplate(this Avalonia.Controls.AutoCompleteBox obj)
    {
        return obj.GetObservable(Avalonia.Controls.AutoCompleteBox.ItemTemplateProperty);
    }

    public static T OnItemTemplate<T>(this T obj, Action<Avalonia.Controls.AutoCompleteBox, IObservable<Avalonia.Controls.Templates.IDataTemplate>> handler) where T : Avalonia.Controls.AutoCompleteBox
    {
        var observable = obj.GetObservable(Avalonia.Controls.AutoCompleteBox.ItemTemplateProperty);
        handler(obj, observable);
        return obj;
    }

    // IsDropDownOpenProperty

    public static T IsDropDownOpen<T>(this T obj, System.Boolean value) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.IsDropDownOpenProperty] = value;
        return obj;
    }

    public static T IsDropDownOpen<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.IsDropDownOpenProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T IsDropDownOpen<T>(this T obj, IObservable<System.Boolean> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.IsDropDownOpenProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindIsDropDownOpen(this Avalonia.Controls.AutoCompleteBox obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.AutoCompleteBox.IsDropDownOpenProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Boolean> ObserveIsDropDownOpen(this Avalonia.Controls.AutoCompleteBox obj)
    {
        return obj.GetObservable(Avalonia.Controls.AutoCompleteBox.IsDropDownOpenProperty);
    }

    public static T OnIsDropDownOpen<T>(this T obj, Action<Avalonia.Controls.AutoCompleteBox, IObservable<System.Boolean>> handler) where T : Avalonia.Controls.AutoCompleteBox
    {
        var observable = obj.GetObservable(Avalonia.Controls.AutoCompleteBox.IsDropDownOpenProperty);
        handler(obj, observable);
        return obj;
    }

    // SelectedItemProperty

    public static T SelectedItem<T>(this T obj, System.Object value) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.SelectedItemProperty] = value;
        return obj;
    }

    public static T SelectedItem<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.SelectedItemProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T SelectedItem<T>(this T obj, IObservable<System.Object> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.SelectedItemProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindSelectedItem(this Avalonia.Controls.AutoCompleteBox obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.AutoCompleteBox.SelectedItemProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Object> ObserveSelectedItem(this Avalonia.Controls.AutoCompleteBox obj)
    {
        return obj.GetObservable(Avalonia.Controls.AutoCompleteBox.SelectedItemProperty);
    }

    public static T OnSelectedItem<T>(this T obj, Action<Avalonia.Controls.AutoCompleteBox, IObservable<System.Object>> handler) where T : Avalonia.Controls.AutoCompleteBox
    {
        var observable = obj.GetObservable(Avalonia.Controls.AutoCompleteBox.SelectedItemProperty);
        handler(obj, observable);
        return obj;
    }

    // TextProperty

    public static T Text<T>(this T obj, System.String value) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.TextProperty] = value;
        return obj;
    }

    public static T Text<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.TextProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Text<T>(this T obj, IObservable<System.String> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.TextProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindText(this Avalonia.Controls.AutoCompleteBox obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.AutoCompleteBox.TextProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.String> ObserveText(this Avalonia.Controls.AutoCompleteBox obj)
    {
        return obj.GetObservable(Avalonia.Controls.AutoCompleteBox.TextProperty);
    }

    public static T OnText<T>(this T obj, Action<Avalonia.Controls.AutoCompleteBox, IObservable<System.String>> handler) where T : Avalonia.Controls.AutoCompleteBox
    {
        var observable = obj.GetObservable(Avalonia.Controls.AutoCompleteBox.TextProperty);
        handler(obj, observable);
        return obj;
    }

    // SearchTextProperty

    public static Avalonia.Data.IBinding BindSearchText(this Avalonia.Controls.AutoCompleteBox obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.OneWay)
    {
        return obj[Avalonia.Controls.AutoCompleteBox.SearchTextProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.String> ObserveSearchText(this Avalonia.Controls.AutoCompleteBox obj)
    {
        return obj.GetObservable(Avalonia.Controls.AutoCompleteBox.SearchTextProperty);
    }

    public static Avalonia.Controls.AutoCompleteBox OnSearchText(this Avalonia.Controls.AutoCompleteBox obj, Action<Avalonia.Controls.AutoCompleteBox, IObservable<System.String>> handler)
    {
        var observable = obj.GetObservable(Avalonia.Controls.AutoCompleteBox.SearchTextProperty);
        handler(obj, observable);
        return obj;
    }

    // FilterModeProperty

    public static T FilterMode<T>(this T obj, Avalonia.Controls.AutoCompleteFilterMode value) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.FilterModeProperty] = value;
        return obj;
    }

    public static T FilterMode<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.FilterModeProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T FilterMode<T>(this T obj, IObservable<Avalonia.Controls.AutoCompleteFilterMode> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.FilterModeProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindFilterMode(this Avalonia.Controls.AutoCompleteBox obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.AutoCompleteBox.FilterModeProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.AutoCompleteFilterMode> ObserveFilterMode(this Avalonia.Controls.AutoCompleteBox obj)
    {
        return obj.GetObservable(Avalonia.Controls.AutoCompleteBox.FilterModeProperty);
    }

    public static T OnFilterMode<T>(this T obj, Action<Avalonia.Controls.AutoCompleteBox, IObservable<Avalonia.Controls.AutoCompleteFilterMode>> handler) where T : Avalonia.Controls.AutoCompleteBox
    {
        var observable = obj.GetObservable(Avalonia.Controls.AutoCompleteBox.FilterModeProperty);
        handler(obj, observable);
        return obj;
    }

    public static T FilterModeNone<T>(this T obj) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.FilterModeProperty] = Avalonia.Controls.AutoCompleteFilterMode.None;
        return obj;
    }

    public static T FilterModeStartsWith<T>(this T obj) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.FilterModeProperty] = Avalonia.Controls.AutoCompleteFilterMode.StartsWith;
        return obj;
    }

    public static T FilterModeStartsWithCaseSensitive<T>(this T obj) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.FilterModeProperty] = Avalonia.Controls.AutoCompleteFilterMode.StartsWithCaseSensitive;
        return obj;
    }

    public static T FilterModeStartsWithOrdinal<T>(this T obj) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.FilterModeProperty] = Avalonia.Controls.AutoCompleteFilterMode.StartsWithOrdinal;
        return obj;
    }

    public static T FilterModeStartsWithOrdinalCaseSensitive<T>(this T obj) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.FilterModeProperty] = Avalonia.Controls.AutoCompleteFilterMode.StartsWithOrdinalCaseSensitive;
        return obj;
    }

    public static T FilterModeContains<T>(this T obj) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.FilterModeProperty] = Avalonia.Controls.AutoCompleteFilterMode.Contains;
        return obj;
    }

    public static T FilterModeContainsCaseSensitive<T>(this T obj) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.FilterModeProperty] = Avalonia.Controls.AutoCompleteFilterMode.ContainsCaseSensitive;
        return obj;
    }

    public static T FilterModeContainsOrdinal<T>(this T obj) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.FilterModeProperty] = Avalonia.Controls.AutoCompleteFilterMode.ContainsOrdinal;
        return obj;
    }

    public static T FilterModeContainsOrdinalCaseSensitive<T>(this T obj) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.FilterModeProperty] = Avalonia.Controls.AutoCompleteFilterMode.ContainsOrdinalCaseSensitive;
        return obj;
    }

    public static T FilterModeEquals<T>(this T obj) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.FilterModeProperty] = Avalonia.Controls.AutoCompleteFilterMode.Equals;
        return obj;
    }

    public static T FilterModeEqualsCaseSensitive<T>(this T obj) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.FilterModeProperty] = Avalonia.Controls.AutoCompleteFilterMode.EqualsCaseSensitive;
        return obj;
    }

    public static T FilterModeEqualsOrdinal<T>(this T obj) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.FilterModeProperty] = Avalonia.Controls.AutoCompleteFilterMode.EqualsOrdinal;
        return obj;
    }

    public static T FilterModeEqualsOrdinalCaseSensitive<T>(this T obj) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.FilterModeProperty] = Avalonia.Controls.AutoCompleteFilterMode.EqualsOrdinalCaseSensitive;
        return obj;
    }

    public static T FilterModeCustom<T>(this T obj) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.FilterModeProperty] = Avalonia.Controls.AutoCompleteFilterMode.Custom;
        return obj;
    }

    // ItemFilterProperty

    public static T ItemFilter<T>(this T obj, Avalonia.Controls.AutoCompleteFilterPredicate<System.Object> value) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.ItemFilterProperty] = value;
        return obj;
    }

    public static T ItemFilter<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.ItemFilterProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T ItemFilter<T>(this T obj, IObservable<Avalonia.Controls.AutoCompleteFilterPredicate<System.Object>> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.ItemFilterProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindItemFilter(this Avalonia.Controls.AutoCompleteBox obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.AutoCompleteBox.ItemFilterProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.AutoCompleteFilterPredicate<System.Object>> ObserveItemFilter(this Avalonia.Controls.AutoCompleteBox obj)
    {
        return obj.GetObservable(Avalonia.Controls.AutoCompleteBox.ItemFilterProperty);
    }

    public static T OnItemFilter<T>(this T obj, Action<Avalonia.Controls.AutoCompleteBox, IObservable<Avalonia.Controls.AutoCompleteFilterPredicate<System.Object>>> handler) where T : Avalonia.Controls.AutoCompleteBox
    {
        var observable = obj.GetObservable(Avalonia.Controls.AutoCompleteBox.ItemFilterProperty);
        handler(obj, observable);
        return obj;
    }

    // TextFilterProperty

    public static T TextFilter<T>(this T obj, Avalonia.Controls.AutoCompleteFilterPredicate<System.String> value) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.TextFilterProperty] = value;
        return obj;
    }

    public static T TextFilter<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.TextFilterProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T TextFilter<T>(this T obj, IObservable<Avalonia.Controls.AutoCompleteFilterPredicate<System.String>> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.TextFilterProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindTextFilter(this Avalonia.Controls.AutoCompleteBox obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.AutoCompleteBox.TextFilterProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.AutoCompleteFilterPredicate<System.String>> ObserveTextFilter(this Avalonia.Controls.AutoCompleteBox obj)
    {
        return obj.GetObservable(Avalonia.Controls.AutoCompleteBox.TextFilterProperty);
    }

    public static T OnTextFilter<T>(this T obj, Action<Avalonia.Controls.AutoCompleteBox, IObservable<Avalonia.Controls.AutoCompleteFilterPredicate<System.String>>> handler) where T : Avalonia.Controls.AutoCompleteBox
    {
        var observable = obj.GetObservable(Avalonia.Controls.AutoCompleteBox.TextFilterProperty);
        handler(obj, observable);
        return obj;
    }

    // ItemSelectorProperty

    public static T ItemSelector<T>(this T obj, Avalonia.Controls.AutoCompleteSelector<System.Object> value) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.ItemSelectorProperty] = value;
        return obj;
    }

    public static T ItemSelector<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.ItemSelectorProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T ItemSelector<T>(this T obj, IObservable<Avalonia.Controls.AutoCompleteSelector<System.Object>> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.ItemSelectorProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindItemSelector(this Avalonia.Controls.AutoCompleteBox obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.AutoCompleteBox.ItemSelectorProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.AutoCompleteSelector<System.Object>> ObserveItemSelector(this Avalonia.Controls.AutoCompleteBox obj)
    {
        return obj.GetObservable(Avalonia.Controls.AutoCompleteBox.ItemSelectorProperty);
    }

    public static T OnItemSelector<T>(this T obj, Action<Avalonia.Controls.AutoCompleteBox, IObservable<Avalonia.Controls.AutoCompleteSelector<System.Object>>> handler) where T : Avalonia.Controls.AutoCompleteBox
    {
        var observable = obj.GetObservable(Avalonia.Controls.AutoCompleteBox.ItemSelectorProperty);
        handler(obj, observable);
        return obj;
    }

    // TextSelectorProperty

    public static T TextSelector<T>(this T obj, Avalonia.Controls.AutoCompleteSelector<System.String> value) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.TextSelectorProperty] = value;
        return obj;
    }

    public static T TextSelector<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.TextSelectorProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T TextSelector<T>(this T obj, IObservable<Avalonia.Controls.AutoCompleteSelector<System.String>> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.TextSelectorProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindTextSelector(this Avalonia.Controls.AutoCompleteBox obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.AutoCompleteBox.TextSelectorProperty.Bind().WithMode(mode)];
    }

    public static IObservable<Avalonia.Controls.AutoCompleteSelector<System.String>> ObserveTextSelector(this Avalonia.Controls.AutoCompleteBox obj)
    {
        return obj.GetObservable(Avalonia.Controls.AutoCompleteBox.TextSelectorProperty);
    }

    public static T OnTextSelector<T>(this T obj, Action<Avalonia.Controls.AutoCompleteBox, IObservable<Avalonia.Controls.AutoCompleteSelector<System.String>>> handler) where T : Avalonia.Controls.AutoCompleteBox
    {
        var observable = obj.GetObservable(Avalonia.Controls.AutoCompleteBox.TextSelectorProperty);
        handler(obj, observable);
        return obj;
    }

    // ItemsProperty

    public static T Items<T>(this T obj, System.Collections.IEnumerable value) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.ItemsProperty] = value;
        return obj;
    }

    public static T Items<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.ItemsProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T Items<T>(this T obj, IObservable<System.Collections.IEnumerable> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.ItemsProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindItems(this Avalonia.Controls.AutoCompleteBox obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.AutoCompleteBox.ItemsProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Collections.IEnumerable> ObserveItems(this Avalonia.Controls.AutoCompleteBox obj)
    {
        return obj.GetObservable(Avalonia.Controls.AutoCompleteBox.ItemsProperty);
    }

    public static T OnItems<T>(this T obj, Action<Avalonia.Controls.AutoCompleteBox, IObservable<System.Collections.IEnumerable>> handler) where T : Avalonia.Controls.AutoCompleteBox
    {
        var observable = obj.GetObservable(Avalonia.Controls.AutoCompleteBox.ItemsProperty);
        handler(obj, observable);
        return obj;
    }

    // AsyncPopulatorProperty

    public static T AsyncPopulator<T>(this T obj, System.Func<System.String,System.Threading.CancellationToken,System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Object>>> value) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.AsyncPopulatorProperty] = value;
        return obj;
    }

    public static T AsyncPopulator<T>(this T obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.AsyncPopulatorProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static T AsyncPopulator<T>(this T obj, IObservable<System.Func<System.String,System.Threading.CancellationToken,System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Object>>>> observable, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj[Avalonia.Controls.AutoCompleteBox.AsyncPopulatorProperty.Bind().WithMode(mode)] = observable.ToBinding();
        return obj;
    }

    public static Avalonia.Data.IBinding BindAsyncPopulator(this Avalonia.Controls.AutoCompleteBox obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Controls.AutoCompleteBox.AsyncPopulatorProperty.Bind().WithMode(mode)];
    }

    public static IObservable<System.Func<System.String,System.Threading.CancellationToken,System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Object>>>> ObserveAsyncPopulator(this Avalonia.Controls.AutoCompleteBox obj)
    {
        return obj.GetObservable(Avalonia.Controls.AutoCompleteBox.AsyncPopulatorProperty);
    }

    public static T OnAsyncPopulator<T>(this T obj, Action<Avalonia.Controls.AutoCompleteBox, IObservable<System.Func<System.String,System.Threading.CancellationToken,System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Object>>>>> handler) where T : Avalonia.Controls.AutoCompleteBox
    {
        var observable = obj.GetObservable(Avalonia.Controls.AutoCompleteBox.AsyncPopulatorProperty);
        handler(obj, observable);
        return obj;
    }

    // SelectionChangedEvent

    public static T OnSelectionChangedHandler<T>(this T obj, Action<T, Avalonia.Controls.SelectionChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.AutoCompleteBox
    {
        obj.AddHandler(Avalonia.Controls.AutoCompleteBox.SelectionChangedEvent, (_, args) => action(obj, args), routes);
        return obj;
    }

    public static T OnSelectionChanged<T>(this T obj, Action<T, IObservable<Avalonia.Controls.SelectionChangedEventArgs>> handler,  Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.AutoCompleteBox
    {
        var observable = obj.GetObservable(Avalonia.Controls.AutoCompleteBox.SelectionChangedEvent, routes);
        handler(obj, observable);
        return obj;
    }

    public static IObservable<Avalonia.Controls.SelectionChangedEventArgs> ObserveOnSelectionChanged(this Avalonia.Controls.AutoCompleteBox obj)
    {
        return Observable
            .FromEventPattern<EventHandler<Avalonia.Controls.SelectionChangedEventArgs>, Avalonia.Controls.SelectionChangedEventArgs>(
                h => obj.SelectionChanged += h, 
                h => obj.SelectionChanged -= h)
            .Select(x => x.EventArgs);
    }
}