using System;

namespace TreehouseDefense
{
    class StrongBot : Invader
    {
        public override int Health { get; protected set; } = 4;
        public StrongBot(Path path) : base(path)
        {}
    }
}