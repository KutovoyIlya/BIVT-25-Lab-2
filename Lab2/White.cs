namespace Lab2
{
    public class White
    {
        const double E = 0.0001;
        public int Task1(int n)
        {
            int answer = 0;

            // code here
            for (int i = 2; i <= 3*n-1; i += 3)
            {
                answer += i;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here    
            for (double i = 1; i <= n; i++)
            {
                answer += (1 / i) ;
            }

            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 1;

            // code here
            for (int i = 1; i <= n; i++)
            {
                answer *= i;
            }

            // end

            return answer;
        }
        public long Task4(int a, int b)
        {
            long answer = 1;

            // code here
            for (int i = 1; i <= b; i++)
            {
                answer *= a;
            }

            // end

            return answer;
        }
        public int Task5(int L)
        {
            int answer = 1;
            int s = 1;
            for (int n = 1; true; n += 3)
            {
                s *= n;
                if ( s > L)
                {
                    answer = n;
                    break;
                }
            }

            // end
            return answer;
        }
        public double Task6(double x)
        {
            double answer = 0;

            // code here
            for (int i = 0; true; i+=2)
            {
                double a = Math.Pow(x, i);
                if ( a > E) answer += a;
                else break;

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
            const double R = 6371.0; // радиус Земли, км

            // code here
            double t = ((Math.Sqrt(R * R + L * L)) - R) / v;
            answer = (int)Math.Ceiling(t);
            // end

            return answer;
        }
    }
    

}