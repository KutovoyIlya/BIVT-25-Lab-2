namespace Lab2
{
    public class White
    {
        const double E = 0.0001;
        public int Task1(int n)
        {
            int answer = 0;

            // code here
            int a = 0;
            
            for (int i = 2;i < 3*n; i+=3)
            {
                a += i;
            }
            answer = a;
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double s = 0;
            for (int i = 1; i < (n+1); i++)
            {
                s += 1.0 / i;
            }
            answer = s;
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long s = 1;
            for (int i = 1; i <= n; i++)
            {
                s *= i;
            }
            answer = s;
            // end

            return answer;
        }
        public long Task4(int a, int b)
        {
            long answer = 0;

            // code here
            long s = 1;
            long q = 1;
            if (b == 0)
            {
                answer = 1;
            }
            else
            {
                while (q <= b)
                {
                    s *= a;
                    q += 1;
                  
                }
                answer = s;

            }
                // end

                return answer;
        }
        public int Task5(int L)
        {
            int answer = 0;

            // code here
            int s = 1;
            int res = 1;
            int q = 0;
            while (res<=L)
            {
                
                s += 3;
                q = s;
                res *= s;
                
                
            }
            answer = q;
            // end

            return answer;
        }
        public double Task6(double x)
        {
            double answer = 0;
            const double R = 6371.0; // радиус Земли, км

            // code here

            double s = 1;
            double q = x * x;
            while (s >= E)
            {
                answer += s;
                s *= q;
            }
            // end

            return answer;
        }

        public int Task7(int n)
        {
            int answer = 0;

            // code here
            int sum = 0;
            while (sum < n)
            {
                answer++;
                sum += answer;

            }

            // end

            return answer;
        }
        public int Task8(double L, double v)
        {
            int answer = 0;

            // code here
           
            int q = 6371;
            double g = Math.Sqrt(L * L + q * q) - q;
            answer = (int)Math.Ceiling(g / v);

            // end

            return answer;
        }
    }
}
