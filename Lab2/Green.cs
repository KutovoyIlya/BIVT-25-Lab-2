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
            double s = 0;
            for (int i = 2; i <= n; i+=2)
            {
                s += (double)i / (i + 1);

            }
            answer += s;
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            double s = 1;
            double a = 1 / x;
            for (int i = 1; i <= n; i++)
            {
                s += a;
                a /= x;
            }
            answer += s;
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long s = 1; long a = 1;
            for (int i = 1; i <= n; i++)
            {
                s += a;
                a = a * (i + 1);
            }
            answer += s;

            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            double chl = Math.Sin(x); double b = x;
            int a = 1;
            while (Math.Abs(chl) >= E)
            {
                answer += chl;
                a += 1;
                b *= x;
                chl = Math.Sin(a*b);
            }
            
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            int n = 2;
            double zn1 = x * x; double zn2 = x;
            double razn = Math.Abs((1 / zn1) - (1 / zn2));
            while (razn >= E)
            {
                n += 1;
                zn1 *= x;
                zn2 *= x;
                razn = Math.Abs((1 / zn1) - (1 / zn2));
            }
            answer = n;
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
            int c = 0;
            while (L > Da)
            {
                L /= 2;
                c += 1;
            }
            answer = c;
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            for (double x = a; x <= b; x = Math.Round(x + h, 7))
            {
                SY += Math.Atan(x);
                SS += x;
                double m = x; double c = 1;
                int i = 0;
                while (Math.Abs(m) >= E)
                {
                    i++;
                    c *= x;
                    m = c*c*x / (2 * i + 1);
                    if (i % 2 == 1)
                    {
                        m = -m;
                    }
                    SS += m;
                }
            }


            // end

            return (SS, SY);
        }
    }
}
