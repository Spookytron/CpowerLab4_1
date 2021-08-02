using System;

namespace Lab4_1
{
    class Parallelogram
    {
        public double height;
        public double width;

        public double GetArea()
        {
            return height * width;
        }

        public double GetPerimeter()
        {
            return 2 * (height + width);
        }
        public static void PrintPara(Parallelogram r)
        {
            Console.WriteLine("Here are the stats of this parallelogram:");
            Parallelogram mycopy = new Parallelogram() { height = r.height, width = r.width };
            Console.WriteLine($"Height is:{mycopy.height}");
            Console.WriteLine($"Width is: {mycopy.width}");
            Console.WriteLine($"The area is {mycopy.GetArea()}");
            Console.WriteLine($"The Perimeter is {mycopy.GetPerimeter()}");
        }
        public void ReSize(double newW, double newH)
        {
            if(newW < 0)
            {
                return;
            }
            if(newH <0)
            {
                return;
            }
            height = newH;
            width = newW;
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Parallelogram one = new Parallelogram() { height = 30, width = 100 };
            Parallelogram.PrintPara(one);
            one.ReSize(50, 1000);
            Parallelogram.PrintPara(one);
        }
    }
}
