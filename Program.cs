using System;
namespace LaboryMath4
{
    class Program
    {
        static void Main(string[] args)
        {
            double X, Y, answermath;
            int stepenY_math, parmsI, stepenX_math, x1_math, x2_math, y1_math, y2_math;
            int parmsNumber;
            bool StopCode = true;
            parmsI = 1;
            answermath = 0;
            stepenX_math = 2;
            stepenY_math = 3;
            x1_math = 2;
            x2_math = 3;
            y1_math = 1;
            y2_math = 3;
            Console.Write("Введите [X]: ");
            X = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите [Y]: ");
            Y = Convert.ToInt32(Console.ReadLine());
            while (StopCode)
            {
                if (parmsI % 2 == 0)
                {
                    answermath -= Y * Math.Pow(X, stepenX_math) / (y1_math * y2_math);
                    stepenY_math += 3;
                    y1_math += 1;
                    y2_math += 3;
                }
                else
                {
                    answermath += X * Math.Pow(Y, stepenY_math) / (x1_math * x2_math);
                    stepenX_math += 2;
                    x1_math += 2;
                    x2_math += 3;
                }

                Console.WriteLine("Ответ: {0:F3}", answermath);
                parmsI++;
                Console.WriteLine("Введите для продолжения любое число, для выхода 0:");
                parmsNumber = Convert.ToInt32(Console.ReadLine());
                if (parmsNumber == 1)
                    break;
            }
        }
    }
}
