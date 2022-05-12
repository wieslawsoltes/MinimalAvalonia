// <auto-generated />
namespace MinimalAvalonia.Extensions;

public static partial class PolyLineSegmentExtensions
{
    // PointsProperty

    public static Avalonia.Media.PolyLineSegment Points(this Avalonia.Media.PolyLineSegment obj, Avalonia.Points value)
    {
        obj[Avalonia.Media.PolyLineSegment.PointsProperty] = value;
        return obj;
    }

    public static Avalonia.Media.PolyLineSegment Points(this Avalonia.Media.PolyLineSegment obj, Avalonia.Data.IBinding binding, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        obj[Avalonia.Media.PolyLineSegment.PointsProperty.Bind().WithMode(mode)] = binding;
        return obj;
    }

    public static Avalonia.Data.IBinding Points(this Avalonia.Media.PolyLineSegment obj, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.TwoWay)
    {
        return obj[Avalonia.Media.PolyLineSegment.PointsProperty.Bind().WithMode(mode)];
    }
}