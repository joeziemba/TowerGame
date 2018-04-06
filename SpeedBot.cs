using System;

namespace TreehouseDefense
{
    class SpeedBot : Invader
    {
        public SpeedBot(Path path) : base(path)
        {}

        public override int Health { get; protected set; } = 2;

        protected override int Speed { get; } = 2;
    }
}