﻿namespace Code_of_the_Hexagon_Server.Shared.CoordinateSystem
{
    public class OffsetCoordinates
    {
        public required int X { get; init; }
        public required int Y { get; init; }

        public override string ToString() =>
            $"(X = {X}, Y = {Y})";
    }
}
