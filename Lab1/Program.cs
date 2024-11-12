﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

        program.Task_1_1();
        //program.Task_1_2();
        //program.Task_1_3();
        //program.Task_1_4(0.9);
        //program.Task_1_5(0, 2);
        //program.Task_1_6(4);
        //program.Task_1_7();
        //program.Task_1_8();
        //program.Task_1_9();
        //program.Task_1_10();
        //program.Task_1_11();
        //program.Task_1_12(0);
        //program.Task_1_13(-1.5);
        //program.Task_1_14();
        //program.Task_1_15();
        //program.Task_1_16();
        //program.Task_1_17(10);
        //program.Task_1_18(24);
        //program.Task_2_1(1);
        //program.Task_2_2();
        //program.Task_2_3(8, 2, 0);
        //program.Task_2_4(0.8);
        //program.Task_2_5(11, 5);
        //program.Task_2_6();
        program.Task_2_7a();
        //program.Task_2_7b();
        //program.Task_2_7c();
        //program.Task_2_8();
        //program.Task_2_9();
        //program.Task_2_10();
        //program.Task_3_1(0.1);
        //program.Task_3_2(0.1);
        //program.Task_3_3(0.1);
        //program.Task_3_4(0.1);
        //program.Task_3_5(double.Pi/5);
        //program.Task_3_6(0.1);
        //program.Task_3_7(0.1);
        //program.Task_3_8(0.1);
        //program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;

        // code here
        for (int i = 2; i < 36; i = i + 3)
        {
            answer = answer + i;
        }
        // end
        

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (double i = 1; i < 11; i++)
        {
            answer = answer + (1 / i);
        }
        answer = Math.Round(answer, 2);

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double i = 2; i < 113; i = i + 2)
        {
            answer = answer + (i / (i + 1));
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if (x ==0)
        {
            answer = 0;
        }
        else
        {
            for (double i = 1; i < 10; i++)
            {
                answer = answer + (Math.Cos(i * x) / (Power(x, (i - 1))));
            }
        }
        static double Power(double baseNum, double exp)
        {
            if (exp == 0)
                return 1; 
            else if (exp < 0)
                return 1 / Power(baseNum, -exp);

            return baseNum * Power(baseNum, exp - 1);
        }
        answer = Math.Round(answer, 2);
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (double i = 0; i < 10; ++i)
        {
            answer =answer+( (p + i * h) * (p + i * h));
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * x * x - 7 * x;
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        answer =answer+ 1;
        for (int i = 1; i < 7; ++i)
        {
            answer =answer*i;
        }
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        for (int i = 1; i <= 6; ++i)
        {
            answer = answer + Factorial(i);
        }
        static int Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;

            return n * Factorial(n - 1);
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        for (int i = 1; i < 7; i++)
        {
            answer = answer + (Power(-1, i) * Power(5, i)) / Factorial(i);
        }
        static double Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;

            return n * Factorial(n - 1);
        }
        static double Power(double baseNum, double exp)
        {
            if (exp == 0)
                return 1;
            else if (exp < 0)
                return 1 / Power(baseNum, -exp);

            return baseNum * Power(baseNum, exp - 1);
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        answer = answer + 3;
        for(int i = 1; i < 7; i++)
        {
            answer = answer * 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        Console.WriteLine("1 2 3 4 5 6");
        Console.WriteLine("5 5 5 5 5 5");
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double zn = 1;
        for (double i = 0; i <= 10; i++)
        {
            if (x != 0)
            {
                answer =answer+ 1 / zn;
                zn *= x;
            }
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
        {
            answer = 1;
        }
        else if (x > -1 && x <= 1)
        {
            answer = -x;
        }
        else
        {
            answer = -1;
        }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a = 1;
        int b = 1;
        Console.WriteLine(a);
        Console.WriteLine(b);
        for (int i = 1; i < 7; i++)
        {
            Console.WriteLine(a + b);
            b = a + b;
            a = b - a;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double a = 1;
        double b = 2;
        double c = 1;
        double d = 1;
        for (int i = 1; i < 4; i++)
        {
            b = a + b;
            a = b - a;
            d = c + d;
            c = d - c;
        }
        answer = b / d; ;
        answer = Math.Round(answer, 1);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double a = 1;
        double t = 1;
        // code here
        for (int i = 0; i < 64; i++)
        {
            if (answer > t * 10)
            {
                t=t* 10;
                power=power+ 1;
            }
            answer=answer+ a;
            a=a* 2;
        }
        answer /= t * 15;
        answer = Math.Round(answer, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double R = 6350;
        answer = (R + x) * (R + x) - R * R;
        answer = Math.Sqrt(answer);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        answer = answer + 10;
        for (int i = 3; i <= x; i = i + 3)
        {
            answer = answer * 2;
        }
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here
        double i = 1;
        double vika = 1;
        while (Math.Abs(vika) >= 0.0001)
        {
            vika = Math.Cos(i * x) / (i * i);
            if (Math.Abs(vika) >= 0.0001)
            {
                answer += vika;
            }

            i += 1;

        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_3(double a, double h, double p)
    {
        int answer = 0;

        // code here
        double s = a;
        if (h > 0)
        {
            while (s <= p)
            {
                answer += 1;
                s += a + answer * h;
            }
        }

        // end

        return answer;
    }
    public double Task_2_4(double x)
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public (int, int) Task_2_5(int N, int M)
    {
        int quotient = 0, remainder = 0;

        // code here
        if (M != 0)
        {
            while (Math.Abs(N) >= Math.Abs(M))
            {
                quotient++;
                N -= M;
            }
            remainder = Math.Abs(N);
        }
        // end

        return (quotient, remainder);
    }
    public int Task_2_6()
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public double Task_2_7a()
    {
        double answer = 0;

        // code here
        double s = 10;
        for (int i = 0; i < 7; ++i)
        {
            answer = answer + s;
            s = s * 1.1;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double k = 0;
        double s = 10;
        while (k < 100)
        {
            k = k + s;
            s = s * 1.1;
            answer = answer + 1;
        }
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double s = 10;
        while (s < 20)
        {
            s = s * 1.1;
            answer++;
        }
        
        // end

        return answer;
    }
    public int Task_2_8()
    {
        int answer = 0;

        // code here;

        // end

        return answer;
    }
    public int Task_2_9()
    {
        int answer = 0;

        // code here;
        double l = 0.1;
        while (l > 1e-10)
        {
            l =l/ 2;
            answer++;
        }
        // end

        return answer;
    }
    public int Task_2_10()
    {
        int answer = 0;

        // code here;

        // end

        return answer;
    }
    #endregion

    #region Level 3
    public (double, double) Task_3_1(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_2(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_3(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_4(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_5(double x)
    {
        double S = 0, y = 0;

        // code here


        S = -1;
        double a_n = 1;
        for (int n = 1; Math.Abs(a_n) >= 0.0001; n++)
        {
            S += a_n;
            a_n = Power(-1, n) * Math.Cos(n * x) / (n * n);
        }
        y = (x * x - Math.Pow(Math.PI, 2) / 3) / 4;
        static double Power(double baseNum, double exp)
        {
            if (exp == 0)
                return 1;
            else if (exp < 0)
                return 1 / Power(baseNum, -exp);

            return baseNum * Power(baseNum, exp - 1);
        }
        // end

        return (S, y);
    
        

       
    }
    public (double, double) Task_3_6(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_7(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_8(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_9(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    #endregion
}