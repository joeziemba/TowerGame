using System;
namespace TreehouseDefense
{
    public class TreehouseDefenseException : System.Exception
    {
        public TreehouseDefenseException()
        {
            
        }
        public TreehouseDefenseException(string message) : base(message)
        {
            
        }
    }

    public class OutOfBoundsException : TreehouseDefenseException
    {
        public OutOfBoundsException() // Default constructors don't need to explicitly call their base constructor as seen below, it happens automatically
        {
            
        }

        public OutOfBoundsException(string message) : base(message)
        {
            
        }
    }
}
