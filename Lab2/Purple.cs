using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
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

            //code here

            while (a >= b)
            {
                a -= b;
                quotient++;
                
            }
            remainder = a;

            //end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here
            List<double> high = new List<double>();
            List<double> low = new List<double>();

            double current = 2;
            double last = 0;
            high.Add(1);
            high.Add(2);
            low.Add(1);
            low.Add(1);
            while (Math.Abs(current - last) < E)
            {
                high.Add(high[high.Count - 2] + high[high.Count - 1]);
                low.Add(low[low.Count - 2] + low[low.Count - 1]);
                last = current;
                current = high[high.Count - 1] / low[low.Count - 1];
            }
            answer = current;
            foreach (int i in high)
            {
                Console.WriteLine(i);
            }
            foreach (int j in low)
            {
                Console.WriteLine(j);
            }
            // end
            return answer;
        }
        public int Task4(double b, double q)
        {
            // code here
            int answer = 0;
            double e = (double)1 / 10000;
            int i = 1;
            while (Math.Abs(b) >= e)
            {
                i++;
                b = b * q;
            }
            answer = i;
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
            //int a = 1;
            //long b = 1;
            //while (a <= 64)
            //{
            //    a++;
            //    b *= 2;
            //}
            //long d = Math.Floor((double)b / 15000000);
            //answer = d;
            //end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;
            // code here
            int month = 0;
            double part = 0;
            S = S * 1000;
            double counter(double S, double d)
            {
                part = ((S/100) * d)/12;
                return part;
            }
            double S2 = S * 2;
            while (S<S2)
            {
                if (month % 12 == 0 || month ==0)
                {
                    part = counter(S, d);
                }
                month++;
                S += part;
            }
            answer = month;

            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            double MyPow(double a, double b)
            {
                double c = a;
                for (int i = 2; i < b; i++)
                {
                    c *= a;
                }
                return c;
            }
            double current = 0;

            for (double x = a; x <= b; x += h)
            {
                
;
            }

            // end

            return (SS, SY);
        }
    }
}
