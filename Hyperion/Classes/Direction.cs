using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyperion
{
    public struct Direction
    {
        public const string North = "north";
        public const string South = "south";
        public const string East = "east";
        public const string West = "west";

        public static bool IsValidDirection(string direction)
        {
            switch (direction)
            {
                case Direction.North:
                case Direction.South:
                case Direction.East:
                case Direction.West:
                    return true;
               
            }

            return false;
        }
    }
}
