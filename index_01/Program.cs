using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Diagnostics;

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

            //5-1列
            //Console.WriteLine("求10個數字的平均值");
            //double[] sum = new double[10];
            //for(int i = 0; i < sum.Length; i++)
            //{
            //    Console.Write($"輸入陣列第{i}值");
            //    sum[i] = Convert.ToDouble(Console.ReadLine());
            //}

            //double x = 0;
            //for (int i = 0; i < sum.Length; i++)
            //{
            //    x += sum[i];
            //}
            //Console.WriteLine($"平均值是{x / 10}");
            //Console.ReadKey();

            //5-2列
            //Console.WriteLine("求10個數字的最大值");
            //double[] sum = new double[10];
            //for (int i = 0; i < sum.Length; i++)
            //{
            //    Console.Write($"輸入陣列第{i}值");
            //    sum[i] = Convert.ToDouble(Console.ReadLine());
            //}

            //double max = 0;
            //for (int i = 0; i < sum.Length; i++)
            //{
            //    if (sum[i] > max) 
            //    { 
            //        max = sum[i]; 
            //    } 
            //}
            //Console.WriteLine($"最大值是{max}");
            //Console.ReadKey();

            //5-3列
            //Console.WriteLine("判斷x是否存在於A陣列中");
            //double[] A = new double[10];
            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.Write($"輸入A陣列第{i}值");
            //    A[i] = Convert.ToDouble(Console.ReadLine());
            //}

            //Console.Write($"輸入要判斷的x值");
            //double x = Convert.ToDouble(Console.ReadLine());
            //bool B = false;
            //for (int i = 0; i < A.Length; i++)
            //{
            //    if (A[i] == x)
            //    {
            //        B = true;
            //    }
            //}
            //if (B) 
            //{
            //    Console.WriteLine($"存在");
            //}
            //else
            //{
            //    Console.WriteLine($"不存在");
            //}
            //Console.ReadKey();

            //5-4列
            //Console.WriteLine("求兩個2乘3的二維矩陣相加之結果，存入C矩陣");
            //int[,] A = new int[2, 3];
            //int[,] B = new int[2, 3];
            //int[,] C = new int[2, 3];
            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {
            //        Console.Write($"輸入A矩陣第{i},{j} 值");
            //        A[i,j] = Convert.ToInt32(Console.ReadLine());
            //        Console.Write($"輸入B矩陣第{i},{j} 值");
            //        B[i,j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {
            //        C[i, j] += A[i, j] + B[i, j];
            //    }
            //}
            //foreach (int Hello in C)
            //{
            //    Console.WriteLine($"C矩陣依序為{Hello}");
            //}
            //Console.ReadKey();

            //5-5列
            //Console.WriteLine("2乘3的A矩陣乘以3乘1的B矩陣，結果存入2乘1的C矩陣");
            //int[,] A = new int[2, 3];
            //int[,] B = new int[3, 1];
            //int[,] C = new int[2, 1];
            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {
            //        Console.Write($"輸入A矩陣第{i},{j} 值");
            //        A[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < B.GetLength(0); i++)
            //{
            //    Console.Write($"輸入B矩陣第{i},0值");
            //    B[i, 0] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    for (int j = 0; j < B.GetLength(1); j++)
            //    {
            //        for (int k = 0; k < A.GetLength(1); k++)
            //        {
            //            C[i, j] += A[i, k] * B[k, j];
            //        }
            //    }
            //}
            //foreach (int Hello in C)
            //{
            //    Console.WriteLine($"C矩陣依序為{Hello}");
            //}
            //Console.ReadKey();


            //5-1習
            //Console.WriteLine("如A[i]>5，則令A[i]=A[i]-5，否則A[i]=A[i]+5");
            //double[] A = new double[10];
            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.Write($"輸入A陣列第{i}值");
            //    A[i] = Convert.ToDouble(Console.ReadLine());
            //}

            //for (int i = 0; i < A.Length; i++)
            //{
            //    if (A[i] > 5)
            //    {
            //        A[i]-= 5;
            //    }
            //    else
            //    {
            //        A[i]+= 5;
            //    }
            //}
            //foreach (double Hello in A)
            //{
            //    Console.WriteLine(Hello);
            //}
            //Console.ReadKey();

            //5-2習
            //Console.WriteLine("對每一個數字，令A[i]=A[i]+i");
            //double[] A = new double[10];
            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.Write($"輸入A陣列第{i}值");
            //    A[i] = Convert.ToDouble(Console.ReadLine());
            //}

            //for (int i = 0; i < A.Length; i++)
            //{

            //    A[i] += i; 
            //}
            //foreach (double Hello in A)
            //{
            //    Console.WriteLine(Hello);
            //}
            //Console.ReadKey();

            //5-3習
            //Console.WriteLine("將10個數字讀入A陣列，並建立一個B陣列，如A[i]≥0，令B[i]=1，否則令B[i]=0");
            //double[] A = new double[10];
            //double[] B = new double[10];
            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.Write($"輸入A陣列第{i}值");
            //    A[i] = Convert.ToDouble(Console.ReadLine());
            //}
            //for (int i = 0; i < A.Length; i++)
            //{
            //    if (A[i] >= 0)
            //    {
            //        B[i] = 1;
            //    }
            //    else
            //    {
            //        B[i] = 0;
            //    }
            //}
            //foreach (double Hello in B)
            //{
            //    Console.WriteLine(Hello);
            //}
            //Console.ReadKey();

            //5-4習
            //Console.WriteLine("將15數字存入3×5的二維陣列A中，求每一行及每一列數字的和");
            //int[,] A = new int[3,5];
            //int sum = 0;
            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {
            //        Console.Write($"輸入A矩陣第{i},{j} 值");
            //        A[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {
            //        sum += A[i, j];
            //        if (j == 4)
            //        {
            //            Console.WriteLine($"A矩陣第{i}行和為{sum}");
            //            sum = 0;
            //        }
            //    }
            //}

            //sum = 0;
            //for (int x = 0; x < A.GetLength(1); x++)
            //{
            //    for (int y = 0; y < A.GetLength(0); y++)
            //    {

            //        sum += A[y, x];
            //        if (y == 2)
            //        {
            //            Console.WriteLine($"A矩陣第{x}列和為{sum}");
            //            sum = 0;
            //        }
            //    }
            //}
            //Console.ReadKey();

            //5-5習
            //Console.WriteLine("將15數字存入3×5的二維陣列A中，求每一行及每一列數字的最小值");
            //int[,] A = new int[3, 5];
            //int min = int.MaxValue;
            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {
            //        Console.Write($"輸入A矩陣第{i},{j} 值");
            //        A[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    for (int j = 0; j < A.GetLength(1); j++)
            //    {
            //        if (min > A[i, j])
            //        {
            //            min = A[i, j];
            //        }
            //        if (j == 4)
            //        {
            //            Console.WriteLine($"A矩陣第{i}行最小值為{min}");
            //            min = int.MaxValue;
            //        }
            //    }
            //}

            //min = int.MaxValue;
            //for (int x = 0; x < A.GetLength(1); x++)
            //{
            //    for (int y = 0; y < A.GetLength(0); y++)
            //    {

            //        if (min > A[y, x])
            //        {
            //            min = A[y, x];
            //        }
            //        if (y == 2)
            //        {
            //            Console.WriteLine($"A矩陣第{x}列最小值為{min}");
            //            min = int.MaxValue;
            //        }
            //    }
            //}
            //Console.ReadKey();

            //5-6習
            //Console.WriteLine("輸入兩組數字：a1,a2,…,a5和b1,b2,…,b5。求ai+bi，i=1到i=5");
            //double[] A = new double[6];
            //double[] B = new double[6];
            //double C = 0;
            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.Write($"輸入A陣列第{i}值");
            //    A[i] = Convert.ToDouble(Console.ReadLine());
            //    Console.Write($"輸入B陣列第{i}值");
            //    B[i] = Convert.ToDouble(Console.ReadLine());
            //}
            //for (int i = 0; i < A.Length; i++)
            //{
            //    if(i == 0)
            //    {
            //        continue;
            //    }
            //    C = A[i] + B[i];
            //    Console.WriteLine($"A{i}+B{i}={C}");
            //}
            //Console.ReadKey();

            //5-7習
            //Console.WriteLine("輸入兩組數字：a1,a2,…,a5和b1,b2,…,b5。令x為a中的最大值，令y為b中的最大值，求x與y中較小者");
            //int[] A = new int[5];
            //int[] B = new int[5];
            //int x=int.MinValue, y=int.MinValue;
            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.Write($"輸入A陣列第{i}值");
            //    A[i] = Convert.ToInt32(Console.ReadLine());
            //    Console.Write($"輸入B陣列第{i}值");
            //    B[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < A.Length; i++)
            //{
            //    if (A[i] > x)
            //    {
            //        x = A[i];
            //    }
            //}
            //for (int i = 0; i < B.Length; i++)
            //{
            //    if (B[i] > y)
            //    {
            //        y = B[i];
            //    }
            //}
            //if (x < y) 
            //{
            //    Console.WriteLine($"x與y中較小者為x:{x}");
            //}
            //else
            //{
            //    Console.WriteLine($"x與y中較小者為y:{y}");
            //}
            //Console.ReadKey();



            //字串.1
            //Console.Write("輸入姓名:");
            //string mane = Console.ReadLine();
            //Console.WriteLine($"Hi~{mane}");
            //Console.ReadKey();

            //字串.2
            //string test_srting = "人人為我，我為人人、饒人不癡漢，癡漢不饒人";
            //Console.Write("輸入要判斷的字串:");
            //string inputstring = Console.ReadLine();
            //bool Answer = test_srting.Contains(inputstring);
            //if (Answer)
            //{
            //    Console.WriteLine("存在");
            //}
            //else
            //{
            //    Console.WriteLine("不存在");
            //}
            //Console.ReadKey();

            //字串.3
            //Console.Write("輸入字串:");
            //string inputstring = Console.ReadLine();
            //string outputstring = null;
            //string Dash = "-";
            //for (int i = 0; i < inputstring.Length; i++) 
            //{
            //    outputstring += inputstring[i] + Dash;
            //}
            //string result = outputstring.Substring(0, outputstring.Length - 1);
            //Console.WriteLine(result);
            //Console.ReadKey();

            //字串.4
            //Console.Write("輸入檔名:");
            //string inputstring = Console.ReadLine();
            //int Location = inputstring.IndexOf('.');
            //string result = inputstring.Substring(Location + 1);
            //Console.WriteLine(result);
            //Console.ReadKey();

            //字串.4
            //Console.Write("輸入字串:");
            //string inputstring = Console.ReadLine();
            //if ((inputstring.Length) > 5)
            //{
            //    string result = inputstring.Substring(0, 3);
            //    Console.WriteLine(result);
            //}
            //else 
            //{
            //    Console.WriteLine("長度不夠");
            //}
            //Console.ReadKey();

            //字串.5
            //Console.Write("輸入字串:");
            //string inputstring = Console.ReadLine();
            //string result = inputstring.Replace("我", "小明");
            //Console.WriteLine(result);
            //Console.ReadKey();

            //字串.6
            //Console.Write("輸入字串:");
            //string inputstring = Console.ReadLine();
            //Console.WriteLine($"你輸入{inputstring.Length}個字");
            //Console.ReadKey();

            //字串.7
            //Console.WriteLine("連續輸入10組字串判斷有無輸入過");
            //string[] A = new string[10];
            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.Write($"輸入第{i}字串:");
            //    string result = Console.ReadLine();
            //    for (int j = 0; j < A.Length; j++)
            //    {
            //        int num = result.CompareTo(A[j]);
            //        if (num == 0)
            //        {
            //            Console.WriteLine("輸入過");
            //            break;
            //        }
            //        else if (j == 9)
            //        {
            //            Console.WriteLine("沒出現過");
            //            A[i] = result;
            //        }

            //    }
            //}
            //Console.ReadKey();

            //字串.8
            //Console.WriteLine("用字母大小寫來模擬波浪舞");
            //Console.Write("輸入字串:");
            //string inputstring = Console.ReadLine();
            //string lowerStr = inputstring.ToLower();
            //for (int i = 0; i < lowerStr.Length; i++)
            //{
            //    string toUpper = lowerStr.Substring(i,1).ToUpper();
            //    string modified = lowerStr.Insert(i, toUpper);
            //    string result1 = modified.Remove((i + 1), 1);
            //    Console.WriteLine(result1);
            //}
            //Console.ReadKey();

            //字串.9
            //Console.WriteLine("輸入時間，顯示幾時幾分");
            //Console.Write("輸入時間例如'12:30':");
            //string inputstring = Console.ReadLine().Trim();
            //int index = inputstring.IndexOf(":");
            //string outputstring01 = inputstring.Substring(0, index);
            //string outputstring02 = inputstring.Substring(index + 1);
            //bool aa = outputstring01.StartsWith("0");
            //if (aa)
            //{
            //    Console.WriteLine($"{outputstring01[1]}點{outputstring02}分");
            //}
            //else
            //{
            //    Console.WriteLine($"{outputstring01}點{outputstring02}分");
            //}
            //Console.ReadKey();

            //字串.10
            //Console.WriteLine("輸入的字，轉成HTML");
            //Console.Write("輸入字串:");
            //string inputstring = Console.ReadLine();
            //string[] words = inputstring.Split(',');
            //string[] aaa = new string[words.Length];
            //int num = 0;
            //foreach (string word in words) 
            //{
            //    aaa[num] = word;
            //    num++;
            //}
            //Console.WriteLine($"<ul> \n    <li>{aaa[0]}</li>\n    <li>{aaa[1]}</li>\n    <li>{aaa[2]}</li>\n</ul>");
            //Console.ReadKey();

            //字串.11
            //Console.WriteLine("輸入5處數字，用空白隔開，求總和");
            //Console.Write("輸入數字:");
            //string inputstring = Console.ReadLine();
            //string[] words = inputstring.Split(' ');
            //int sum = 0;
            //for (int i = 0; i < words.Length; i++) 
            //{
            //    sum += Convert.ToInt32(words[i]);
            //}
            //Console.WriteLine($"總合為:{sum}");
            //Console.ReadKey();

            //字串.12
            //Console.WriteLine("請輸入一個字符串：");
            //string inputstring = Console.ReadLine();
            //char[] charArray = inputstring.ToCharArray();
            //Array.Reverse(charArray);
            //string reversedString = new string(charArray);
            //Console.WriteLine(reversedString);
            //Console.ReadKey();

            //Function-1
            //Console.WriteLine("將文字轉成html格式");
            //Console.Write("輸入文字:");
            //string aa = Console.ReadLine();
            //CountArea(aa);
            //Console.ReadKey();
            //void CountArea(string a)
            //{
            //    string b = null;
            //    for (int i = 0; i < 6; i++)
            //    {

            //        if (a.Contains(">") && i <= 1)
            //        {
            //            b = a.Replace(">", "&gt;");
            //        }
            //        else if (a.Contains("<") && i <= 1)
            //        {
            //            b = a.Replace("<", "&lt;");
            //        }
            //        else if (a.Contains(" "))
            //        {
            //            b = a.Replace(" ", "&nbsp;");
            //        }
            //        else if (a.Contains("\\r\\n"))
            //        {
            //            b = a.Replace("\\r\\n", "<br>");
            //        }
            //        else if (a.Contains("|"))
            //        {
            //            b = a.Replace("|", "&brvbar;");
            //        }
            //        a = b;

            //    }
            //    Console.WriteLine(a);
            //}

            //Function-2
            //Console.WriteLine("判斷是否為數字");
            //Console.Write("輸入字串:");
            //string aa = Console.ReadLine();
            //CountArea(aa);
            //Console.ReadKey();
            //void CountArea(string a)
            //{

            //    foreach (char c in a)
            //    {
            //        if (!char.IsDigit(c))
            //        {
            //            Console.WriteLine("不是數字");
            //        }
            //        else
            //        {
            //            Console.WriteLine("是數字");
            //        }
            //    }
            //}

            //Function-3
            //Console.WriteLine("判斷是否為電子信箱格式");
            //Console.Write("輸入字串:");
            //string aa = Console.ReadLine();
            //CountArea(aa);
            //Console.ReadKey();
            //void CountArea(string a)
            //{
            //    string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            //    Regex ReObj = new Regex(pattern); 

            //    bool bb = ReObj.IsMatch(a);
            //    if (bb)
            //    {
            //        Console.WriteLine("是電子信箱格式");
            //    }
            //    else
            //    {
            //        Console.WriteLine("不是電子信箱格式");
            //    }
            //}

            //Function-4
            //Console.WriteLine("判斷是否為手機格式");
            //Console.Write("輸入字串:");
            //string aa = Console.ReadLine();
            //CountArea(aa);
            //Console.ReadKey();
            //void CountArea(string a)
            //{
            //    string pattern = @"^09\d{8}$";

            //    Regex ReObj = new Regex(pattern);

            //    bool bb = ReObj.IsMatch(a);
            //    if (bb)
            //    {
            //        Console.WriteLine("是手機格式");
            //    }
            //    else
            //    {
            //        Console.WriteLine("不是手機格式");
            //    }
            //}

            //Function-5
            //Console.WriteLine("判斷是否為身分證字號格式");
            //Console.Write("輸入字串:");
            //string aa = Console.ReadLine();
            //CountArea(aa);
            //Console.ReadKey();
            //void CountArea(string a)
            //{
            //    string pattern = @"^[A-Z]\d{9}$";

            //    Regex ReObj = new Regex(pattern);

            //    bool bb = ReObj.IsMatch(a);
            //    if (bb)
            //    {
            //        Console.WriteLine("是身分證字號格式");
            //    }
            //    else
            //    {
            //        Console.WriteLine("不是身分證字號格式");
            //    }
            //}

            //Function-6
            //Console.WriteLine("輸入文字大於Ｎ個，則超過的字不要，變成點點點");
            //Console.Write("輸入字串:");
            //string aa = Console.ReadLine();
            //Console.Write("輸入超過幾個數字:");
            //int bb = Convert.ToInt32(Console.ReadLine());
            //CountArea(aa, bb);
            //Console.ReadKey();
            //void CountArea(string a, int b)
            //{
            //    string dd = a.Substring(0, b);
            //    string gg = ".";
            //    for (int i = b; i < a.Length; i++)
            //    { 
            //        dd += gg;
            //    }
            //    Console.WriteLine(dd);
            //}

            //Function-7
            //Console.WriteLine("輸入一個日期，把該日期轉成民國年.月.日格式");
            //Console.Write("輸入字串:");
            //string aa = Console.ReadLine();
            //CountArea(aa);
            //Console.ReadKey();
            //void CountArea(string a)
            //{
            //    string dd = a.Substring(0, 4);
            //    int year = Convert.ToInt32(dd);
            //    int roc = year - 1911;
            //    string rocstr = Convert.ToString(roc);
            //    string gg = ".";
            //    string month = a.Substring(4, 2);
            //    string day = a.Substring(6, 2);
            //    rocstr += gg + month + gg + day;
            //    Console.WriteLine(rocstr);
            //}

            //Function-8
            //Console.WriteLine("輸入一個日期，把該轉成民國XX年XX月XX日 星期X 格式");
            //Console.Write("輸入字串:");
            //string aa = Console.ReadLine();
            //CountArea(aa);
            //Console.ReadKey();
            //void CountArea(string a)
            //{
            //    string dd = a.Substring(0, 4);
            //    int year = Convert.ToInt32(dd);
            //    int roc = year - 1911;
            //    string rocstr = Convert.ToString(roc);
            //    string month = a.Substring(4, 2);
            //    string day = a.Substring(6, 2);
            //    string week = a.Substring(8, 1);
            //    rocstr += "年" + month + "月" + day + "日" + "星期" + week;
            //    Console.WriteLine(rocstr);
            //}

            //Function-9
            //Console.WriteLine("判斷輸入的年是否閏年");
            //Console.Write("輸入字串:");
            //int aa = Convert.ToInt32(Console.ReadLine());
            //CountArea(aa);
            //Console.ReadKey();
            //void CountArea(int a)
            //{
            //    if (a % 4 == 0)
            //    {
            //        if (a % 100 != 0)
            //        {
            //            Console.WriteLine("是閏年");
            //        }
            //        else
            //        {
            //            if (a % 400 == 0)
            //            {
            //                Console.WriteLine("是閏年");
            //            }
            //            else
            //            {
            //                if (a % 1000 == 0)
            //                {
            //                    Console.WriteLine("是閏年");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("不是閏年");
            //                }
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("不是閏年");
            //    }
            //}

            //Function-10
            //Console.WriteLine("輸入手機號碼，回傳今天運勢(手機運勢算法：用你的手機號碼的最後四位數除以80，再減去整數部分（只留小數），再乘以80，就會得到一個數，這就是代表吉凶的數字");
            //Console.Write("輸入字串:");
            //string aa = Console.ReadLine();
            //CountArea(aa);
            //Console.ReadKey();
            //void CountArea(string a)
            //{
            //    string lastFourDigits = a.Substring(a.Length - 4);
            //    int lastFourDigitsInt = int.Parse(lastFourDigits);
            //    double result = (lastFourDigitsInt % 80) / 80.0;
            //    result = result - Math.Floor(result);
            //    result = result * 80;

            //    Console.WriteLine(result);
            //}


            //for (int i = 1; i < 10; i += 3)//分成上中下三個區塊1,4,7,每個區塊開頭差3
            //{
            //    for (int j = 1; j < 10; j++)//每區塊會從1-9共跑9次
            //    {
            //        for (int k = i; k < (i + 3); k++)//*前方數字每行從i開始,符合<i+3就跑一圈
            //        {
            //            Console.Write($"{k:##} * {j:##} = {k * j:##}\t");
            //            //每次輸出不換行但用\t隔開,直到k=(i+3)
            //        }
            //        Console.WriteLine();//不符合k<(i+3)後跳出迴圈並換行
            //    }
            //    Console.WriteLine();//跑完每一個區塊後換行,也就是i=3,6,9時
            //}
            //Console.ReadKey();

            //檔案-1
            //Console.WriteLine("寫一篇中文歌的歌詞到到自己指定的文字檔(使用UTF-8編碼)");
            //string path = @"C:\Users\male7\Desktop\C_sharp_01\MyTest.txt";

            //string lyrics = "再給我兩分鐘\t讓我把記憶結成冰\n別融化了眼淚 妳妝都花了要我怎麼記得";

            //File.WriteAllText(path, lyrics, Encoding.UTF8);
            //Console.ReadKey();

            //檔案-2
            //Console.WriteLine("寫入九九乘法表資料到一個文字檔到自己指定的文字檔");
            //string path = @"C:\Users\male7\Desktop\C_sharp_01\MyTest_02.txt";

            //for (int i = 1; i < 10; i += 3)
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        for (int k = i; k < (i + 3); k++)
            //        {
            //            string result = string.Format($"{k:##} * {j:##} = {k * j:##}\t");
            //            File.AppendAllText(path, result);
            //        }
            //        string newline_01 = "\n";
            //        File.AppendAllText(path, newline_01);
            //    }
            //    string newline_02 = "\n";
            //    File.AppendAllText(path, newline_02);
            //}
            //Console.ReadKey();

            //檔案-3
            //Console.WriteLine("讀取1.txt 顯示在畫面上，並將1.txt 裡的阿拉伯數字，轉換成中文數字(壹、貳、叁、肆…..)，並儲存到指定的路徑。(UTF-8)");

            //string num_path = @"C:\Users\male7\Desktop\C_sharp_01\1.txt";

            //string num = "987654321";

            //File.WriteAllText(num_path, num);

            //string str = File.ReadAllText(num_path);

            //string strnum = string.Empty;

            //foreach (char str2 in str)
            //{
            //    if (str2.ToString() == "1")
            //    {
            //        strnum += "壹、";
            //    }
            //    else if (str2.ToString() == "2")
            //    {
            //        strnum += "貳、";
            //    }
            //    else if (str2.ToString() == "3")
            //    {
            //        strnum += "參、";
            //    }
            //    else if (str2.ToString() == "4")
            //    {
            //        strnum += "肆、";
            //    }
            //    else if (str2.ToString() == "5")
            //    {
            //        strnum += "伍、";
            //    }
            //    else if (str2.ToString() == "6")
            //    {
            //        strnum += "陸、";
            //    }
            //    else if (str2.ToString() == "7")
            //    {
            //        strnum += "柒、";
            //    }
            //    else if (str2.ToString() == "8")
            //    {
            //        strnum += "捌、";
            //    }
            //    else if (str2.ToString() == "9")
            //    {
            //        strnum += "玖、";
            //    }
            //    else if (str2.ToString() == "0")
            //    {
            //        strnum += "零、";
            //    }
            //}
            //string result = strnum.Trim('、');
            //File.WriteAllText(num_path, result, Encoding.UTF8);
            //Console.ReadKey();

            //檔案-4
            //Console.WriteLine("讀取fc4bb.csv，並將此資料轉成HTML TABLE 格式，並儲存到指定的HTML檔裡");
            //string csv_path = @"C:\Users\male7\Desktop\C_sharp_01\fc4bb.csv";
            //string html_path = @"C:\Users\male7\Desktop\C_sharp_01\testcsv.html";

            //string csv_str = File.ReadAllText(csv_path);
            //string[] csv_lines = csv_str.Split(',');

            //using (var writer = new StreamWriter(html_path))
            //{
            //    writer.WriteLine("<html><body><table border='1'>");
            //    writer.WriteLine("<tr>");

            //    foreach (var column in csv_lines)
            //    {
            //        writer.WriteLine($"<td>{column}</td>");
            //    }

            //    writer.WriteLine("</tr>");
            //}
            //Console.ReadKey();

            //亂數-1
            //Console.WriteLine("請隨機由0~99產生一個數字輸出");
            //Random for_99num = new Random();
            //int I = for_99num.Next(0, 100);
            //Console.WriteLine(I);
            //Console.ReadKey();

            //亂數-2
            //Console.WriteLine("請隨機由0~99產生10個數字輸出");
            //Random for_99num = new Random();
            //int[] ints = new int[10];
            //for (int i = 0; i < 10; i++) 
            //{
            //    int ten_num = for_99num.Next(0, 100);
            //    ints[i] = ten_num;
            //}
            //foreach (int j in ints) 
            //{
            //    Console.WriteLine(j);
            //}
            //Console.ReadKey();

            //亂數-3
            //Console.WriteLine("隨機幫每位學員產生成績，並寫入文字檔(欄位之間用，分開，換行寫入下一筆)");
            //string score_path = @"C:\Users\male7\Desktop\C_sharp_01\student_score.txt";
            //Random for_99num = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    int student_score = for_99num.Next(0, 100);
            //    string result = string.Format($"座號{i+1}學生的成績是: {student_score}分\n\n");
            //    File.AppendAllText(score_path, result);
            //}
            //Console.ReadKey();

            //亂數-4
            //Console.WriteLine("請設計樂透開獎程式");
            //Random for_99num = new Random();
            //for (int i = 1; i <= 7; i++)
            //{
            //    int ten_num = for_99num.Next(1, 50);
            //    if (i == 7)
            //    {
            //        Console.WriteLine($"特別號為: {ten_num}");
            //    }
            //    else 
            //    {
            //        Console.WriteLine($"第{i}個號碼為: {ten_num}");
            //    }
            //}
            //Console.ReadKey();

            //亂數-5
            //Console.WriteLine("請在文字檔裡輸入所有午餐的店家，讀取文字檔，隨機抽出今天中午要吃哪一家");
            //string Lunch_path = @"C:\Users\male7\Desktop\C_sharp_01\Lunch.txt";
            //string[] Lunch_lines = File.ReadAllLines(Lunch_path);
            //Random for_99num = new Random();
            //int I = for_99num.Next(1, 6);
            //if (I == 1)
            //{
            //    Console.WriteLine($"中午吃{Lunch_lines[0]}");
            //}
            //else if (I == 2) 
            //{
            //    Console.WriteLine($"中午吃{Lunch_lines[1]}");
            //}
            //else if (I == 3)
            //{
            //    Console.WriteLine($"中午吃{Lunch_lines[2]}");
            //}
            //else if (I == 4)
            //{
            //    Console.WriteLine($"中午吃{Lunch_lines[3]}");
            //}
            //else if (I == 5)
            //{
            //    Console.WriteLine($"中午吃{Lunch_lines[4]}");
            //}
            //Console.ReadKey();

            //亂數-6
            //Console.WriteLine("請在文字檔裡輸入所有教室裡的學員名字，讀取文字檔，隨機抽出今天的值日生，抽過不能再被抽中，直到全部學員都被抽過，才可以再被抽");
            //string On_duty_path = @"C:\Users\male7\Desktop\C_sharp_01\On_duty.txt";
            //string[] On_duty_lines = File.ReadAllLines(On_duty_path);
            //Random for_99num = new Random();
            //int a=1,b=1,d=0;
            //int[] c = new int[5];
            //while (true) 
            //{
            //    int I = for_99num.Next(1, 6);
            //    if (c.Contains(I))
            //    {
            //        continue;
            //    }

            //    if (I == 1)
            //    {
            //        Console.WriteLine($"第{a}周星期{b}值日生是 : {On_duty_lines[0]}");
            //        b++;
            //        c[d] = I;
            //        d++;
            //    }
            //    else if (I == 2)
            //    {
            //        Console.WriteLine($"第{a}周星期{b}值日生是 : {On_duty_lines[1]}");
            //        b++;
            //        c[d] = I;
            //        d++;
            //    }
            //    else if (I == 3)
            //    {
            //        Console.WriteLine($"第{a}周星期{b}值日生是 : {On_duty_lines[2]}");
            //        b++;
            //        c[d] = I;
            //        d++;
            //    }
            //    else if (I == 4)
            //    {
            //        Console.WriteLine($"第{a}周星期{b}值日生是 : {On_duty_lines[3]}");
            //        b++;
            //        c[d] = I;
            //        d++;
            //    }
            //    else if (I == 5)
            //    {
            //        Console.WriteLine($"第{a}周星期{b}值日生是 : {On_duty_lines[4]}");
            //        b++;
            //        c[d] = I;
            //        d++;
            //    }

            //    if (b == 6) 
            //    {
            //        b = 1;
            //        a++;
            //        c = new int[5];
            //        d = 0;
            //    }

            //    if(a == 3)
            //    {
            //        break;
            //    }
            //}
            //Console.ReadKey();

            //日期-1
            //Console.WriteLine("顯示現在日期與時間");
            //DateTime a = DateTime.Now;
            //Console.WriteLine($"今年 {a.Year}年 {a.Month}月 {a.Day}日 {a.Hour}時:{a.Minute}分:{a.Second}秒");
            //Console.ReadKey();

            //日期-2
            //Console.WriteLine("顯示再過30天為哪一天");
            //DateTime noww = DateTime.Now;
            //DateTime futureday = noww.AddDays(30);
            //Console.WriteLine($"再過30天為{futureday}");
            //Console.ReadKey();

            //日期-3
            //Console.WriteLine("顯示24小時前的年月日時分秒");
            //DateTime noww = DateTime.Now;
            //DateTime pastday = noww.AddDays(-1);
            //Console.WriteLine($"24小時前為{pastday}");
            //Console.ReadKey();

            //日期-4
            //DateTime now = DateTime.Now;
            //int month = now.Month;
            //Console.WriteLine($"目前是{month}月");
            //Console.ReadKey();

            //日期-5
            //Console.WriteLine("取得明年是否為閏年");
            //double year = 2025;
            //if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            //{
            //    Console.WriteLine($"是閏年");
            //}
            //else
            //{
            //    Console.WriteLine($"不是閏年");
            //}
            //Console.ReadKey();

            //日期-6
            //Console.WriteLine("取得離2025年1月1日還有幾天");
            //DateTime today = DateTime.Today;
            //DateTime newyear = new DateTime(2025, 1, 1);
            //int next = (int)(newyear - today).TotalDays;
            //Console.WriteLine($"距離2025 / 1 / 1還有{next}天");
            //Console.ReadKey();

            //日期-7
            //Console.WriteLine("請顯示今天猴子做甚麼事");
            //DateTime week = DateTime.Today;
            //if (week.DayOfWeek.ToString() == "Monday") 
            //{
            //    Console.WriteLine("猴子穿新衣");
            //}
            //else if (week.DayOfWeek.ToString() == "Tuesday")
            //{
            //    Console.WriteLine("猴子肚子餓");
            //}
            //else if (week.DayOfWeek.ToString() == "Wednesday")
            //{
            //    Console.WriteLine("猴子去爬山");
            //}
            //else if (week.DayOfWeek.ToString() == "Thursday")
            //{
            //    Console.WriteLine("猴子看電視");
            //}
            //else if (week.DayOfWeek.ToString() == "Friday")
            //{
            //    Console.WriteLine("猴子去跳舞");
            //}
            //else if (week.DayOfWeek.ToString() == "Saturday")
            //{
            //    Console.WriteLine("猴子去斗六");
            //}
            //else if (week.DayOfWeek.ToString() == "Sunday")
            //{
            //    Console.WriteLine("猴子過生日");
            //}
            //Console.ReadKey();

            //日期-8
            //Console.WriteLine("輸入‘兩個日期，輸出兩個日期相差幾天");
            //Console.Write("輸入第一個日期: ");
            //string a = Console.ReadLine();
            //Console.Write("輸入第二個日期: ");
            //string b = Console.ReadLine();

            //string[] a_line = a.Split(',');
            //string[] b_line = b.Split(',');

            //DateTime day_one = new DateTime(Convert.ToInt32(a_line[0]), Convert.ToInt32(a_line[1]), Convert.ToInt32(a_line[2]));
            //DateTime day_two = new DateTime(Convert.ToInt32(b_line[0]), Convert.ToInt32(b_line[1]), Convert.ToInt32(b_line[2]));

            //int sum = (int)(day_one - day_two).TotalDays;
            //Console.WriteLine($"兩個日期距離{Math.Abs(sum)}天");
            //Console.ReadKey();

            //日期-9
            //Console.WriteLine("隨機產生一個今年日期，然後公式，得到S的值，再依照S的值從0到2分別給與 普通、吉、大吉 等三種不同的運勢，輸出運勢");
            //Random month_num = new Random();
            //int random_month_num = month_num.Next(1, 13);

            //int dday;
            //if ((random_month_num == 4) || (random_month_num == 6) ||
            //    (random_month_num == 9) || (random_month_num == 11))
            //{
            //    Random day30_num = new Random();
            //    int random_day30_num = day30_num.Next(1, 31);
            //    dday = random_day30_num;
            //}
            //else if (random_month_num == 2)
            //{
            //    Random day28_num = new Random();
            //    int random_day28_num = day28_num.Next(1, 29);
            //    dday = random_day28_num;
            //}
            //else 
            //{
            //    Random day31_num = new Random();
            //    int random_day31_num = day31_num.Next(1, 32);
            //    dday = random_day31_num;
            //}

            //double s = (random_month_num * 2 + dday) % 3;

            //if (s == 0) 
            //{
            //    Console.WriteLine($"2024年{random_month_num}月{dday}日的運勢為:普通");
            //}
            //else if (s == 1) 
            //{
            //    Console.WriteLine($"2024年{random_month_num}月{dday}日的運勢為:吉");
            //}
            //else if (s == 2)
            //{
            //    Console.WriteLine($"2024年{random_month_num}月{dday}日的運勢為:大吉");
            //}
            //Console.ReadKey();

        }
    }
}


