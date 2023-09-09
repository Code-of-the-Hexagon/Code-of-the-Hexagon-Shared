using System.Numerics;

namespace Shared.CoordinateSystem
{
    public class ObjectCoordinates
    {
        public required OffsetCoordinates Label { get; init; }
        public required Vector3 RealWorldPosition { get; init; }
    }
}
