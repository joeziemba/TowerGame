using System;

namespace TreehouseDefense
{
    public class Tower
    {
        // FIELDS
        private readonly MapLocation _location;

        // PROPERTIES
        protected virtual int Range {get;} = 1;
        protected virtual int Power {get;} = 1;
        protected virtual double Accuracy {get;} = .75;

        private static readonly Random _random = new Random();

        // METHODS
        public Tower(MapLocation location)
        {
            // Validate that location is not on path, will likely need to pass the path in
            _location = location;
        }

        public bool IsShotSuccessful()
        {
            return _random.NextDouble() < Accuracy;
        }

        public void FireOnInvaders(IInvader[] invaders)
        {
           foreach(IInvader invader in invaders)
            {
                if(invader.IsActive && _location.InRangeOf(invader.Location, Range))
                {
                    if(IsShotSuccessful())
                    {
                        invader.Hit(Power);
                        

                        if(invader.IsNeutralized)
                        {
                            Console.WriteLine("Invader neutralized at " + invader.Location + "!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Shot and missed!");
                    }
                break;
                }
            }
        }
    }
}
