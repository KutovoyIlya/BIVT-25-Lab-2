using System.Collections.Generic;
using System.Diagnostics;

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

            for(int i = 2; i <= n; i += 2)
            {
                answer += (double)i / (i + 1);
            }

            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            double zn = 1;
            double sm = 1;
            if (x != 0)
            {

                for (int i = 1; i <= n; i++)
                {
                    zn *= x;
                    sm += (1/zn);
                      
                }
            }
            answer = sm;
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here

            long fact = 1;

            for(int i = 0; i <= n; i++)
            {
                if(i > 0)
                {
                    fact *= i;
                }
                answer += fact;
            }

            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;
            double eps = 1e-4;
            double n = 1;
            double st = x;
            double t;
            // code here

            do
            {
                t = Math.Sin(n * st);
                if (Math.Abs(t) >= eps)
                {
                    answer += t;
                    n++;
                    st *= x;
                }
            } while (Math.Abs(t) >= eps);

            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;
            double eps = 1e-4;
            double pr = 1;
            double nst = 1 / x;
            int n = 1;
            double st = x;
            // code here

            while(Math.Abs(nst - pr) >= eps)
            {
                n++;
                pr = nst;
                st *= x;
                nst = 1 / st;
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
            return answer;

            // end

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;
            double d = 1e-10;
            // code here

            while(L >= d)
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
            const double eps = 1e-4;
            // code here

            for(double x = a; x <= b + eps; x += h)
            {
                int i = 0;
                double p = 1, num = x;
                while (Math.Abs(p * num / (2 * i + 1)) >= eps)
                {
                    double zn = p * num / (2 * i + 1);
                    SS += zn;
                    i++;
                    p = -p;
                    num *= x * x;
                }
                SS += p * num / (2 * i + 1);
                SY += Math.Atan(x);
            }

            // end

            return (SS, SY);
        }
    }
}
