using System;

namespace Methods
{
    class program
    {
        public int Add(param int[] number)
        {
           var sum = 0;
           foreach (var number in numbers)
           {
               sum += number;
           }
           return sum;
        }

        static void Main(string[] args)
        {
            ...
        }

        static void UsePoint()
        {

            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }

            catch (Execption)
            {
                Console.WriteLine("An unexpected errror occured.");
            }
        }
    }

}