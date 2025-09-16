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
            for(int i = 2; i <= n; i+=2)
            {
                answer += ((double)i / (double)(i + 1));
            }
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            double now = 1;
            answer += now;
            for(int i = 1; i <= n; i++)
            {
                now /= x;
                answer += now;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long now = 1;
            answer += now;
            for(int i = 1; i <= n; i++)
            {
                now *= i;
                answer += now;
            }
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            double t = 1;
            double defx = 1;
            for(int i = 1; Math.Abs(t) > E; i++)
            {
                defx *= x;
                t = Math.Sin(i * defx);
                answer += t;
            }
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            int i = 1;
            double xn = 1 / x, xn1 = 1;
            while(Math.Abs(xn1 - xn) > E)
            {
                xn1 /= x;
                xn /= x;
                i += 1;
            }
            answer = i;
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
