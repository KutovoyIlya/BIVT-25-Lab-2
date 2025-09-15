using System.Collections.Generic;
using System.ComponentModel;
using System.Formats.Asn1;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int s = 0;

            for (int i = 0; i < n ;i++) {
                s += (p + i * h) * (p + i * h);
            }
            return s;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;

            while (a >= b)
            {
                a -= b;
                quotient += 1;
            }

            return (quotient, a);
        }
        public double Task3()
        {
            double a1 = 1;
            double a2 = 1;
            double a3 = a1 + a2;

            while (Math.Abs(a1 / a2 - a3 / a1) > E)
            {
                a2 = a1;
                a1 = a3;
                a3 = a1 + a2;
            }
            Console.WriteLine(a3 / a1);
            return a3 / a1;
        }
        public int Task4(double b, double q)
        {
            int n = 1;

            for (double i = 1; Math.Abs(b * q * i) > E; i *= q)
            {
                n += 1;
            }
            return n + 1;
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
            long zerna = 2;

            for (int i = 0; i != 57; i++)
            {
                zerna *= 2;
            }

            answer = zerna / (15 * 125 * 125);
            return answer;
        }

        public int Task7(double S, double d)
        {
            double Ss = S;
            int n = 0;
            double YP = 0;
            
            while (Ss < 2 * S)
            {
                if (n == 0 || n % 12 == 0)
                {
                    YP = Ss * d;
                }
                Ss += YP / 2;
                n++;
            }

            return n;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here

            // end

            return (SS, SY);
        }
    }
}
