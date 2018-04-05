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

        /*
        Alternately, you can use Properties for quicker get/set functionality:

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

        /* Can also create auto-properties with one-line declaration. This syntax doesn't require a field to be created in the class.
        
        public MapLocation Location { get; private set; }
        
        */

        
        // FIELDS
        private readonly Path _path;
        private int _pathStep = 0;
        private const Names = {'Blork', 'Cork', 'Tork', }

        // PROPS
        public MapLocation Location => _path.GetLocationAt(_pathStep);
        public int Health { get; private set; } = 2;

        public bool HasScored => _pathStep >= _path.Length;

        public bool IsNeutralized => Health <= 0;

        public bool IsActive => !(IsNeutralized || HasScored);

        public Invader(Path path)
        {
            _path = path;
            Health = 10;
        }

        public void Move() => _pathStep += 1;

        public void Hit(int damage) => Health -= damage;
    }
}
