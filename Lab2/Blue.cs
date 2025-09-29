using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;
            double m = 1;

            // code here
            for (int i = 1; i <= n; i++)
            {
                answer += (Math.Sin(x * i) / m);
                m = m * x;
                
            }
                // end

                return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double x = 1;
            for (int i = 1; i <= n; i++)
            {
                answer += (Math.Pow((-1), i) * (Math.Pow(5, i) / x));
                x *= (i + 1);
            }

            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long a1 = 1;
            long a2 = 0;
            long s = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    s= 0;
                }
                else
                {
                    s  = a1 + a2;
                    a1 = a2;
                    a2 = s;
                }
                answer += s;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int n = 1;
            int s = 0;
            do
            {
                s += (a + (n - 1) * h);
                n++;
                answer++;
                Console.WriteLine(s);
            }
            while (s < L);
            if (s > L)
            {
                answer -= 1;
            }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0;
            double zn = 1;
            double elem = ch / zn;
            int i = 1;
            do
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i += 1;
            }
            while (elem > 0.0001);
            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            do
            {
                answer += h;
                S *= 2;
            }
            while (S < L);
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            double s = 0;
            double s1 = S;
            double s2 = S;
            double s3 = 0;
            for (int i = 1; i <= 7; i += 1)
            {
                a += S;
                S += (S * (I / 100));
            }
            while (s < 100)
            {
                b += 1;
                s += s1;
                s1 += (s1 * (I / 100));

            }
            while (s2 <= 42)
            {
                c += 1;
                s2 += (s2 * (I / 100));

            }
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            double x = a;
            while (x <= b + 1e-10)
            {
                double x2 = 1;
                int i = 0;
                int i2 = 1;
                double s = 0;

                do
                {
                    if (i > 0)
                    {
                        i2 *= i;
                    }
                    SS += ((2 * i + 1) * x2) / i2;
                    x2 *= x * x;
                    i++;
                }
                while (Math.Abs(((2 * i + 1) * x2) / i2) >= E);

                SY += (1 + 2 * x * x) * Math.Exp(x * x);
                x += h;

                // end
            }
                return (SS, SY);
        }
    }
}
