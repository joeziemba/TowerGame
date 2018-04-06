using System;
namespace TreehouseDefense
{
    public abstract class Invader : IInvader
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

        // PROPS
        public MapLocation Location => _path.GetLocationAt(_pathStep);
        public abstract int Health { get; protected set; }
        protected virtual int Speed { get; } = 1;
        public bool HasScored => _pathStep >= _path.Length;
        public bool IsNeutralized => Health <= 0;
        public bool IsActive => !(IsNeutralized || HasScored);

        // METHODS
        public Invader(Path path) {
            _path = path;
        }

        public void Move() => _pathStep += Speed;

        public virtual void Hit(int damage)
        {
            Health -= damage;
            Console.WriteLine("Shot and hit an invader!");
        }
    }
}
