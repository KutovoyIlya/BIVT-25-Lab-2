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
            double pow = 1;
            for (int i = 1; i <= n; i++)
            {
                answer += Math.Sin(x * i) / (pow);
                pow *= x;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double five = 5;
            double zn = -1;
            double fct = 1;
            for (int i = 1; i <= n; i++)
            {
                fct *= i;
                answer += zn * (five / fct);
                zn *= -1;
                five *= 5;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            if (n > 1)
            {
                int k1 = 0;
                int k2 = 1;
                int s = 1;
                for (int m = 2; m < n; m++)
                {
                    int next = k1 + k2;
                    s += next;
                    k1 = k2;
                    k2 = next;
                }
                answer = s;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int s = 0;
            for (int n = 1; s <= L; n++)
            {
                if ((s + (a + (n - 1) * h)) > L)
                {
                    break;
                }
                s += (a + (n - 1) * h);
                answer++;
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
            int i = 1;
            double elem = ch / zn;
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
            a = S;
            double sa = S;
            double sb = S;
            double sc = S;
            double d = 0;
            for (int i = 2; i <= 7; i++)
            {
                sa = sa + (sa * (I / 100));
                a += sa;
            }

            while (d < 100)
            {
                b += 1;
                d += sb;
                sb = sb + (sb * (I / 100));
            }

            while (sc <= 42)
            {
                c += 1;
                sc = sc + (sc * (I / 100));
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
            while (x <= b + E)
            {
                double c = 1.0;
                SS += c;
                for (double i = 1; c > E; ++i)
                {
                    c = (2 * i + 1) * c * x * x / (i * (2 * i - 1));
                    SS += c;
                }
                SY += (1 + 2 * x * x) * Math.Exp(x * x);
                x += h;
            }
            // end

            return (SS, SY);
        }
    }
}
