namespace TreehouseDefense
{
    interface IInvader
    {
        MapLocation Location { get; }
        int Health { get; }
        bool HasScored { get; }
        bool IsNeutralized { get; }
        bool IsActive { get; }
        void Move();
        void Hit(int damage);
    }
}