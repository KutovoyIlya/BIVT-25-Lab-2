using System.Collections.Generic;
using System.ComponentModel;
using System.Formats.Asn1;
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
            int c = 0;
            int an = 0;
            while (c != n)
            {
                c++;
                an = p + ((c - 1) * h);
                answer = answer + an*an;

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
                a = a - b;
                quotient++;
            }
            remainder = a;
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
            int ca = 0;
            double a = 10000;
            while (Math.Abs(a) >= 0.00000001)
            {
                ca++;
                a = b * (Math.Pow(q, ca) - q);

            }
            // end
            answer = ca;
            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
        public long Task6()
        {
            long answer = 0;

            // code here

            // end

            return answer;
        }

        public int Task7(double S, double d)
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
