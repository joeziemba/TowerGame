using System;
using TreehouseDefense;
namespace TreehouseDefense
{
    public class Path
    {
        private readonly MapLocation[] _path; // Underscores conventionally used for names of private fields to distinguish between instance variables and method variables 

        public Path(MapLocation[] path)
        {
            _path = path;
        }

        public MapLocation GetLocationAt(int pathStep) 
        {
            return (pathStep < _path.Length) ? _path[pathStep] : null;
        }
    }
}
