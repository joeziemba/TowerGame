using System;
namespace TreehouseDefense
{
    public class Point
    {
        public readonly int X_Co;
        public readonly int Y_Co;

        public Point(int x, int y)
        {
            X_Co = x;
            Y_Co = y;
        }

        public int DistanceTo(int x, int y)
        {
            //int xDiff = X_Co - x;
            //int yDiff = Y_Co - y;
            //int xDiffSq = xDiff * xDiff;
            //int yDiffSq = yDiff * yDiff;

            //Console.WriteLine(Math.Sqrt(xDiffSq + yDiffSq));
            //return (int)Math.Sqrt(xDiffSq + yDiffSq);

            return (int)Math.Sqrt(Math.Pow(X_Co - x, 2) + Math.Pow(Y_Co - y, 2));
        }

        public int DistanceTo(Point point)
        {
            return DistanceTo(point.X_Co, point.Y_Co);
        }

        public override string ToString()
        {
            return X_Co.ToString() + ',' + Y_Co;
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Point))
            {
                return false;
            }

            Point that = obj as Point;

            return this.X_Co == that.X_Co && this.Y_Co == that.Y_Co;
        }

        public override int GetHashCode()
        {
            return X_Co.GetHashCode() * 31 + Y_Co.GetHashCode();
        }
    }
}
