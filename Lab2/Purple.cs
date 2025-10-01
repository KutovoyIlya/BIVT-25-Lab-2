using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Formats.Asn1;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0;
            // code here
            int c = 0;
            int an = 0;
            while (c != n)
            {
                c++;
                an = p + ((c - 1) * h);
                answer = answer + an*an;

            }

            // end

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here
            while (a >= b)
            {
                a = a - b;
                quotient++;
            }
            remainder = a;
            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here
            double c1 = 1;
            double c2 = 1;
            double c3 = 2;
            double c4 = 1;
            double c5 = 3;
            double c6 = 2;
            while (Math.Abs(c5 / c6 - c3 / c4) >= Math.Pow(10,-4))
            {
                c1 = c3;
                c2 = c4;
                c3 = c5;
                c4 = c6;
                c5 = c1 + c3;
                c6 = c2 + c4;
                answer = c5 / c6;
            }
            // end
                return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here
            int n = 1;
            while (Math.Abs(b) >= 0.0001)
            {
                b = b * q;
                n++;
            }
            answer = n;
                // end
            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;

            // code here
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

            // end

            return answer;
        }
        public long Task6()
        {
            long answer = 0;

            // code here
            long p = 1;
            for (int i = 1; i < 63; i++)
            {
                p *= 2;
                answer += p;
            }
            answer = answer / (15 * 1000 * 500);
            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;
            // code here
            double ok = S;
            int m = 0;
            double p = 0;
            while (S < ok * 2)
            {
                if (ok * 2 < S + (S * d / 100))
                {
                    S += S * d / 100;
                    m += 12;
                }
                else
                {
                    if (m % 12 == 0)
                    {
                        p = S * d / 100 / 12;
                    }
                    S += p;
                    m++;
                }
            }
            answer = m;
                // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
                        
            int n = (int) Math.Floor((b - a) / h + 1e-12);
            for (int k = 0; k <= n; k += 1)
            {
                double cur = 1.0;
                double x = a + k * h;
                
                for (int i = 0;; i += 1)
                {
                    if (Math.Abs(cur) < E) break;
                    SS += cur;
                    double rya = -(x * x) / ((2.0 * i + 1) * (2.0 * i + 2));
                    cur *= rya;
                }
                SY += Math.Cos(x);
            }
            
            // end

            return (SS, SY);
        }
    }

}
