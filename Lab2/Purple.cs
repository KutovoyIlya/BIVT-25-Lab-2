using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0;

            // code here
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += (p + i * h) * (p + i * h);
            }
            // end
            answer = (int)sum; 
            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;
            int x = 0;
            // code here
            while (a >= b)
            {
                a = a - b;
                x += 1;
            }
            quotient = x;
            remainder = a;
            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here
            double chis1 = 1, znam1 = 1;
            double chis2 = 2, znam2 = 1;
            double s1 = chis1 / znam1, s2 = chis2 / znam2;
            while (Math.Abs(s2 - s1) > E)
            {
                double chis3 = chis1 + chis2, znam3 = znam1 + znam2;

                s1 = chis2 / znam2;
                s2 = chis3 / znam3;

                chis1 = chis2;
                chis2 = chis3;
                znam1 = znam2;
                znam2 = znam3;
                answer = chis3 / znam3;
            }
            
            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here
            answer = answer + 1;
            while (Math.Abs(b) > E) {
                answer = answer + 1;
                b = b * Math.Abs(q);
            }
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
                number = number * b;
                b--;
            }
            while (number >= 10) {
                number = number / 10;
                answer = answer + 1;
            }
            // end

            return answer;
        }
        public long Task6()
        {
            long answer = 0;
            int m = 15;
            ulong n = 1;
            for (int i = 0; i <= 63; i++)
            {
                n *= 2;
            }
            answer = (long)Math.Floor((double)(n - 1) / (m * 1_000_000));
            // code here

            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here
            double p = S * d / 100 / 12;
            double s1 = S;
            int n = 0;
            while (s1 < S * 2)
            {
                s1 = s1 + p; 
                n = n + 1;
                if (n % 12 == 0)
                {
                    p = s1 * d / 100 / 12;
                }
            }
            answer = n;
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= b + 0.0001; x += h)
            {
                int i = 0;
                double p = 1, chis = 1, znam = 1;
                while (Math.Abs(p * chis / znam) >= E)
                {
                    SS += p * chis / znam;
                    i++;
                    p = -p;
                    chis *= x * x;
                    znam *= 2 * i * (2 * i - 1);
                }
                SS += p * chis / znam;
                SY += Math.Cos(x);
            }
            // end

            return (SS, SY);
        }
    }
}