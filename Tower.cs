using System;

namespace TreehouseDefense
{
    public class Tower
    {
        private readonly MapLocation _location;
        private const int _range = 1;
        private const int _power = 1;
        public Tower(MapLocation location)
        {
            // Validate that location is not on path, will likely need to pass the path in
            _location = location;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
           foreach(Invader invader in invaders)
            {
                if(invader.IsActive && _location.InRangeOf(invader.Location, _range))
                {
                    invader.Hit(_power);
                    break;
                }
            }
        }
    }
}
