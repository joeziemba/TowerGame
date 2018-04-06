using System;
namespace TreehouseDefense
{
    public class MapLocation : Point
    {
        public MapLocation(int x, int y, Map map) : base(x,y)
        {
            if(!map.OnMap(this))
            {
                throw new OutOfBoundsException(this.ToString() + " is outside the map");
            }
        }

        public bool InRangeOf(MapLocation location, int range)
        {
            return DistanceTo(location) <= range;
        }
    }
}
