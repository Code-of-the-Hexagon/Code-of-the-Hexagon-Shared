using System.Numerics;

namespace Code_of_the_Hexagon_Server.Shared.CoordinateSystem
{
    public class ObjectCoordinates
    {
        public required OffsetCoordinates Label { get; init; }
        public required Vector3 RealWorldPosition { get; init; }
    }
}
