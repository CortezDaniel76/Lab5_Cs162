using System;

namespace CardClasses
{
    public class Domino
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }

        public Domino(int side1, int side2)
        {
            Side1 = side1;
            Side2 = side2;
        }

        public override string ToString()
        {
            return $"[{Side1}|{Side2}]";
        }
    }
}
