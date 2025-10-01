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
            for (int i = 2; i<=n;i+=2)
            {
                answer += (double) i/(i+1);
            }
            // end

            return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            double num = 1;
            for (int i=0;i<=n;i+=1)
            {
                answer += num;
                num = num / x;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long fact = 1;
            answer += 1;
            for (int i=1;i<=n;i++)
            { 
                    fact*=i;
                    answer += fact; 
            }
            // end

                return answer;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            const double r = 1E-4;
            double power = x;
            for (int i=1; ; i++)
            {
                double term = Math.Sin(i * power);
                if (Math.Abs(term) < r)
                {
                    break;
                }
                answer += term;
                power *= x;
            }
            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            int n = 1;
            double r = x;
            while (Math.Abs((1 / r) - (x / r)) >= 1E-4)
            {
                n++;
                r *= x;
                answer = n;
            }
            // end

            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int elem = 1;
            int i= 0;
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
            double D=1e-10;
            if (L<=D)
            {
                return 0;
            }
            double r = L / D;
            answer = (int)Math.Ceiling(Math.Log(r, 2));
            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;
            
            // code here
            double sx, num, den;
            const double e= 0.0001;
            double x, y;
            for (x=a; x<=b+(1E-12); x+=h)
            {
                sx = x; num = x;den = 1;
                int stepen = -1;
                for (int i=1; ;i++)
                {
                    num = num * x * x;
                    den = 2 * i + 1;
                    sx += stepen * (num / den);
                    stepen *= -1;
                    if (Math.Abs(num/den)<e)
                    {
                        break;
                    }
                }
                SS += sx;
                SY += Math.Atan(x);
            }
            // end

            return (SS, SY);
        }
    }
}