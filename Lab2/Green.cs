using System.Collections.Generic;
using System.Security.Cryptography;

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
            for (int i = 2; i <= n; i += 2)
            {
                answer += (double) i / (i + 1);
            }
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            double xx = x;
            for (int i = 0; i <= n; i++)
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
            long factorial = 1;
            for (int i = 1; i <= n; i ++)
            {
              
                factorial *= i;
                answer += factorial;

                }
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            int n = 4;
            double num = 0;

            if (Math.Abs(x) < 1)
            {
                while (Math.Abs(num) >= E)
                {
                    n++;
                    num = Math.Sin(n * (Math.Pow(x, n)));
                    answer += num;
                }
            }
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            int n = 1;
            if (Math.Abs(x) > 1)
            {
                while (true)
                {
                    double chi1 = 1 / Math.Pow(x, n);
                    double chi2 = 1 / Math.Pow(x, n - 1);
                    if (chi1 - chi2 < E)
                    {
                        break;
                    }
                    n ++;
                }
            }
            answer = n;

            // end

                return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int elem = 1, i = 0;
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
                answer++;

            }
            // end

            return answer;
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
