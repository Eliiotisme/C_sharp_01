using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace index_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#1-1
            //Console.WriteLine("請輸入4個值");
            //double a = Convert.ToDouble(Console.ReadLine());
            //double b = Convert.ToDouble(Console.ReadLine());
            //double c = Convert.ToDouble(Console.ReadLine());
            //double d = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine($"a = {a}, b = {b}, c = {c}, d = {d}");

            //double z = ((a + b) / (c - d)) * 2;
            //Console.WriteLine($"z= {z}");
            //Console.ReadKey();


            //#1-2
            //Console.WriteLine("請輸入6個值");
            //double a1 = Convert.ToDouble(Console.ReadLine());
            //double b1 = Convert.ToDouble(Console.ReadLine());
            //double c1 = Convert.ToDouble(Console.ReadLine());
            //double a2 = Convert.ToDouble(Console.ReadLine());
            //double b2 = Convert.ToDouble(Console.ReadLine());
            //double c2 = Convert.ToDouble(Console.ReadLine());

            //double x = (c1 * b2 - c2 * b1) / (a1 * b2 - a2 * b1);

            //double y = (c1 * a2 - c2 * a1) / (b1 * a2 - a1 * b2);

            //Console.WriteLine($"x = {x},y = {y}");
            //Console.ReadKey();

            //#1-3
            //Console.WriteLine("請輸入2個值");
            //double a = Convert.ToDouble(Console.ReadLine());
            //double b = Convert.ToDouble(Console.ReadLine());

            //double y = (Math.Pow(a, 2) + Math.Pow(b, 2)) / (Math.Pow(a, 2) - Math.Pow(b, 2));
            //Console.WriteLine($"y = {y}");
            //Console.ReadKey();

            //#1-4
            //Console.WriteLine("請輸入2個值");
            //double a = Convert.ToDouble(Console.ReadLine());
            //double b = Convert.ToDouble(Console.ReadLine());

            //double y = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            //Console.WriteLine($"y = {y}");
            //Console.ReadKey();

            //#1-5    
            //Console.WriteLine("請輸入3個值");
            //double a = Convert.ToDouble(Console.ReadLine());
            //double b = Convert.ToDouble(Console.ReadLine());
            //double c = Convert.ToDouble(Console.ReadLine());

            //double y = a-(b+c)*(3*a - c);
            //Console.WriteLine($"y = {y}");
            //Console.ReadKey();

            //#1-6
            //Console.WriteLine("請輸入1個正or負值");
            //Console.WriteLine(Math.Abs(Convert.ToDouble(Console.ReadLine())));
            //Console.ReadKey();

            //#1-7
            //Console.WriteLine("請輸入西元");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = a - 1911;
            //Console.WriteLine($"西元{a}年 = 民國{b}年");
            //Console.ReadKey();

            //#1-8
            //Console.WriteLine("請輸入身高、體重2個值");
            //double h = Convert.ToDouble(Console.ReadLine());
            //double w = Convert.ToDouble(Console.ReadLine());

            //double bmi = w / (Math.Pow((h / 100), 2));
            //Console.WriteLine($"BMI = {Math.Round(bmi, 1)}");
            //Console.ReadKey();


            //#switch改寫
            //Console.WriteLine("請輸入分數");
            //int score = Convert.ToInt32(Console.ReadLine());
            //switch (score)
            //{
            //    case int n when (score >= 90):
            //        Console.WriteLine("grade = A");
            //        break;
            //    case int n when (score >= 80):
            //        Console.WriteLine("grade = B");
            //        break;
            //    case int n when (score >= 70):
            //        Console.WriteLine("grade = C");
            //        break;
            //    case int n when (score >= 60):
            //        Console.WriteLine("grade = D");
            //        break;
            //    default:
            //        Console.WriteLine("grade = F");
            //        break;

            //}
            //Console.ReadKey();

            //#2-1
            //Console.WriteLine("請輸入 x,y 2個值");
            //double x = Convert.ToDouble(Console.ReadLine());
            //double y = Convert.ToDouble(Console.ReadLine());
            //if (x >= y)
            //    Console.WriteLine(x);
            //else
            //{
            //    Console.WriteLine(y);
            //}
            //Console.ReadKey();

            //#2-2
            //Console.WriteLine("請輸入 x,y 2個值");
            //double x = Convert.ToDouble(Console.ReadLine());
            //double y = Convert.ToDouble(Console.ReadLine());
            //double z;
            //if (x >= 0 & y >= 0)
            //{
            //    z = 1;
            //    Console.WriteLine(z);
            //}
            //else if(x < 0 & y < 0)
            //{
            //    z = -1;
            //    Console.WriteLine(z);
            //}
            //else
            //{
            //    z = 0;
            //    Console.WriteLine(z);
            //}
            //Console.ReadKey();

            //#2-3
            //Console.WriteLine("請輸入4個值");
            //double x = Convert.ToDouble(Console.ReadLine());
            //double y = Convert.ToDouble(Console.ReadLine());
            //double u = Convert.ToDouble(Console.ReadLine());
            //double v = Convert.ToDouble(Console.ReadLine());

            //if ((x + y) > (u + v))
            //{
            //    Console.WriteLine("z = " + (x+y));
            //}
            //else
            //{
            //    Console.WriteLine("z = " + (u+v));
            //}
            //Console.ReadKey();

            //#2-4
            //Console.WriteLine("請輸入4個值");
            //double x = Convert.ToDouble(Console.ReadLine());
            //double y = Convert.ToDouble(Console.ReadLine());
            //double u = Convert.ToDouble(Console.ReadLine());
            //double v = Convert.ToDouble(Console.ReadLine());

            //if (((x + y)/(u + v))>=2)
            //{
            //    Console.WriteLine("z = " + (x + y));
            //}
            //else
            //{
            //    Console.WriteLine("z = " + (u + v));
            //}
            //Console.ReadKey();

            //#2-5
            //Console.WriteLine("請輸入 x,y 2個值");
            //double x = Convert.ToDouble(Console.ReadLine());
            //double y = Convert.ToDouble(Console.ReadLine());

            //if (x>=y)
            //{
            //    Console.WriteLine("z = " + (Math.Pow(x,2)));
            //}
            //else
            //{
            //    Console.WriteLine("z = " + (Math.Pow(y, 2)));
            //}
            //Console.ReadKey();

            //#2-6
            //Console.WriteLine("請輸入1個值");
            //double income = Convert.ToDouble(Console.ReadLine());

            //if(income >= 4090000)
            //{
            //    Console.WriteLine("tax = " + ((income * 0.4) - 721100));
            //}
            //else if(income >= 2180000)
            //{
            //    Console.WriteLine("tax = " + ((income * 0.3) - 312100));
            //}
            //else if (income >= 1090000)
            //{
            //    Console.WriteLine("tax = " + ((income * 0.21) - 115900));
            //}
            //else if (income >= 410000)
            //{
            //    Console.WriteLine("tax = " + ((income * 0.13) - 28700));
            //}
            //else
            //{
            //    Console.WriteLine("tax = " + (income * 0.06));
            //}
            //Console.ReadKey();

            ///#2-7
            //Console.WriteLine("請輸入 x,y 2個值");
            //double x = Convert.ToDouble(Console.ReadLine());
            //double y = Convert.ToDouble(Console.ReadLine());

            //if (x > 0)
            //{
            //    if(y > 0)
            //    {
            //        Console.WriteLine("1st quadrant\n");
            //    }
            //    else if(y == 0)
            //    {
            //        Console.WriteLine("X axis\n");
            //    }
            //    else
            //    {
            //        Console.WriteLine("4st quadrant\n");
            //    }
            //}
            //else if(x == 0)
            //{
            //    if (y == 0)
            //    {
            //        Console.WriteLine("Origin\n");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Y axis\n");
            //    }
            //}
            //else
            //{
            //    if (y > 0)
            //    {
            //        Console.WriteLine("2st quadrant\n");
            //    }
            //    else if(y == 0)
            //    {
            //        Console.WriteLine("X axis\n");
            //    }
            //    else
            //    {
            //        Console.WriteLine("3st quadrant\n");
            //    }
            //}
            //Console.ReadKey();

            //#2-8
            //Console.WriteLine("請輸入1個值");
            //double x = Convert.ToDouble(Console.ReadLine());
            //double Score;
            //if (x > 40)
            //{
            //    Score = 100;
            //    Console.WriteLine($"Score = {Score}");
            //}
            //else if(x <= 40 & x >= 21)
            //{
            //    Score = (60 + 20) + ((x - 20) * 1);
            //    Console.WriteLine($"Score = {Score}");
            //}
            //else if (x <= 20 & x >= 11)
            //{
            //    Score = 60 + ((x - 10) * 2);
            //    Console.WriteLine($"Score = {Score}");
            //}
            //else
            //{
            //    Score = x * 6;
            //    Console.WriteLine($"Score = {Score}");
            //}
            //Console.ReadKey();

            //#2-9
            //Console.WriteLine("請輸入身高、體重2個值");
            //double h = Convert.ToDouble(Console.ReadLine());
            //double w = Convert.ToDouble(Console.ReadLine());

            //double bmi = w / (Math.Pow((h / 100), 2));

            //if (bmi < 18.5)
            //{
            //    Console.WriteLine("BMI = 過輕");
            //}
            //else if (bmi >= 18.5 & bmi < 24)
            //{
            //    Console.WriteLine("BMI = 正常");
            //}
            //else
            //{
            //    Console.WriteLine("BMI = 過重");
            //}
            //Console.ReadKey();

            //#2-10
            //Console.WriteLine("請輸入3個值");
            //double x = Convert.ToDouble(Console.ReadLine());
            //double y = Convert.ToDouble(Console.ReadLine());
            //double z = Convert.ToDouble(Console.ReadLine());

            //if(x > y & x > z)
            //{
            //    if(y > z)
            //    {
            //        Console.WriteLine($"{x}, {y}, {z}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{x}, {z}, {y}");
            //    }
            //}
            //else if(y > x & y > z)
            //{
            //    if (x > z)
            //    {
            //        Console.WriteLine($"{y}, {x}, {z}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{y}, {z}, {x}");
            //    }
            //}
            //else
            //{
            //    if (x > y)
            //    {
            //        Console.WriteLine($"{z}, {x}, {y}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{z}, {y}, {x}");
            //    }
            //}
            //Console.ReadKey();

            //#2-11
            Console.WriteLine("請輸入1個值");
            double x = Convert.ToDouble(Console.ReadLine());
            double bonus;
            if (x <= 100000)
            {
                bonus = x* 0.1;
                Console.WriteLine($"bonus = {bonus}");
            }
            else if (x <= 200000 & x > 100000)
            {
                bonus = 10000 + ((x - 100000) * 0.075);
                Console.WriteLine($"bonus = {bonus}");
            }
            else if (x <= 400000 & x > 200000)
            {
                bonus = (10000 + 7500) + ((x - 200000) * 0.05);
                Console.WriteLine($"bonus = {bonus}");
            }
            else if (x <= 600000 & x > 400000)
            {
                bonus = (10000 + 7500 + 10000) + ((x - 400000) * 0.03);
                Console.WriteLine($"bonus = {bonus}");
            }
            else if (x <= 1000000 & x > 600000)
            {
                bonus = (10000 + 7500 + 10000 + 6000) + ((x - 600000) * 0.015);
                Console.WriteLine($"bonus = {bonus}");
            }
            else
            {
                bonus = (10000 + 7500 + 10000 + 6000 + 6000) + ((x - 1000000) * 0.01);
                Console.WriteLine($"bonus = {bonus}");
            }
            Console.ReadKey();
        }
    }
}
