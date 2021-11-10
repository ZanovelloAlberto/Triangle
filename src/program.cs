using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Insert the lenght of the sides");

                int i = 3;
                var a = new int[3];

                while (i-- > 0)
                {
                    Console.WriteLine($"side {3 - i}");
                    a[i] = ReadLine();
                }
                var tri = new Triangle(a);

                if (tri.IsTriangle())
                {
                    Console.WriteLine($"Area:           {tri.GetArea()}");
                    Console.WriteLine($"Max Side:       {tri.GetMaxSide()}");
                    Console.WriteLine($"Perimeters:     {tri.GetPerimeters()}");
                    Console.WriteLine($"");
                    Console.WriteLine($"Isosceles:      {tri.IsIsosceles()}");
                    Console.WriteLine($"Equilateral:    {tri.IsEquilateral()}");
                }
                else
                {
                    Console.WriteLine($"sides lenght dont mach with a triangle");
                }
                Console.WriteLine($"============= DONE ============== \n");
            }
        }
        private static int ReadLine()
        {
            while (true)
            {
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine($"insert an Intger");
                }
            }

        }
    }
}