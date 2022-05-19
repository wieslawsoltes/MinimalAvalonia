// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class DrawingImageSetters
{
    // DrawingProperty

    public static Style SetDrawingImageDrawing(this Style style, Avalonia.Media.Drawing value)
    {
        style.Setters.Add(new Setter(Avalonia.Media.DrawingImage.DrawingProperty, value));
        return style;
    }

    public static Style SetDrawingImageDrawing(this Style style, Avalonia.Data.IBinding binding)
    {
        style.Setters.Add(new Setter(Avalonia.Media.DrawingImage.DrawingProperty, binding));
        return style;
    }

    public static Style SetDrawingImageDrawing(this Style style, IObservable<Avalonia.Media.Drawing> observable)
    {
        style.Setters.Add(new Setter(Avalonia.Media.DrawingImage.DrawingProperty, observable.ToBinding()));
        return style;
    }

    public static KeyFrame SetDrawingImageDrawing(this KeyFrame keyFrame, Avalonia.Media.Drawing value)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.DrawingImage.DrawingProperty, value));
        return keyFrame;
    }

    public static KeyFrame SetDrawingImageDrawing(this KeyFrame keyFrame, Avalonia.Data.IBinding binding)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.DrawingImage.DrawingProperty, binding));
        return keyFrame;
    }

    public static KeyFrame SetDrawingImageDrawing(this KeyFrame keyFrame, IObservable<Avalonia.Media.Drawing> observable)
    {
        keyFrame.Setters.Add(new Setter(Avalonia.Media.DrawingImage.DrawingProperty, observable.ToBinding()));
        return keyFrame;
    }
}