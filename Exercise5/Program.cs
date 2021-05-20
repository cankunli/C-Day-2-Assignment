using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume = 0;
            Box b = new Box();
            b.GetData();
            volume = b.getVolume();
            Console.WriteLine("Volume of Box : ", volume);
            Console.ReadLine();
        }
    }
}
