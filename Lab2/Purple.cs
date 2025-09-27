using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public double Task1(int n, int p, int h)
        {
            double answer = 0;
            

            // code here
            for (double i = 0; i < n; i++)
            {
                answer += Math.Pow(p + i * h, 2);
            }

            // end
            

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here
            quotient = a / b;
            remainder = a % b;

            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 1;

            // code here
            
            double x = 1;
            double y = 1;
            double z = 2;
            while (Math.Abs(z / y - y / x) > 0.0001)
            {
                x = y;
                y = z;
                z = y + x;
            }
            answer = z / y;

            // end


            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 1;

            // code here
            
            while (Math.Abs(b) >= 0.0001)
            {
                b *= q;
                answer += 1;
            }


            // end
            

            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;
            long number = a;

            // code here
            
            
            while (b > 0)
            {
                number *= b;
                b -= 1;
            }
            while (number >= 10)
            {
                number /= 10;
                answer += 1;
            }


                // end
                
                

            return answer;
        }
        public long Task6()
        {
            long answer = 0;

            // code here

            answer = (long)((Math.Pow(2, 64) - 1) / 15000000);

            // end
            

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;
            double new_S = S;
            double plus = 0;
            bool flag = false;

            // code here

            while (true)
            {
                plus = new_S * (d / 1200);
                for (int i = 0; i < 12; i++)
                {
                    if (new_S >= 2 * S)
                    {
                        flag = true;
                        break;
                    }
                    new_S += plus;
                    answer += 1;
                    
                }
                if (flag)
                {
                    break;
                }

            }

            // end
            

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            for (double j = a; j <= b + 0.0001; j += h)
            {
                SY += Math.Cos(j);
                
                double i = 0;
                double e = 1; 
                
                while (Math.Abs(e) >= 0.0001)
                {
                    SS += e;
                    
                    i += 1;
                    double fac_i = 1;
                    for (int k = 1; k <= 2 * i; k++)
                    {
                        fac_i *= k;
                    }
                    e = Math.Pow(-1, i) * Math.Pow(j, 2 * i) / fac_i;
                }
                
            }
                    

            // end


            return (SS, SY);
        }
    }
}