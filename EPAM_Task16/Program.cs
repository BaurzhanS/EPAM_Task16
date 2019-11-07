using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EPAM_Task16
{
    class Program
    {
        static int n;

        static void Main(string[] args)
        {
            //SumNumbersAsync().Wait();
            SetIntervalAsync().Wait();
        }

        static async Task SumNumbersAsync()
        {
            await Task.Run(() =>
            {
                if (n == 0)
                {
                    n = Int32.Parse(Console.ReadLine());
                }
               
                int sum = 0;

                for (int i = 0; i <= n; i++)
                {
                    sum += i;
                    Thread.Sleep(1000);
                }

                Console.Write($"Сумма чисел равна {sum}");
            });
        }

        static async Task SetIntervalAsync()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Введите предельное число для суммирования: ");
                n = Int32.Parse(Console.ReadLine());

                while (true)
                {
                    if (n != 0)
                    {
                        Console.WriteLine("Измените предельное число для суммирования: ");
                        n = Int32.Parse(Console.ReadLine());
                        SumNumbersAsync();
                    }
                }
            });
        }
    }
}
