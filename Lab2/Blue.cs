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
            for (int i = 1; i <= n; i += 1)
            {
                answer += Math.Sin(i * x) / Math.Pow(x, i - 1);
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            int minus1 = -1;
            double pyat = 5;
            double nfactorial = 1;

            for (int i = 1; i <= n; i += 1)
            {
                nfactorial *= i;
                answer += (double)minus1 * pyat / nfactorial;
                pyat *= 5;
                minus1 *= -1;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long cur = 1;
            long prosh = 0;

            for (int i = 0; i < n; i += 1)
            {
                answer += prosh;
                long sum = prosh + cur;
                prosh = cur;
                cur = sum;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int sum = 0;
            int n = 1;
            while (sum <= L)
            {
                sum += (a + (n - 1) * h);
                n += 1;
            }
            answer = n - 2;
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
                i++;
            } while (elem > 0.0001);
            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            int counter = 0;
            int chasy = 0;
            while (S < L)
            {
                chasy += h;
                S *= 2;
            }
            answer = chasy;
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            double summ = 0;
            double dni = S;
            for (int i = 0; i < 7; i += 1)
            {
                summ += dni;
                dni += dni * I / 100.0; //На сколько км больше в следующий раз
            }
            a = summ;


            int day = 0;
            summ = 0;
            dni = S;
            while (summ < 100)
            {
                summ += dni;
                dni += dni * I / 100.0;
                day += 1;
            }


            b = day;


            day = 0;
            summ = 0;
            dni = S;
            while (dni <= 42)
            {
                summ += dni;
                dni += dni * I / 100.0;
                day += 1;
            }

            c = day;
            // end

            return (a, b, c);
        }


        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= b + E; x += h)
            {
                SY += (1 + (2.0 * x * x)) * Math.Exp(x * x);
                double it = 1, fac = 1, um = 1;
                int i = 0;
                while (Math.Abs(it) >= E)
                {
                    it = ((2 * i + 1) * um) / fac;
                    SS += it;
                    i++;
                    fac *= i;
                    um *= x * x;
                }
            }
            // end

            return (SS, SY);
        }
    }
}
