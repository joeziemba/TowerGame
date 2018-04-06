using System;

namespace TreehouseDefense
{
    class PlainBot : Invader
    {
        public PlainBot(Path path) : base(path)
        { }

        public override int Health { get; protected set; } = 2;
    }
}