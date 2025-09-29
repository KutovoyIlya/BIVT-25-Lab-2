using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0;

            // code here
            for (int i = 0; i< n; i++)
            {
                answer += (p+h*i)* (p + h*i);
            }
            // end

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            //code here

            while (a >= b)
            {
                a -= b;
                quotient++;
                
            }
            remainder = a;

            //end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here

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
            // end
            return answer;
        }
        public int Task4(double b, double q)
        {
            // code here
            int answer = 0;
            double e = (double)1 / 10000;
            int i = 1;
            while (Math.Abs(b) >= e)
            {
                i++;
                b = b * q;
            }
            answer = i;
            // end

            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;
            long number = a;
            // code here
            while (b > 0)
            {
                number *= b;
                b --;
            }
            while (number >= 10)
            {
                number /= 10;
                answer++;
            }
            // end

            return answer;
        }
        public long Task6()
        {
            long answer = 0;

            //code here
            int a = 1;
            double b = 1;
            while (a <= 64)
            {
                a++;
                b *= 2;
            }
            long d = (long)Math.Floor((double)b / 15000000);
            //long d = (long)Convert.ToInt64(Math.Floor((double)b / 15000000));
            answer = d;
            //end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;
            // code here
            int month = 0;
            double part = 0;
            S = S * 1000;
            double counter(double S, double d)
            {
                part = ((S/100) * d)/12;
                return part;
            }
            double S2 = S * 2;
            while (S<S2)
            {
                if (month % 12 == 0 || month ==0)
                {
                    part = counter(S, d);
                }
                month++;
                S += part;
            }
            answer = month;

            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            //double e = 0.0001;
            //for (double x = a; x <= b + e; x += h)
            //{
            //    int i = 1;
            //    double current = 1;
            //    double sum = 0;
            //    do
            //    {
            //        current = (-current) * ((x * x) / ((2 * i) * (2 * i - 1)));
            //        sum += current;
            //        i++;
            //    } while (Math.Abs(current) >= 0.0001);
            //    SS += sum;
            //    SY += Math.Cos(x);
            //}

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
            for (double x = a; x <= b + e; x += h)
            {
                double SX = 0;
                SY += Math.Cos(x);

                for (int i = 0; i < 100; i++)
                {
                    SX = Math.Pow(-1, i) * Math.Pow(x, 2 * i) / Factorial(2 * i);
                    SS += SX;
                    if (Math.Abs(SX) < e)
                        break;

                }
                ;
            }


            // end

            return (SS, SY);
        }
    }
}
