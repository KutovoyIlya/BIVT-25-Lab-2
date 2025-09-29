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
            for (int i = 0; i <= n; i+=2)
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
            double znam = 1;
            for (int i = 0; i <= n; i++)
            {
                answer += 1 / znam;
                znam *= x;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;
           
            // code here
            long factorial = 1;
            for (int i = 0; i <= n; i++)
            {
                if (i > 0)
                {
                    factorial *= i;
                }
                answer += factorial;
            }   
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            for (int n = 1; Math.Abs(Math.Sin(n*Math.Pow(x,n))) >= E; n++)
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
            answer = 2;
            double a = 1 / (x * x);
            double b = 1 / x;
            while ( Math.Abs(a-b) >= E)
            {
                b = a;
                a = a / x;
                answer++;
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
            for (double x = a; x <= b + 0.00001; x += h)
            {
                int i = 0; //степень с которой начинаем
                double _1stnum = -1; // первая 
                double _num2 = 1; // x^2i
                double numI = 1;
                while (Math.Abs(numI) >= E)
                {
                    numI = -_1stnum * x * _num2 / (2 * i + 1);
                    SS += numI;
                    _num2 = _num2 * x * x;
                    i++;
                    _1stnum = -_1stnum;
                }
                SY += Math.Atan(x);
            }
            // end

            return (SS, SY);
        }
    }
}
