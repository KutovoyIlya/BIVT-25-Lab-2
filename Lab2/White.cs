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
            for (int i = 1; i <= n; i++)
            {
                answer += 1.0 / i;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
            long x = 1;
            for (int i = 1; i <= n; i++)
            {
                x *= i;
            }
            answer = x;
            // end

            return answer;
        }
        public long Task4(int a, int b)
        {
            long answer = 0;

            // code here
            long x = 1;
            for (int i = 0; i < b; i++)
            {
                x *= a;
            }
            answer = x;
            // end

            return answer;
        }
        public int Task5(int L)
        {
            int answer = 0;

            // code here
            int p = 1;
            int n = 1;
            while (p <= L)
            {
                n += 3;
                p *= n;
            }
            answer = n;
            // end

            return answer;
        }
        public double Task6(double x)
        {
            double answer = 0;

            // code here

            double s = 1;
            double e = 0.0001;
            double x1 = 1;
            while (x1 >= e)
            {
                x1 *= x * x;
                s += x1;
            }
            answer = s;
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
            double l2 = 0;
            double h = R;
            while (l2 <= L)
            {
                answer++;
                h += v;
                l2 = Math.Pow(h * h - R * R, 0.5);
            }
            // end

            return answer;
        }
    }

}
