using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{

    public class Blue
    {

        public double Pow(double num, int stepen)
        {
            double res = 1;
            for (int i = 1; i <= stepen; i++)
            {
                res *= num;
            }

            return res;
        }

        public double Factorial(double num)
        {
            double res = 1;
            for (int i = 2; i <= num; i++)
            {
                res *= i;
            }

            return res;
        }

        public double Fibanachi(int n)
        {
            //1 1 2 3 5 8 13 21 34 55 89
            int res = 2;

            int a = 1, b = 1;

            if (n <= 1)
                res = n;
            else
            {
                for (int i = 2; i <= n-1; i++)
                {
                    int a1 = b;
                    int b1 = a + b;

                    res += b1;

                    a = a1;
                    b = b1;
                }
            }

            return res;
        }

        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;

            // code here

            for (int i = 0; i < n; i++)
            {
                answer = answer + Math.Sin((i+1)*x)/Pow(x, i);
            }
            // end

            return answer;
        }

        public double Task2(int n)
        {
            double answer = 0;

            // code here
            for (int i = 1; i <= n; i++)
            {
                if (i%2==1)
                {
                    answer -= Pow(5, i) / Factorial(i);
                } else
                {
                    answer += Pow(5, i) / Factorial(i);
                }
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            answer = (long)Fibanachi(n);
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here

            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here

            // end

            return (a, b, c);
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