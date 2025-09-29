using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Lab2
{
    public class Green
    {
        const double E = 0.0001;
        const double Da = 0.0000000001;
        public double Task1(int n)
        {
            double answer = 0;

            // code here
            for (double i = 2; i <= n; i += 2)
            {
                answer += (i / (i + 1));
            }
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            for (double i = 0; i <= n; i++)
            {
                answer += Math.Pow(x, -i);
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long s = 1;
            for (int i = 1; i <= n; i++)
            {
                s *= i;
                answer += s;
            }
            answer += 1;
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            double n = 1;
            while (Math.Abs(Math.Sin(n * Math.Pow(x, n))) >= E)
            {
                answer += Math.Sin(n * Math.Pow(x, n));
                n++;
            }
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            int n = 1;
            while (Math.Abs(1 / Math.Pow(x, n) - 1 / Math.Pow(x, n - 1)) >= E)
            {
                n += 1;
            }
            answer += n;
            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int elem = 1;
            int i = 0;
            while (elem < limit)
            {
                elem *= 2;
                answer += elem;
                i++;
            }
            // end

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;

            // code here
            while (L > Da)
            {
                L /= 2;
                answer += 1;
            }
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= b + E; x += h)
            {
                SY += Math.Atan(x);
                double item = 0;
                int i = 0;
                do
                {
                    item = Math.Pow(-1, i) * Math.Pow(x, 2 * i + 1) / (2 * i + 1);
                    i++;
                    SS += item;
                } while (Math.Abs(item) >= E);
            }
            // end

            return (SS, SY);
        }
    }
}