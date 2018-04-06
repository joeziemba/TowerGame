using System;

namespace TreehouseDefense
{
    public class PowerTower : Tower
    {
        protected override int Power { get; } = 2;
        public PowerTower(MapLocation location) : base(location)
        {}

    }
}