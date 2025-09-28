using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

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

            int counter = 2;
            while (counter <= n)
            {
                double x = counter;
                double dr = x / (x + 1);
                Console.WriteLine(dr);
                answer += dr;
                counter += 2;
            }

            // end

                return answer;
        }
        public double Task2(int n, double x)
        {
            double answer = 0;

            // code here
            answer = 1;
            double lim = n;

            double coun = 1;
            while (coun <= lim)
            {
                answer += (1 / (Math.Pow(x, coun)));
                coun += 1;
            }

            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here

            
            long fact = 1;
            int count = 1;
            while (count <= n)
            {
                
                Console.WriteLine(fact);
                answer += fact;
                count += 1;
                fact *= count;


            }

            // end

            return answer+1;
        }
        public double Task4(double x)
        {
            double answer = 0;

            // code here
            int mnoch = 1;
            double res_step = x;
            double res = Math.Sin(x);
            while (Math.Abs(res) >= E)
            {
                Console.WriteLine(res);
                answer += res;
                mnoch += 1;
                res_step = res_step * x;
                res = Math.Sin(res_step * mnoch);
            }

            // end

            return answer;
        }
        public int Task5(double x)
        {
            int answer = 0;

            // code here
            int n = 2;

            double zhach_1 = x*x;
            double zhach_2 =  x;
            double razn = Math.Abs((1 / zhach_1) - (1 / zhach_2));
            while (razn >= E)
            {
                n += 1;
                zhach_1 *= x;
                zhach_2 *= x;
                razn = Math.Abs((1 / zhach_1) - (1 / zhach_2));

            }
            answer = n;
            // end
            
            return answer;
        }
        public int Task6(int limit)
        {
            int answer = 0;

            // code here
            int elem = 1;
            int i = 0;
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
            while (L > Da)
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
            double E = 1e-6;

            // code here

            if (h == 0) throw new ArgumentException("h не может быть 0");
           
            bool increasing = h > 0;

           
            double tol = Math.Abs(h) * 1e-8;
            double x = a;

            while (increasing ? x <= b + tol : x >= b - tol)
            {
                double sValue;
                double absX = Math.Abs(x);

                if (absX <= 1.0)
                {
                    double term = x;       
                    double powNumer = x;     
                    double mult = -x * x;     
                    int i = 0;
                    double sum = 0.0;

                    while (true)
                    {
                        double denom = 2 * i + 1;
                        term = powNumer / denom;
                        if (Math.Abs(term) < E) break;
                        sum += term;
                        powNumer *= mult;
                        i++;
                        if (i > 1000000) break;
                    }
                    sValue = sum;
                }
                else
                {
                    double inv = 1.0 / x;
                    double powNumer = inv;   
                    double mult = -inv * inv;
                    int i = 0;
                    double sumInv = 0.0;
                    while (true)
                    {
                        double denom = 2 * i + 1;
                        double term = powNumer / denom;
                        if (Math.Abs(term) < E) break;
                        sumInv += term;
                        powNumer *= mult;
                        i++;
                        if (i > 1000000) break;
                    }
                    sValue = Math.Sign(x) * Math.PI / 2 - sumInv;
 
                }

                double yValue = Math.Atan(x);

                SS += sValue;
                SY += yValue;

                x += h;
            }
            

    
            // end
   

            return (SS, SY);
        }
    }
}