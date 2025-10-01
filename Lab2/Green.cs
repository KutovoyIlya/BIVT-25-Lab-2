using System.Collections.Generic;

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
            int zn = 3;
            for (int ch=2; ch<=n; ch+=2)
            {
                answer += (double)ch / zn;
                zn+=2;
            }
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            for (int i=0;i>=-n;i--)
            {
                answer += Math.Pow(x, i);
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;
            long fact = 1;
            // code here
            for (int i = 1; i <= n;i++)
            {
                fact *= i;
                answer += fact;
            }
            answer += 1;
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            for (int n = 1; Math.Abs(Math.Sin(n*Math.Pow(x,n)))>=Math.Pow(10,-4);n++)
            {
                answer += Math.Sin(n * Math.Pow(x, n));
            }
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            for (int n = 1;Math.Abs(1.0/(Math.Pow(x,n-1))-1.0/Math.Pow(x,n))>=0.0001;n++)
            {
                answer = n + 1;
            }
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
            while (L>Da)
            {
                answer += 1;
                L /= 2;
            }
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            // code here
            for (double x = a;x <= b + 0.0001; x += h)
            {
                double sx = 0;
                double ch = x;
                double zn = 1;
                while (true)
                {
                    sx += ch / zn;
                    if (Math.Abs(ch / zn) < E) break;
                    ch *= (-1) * x * x;
                    zn += 2;
                }
                SS += sx;
                SY += Math.Atan(x);
            }
            // end

            return (SS, SY);
        }
    }
}