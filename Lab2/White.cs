namespace Lab2
{
    public class White
    {
        const double E = 0.0001;
        public int Task1(int n)
        {
            int answer = 0;

            // code here
            int s = 0;
            
            for (int i = 1; i <= n; i++)
            {
                s = s + (3 * i - 1);
                answer = s;
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double s = 0;
            for (double i = 1; i <= n; i++)
            {
                s = s + (1 / i);
                answer = s;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            answer = answer + 1;
            for (int i = 1; i <= n; i++)
            {
                answer = answer * i;
            }
            // end

            return answer;
        }
        public long Task4(int a, int b)
        {
            long answer = 0;

            // code here
            long s = a;
            if (b != 0)
            {
                for (int i = 1; i < b; i++)
                {
                    s = s * a;
                }
                answer = s;
            }
            else
            {
                answer = 1;
            }

                // end

                return answer;
        }
        public int Task5(int L)
        {
            int answer = 0;

            // code here
            int p = 1;
            int m = 0;
            for (int n = 1; p <= L ; n = n + 3)
            {
                p = p * n;
                m = n;
            }
            answer = m;
            // end

            return answer;
        }
        public double Task6(double x)
        {
            double answer = 0;

            // code here
            const double E = 0.0001;
            double s = 1;
            while (s >= E)
            {
                answer = answer + s;
                s = s * (x * x);
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
                answer = answer + 1;
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
            double h = 0;
            double l = 0;
            int time = 0;
            while (l <= L)
            {
                time = time + 1;
                h = v * time;
                l = Math.Sqrt((R + h) * (R + h) - (R * R));

                answer = time;
            }
            // end

            return answer;
        }
    }

}
