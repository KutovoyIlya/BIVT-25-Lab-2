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


            double u = 1.0;
            for (int i = 1; i <= n; i++ )
             {
               answer += Math.Sin(x * i) / u;
               u *= x;
             }
            
        
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here

                double a = 1;
                double c = 1;
                double m = 1;
                double u = -1;
                for (int i = 1; i <= n; i++)
                {
                    answer += u * (5 / m);
                    u *= -1;
                    a++;
                    c++;
                    m *= c*0.2;
                }
    
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            if (n <= 0)
            {
                return 0;
            }

            long f1 = 0;
            long f2 = 1;
            answer = f1;
            if (n == 1)
            {
                return answer;
            }
            answer += f2;
            for (int i = 3; i <= n; i++)
            {
                long f = f1 + f2;
                answer += f;
                f1 = f2;
                f2 = f;
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int s = 0;
            int w = 0;
            while (s <= L) 
            {
                s += (a + h * w);
                w++;
            }
            answer = w-1;


            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0;
            double zn = 1;
            int i = 1;
            double elem = ch / zn;
            ch += i;
            zn *= x;
            answer += elem;
            elem = ch / zn;
            i++;
            while (elem > 0.0001)
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;
            }

                // end

                return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            if(S >= L)
            {
                return 0;
            }
                

            int k = S;
            int time = 0;

            while (k < L)
            {
                time += h;
                k *= 2;
            }
            answer = time;
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            double r = 0;
            double aa = S;
            for (int s = 1; s <= 7; s++)
            {
                r += aa;
                aa *= (1 + I / 100);
            }
            a = Math.Round(r, 6);
            r = 0;
            aa = S;
            b = 0;
            while (r < 100)
            {
                b++;
                r += aa;
                aa *= (1 + I / 100);
            }
            aa = S;
            c = 0;
            while (aa <= 42)
            {
                c++;
                aa *= (1 + I / 100);
            }
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            double eps = 0.0001;
            for (double x = a; x <= b + 1e-12; x += h)
            {
                double s = 0;
                int i = 0;
                double n;
                double f = 1;
                double xp = 1;
                double xs = x * x;
                do
                {
                    if (i > 0)
                    {
                        f *= i;
                        xp *= xs;
                    }
                    n = (2 * i + 1) * xp / f;
                    s += n;
                    i += 1;
                }
                while (n >= eps);


                double y = (1 + 2 * x * x) * Math.Exp(x * x);
                SS += s;
                SY += y;

            }
            // end

            return (SS, SY);
        }
    }
}
