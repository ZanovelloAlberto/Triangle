using System;

namespace Triangle
{
    class Program{
        static void Main(string[] args){
            
            
            while(true){
                
                Console.WriteLine("Insert the lenght of the sides");
            
                int i = 3;
                var a = new int[3];

                while(i-->0){
                    Console.WriteLine($"side number: {3-i}");
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }
                var tri = new Triangle(a);


                Console.WriteLine($"Area:       {tri.GetArea()}");
                Console.WriteLine($"Max Side:   {tri.GetMaxSide()}");
                Console.WriteLine($"Perimeters: {tri.GetPerimeters()}");

            }
        }
    }
}