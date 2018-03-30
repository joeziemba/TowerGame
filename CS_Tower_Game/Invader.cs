using System;
namespace TreehouseDefense
{
    public class Invader
    {
        

        public Invader()
        {

        }
        /* 
        private MapLocation _location; // Poor practice to make fields public, so make them private

        public MapLocation GetLocation() // Create a Getter function to return the value
        {
            return _location; 
        }

        public void SetLocation(MapLocation value) // And a Setter function to change the value
        {
            _location = value;
        }
        */

        /* Alternately, you can use Properties for quicker get/set functionality:
        public MapLocation Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
            }
        }
        */

        // Can also create auto-properties with one-line declaration
        // This syntax doesn't require a field to be created in the class.
        public MapLocation Location { get; private set; }
    }
}
