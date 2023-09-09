namespace Shared.CoordinateSystem
{
    public class OffsetCoordinates
    {
        public required int X { get; init; }
        public required int Y { get; init; }

        public override string ToString () =>
            $"(X = {X}, Y = {Y})";
    }
}
