namespace TreehouseDefense
{
    public interface IMappable
    {
        MapLocation Location { get; }
    }

    public interface IMoveable
    {
        void Move();
    }
    public interface IInvader : IMappable, IMoveable
    {
        
        int Health { get; }
        bool HasScored { get; }
        bool IsNeutralized { get; }
        bool IsActive { get; }
        void Hit(int damage);
    }
}