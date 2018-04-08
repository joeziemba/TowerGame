using System;

namespace TreehouseDefense
{
    class ZomBot : IInvader
    {
        private PlainBot _life1;
        private StrongBot _life2;

        public MapLocation Location => _life1.IsNeutralized ? _life2.Location : _life1.Location;
        public int Health => _life1.IsNeutralized ? _life2.Health : _life1.Health;
        public bool HasScored => _life1.HasScored || _life2.HasScored;
        public bool IsNeutralized => _life1.IsNeutralized && _life2.IsNeutralized;
        public bool IsActive => !(IsNeutralized || HasScored);
        public void Hit(int damage)
        {
            if(!_life1.IsNeutralized)
            {
                _life1.Hit(damage);
            }
            else
            {
                _life2.Hit(damage);
            }
        }
        public void Move()
        {
            _life1.Move();
            _life2.Move();
        }

        public ZomBot(Path path)
        {
            _life1 = new PlainBot(path);
            _life2 = new StrongBot(path);
        }
    }
}