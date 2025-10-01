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
            
            
            for (int a = 2; a<= n;a++)
            {
                answer += (double)a / (a + 1);
                a += 1;
            }
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            double a = 1;
            for (int i = 0; i <= n;i++)
            {
                answer += a;
                a /= x;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long a = 1;
            answer = 1;
            for (int i = 0; i < n; ++i)
            {
                a = a * (i + 1);
                answer += a;
                
            }

            
            // end

            return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            double a = 1;
            double b = 1.0 / 10000;
            int i = 1;
            double c = x;
            while (Math.Abs(a) > b)
            {
                a = Math.Sin(c * i);
                c *= x;
                i += 1;
                answer += a;
            }
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            double b = 1.0 / 10000;
            answer = 1;
            double a = 1.0;
            double av = 1.0/x;
            while (Math.Abs(a - av) > b)
            {
                a /= x;
                av /= x;
                answer += 1;
            }
            
            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int elem = 1, i = 0;
            while (elem <limit)
            {
                elem *= 2;
                answer += elem;
                i+=1;

            }
            // end

            return answer;
        }

        public int Task7(double L)
        {
            int answer = 0;

            // code here
            
            double v = 0.0000000001;
            while (L>v)
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
            for (double x = a; x <= b; x = Math.Round(x + h, 7))
            {
                SY += Math.Atan(x);
                SS += x;
                double xx = 1;
                double l = x;
                int i = 0;
                while (Math.Abs(l) >= 0.0001)
                {

                    
                    i ++;
                    xx *= x;
                    l = xx*xx*x / (2 * i + 1);
                    if (i % 2 == 1)
                        l = -l;
                    SS += l;

                } 
            }

            // end

            return (SS, SY);
        }
    }
}
