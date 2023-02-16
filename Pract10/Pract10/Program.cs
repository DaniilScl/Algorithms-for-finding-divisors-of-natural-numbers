using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Найти_количество_делителей_числа;

    class Program
    {
        static void Main(string[] args)
        {
               Test10();
        }

    private static void Test()
    {
        Console.WriteLine("Введите целое число ");
        int count = 0;
        int val;
        if (Int32.TryParse(Console.ReadLine(), out val))
        {
            Console.WriteLine("Делители числа" + val);
            for (int i = 1; i <= val; i++)
                if (val % i == 0)
                {
                    Console.Write(i + " ");
                    count++;
                }
            Console.WriteLine("Количество делителей числа " + val + " : " + count);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Атата.");
            Console.ReadLine();
        }
    }

    private static void Test1()
    {

        try
        {
            Console.WriteLine("Введите целое число ");
            int val = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 1; i <= val; i++)
            {
                if (val % i == 0)
                
                    count += i;
                   
            }
            Console.Write(count);


        }
        catch 
        {
            Console.WriteLine("Ошибка!");
        }

    }

    private static void Test2()
    {
        try
        {
            Console.WriteLine("Введите целое число ");
            int val = int.Parse(Console.ReadLine());
            var max = 0;



            for (int i = 1; i < val; i++)
            {
                if (val % i == 0)
                {
                     max = Math.Max(i,i);
                   
                }
  

            }
            Console.WriteLine(max);


        }
        catch
        {
            Console.WriteLine("Ошибка!");
        }
    }

    private static void Test3()
    {
        try
        {
            Console.WriteLine("Введите целое число ");
            int val = int.Parse(Console.ReadLine());
            var max = 0;
            Console.WriteLine("Введите С");
            int val2 = int.Parse(Console.ReadLine());
           

            for (int i = 1; i < val; i++)
            {
              if (i % val2 == 0) 
                {
                    Console.WriteLine("Вывод");
                    Console.WriteLine(i);
                }

            }

        }
        catch
        {
            Console.WriteLine("Ошибка!");
        }
    }

    private static void Test4()
    {
        try
        {
            Console.WriteLine("Введите целое число ");
            int val = int.Parse(Console.ReadLine());
            var max = 0;
            Console.WriteLine("Введите С, D");
            int val2 = int.Parse(Console.ReadLine());
            int val3 = int.Parse(Console.ReadLine());

            for (int i = 1; i < val; i++)
            {
                if (i % val2 == 0 && i % val3 == 0)
                {
                    Console.WriteLine("Вывод");
                    Console.WriteLine(i);
                }

            }



        }
        catch
        {
            Console.WriteLine("Ошибка!");
        }
    }

    private static void Test5()
    {
        try
        {
            Console.WriteLine("Введите целое число ");
            int val = int.Parse(Console.ReadLine());
            var max = 0;
            Console.WriteLine("Введите С");
            int val2 = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 1; i < val; i++)
            {
                if (i % val2 != 0)
                {
                    count += i;
                    
                }

            }
            Console.WriteLine("Вывод");
            Console.WriteLine(count);

        }
        catch
        {
            Console.WriteLine("Ошибка!");
        }
    }

    private static void Test6()
    {
        try
        {
            Console.WriteLine("Введите целое число ");
            int val = int.Parse(Console.ReadLine());
            var max = 0;
            Console.WriteLine("Введите С, D");
            int val2 = int.Parse(Console.ReadLine());
            int val3 = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 1; i < val; i++)
            {
                if (i % val2 == 0 | i % val3 == 0)
                {
                    count += i;
                }

            }
            Console.WriteLine("Вывод");
            Console.WriteLine(count);

        }
        catch
        {
            Console.WriteLine("Ошибка!");
        }
    }
    private static void Test7()
    {
        double sum = 0, counter = 0;
        Console.Write("Введите число: ");
        int num = int.Parse(Console.ReadLine());
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0) continue;
            Console.WriteLine($"число {num} делится на {i}");
            sum += i;
            counter++;
        }
        Console.WriteLine($"среднее арифметическое делителей: {sum / counter}");
        Console.ReadKey();
    }
    private static void Test8()
    {
        double sum = 0, counter = 0;
        Console.Write("Введите число: ");
        int num = int.Parse(Console.ReadLine());
        for (int i = 1; i < num; i++)
        {
            if (i % 10 == 0 && num % i == 0)
            {
                Console.WriteLine($"число {num} делится на {i}");
                sum += i;
                counter++;

            }

        }
        Console.WriteLine($"среднее арифметическое делителей: {sum / counter}");
        Console.ReadKey();
    }

    private static void Test9()
    {
        double sum = 0, counter = 0;

        Console.WriteLine("Введите число: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите число: ");
        int num2 = int.Parse(Console.ReadLine());

        for (; num <= num2; num++)
        {
            if (num2 % num == 0) 
            Console.WriteLine($"число {num2} делится на {num}");
            sum += num;
            counter++;
        }
        Console.WriteLine($"среднее арифметическое делителей: {sum / counter}");
        Console.ReadKey();
    }

    private static void Test10()
    {
        Console.WriteLine("Введите Число");
        int x = int.Parse(Console.ReadLine());
        int i = 2;
        if (x % 2 == 0)
        {
            for (; i < x; i++)
            {
                if (x % i == 0)
                {
                    Console.WriteLine(i);
                }

            }


        }
        else if (x % 2 != 0) 
        {
            for (int j = 2; j < x; j++)
            {
                if (x % j != 0) ;

            }
            Console.WriteLine("Число простое");
        }


    }

   
    }

