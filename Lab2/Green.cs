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
            for (double i = 0; i <= n; i = i + 2)
            {
                answer += (i / (i + 1));
            }
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;
            double su = 0;

            // code here
            for (double i = 0; i <= n; i++)
            {
                su = 1;

                for (double k = 0; k < i; k++)
                {
                    su /= x;
                }

                answer += su;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;
            long f = 1;
            answer += 1;
            // code here
            for (int i = 1; i <= n; i++)
            {
                f = f * i;
                answer += f;
            }
    
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;
            double arg = x;
            int n = 1;
            // code here
            while (true)
            {
                double el = Math.Sin(n * arg);
                if (Math.Abs(el) < (1E-4))
                {
                    break;
                }
                answer += el;
                n++;
                arg *= x;
            }
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;
            int n = 1;
            double arg = x;

            // code here
            while ((Math.Abs((1 / arg) - (x / arg)) >= (1E-4)))
            {
                n++;
                arg *= x;
                answer = n;
            }
            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;
            int elem = 1;
            int i = 0;

            // code here
            for (i = 0; elem < limit; i++)
            {
                elem *= 2;
                answer += elem;
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
                L = L / 2;
                answer += 1;
            }            
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            double sx, num, den;
            double x, y;
            // code here
            for (x=a; x<=b+1E-12; x += h)
            {
                sx = x; num = x; den = 1;
                int sign = -1;
                for (int i = 1; ; i++)
                {
                    num = num * x * x;
                    den = 2 * i + 1;
                    sx += sign * (num / den);
                    sign *= -1;
                    if (Math.Abs(num / den) < E)
                    {
                        break;
                    }

                }
                SS += sx;
                SY += Math.Atan(x);



            }
            // end

            return (SS, SY);
        }
    }
}
