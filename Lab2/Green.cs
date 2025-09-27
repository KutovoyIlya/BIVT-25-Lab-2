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
            int i = 2;
            for (; i <= n; i = i + 2)
            {
                answer += ((double)i / (i + 1));
            }
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            int i = 1;
            answer = 1;
            double x2 = x;
            for (; i <= n; i++)
            {
                answer += 1 / x;
                x *= x2;

            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long b = 1;
            answer += 1;
            for (int i = 1; i <= n; i++)
            {
                b *= i;
                answer += b;

            }
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            int i = 1;
            double s1 = x;
            while (Math.Abs(Math.Sin(x * i)) >= E)
            {
                answer += Math.Sin(i * x);
                x *= s1;
                i++;
            }

            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            int i = 1;
            double s1 = x;
            double s2 = 1;
            const double E = 1e-4;
            while ((Math.Abs((1 / x) - (1 / s2))) >= E)
            {
                i++;
                x *= s1;
                s2 *= s1;
            }
            answer = i;
            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            double ch = 0, zn = 0;
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
            while (L >= Da)
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
                int si = -1;
                double min = 1;
                for (int i = 0; ;i++)
                {
                    double s = (-1) * si * x * min / (2 * i + 1);
                    SS += s;
                    si *= (-1);
                    min *= (x * x);
                    if (Math.Abs(s) < E) break;
                    
                }
            }
            // end

            return (SS, SY);
        }
    }
}
