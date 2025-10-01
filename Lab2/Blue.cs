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

            // code here
            double x1 = 1;

            for (int i = 1; i <= n; i++)
            {
                double a = (Math.Sin(i * x)) / x1;
                answer += a;
                x1 *= x;

            }

            // end
            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double a = 5;
            double b = 1;
            int c = -1;
            for (int i = 1; i <= n; i++)
            {
                b *= i;
                double r = a / b;
                answer += r * c;
                a *= 5;
                c *= (-1);
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long a = 0;
            long b = 1;
            for (int i = 0; i < n; i++)
            {
                answer += a;
                long c = a;
                a = b;
                b = c + b;

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
            while (s <= L)
            {
                s += (a + (n - 1) * h);
                n++;
                answer++;


            }

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

            double daily = S;
            double daily42 = S;
            double total = 0;

            for (int i = 1; i <= 7; i++)
            {
                a += S;
                S += (S * (I / 100));

            }
            while (total < 100)
            {
                b += 1;
                total += daily;
                daily += (daily * (I / 100));

            }
            while (daily42 <= 42)
            {
                c += 1;
                daily42 += (daily42 * (I / 100));

            }

            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            for (double x = a; x <= b + 1e-10; x += h)
            {
                double s = 0;
                int i = 0;
                double factorial = 1;
                double term;

                double x_pow = 1;
                double x_sq = x * x;

                do
                {
                    term = (2 * i + 1) * x_pow / factorial;
                    s += term;

                    i++;

                    factorial *= i;

                    x_pow *= x_sq;

                }
                while (Math.Abs(term) >= E);

                double y = (1 + 2 * x * x) * Math.Exp(x * x);

                SS += s;
                SY += y;
            }

            return (SS, SY);
        }       
    }
}
