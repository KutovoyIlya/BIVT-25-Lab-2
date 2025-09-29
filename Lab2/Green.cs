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
            for (int i=2; i<=n; i+=2)
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
            answer = 1;
            double pow = 1;
            for (int i=1; i<=n; i++)
            {
                pow /= x;
                answer += pow;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long f = 1;
            answer = 1;
            for (int i = 1; i<=n; i++)
            {
                f*=i; answer += f;
            }
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            double xpow = x;
            int n = 1;
            double xcl = Math.Sin(n * xpow);
            while (Math.Abs(xcl) >= E)
            {
                xcl = Math.Sin(n * xpow);
                answer += xcl;
                n++;
                xpow *= x;
            }
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            double cl = 1 / x;
            for (answer=2; (Math.Abs(cl * (1 / x) - cl)>=E); answer++)
            {
                cl *= 1 / x;
            }
            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int elem = 1;
            int i = 0;
            while (elem<limit)
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
            
            // end

            return (SS, SY);
        }
    }
}