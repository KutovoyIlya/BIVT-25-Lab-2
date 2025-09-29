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
            double sinus = Math.Sin(x);
            double ix = 1.0;
            answer += sinus;
            for (int i = 2; i <= n; i++)
            {
                double num = Math.Sin(i * x);
                ix *= x;
                sinus = num / ix;
                answer += sinus;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double step = 0;
            double first = 1;
            double fac = 1;
            int znak = -1;
            for (int k = 1; k <= n; k++)
            {
                first *= 5;
                fac *= k;
                step = (double)first / fac;
                answer += znak * step;
                znak = -znak;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            if (n <= 0) return 0;
            if (n == 1) return 0;

            long fibo1 = 0;
            long fibo2 = 1;
            answer = fibo1;
            if (n == 1) return answer;
            answer += fibo2;
            for (int i = 3; i <= n; i++)
            {
                long fibo = fibo1 + fibo2;
                answer += fibo;
                fibo1 = fibo2;
                fibo2 = fibo;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            if (L < a) return 0;
            int sum = 0;
            int stepa = a;
            int n = 0;
            while (sum <= L)
            {
                sum += stepa;
                if (sum > L) break;
                answer++;
                n++;
                stepa = a + n * h;
            }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0, zn = 1;
            int i = 1;
            double elem;

            do
            {
                ch += i;
                zn *= x;
                elem = ch / zn;
                if (elem > E)
                    answer += elem;
                i++;
            } while (elem > E);
            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            if (S >= L) return 0;

            int kl = S;
            int per = 0;

            while (kl < L)
            {
                per += h;
                kl *= 2;
            }
            answer = per;
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            double dist = 0;
            double oneday = S;
            for (int day = 1; day <= 7; day++)
            {
                dist += oneday;
                oneday *= (1 + I / 100);
            }
            a = Math.Round(dist, 6);
            dist = 0;
            oneday = S;
            b = 0;
            while (dist < 100)
            {
                b++;
                dist += oneday;
                oneday *= (1 + I / 100);
            }
            oneday = S;
            c = 0;
            while (oneday <= 42)
            {
                c++;
                oneday *= (1 + I / 100);
            }
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= b + 1e-12; x += h)
            {
                double sum = 0;
                int i = 0;
                double n;
                double fac = 1;
                double first = 1;
                double kv = x * x;
                do
                {
                    if (i > 0)
                    {
                        fac *= i;
                        first *= kv;
                    }
                    n = (2 * i + 1) * first / fac;
                    sum += n;
                    i += 1;
                }
                while (n >= E);
                double y = (1 + 2 * x * x) * Math.Exp(x * x);
                SS += sum;
                SY += y;
            }
            // end

            return (SS, SY);
        }
    }
}
