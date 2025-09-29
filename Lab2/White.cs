namespace Lab2
{
    public class White
    {
        const double E = 0.0001;
        public int Task1(int n)
        {
            int answer = 0;

            // code here
            for (int i = 1; i <= n; i++)
            {
                answer += 3 * i - 1;

            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double x = 1;
            for (int i = 1; i <= n; i++)
            {
                answer += x / i;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            answer = 1;
            for (int i = 1; i <= n; i++)
            {
                answer *= i;
            }
            // end

            return answer;
        }
        public long Task4(int a, int b)
        {
            long answer = 0;

            // code here
            answer = 1;
            for(int i = 1; i <= b; i++)
            {
                answer *= a;
            }
            // end

            return answer;
        }
        public int Task5(int L)
        {
            int answer = 0;

            // code here
            int n = 1;
            int s = 0;
            for (int i = 1; n <= L; i += 3) 
            {
                n *= i;
                s = i;
            }
            answer = s;
            // end

            return answer;
        }
        public double Task6(double x)
        {
            double answer = 0;

            // code here
            answer = 1;
            double x1 = x * x;
            while (x1 > E)
            {
                answer =answer + x1;
                x1 = x1 * x * x;
            }
            // end

            return answer;
        }

        public int Task7(int n)
        {
            int answer = 0;

            // code here
            for(int sum = 0; sum < n; sum = sum + answer)
            {
                answer++;
            }
            // end

            return answer;
        }
        public int Task8(double L, double v)
        {
            int answer = 0;
            const double R = 6371.0; // радиус Земли, км

            // code here
            double h = 0;
            double l1 = 0;
            while(l1 <= L)
            {
                answer++;
                h = v * answer;
                l1 = Math.Sqrt((R + h) * (R + h) - R * R);
            }
            // end

            return answer;
        }
    }

}
