using System;

namespace Geometeia
{

    class Program
    {
        class CircularSegment
        {
            private double r;
            private double alpha;

            public CircularSegment(double r, double alpha)
            {
                this.r = r;
                this.alpha = alpha;
            }

            private double AreaOfSegment(double r, double alpha) //высчитываем площадь
            {
                return (0.5 * alpha * (r * r)) - (0.5 * (r * r) * Math.Sin(alpha)); // S = 1/2ar^2 - 1/2r^2 sin a 
            }
            private double PerimetrOfSegment(double r, double alpha) //высчитываем периметр
            {
                return (alpha * r) + (2 * r * Math.Sin(alpha / 2));  // P = ar + 2r sin a/2
            }


            private bool CheckingAlpha(double alpha) //Проверка а
            {
                if (alpha < 180 && alpha > 0) //нельзя угол больше 180, иначе будут два сегмента
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("The alpha angle must be in diapasone of 0 to 180!"); //вывод сообщения о недопустимости ввода угла выше 180 градусов
                    return false;
                }
            }

            public void WriteResult() //функция вывода результата
            {
                bool ch = CheckingAlpha(alpha); //вызов проверки

                if (ch == true)
                {
                    Console.WriteLine("Perimertre: " + PerimetrOfSegment(r, alpha)); //вывод периметра
                    Console.WriteLine("Area: " + AreaOfSegment(r, alpha));  //вывод площади
                }
            }

        }

        static void Main(string[] args)
        {

            Console.WriteLine("Enter radius: ");
            string radius = Console.ReadLine();
            double r = double.Parse(radius);

            Console.WriteLine("Enter angle: ");
            string alpha = Console.ReadLine();
            double al = double.Parse(alpha);

            CircularSegment cs = new CircularSegment(r, al);
            cs.WriteResult();
            Console.ReadKey();

        }
    }
}