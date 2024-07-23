using System;
using System.Collections;
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
            //Console.WriteLine("請輸入1個值");
            //double x = Convert.ToDouble(Console.ReadLine());
            //double bonus;
            //if (x <= 100000)
            //{
            //    bonus = x* 0.1;
            //    Console.WriteLine($"bonus = {bonus}");
            //}
            //else if (x <= 200000 & x > 100000)
            //{
            //    bonus = 10000 + ((x - 100000) * 0.075);
            //    Console.WriteLine($"bonus = {bonus}");
            //}
            //else if (x <= 400000 & x > 200000)
            //{
            //    bonus = (10000 + 7500) + ((x - 200000) * 0.05);
            //    Console.WriteLine($"bonus = {bonus}");
            //}
            //else if (x <= 600000 & x > 400000)
            //{
            //    bonus = (10000 + 7500 + 10000) + ((x - 400000) * 0.03);
            //    Console.WriteLine($"bonus = {bonus}");
            //}
            //else if (x <= 1000000 & x > 600000)
            //{
            //    bonus = (10000 + 7500 + 10000 + 6000) + ((x - 600000) * 0.015);
            //    Console.WriteLine($"bonus = {bonus}");
            //}
            //else
            //{
            //    bonus = (10000 + 7500 + 10000 + 6000 + 6000) + ((x - 1000000) * 0.01);
            //    Console.WriteLine($"bonus = {bonus}");
            //}
            //Console.ReadKey();

            //3-1
            //Console.WriteLine("輸入10個整數，求其最小值");
            //int sum = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write($"第{i}個值:");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    if (sum == 0)
            //    {
            //        sum = num;
            //    }
            //    else if (num < sum)
            //    {
            //        sum = num;
            //    }
            //}
            //Console.WriteLine($"最小值為:{sum}");
            //Console.ReadKey();

            //3-1(while)
            //Console.WriteLine("輸入10個整數，求其最小值");
            //int sum = 0;
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.Write($"第{i}個值:");
            //    i++;
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    if (sum == 0)
            //    {
            //        sum = num;
            //    }
            //    else if (num < sum)
            //    {
            //        sum = num;
            //    }
            //}
            //Console.WriteLine($"最小值為:{sum}");
            //Console.ReadKey();

            //3-2
            //Console.WriteLine("輸入N個整數，求其最小值");
            //int sum = 0;
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.Write($"第{i}個值:");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    if (sum == 0)
            //    {
            //        sum = num;
            //    }
            //    else if (num < sum)
            //    {
            //        sum = num;
            //    }
            //}
            //Console.WriteLine($"最小值為:{sum}");
            //Console.ReadKey();

            //3-2(while)
            //Console.WriteLine("輸入N個整數，求其最小值");
            //int sum = 0;
            //int i = 1;
            //int n = Convert.ToInt32(Console.ReadLine());
            //while (i <= n)
            //{
            //    Console.Write($"第{i}個值:");
            //    i++;
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    if (sum == 0)
            //    {
            //        sum = num;
            //    }
            //    else if (num < sum)
            //    {
            //        sum = num;
            //    }
            //}
            //Console.WriteLine($"最小值為:{sum}");
            //Console.ReadKey();

            //3-3
            //Console.WriteLine("輸入10個整數，列出其中所有大於12的數字");
            //string sum = "";
            //string s = ",";
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write($"第{i}個值:");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    if (num > 12)
            //    {
            //        sum += s + Convert.ToString(num);
            //    }

            //}
            //Console.WriteLine($"大於12的數字為:{sum.Substring(1)}");
            //Console.ReadKey();

            //3-3(while)
            //Console.WriteLine("輸入10個整數，列出其中所有大於12的數字");
            //string sum = "";
            //string s = ",";
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.Write($"第{i}個值:");
            //    i++;
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    if (num > 12)
            //    {
            //        sum += s + Convert.ToString(num);
            //    }
            //}
            //Console.WriteLine($"大於12的數字為:{sum.Substring(1)}");
            //Console.ReadKey();

            //3-4
            //Console.WriteLine("輸入10個整數，列出其中所有大於12的數字");
            //int sum = 0;
            //string a = "";
            //string s = ",";
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write($"第{i}個值:");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    if (num > 12)
            //    {
            //        a += s + Convert.ToString(num);
            //        sum += num;
            //    }

            //}
            //Console.WriteLine($"大於12的數字為:{a},總和為:{sum}");
            //Console.ReadKey();

            //3-4(while)
            //Console.WriteLine("輸入10個整數，列出其中所有大於12的數字");
            //string a = "";
            //string s = ",";
            //int sum = 0;
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.Write($"第{i}個值:");
            //    i++;
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    if (num > 12)
            //    {
            //        a += s + Convert.ToString(num);
            //        sum += num;
            //    }
            //}
            //Console.WriteLine($"大於12的數字為:{a},總和為:{sum}");
            //Console.ReadKey();

            //3-5
            //Console.WriteLine("輸入N個數字，求其所有奇數中的最大值");
            //int sum = 0;
            //Console.Write("設定n值");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("輸入N個數字");
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.Write($"第{i}個值:");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    if(num%2 != 0)
            //    {
            //        if (num > sum)
            //        {
            //            sum = num;
            //        }
            //    }
            //}
            //Console.WriteLine($"奇數中的最大值為:{sum}");
            //Console.ReadKey();

            //3-5(while)
            //Console.WriteLine("輸入N個數字，求其所有奇數中的最大值");
            //int sum = 0;
            //int i = 1;
            //Console.Write("設定n值");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("輸入N個數字");
            //while (i <= n)
            //{
            //    Console.Write($"第{i}個值:");
            //    i++;
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    if (num%2 != 0)
            //    {
            //        if (num > sum)
            //        {
            //            sum = num;
            //        }
            //    }
            //}
            //Console.WriteLine($"奇數中的最大值為:{sum}");
            //Console.ReadKey();

            //3-6
            //Console.WriteLine("輸入N個數字，求其所有正數之平方的加總");
            //double sum = 0;
            //Console.Write("設定n值");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("輸入N個數字");
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.Write($"第{i}個值:");
            //    double num = Convert.ToDouble(Console.ReadLine());

            //    if (num > 0)
            //    {
            //        sum += Math.Pow(num, 2);
            //    }
            //}
            //Console.WriteLine($"數之平方的加總為:{sum}");
            //Console.ReadKey();

            //3-6(while)
            //Console.WriteLine("輸入N個數字，求其所有正數之平方的加總");
            //double sum = 0;
            //int i = 1;
            //Console.Write("設定n值");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("輸入N個數字");
            //while (i <= n)
            //{
            //    Console.Write($"第{i}個值:");
            //    i++;
            //    double num = Convert.ToDouble(Console.ReadLine());

            //    if (num > 0)
            //    {
            //        sum += Math.Pow(num, 2);
            //    }
            //}
            //Console.WriteLine($"數之平方的加總為:{sum}");
            //Console.ReadKey();

            //3-7
            //Console.WriteLine("輸入N個數字，其中有些是負數，將這些負數轉換成正數");
            //string a = "";
            //string s = ",";
            //Console.Write("設定n值");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("輸入N個數字");
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.Write($"第{i}個值:");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    if (num < 0)
            //    {
            //        a += s + Math.Abs(num);
            //    }
            //}
            //Console.WriteLine($"負數轉換成正數為:{a}");
            //Console.ReadKey();

            //3-7(while)
            //Console.WriteLine("輸入N個數字，其中有些是負數，將這些負數轉換成正數");
            //string a = "";
            //string s = ",";
            //int i = 1;
            //Console.Write("設定n值");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("輸入N個數字");
            //while (i <= n)
            //{
            //    Console.Write($"第{i}個值:");
            //    i++;
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    if (num < 0)
            //    {
            //        a += s + Math.Abs(num);
            //    }
            //}
            //Console.WriteLine($"負數轉換成正數為:{a}");
            //Console.ReadKey();

            //3-8
            //Console.WriteLine("判斷101-200之間有多少個質數，並輸出所有質數");
            //int start = 101;
            //int end = 200;
            //int prime = 0;
            //string p = "";
            //string s = ",";
            //for (int i = start; i <= end; i++)
            //{
            //    bool isPrime = true;
            //    if (i <= 1)
            //    {
            //        isPrime = false;
            //    }
            //    for (int j = 2; j <= Math.Sqrt(i); j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //    if (isPrime)
            //    {
            //        prime++;
            //        p += s + Convert.ToString(i);
            //    }
            //}
            //Console.WriteLine($"{prime}個質數,質數為:{p.Substring(1)}");
            //Console.ReadKey();

            //3-8(while)
            //Console.WriteLine("判斷101-200之間有多少個質數，並輸出所有質數");
            //int start = 101;
            //int end = 200;
            //int prime = 0;
            //string p = "";
            //string s = ",";
            //while (start <= end)
            //{
            //    bool isPrime = true;
            //    if (start <= 1)
            //    {
            //        isPrime = false;
            //    }
            //    for (int j = 2; j <= Math.Sqrt(start); j++)
            //    {
            //        if (start % j == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //    if (isPrime)
            //    {
            //        prime++;
            //        p += s + Convert.ToString(start);
            //    }
            //    start++;
            //}
            //Console.WriteLine($"{prime}個質數,質數為:{p.Substring(1)}");
            //Console.ReadKey();

            //3-9
            //Console.WriteLine("輸入一個數，輸出其質因數");
            //string p = "";
            //string s = ",";
            //int num = Convert.ToInt32(Console.ReadLine());
            //for (int i = 2; i <= num; i++)
            //{
            //    if (num % i == 0)
            //    {
            //        bool isPrime = true;
            //        if (i <= 1)
            //        {
            //            isPrime = false;
            //        }
            //        for (int j = 2; j <= Math.Sqrt(i); j++)
            //        {
            //            if (i % j == 0)
            //            {
            //                isPrime = false;
            //                break;
            //            }
            //        }
            //        if (isPrime)
            //        {
            //            p += s + Convert.ToString(i);
            //        }
            //    }
            //}
            //Console.WriteLine($"質因數為:{p.Substring(1)}");
            //Console.ReadKey();

            //3-9(while)
            //Console.WriteLine("輸入一個數，輸出其質因數");
            //string p = "";
            //string s = ",";
            //int num = Convert.ToInt32(Console.ReadLine());
            //int i = 2;
            //while (i <= num)
            //{
            //    if (num % i == 0)
            //    {
            //        bool isPrime = true;
            //        if (i <= 1)
            //        {
            //            isPrime = false;
            //        }
            //        for (int j = 2; j <= Math.Sqrt(i); j++)
            //        {
            //            if (i % j == 0)
            //            {
            //                isPrime = false;
            //                break;
            //            }
            //        }
            //        if (isPrime)
            //        {
            //            p += s + Convert.ToString(i);
            //        }
            //    }
            //    i++;
            //}
            //Console.WriteLine($"質因數為:{p.Substring(1)}");
            //Console.ReadKey();

            //3-10
            //Console.WriteLine("求100到300中可以被3與7整除的個數");
            //int start = 100;
            //int end = 300;
            //string p = "";
            //string s = ",";
            //for (int i = start; i <= end; i++)
            //{
            //    if ((i % 3 == 0) && (i % 7 == 0))
            //    {
            //        p += s + Convert.ToString(i);
            //    }
            //}
            //Console.WriteLine($"個數為:{p.Substring(1)}");
            //Console.ReadKey();

            //3-10(while)
            //Console.WriteLine("求100到300中可以被3與7整除的個數");
            //int start = 100;
            //int end = 300;
            //string p = "";
            //string s = ",";
            //while (start <= end)
            //{
            //    if ((start % 3 == 0) && (start % 7 == 0))
            //    {
            //        p += s + Convert.ToString(start);
            //    }
            //    start++;
            //}
            //Console.WriteLine($"個數為:{p.Substring(1)}");
            //Console.ReadKey();

            //4-1
            //Console.WriteLine("求N個數字的最大值");
            //Console.Write("設定n值");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("輸入N個數字");
            //int i = 1, max = 0;
            //while (i <= n)
            //{
            //    int into = Convert.ToInt32(Console.ReadLine());
            //    if (max == 0)
            //    {
            //        max = into;
            //    }
            //    else if (into > max)
            //    {
            //        max = into;
            //    }
            //    i++;
            //}
            //Console.WriteLine($"最大值為:{max}");
            //Console.ReadKey();

            //4-2
            //Console.WriteLine("求一個等差級數數字的和");
            //Console.Write("輸入起始值");
            //int start = Convert.ToInt32(Console.ReadLine());
            //Console.Write("輸入間格差");
            //int s = Convert.ToInt32(Console.ReadLine());
            //Console.Write("設定n值");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int i = 1;
            //int sum = 0;
            //while(i <= n)
            //{
            //    sum += start;
            //    start += s;
            //    i++;
            //}
            //Console.WriteLine($"總和為:{sum}");
            //Console.ReadKey();

            //4-3
            //Console.WriteLine("找出所有小於13的數，再求這些數字的和");
            //Console.Write("設定n值");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int i = 1;
            //int sum = 0;
            //string p = "";
            //string s = ",";
            //while (i <= n)
            //{
            //    Console.Write($"第{i}個值:");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    if (num < 13)
            //    {
            //        sum += num;
            //        p += s + Convert.ToString(num);
            //    }
            //    i++;
            //}
            //Console.WriteLine($"個數為:{p.Substring(1)},總和為:{sum}");
            //Console.ReadKey();

            //4-4
            //Console.WriteLine("找到第一個大於7而小於10的數字就停止，而且列印出這個數字");
            //Console.Write("設定n值");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int i = 1;
            //string p = "";
            //while (i <= n)
            //{
            //    Console.Write($"第{i}個值:");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    if (num > 7 && num < 10)
            //    {
            //        p += Convert.ToString(num);
            //        break;
            //    }
            //    i++;
            //}
            //if(p == "")
            //{
            //    Console.WriteLine("沒有大於7而小於10的數字");
            //}
            //else
            //{
            //    Console.WriteLine($"數字為:{p}");
            //}
            //Console.ReadKey();

            //4-5
            //Console.WriteLine("讀入a1,a2,…,a5和b1,b2,…,b5。找到第一個ai>bi，即停止，並列印出ai及bi");
            //int n = 5;
            //int i = 1;
            //string p="",s="";
            //while (i <= n)
            //{
            //    Console.Write($"輸入a{i}");
            //    double num_a = Convert.ToDouble(Console.ReadLine());
            //    Console.Write($"輸入b{i}");
            //    double num_b = Convert.ToDouble(Console.ReadLine());
            //    if (num_a > num_b)
            //    {
            //        p += Convert.ToString(num_a);
            //        s += Convert.ToString(num_b);
            //        break;
            //    }
            //    i++;
            //}
            //if(p == "")
            //{
            //    Console.WriteLine("沒有符合數字");
            //}
            //else
            //{
            //    Console.WriteLine($"ai為:{p},bi為:{s}");
            //}
            //Console.ReadKey();

            //4-6
            //Console.WriteLine("請隨意輸入一個時間，輸出這段時間吃漢堡的紀錄");
            //Console.Write("輸入一個時間");
            //int time = Convert.ToInt32(Console.ReadLine());
            //int m = 5;
            //int b = 0;
            //while (m <= time)
            //{
            //    b++;
            //    m += 5;
            //}
            //Console.WriteLine($"吃了{b}漢堡,花了{39*b}元");
            //Console.ReadKey();

            //4-7
            //Console.WriteLine("請問需要幾個月還清");
            //int h = 560;
            //int tt = 0;
            //int m = 0;
            //while (0 <= h)
            //{
            //    m++;
            //    h-= 4;
            //    if (m == 12)
            //    {
            //        h -= 1;
            //        tt+= m;
            //        m = 0;
            //    }
            //}
            //Console.WriteLine($"需要{tt + m}個月");
            //Console.ReadKey();

            //4-8
            //Console.WriteLine("讓使用者數入數字，直到猜中才離開程式！");
            //Random rnd = new Random();
            //int Guess = rnd.Next(1, 101);
            //while (true)
            //{
            //    Console.Write("輸入你猜的數字");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    if (a < Guess)
            //    {
            //        Console.WriteLine("再大一點");
            //    }
            //    else if (a > Guess)
            //    {
            //        Console.WriteLine("再小一點");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"答對了,答案是{Guess}");
            //        break;
            //    }
            //}
            //Console.ReadKey();
        }
    }
}


