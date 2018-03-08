using System;
namespace TreehouseDefense
{
    public class Map
    {
        public readonly int Width;
        public readonly int Height;

        public Map(int width, int height) // Constructor methods in C# use the name of the class they are in
        {
            Width = width;
            Height = height;
        }

        public bool OnMap(Point point)
        {
            return point.X_Co >= 0 &&
                   point.X_Co < Width &&
                   point.Y_Co >= 0 &&
                   point.Y_Co < Height;
        }
    }
}
