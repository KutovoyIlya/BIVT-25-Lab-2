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

        public static double Fibanachi(int n)
        {

            //0 1 1 2 3 
            int res = 0;

            int a = 0, b = 1;


            if (n <= 1)
                res = 0;
            if (n >= 2)
                res = 1;

            for (int i = 2; i < n; i++)
            {
                int a1 = b;
                int b1 = a + b;

                res += b1;

                a = a1;
                b = b1;
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
            int schet = 0;
            int w = 0;
            while (schet <= L)
            {
                schet += (a + h * w);
                w += 1;
            }
            answer = w - 1;
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
            i += 1;
            while (elem > 0.0001)
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i += 1;
            }

            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            if (S >= L) return 0;

            int kletki = S;

            while (kletki < L)
            {
                answer += h;
                kletki *= 2;
            }
            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            double result1 = 0;
            double tempValue = S;
            for (int counter = 1; counter <= 7; counter++)
            {
                result1 += tempValue;
                tempValue *= (1 + I / 100);
            }
            a = Math.Round(result1, 6);

            double result2 = 0;
            double tempValue2 = S;
            b = 0;
            while (result2 < 100)
            {
                b++;
                result2 += tempValue2;
                tempValue2 *= (1 + I / 100);
            }

            double tempValue3 = S;
            c = 0;
            while (tempValue3 <= 42)
            {
                c++;
                tempValue3 *= (1 + I / 100);
            }
            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            //Не понял данное задание как делать
            for (double x = a; x <= b + 1e-12; x += h)
            {
                double sum = 0;
                int i = 0;
                double n;
                double fac = 1;
                double first = 1;
                double kv = x * x;
                do
                {
                    if (i > 0)
                    {
                        fac *= i;
                        first *= kv;
                    }
                    n = (2 * i + 1) * first / fac;
                    sum += n;
                    i += 1;
                }
                while (n >= E);
                double y = (1 + 2 * x * x) * Math.Exp(x * x);
                SS += sum;
                SY += y;
            }
            // end

            return (SS, SY);
        }
    }
}