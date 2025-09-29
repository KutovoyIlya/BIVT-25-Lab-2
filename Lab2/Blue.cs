using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;

            // code here
            double k = 1;
            for (int i = 1; i <= n; i++)
            {
                answer += (Math.Sin(i * x)) / k;
                k *= x;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double k = 5;
            double l = 1;
            double m = -1;
            for (int i = 1; i <= n; i++)
            {
                l *= i;
                answer += (m * k) / l;
                k *= 5;
                m *= (-1);
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long k = 1;
            long l = 0;
            if (n == 1)
                return answer = 0;
            for (int i = 1; i <= n; i++)
            {
                answer += l;
                long next = l + k;
                l = k;
                k = next;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int n = 0;
            int s = 0;
            int cur = a;
            if (a > L)
                return 0;
            while (s <= L)
            {
                if (s + cur > L)
                    break;
                s += cur;
                n++;
                cur = a + n * h;
            }
            // end

            return n;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0;
            double zn = 1;
            double elem;
            int i = 1;
            do
            {
                ch += i;
                zn *= x;
                elem = ch / zn;
                if (elem > 0.0001)
                    answer += elem;

                i++;
            } while (elem > 0.0001);
            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            if (S >= L)
                answer = 0;

            while (S < L)
            {
                answer += h;
                S *= 2;
            }
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            double a2 = 0;
            double S2 = S;
            double S3 = S;
            for (int i = 1; i <= 7; i++)
            {
                a += S;
                if (i < 7)
                {
                    S *= (1 + (I / 100.0));
                }
            }
            while (a2 < 100)
            {
                a2 += S2;
                S2 *= (1 + I * 0.01);
                b++;
            }
            while (S3 <= 42)
            {
                S3 *= (1 + I * 0.01);
                c++;
            }
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            double e = 0.0001;
            // code here

            for (double x =a; x<= b+1e-10;x+=h)
            {
                double s = 0;
                double t;
                int i = 0;
                do
                { 
                    double p = 1;
                    for (int j = 1; j <= 2 * i; j++)
                    {
                        p *= x;
                    }
                    int f = 1;
                    for (int j = 1; j <= i; j++)
                    {
                        f *= j;
                    }
                    t = (2 * i + 1) * p / f;
                    s += t;
                    i++;
                } while (Math.Abs(t) >= e);
                double y = (1 + 2 * x*x) * Math.Exp(x*x);
                SS +=s;
                SY +=y;
            }

            // end
            return (SS, SY);
        }
    }
}
