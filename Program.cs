using System;

namespace homework_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание № 5");
            Console.WriteLine("Введите сумму вклада:");
            double sum = Convert.ToDouble(Console.ReadLine());
            if (sum < 100)
            {
                Console.WriteLine("Сумма вклада с начисленными процентами и бонусом:");
                Console.WriteLine(sum += sum * 0.05 + 15);
            }
            else if (sum < 200)
            {
                Console.WriteLine("Сумма вклада с начисленными процентами и бонусом:");
                Console.WriteLine(sum += sum * 0.07 + 15);
            }
            else {
                Console.WriteLine("Сумма вклада с начисленными процентами и бонусом:");
                Console.WriteLine(sum += sum * 0.1 + 15);
            }

        }
    }
}
