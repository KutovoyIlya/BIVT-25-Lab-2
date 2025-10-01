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
            double s = Math.Sin(x);
            double mult = x;
            for (int i=2;i<=n;i++,mult*=x)
            {
                s +=(double) Math.Sin(i * x)/mult;
            }
            answer = s;


            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double s = 0;
            long mult = -5;
            long fact = 1;
            for (int i = 1; i <= n; i++, mult *= (-5))
            {
                fact *= i;
                s +=(double) mult / fact;

            }
            answer = Math.Round(s,6);
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;
            // code here
            int n1 = 0, n2 = 1;
            long s = 0;
            int temp = 0;
            switch (n)
            {
                case 0:
                case 1:

                    answer = 0;
                    break;

                default:
                    for (int i = 2; i <= n; i++)
                    {
                        s += n2;
                        temp = n2;
                        n2 += n1;
                        n1 = temp;
                    }
                    break;

            }
            answer = s;
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int s = 0;
            int c = 0;
            while (s <= L)
            {
                s += (a + c * h);
                c += 1;
                answer += 1;
            }

            // end

            return answer-1;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0, zn = 1;
            double elem = ch / zn;
            int i = 1;
            do
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;
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
            bool f1 = true;
            bool f2 = true;
            bool f3 = true;
            double s = 0;
            int day = 1;
            do
            {
                if (day != 1)
                    S += (S * (I / 100));
                s += S;
                if (day <= 7)
                {
                    a += S;
                    if (day == 7)
                        f3 = false;
                }
                if (f2)
                {
                    if (s >= 100)
                    {
                        b = day;
                        f2 = false;
                    }
                }
                if (f1)
                {
                    if (S > 42)
                    {
                        c = day - 1;
                        f1 = false;
                    }
                }
                day += 1;
            } while (f1 || f2 || f3);
            a = Math.Round(a, 6);
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here

            double eps = 0.0001;

            for (double x = a; x <= b + 1e-12; x += h)
            {
                double s = 0;
                double tt = 1;
                int i = 0;
                int g = 0;

                while (true)
                {
                    s += tt;
                    if (Math.Abs(tt) < eps || g++ >= 1000000)
                        break;

                    tt = tt * (x * x) * (2 * i + 3) / ((i + 1) * (2 * i + 1));
                    i++;
                }

                double y = (1 + 2 * x * x) * Math.Pow(Math.E,x*x);
                SS += s;
                SY += y;
            }

            // end

            return (SS, SY);
        }
    }
}
