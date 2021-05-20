using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Box
    {
        double length = 1;
        double breadth = 1;
        double height = 1;
        public void GetData()
        {
            Console.WriteLine("enter length:");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter breadth:");
            breadth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter height:");
            breadth = Convert.ToInt32(Console.ReadLine());
        }
        public double getVolume()
        {
            return length * breadth * height;
        }
        public void setLength(double len)
        {
            length = len;
        }

        public void setBreadth(double bre)
        {
            breadth = bre;
        }

        public void setHeight(double hei)
        {
            height = hei;
        }


    }
}
