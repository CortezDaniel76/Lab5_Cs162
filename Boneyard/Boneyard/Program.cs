using System;
using CardClasses;

namespace CardTests
{
    class Program
    {
        static void Main(string[] args)
        {
            TestBoneyardConstructor();
            TestBoneyardShuffle();
            TestBoneyardDraw();

            Console.ReadLine();
        }

        static void TestBoneyardConstructor()
        {
            Boneyard b = new Boneyard(6);
            Console.WriteLine("Testing Boneyard constructor");
            Console.WriteLine("NumDominos.  Expecting 28. " + b.NumDominos);
            Console.WriteLine("IsEmpty.   Expecting false. " + b.IsEmpty);
            Console.WriteLine("ToString.  Expect a ton of dominos in order.\n" + b.ToString());
            Console.WriteLine();
        }

        static void TestBoneyardShuffle()
        {
            Boneyard b = new Boneyard(6);
            b.Shuffle();
            Console.WriteLine("Testing Boneyard shuffle");
            Console.WriteLine("NumDominos.  Expecting 28. " + b.NumDominos);
            Console.WriteLine("IsEmpty.   Expecting false. " + b.IsEmpty);
            Console.WriteLine("First Domino will rarely be [0|0]. " + b[0]);
            Console.WriteLine("ToString.  Expect a ton of dominos in shuffled order.\n" + b.ToString());
            Console.WriteLine();
        }

        static void TestBoneyardDraw()
        {
            Boneyard b = new Boneyard(6);
            Domino d = b.Draw();
            Console.WriteLine("Testing Boneyard draw");
            Console.WriteLine("NumDominos.  Expecting 27. " + b.NumDominos);
            Console.WriteLine("IsEmpty.   Expecting false. " + b.IsEmpty);
            Console.WriteLine("Drawn Domino should be [0|0]. " + d);

            for (int i = 1; i <= 27; i++)
                d = b.Draw();
            Console.WriteLine("Drawn all 28 dominos");
            Console.WriteLine("NumDominos.  Expecting 0. " + b.NumDominos);
            Console.WriteLine("IsEmpty.   Expecting true. " + b.IsEmpty);
            Console.WriteLine("Drawing again should return null. Expecting true. " + (b.Draw() == null));

            Console.WriteLine();
        }
    }
}
