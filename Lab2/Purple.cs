using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0;
            for (int i = 0; i < n; i++)
            {
                answer += (p + h * i) * (p + h * i);
            }

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;
            int i = 0;

            while (a - b >= 0)
            {
                quotient++;
                a -= b;
            }
            remainder = a;
            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            const double e = 0.0001;
            double old_num = 2;
            double old_den = 1;
            double new_num = 3;
            double new_den = 2;
            while (true)
            {
                new_num = old_num + new_num;
                new_den = old_den + new_den;
                old_num = new_num - old_num;
                old_den = new_den - old_den;
                if (Math.Abs((new_num / new_den) - (old_num / old_den)) < e)
                {
                    answer = (new_num / new_den);
                    break;
                }
            }

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            const double e = (double)1 / 10000;
            int i = 1;
            while (Math.Abs(b) >= e)
            {
                i++;
                b = b * q;
            }
            answer = i;
            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;
            long number = a;

            while (b > 0)
            {
                number *= b;
                b--;
            }
            while (number >= 10)
            {
                number /= 10;
                answer++;
            }
            return answer;
        }
        public long Task6()
        {
            long answer = 0;
            ulong amount = 0;
            ulong cur = 1;
            for (int i = 1; i < 65; i++)
            {

                amount += cur;
                cur *= 2;
            }
            amount = amount / 15000000;
            answer = (long) amount;
            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;
            double s = S * 1000;
            double sn = s;
            double r = d / 100;
            double sk = s;

            for (int i = 1; i < 12000; i++)
            {
                if (i % 12 == 1)
                {
                    sn = (sk * r / 12);
                }
                sk += sn;
                if (sk > 2 * s)
                {
                    answer = i;
                    break;
                }
            }
            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            double e = 0.0001;
            static long Factorial(int n)
            {
                long res = 1;
                for (int i = 1; i <= n; i++)
                {
                    res *= i;
                }
                return res;
            }
            for (double x = a; x <= b + e; x+=h)
            {
                SY += Math.Cos(x);
                for (int i = 0; i < 100; i++)
                {
                    double SX  = Math.Pow(-1, i) * Math.Pow(x, 2*i) / Factorial(2*i);
                    SS += SX;
                    if (Math.Abs(SX) < e)
                        break;
                }      
            }
            return (SS, SY);
        }
    }
}
