using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0;

            // code here
            for (int i = 0; i< n; i++)
            {
                answer += (p+h*i)* (p + h*i);
            }
            // end

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here
            if (a == b)
            {
                quotient = 1;
                return (quotient, remainder);
            }

            while(a > b)
            {
                a -= b;
                quotient++;
                remainder = a;
            } 
            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here

            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;
            long number = a;
            // code here
            while (b > 0)
            {
                number *= b;
                b --;
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
            int a = 1;
            decimal b= 1;
            while (a <= 64)
            {
                a++;
                b *= 2;
            }
            decimal d = (b /15)/ 1000000;
            answer = (long)Convert.ToInt64(Math.Floor(d));
            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;
            // code here
            int counter(double S, double d) { }
            {

            }
            double S2 = S * 2;
            while (S == S2)
            {

            }
            {

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
