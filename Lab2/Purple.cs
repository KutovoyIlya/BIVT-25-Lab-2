using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0;

            // code here
            int sum = p;
            for (int i=0; i<n; i++)
            {
                answer += sum * sum;
                sum += h;
            }
            // end

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here
            while (a >= b)
            {
                quotient++;
                a -= b;
            }
            remainder = a;
            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here
            double fib1 = 1;
            double fib2 = 1;
            double fib3 = 2;

            while (Math.Abs((fib3 / fib2) - (fib2 / fib1)) > E)
            {
                (fib1, fib2, fib3) = (fib2, fib3, fib2 + fib3);
            }
            answer = fib3 / fib2;

            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here
            answer++;
            while (Math.Abs(b) >= E)
            {
                answer++;
                b *= q;
            }
            // end

            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;

            // code here
            long number = a;
            while (b > 0)
            {
                number *= b;
                b--;
            }
            while (number >= 10)
            {
                number /= 10;
                answer++;
            }
            // end

            return answer;
        }
        public long Task6()
        {
            long answer = 0;

            // code here
            double tonna=0;
            for (int i=0; i<64; i++)
            {
                tonna += Math.Pow(2, i)/15000000.0;
            }
            answer = Convert.ToInt64(Math.Round(tonna));
            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here
            double sum = S;
            double procent = S * d / 100.0 / 12.0;
            int month = 0;

            while (sum < 2 * S)
            {
                sum += procent;
                answer++;
                month++;

                if (month == 12)
                {
                    procent = sum * d / 100.0 / 12.0;
                    month = 0;
                }
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
                double s = 0;
                int i = 0;
                double count = 1;
                double fact = 1;
                while (Math.Abs(count) >= E)
                {
                    count = Math.Pow(-1, i)*(Math.Pow(x, 2*i))/fact;
                    s += count;
                    i++;
                    fact *= 2*i;
                    fact *= 2*i-1;
                }

                SY += Math.Cos(x);
                SS += s;
            }

            // end

            return (SS, SY);
        }
    }
}
