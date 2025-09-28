namespace Lab2
{
    public class White
    {
        const double E = 0.0001;
        public int Task1(int n)
        {
            int answer = 0;

            // code here
            int a1 = 2;
            int a9 = 3 * n - 1;
            answer = ((a1 + a9) * n) / 2;
            
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            double a = 1;
            for (int b = 1; b <= n; b ++)
            {
                answer += a / b;
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 1;

            // code here
            for (int a = n; a > 1; a--)
                answer *= a;
            // end

            return answer;
        }
        public long Task4(int a, int b)
        {
            long answer = 1;

            // code here
           
            for(int i = 1; i <= b; i ++)
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
            int n = 1, p = 1;
            while(p <= L)
            {
                n += 3;
                p *= n;
                answer = n;
            }
            // end

            return answer;
        }
        public double Task6(double x)
        {
            double answer = 0;

            //code here
            double s = 0;
            
            int n = 0; 
            do
            { 
            
                double r = Math.Pow(x, 2 * n);
                n += 1;
                s += r;
                if (r <= 0.0001)
                    break;
                Console.WriteLine(r);

                
            }
            while (true);
            answer = s;
            //end

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
        public int Task8(double L, double V)
        {
            int answer = 0;
            const double R = 6371.0; // радиус Земли, км

            // code here
            
            double X = Math.Sqrt(Math.Pow(R, 2) + Math.Pow(L, 2));
            double Y = ((X - R) / V)+1;
            double a = Math.Floor(Y);

            
            // end
            Console.WriteLine(Y);
            answer = (int)a;
            return answer;
        }
    }

}
