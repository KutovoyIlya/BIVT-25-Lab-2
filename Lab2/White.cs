namespace Lab2
{
    public class White
    {
        const double E = 0.0001;
        public int Task1(int n)
        {
            int answer = 0;

            // code here
           int S = 0;
for (int i = 1; i <= n; i++)
{
    S+=(3*i - 1);
    answer = S;
}
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
           double S = 0;
for(double i = 1; i <=n; i++)
{
    S+=(1/i);
    answer = S;
}
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here
answer = 1;
for(long i = 1; i <=n; i++)
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
for(long i = 1; i <=b ; i++)
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
int p = 1;
for (int i = 1; p <= L;i+=3)
{
    p *= (i);
    answer = i;
}
            // end

            return answer;
        }
        public double Task6(double x)
        {
            double answer = 0;

            // code here
        double S = 1;
double xx = 1;
for (double i = 1; xx>=E; i += 2)
{

    xx *= (x*x);
    S += xx;

}
answer = S;
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
double h = -R + Math.Sqrt(R * R + L * L);
answer = (int)(h / v)+1;
            // end

            return answer;
        }
    }

}

