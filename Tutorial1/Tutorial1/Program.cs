using System;

namespace Tutorial1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double distanceA = CalculateDistance2D(0, 0, 3, 4);
            Console.WriteLine(distanceA);

            double distanceB = CalculateDistance2D(1, 2, 5, 3);
            Console.WriteLine(distanceB);

            double distanceC = CalculateDistance2D(0, 4, 5, 1);
            Console.WriteLine(distanceC);

            double distanceD = CalculateDistance3D(0, 4, 5, 1, 1, 2);
            Console.WriteLine(distanceD);

            double distanceE = CalculateDistance3D(0, 4, 5, 1, 3, 4);
            Console.WriteLine(distanceE);

            double distanceF = CalculateDistance3D(0, 4, 5, 1, 5, 6);
            Console.WriteLine(distanceF);

        }

        public static double CalculateDistance2D(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public static double CalculateDistance3D(int x1, int y1, int z1, int x2, int y2, int z2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
        }



    }
}
