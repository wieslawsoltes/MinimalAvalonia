namespace MinimalAvalonia.Extensions;

public static partial class KeyFrameExtensions
{
    // KeyTime

    public static T KeyTime<T>(this T keyFrame, TimeSpan keyTime) where T : KeyFrame
    {
        keyFrame.KeyTime = keyTime;
        return keyFrame;
    }

    // Cue

    public static T Cue<T>(this T keyFrame, Cue cue) where T : KeyFrame
    {
        keyFrame.Cue = cue;
        return keyFrame;
    }

    public static T Cue<T>(this T keyFrame, double cue) where T : KeyFrame
    {
        keyFrame.Cue = new Cue(cue);
        return keyFrame;
    }

    public static T Cue<T>(this T keyFrame, string cue) where T : KeyFrame
    {
        keyFrame.Cue = Avalonia.Animation.Cue.Parse(cue, System.Globalization.CultureInfo.InvariantCulture);
        return keyFrame;
    }

    // KeySpline

    public static T KeySpline<T>(this T keyFrame, KeySpline keySpline) where T : KeyFrame
    {
        keyFrame.KeySpline = keySpline;
        return keyFrame;
    }

    public static T KeySpline<T>(this T keyFrame, double x1, double y1, double x2, double y2) where T : KeyFrame
    {
        keyFrame.KeySpline = new KeySpline(x1, y1, x2, y2);
        return keyFrame;
    }

    public static T KeySpline<T>(this T keyFrame, string keySpline) where T : KeyFrame
    {
        keyFrame.KeySpline = Avalonia.Animation.KeySpline.Parse(keySpline, System.Globalization.CultureInfo.InvariantCulture);;
        return keyFrame;
    }

    // Setters

    public static T Setters<T>(this T keyFrame, params IAnimationSetter[] setters) where T : KeyFrame
    {
        foreach (var setter in setters)
        {
            keyFrame.Setters.Add(setter);
        }
        return keyFrame;
    }

    // Setter

    public static T Setter<T>(this T keyFrame, AvaloniaProperty property, object value) where T : KeyFrame
    {
        keyFrame.Setters.Add(new Setter(property, value));
        return keyFrame;
    }
}
