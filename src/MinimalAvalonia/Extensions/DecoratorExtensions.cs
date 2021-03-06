namespace MinimalAvalonia.Extensions;

public static partial class DecoratorExtensions
{
    // PaddingProperty

    public static T Padding<T>(this T decorator, double uniformLength) where T : Decorator
    {
        decorator[Avalonia.Controls.Decorator.PaddingProperty] = new Thickness(uniformLength);
        return decorator;
    }

    public static T Padding<T>(this T decorator, double horizontal, double vertical) where T : Decorator
    {
        decorator[Avalonia.Controls.Decorator.PaddingProperty] = new Thickness(horizontal, vertical);
        return decorator;
    }

    public static T Padding<T>(this T decorator, double left, double top, double right, double bottom) where T : Decorator
    {
        decorator[Avalonia.Controls.Decorator.PaddingProperty] = new Thickness(left, top, right, bottom);
        return decorator;
    }
}
