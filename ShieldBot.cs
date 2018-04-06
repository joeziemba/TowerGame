using System;

namespace TreehouseDefense
{
    class ShieldBot : Invader
    {
        private static Random _random = new Random();
        public ShieldBot(Path path) : base(path)
        {

        }

        public override int Health { get; protected set; } = 2;

        public override void Hit(int damage) {
            if(_random.NextDouble() < .5) {
                base.Hit(damage);
                Console.WriteLine("Shot and hit a ShieldBot!");
            } else {
                Console.WriteLine("ShieldBot resisted the damage!");
            }
        }
    }
}