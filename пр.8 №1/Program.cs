using System;
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение х=");
            double x = double.Parse(Console.ReadLine());
            double y;

            if (x > 2.8 && x < 6)
                y = (x - 1) / (x + 1);
            else
            {
                if (x > 6)
                    y = (Math.Pow(Math.E, x)) + (Math.Sin(x));
                else
                {
                    y = (x);
                }
            }
            Console.WriteLine("y=" + y);

        }
    }
}
