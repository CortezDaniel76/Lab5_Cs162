using System;
using System.Collections.Generic;

namespace CardClasses
{
    public class Boneyard
    {
        private List<Domino> dominos = new List<Domino>();

        public Boneyard(int maxDots)
        {
            for (int side1 = 0; side1 <= maxDots; side1++)
            {
                for (int side2 = side1; side2 <= maxDots; side2++)
                {
                    dominos.Add(new Domino(side1, side2));
                }
            }
        }

        public int NumDominos
        {
            get
            {
                return dominos.Count;
            }
        }

        public bool IsEmpty
        {
            get
            {
                return (dominos.Count == 0);
            }
        }

        public Domino this[int i]
        {
            get
            {
                return dominos[i];
            }
            set
            {
                dominos[i] = value;
            }
        }

        public Domino Draw()
        {
            if (!IsEmpty)
            {
                Domino d = dominos[0];
                dominos.RemoveAt(0);
                return d;
            }
            return null;
        }

        public void Shuffle()
        {
            Random gen = new Random();
            for (int i = 0; i < NumDominos; i++)
            {
                int rnd = gen.Next(0, NumDominos);
                Domino d = dominos[rnd];
                dominos[rnd] = dominos[i];
                dominos[i] = d;
            }
        }

        public override string ToString()
        {
            string output = "";
            foreach (Domino d in dominos)
                output += (d.ToString() + "\n");
            return output;
        }
    }
}
