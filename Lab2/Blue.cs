using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
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
            double pw = 1;
            for (int i = 1; i <= n; i++)
            {
                answer += Math.Sin(x * i) / pw;
                pw *= x;
            }
            
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double pw1= 5;
            double pw2 = 1;
            int x = -1;
            for (int i = 1; i <= n; i++)
            {
                answer += x * pw1 / pw2;
                pw1 *= 5;
                x *= -1;
                pw2 *= i+1;
            }

            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long now = 1, cnt=1;
            long pre = 0; 
            for (int i = 0; i < n-1; i++)
            {
                answer+= now;
                cnt = now;
                now += pre;
                pre = cnt;

            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            int n = 0, cnt = 0;
            while (cnt <= L)
            {
                answer = n++;
                cnt += a + (n - 1) * h;
            }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0, zn = 1, elem = ch / zn;
            int i = 1;
            do
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;
            }
            while (elem > 0.0001);

            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            while (L > S)
            {
                answer += h;
                S *= 2;
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
            double Sa = S, Ia = I, Ssuma=0;
            for (int i=0; i<7; i++)
            {
                Ssuma += Sa;
                Sa *= (Ia / 100 + 1);
            }
            a = Ssuma;
            double Sb = S, Ib = I, Ssumb=0;
            int ib = 0;
            while (Ssumb < 100)
            {
                Ssumb += Sb;
                Sb*= (Ib/100 +1);
                ib++;
            }
            b = ib;
            double Sc = S, Ic = I;
            int ic = 0;
            while (Sc <= 42)
            {
                Sc *= (Ic / 100 + 1);
                ic++;
            }
            c = ic;
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