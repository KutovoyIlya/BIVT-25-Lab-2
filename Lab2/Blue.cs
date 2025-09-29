   using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata;
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

            double xP = 1;

            int i = 1;

            while (i <= n) 
            {
                answer += Math.Sin(i * x) / xP;
                xP *= x;
                i++;
            }


            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;
            int i = 1;
            double factorial = 1;
            double r5 = 5;
            int sign = (-1);
            
            while (i <= n)
            {
                answer += sign * (r5 / factorial);
                i++;
                factorial *= i;
                r5 *= 5;
                sign *= -1;

            }


            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;
            int F0 = 0;
            int F1 = 1;
            int i = 1;

            while (i <= n)
            {
                answer += F0;
                int Fn = F0 + F1;
                F0 = F1;
                F1 = Fn;
                i++;
            }


            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;
            int sum = 0;

            while (true)
            {
                int n = a + answer * h;
                    if (sum + n > L)
                {
                    break;
                }
                sum += n;
                answer++;   
            }

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;
            double ch = 0;
            double zn = 1;
            double elem = ch / zn;
            int i = 1;

            ch += i;
            zn *= x;
            answer += elem;
            elem = ch / zn;
            i++;


            while (elem > 0.0001)
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;
            }


                return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            while (S <= L)
            {
                answer += h;
                S = S * 2;
      
            }
            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;
            int days = 1;
            double sum = 0;
            double S1 = S;
            double DailyDistanceA = S;
            double DailyDistanceB = S;
            double DailyDistanceC = S;
            while (days <= 7)
            {
                a += DailyDistanceA;
                DailyDistanceA *= 1 + I / 100;
                days++;
            }
            while (sum <= 100)
            {
                sum += DailyDistanceB;
                DailyDistanceB *= 1 + I / 100;
                b++;
                
            }
            while (S1 <= 42)
            {
                S1 *= 1 + I / 100;
                c++;
            }


            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            double E = 0.0001;

            int steps = (int)Math.Round((b - a) / h) + 1;

            for (int i = 0; i < steps; i++)
            {
                double x = a + i * h;
                if (x > b)
                {
                    break;
                }
                double summa = (1 + 2 * x * x) * Math.Exp(x * x);
                double y = summa;
                
                SS += summa;
                SY += y;
            }


                return (SS, SY);
        }
    }
}
