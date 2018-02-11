using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle1
{
    class Rectangle
    {
        public int width;
        public int height;

        public Rectangle(int a, int b)
        {
            width = a;
            height = b;
        }

        public int FindArea()
        {
            return width * height;
        }

        public int FindPerim()
        {
            return (width + height) * 2; 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Rectangle r = new Rectangle(a, b);
            Console.WriteLine(r.FindArea() + " " + r.FindPerim());
            
            Console.ReadKey();
        }


    }
}
