using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Transactions;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            // code here

            double answer = 0;
            double S = 0;
            for (double ch = 1, zn = 1; ch <= n; ch++)
            {
                S += Math.Sin(ch * x) / zn;
                zn *= x;
            }
            answer = S;
            
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here

            double s = 0;
            double f = 1;
            double power = 1;
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    f *= i;
                    power *= -5;
                    s += power / f;
                }
            }
            answer = s;

            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;

            // code here

            long sum = 0;
            long a = 0;
            long b = 1;

            for (int i = 0; i < n; i++)
            {
                sum += a;
                long next = a + b;
                a = b;
                b = next;
            }
            answer = sum;

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here
            
            int summ = 0;
            for (int n =1; summ <= L; n++)
            {
                summ += a + (n - 1) * h;
                if (summ > L)
                {
                    answer = n - 1;
                }
            }

            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0, zn = 1;
            double elem = ch / zn;
            int i = 1;

            do
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;
            }
            while (elem > 0.0001);

            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here

            // S клеток квждые h часов делятся на 2 клетки. Через сколько часов будет >=L клеток
            int hours = 0;
            while (S < L)
            {
                S *= 2;
                hours += h;
            }
            answer = hours;


            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here
            // a. Суммарный путь за 7 дней
            double totalDistance = 0;
            double dailyDistance = S;

            for (int day = 1; day <= 7; day++)
            {
                totalDistance += dailyDistance;
                dailyDistance += dailyDistance * (I / 100);
            }
            a= totalDistance;

            // b. Через сколько дней суммарный путь достигнет 100 км
            totalDistance = 0;
            dailyDistance = S;
            int daysTo100km = 0;

            while (totalDistance < 100)
            {
                daysTo100km+=1;
                totalDistance += dailyDistance;
                dailyDistance += dailyDistance * (I / 100);
            }

            b= daysTo100km;

            // c. Через сколько дней дневная норма превысит 42 км
            dailyDistance = S;
            int daysTo42km = 0;

            while (dailyDistance <= 42)
            {
                daysTo42km++;
                dailyDistance += dailyDistance * (I / 100);
            }
            c= daysTo42km;

            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            double epsilon = 0.0001;

            for (double x = a; x <= b + 0.000001; x += h)
            {
                double sum = 0;
                int i = 0;
                double term;

                do
                {
                    double power = 1;
                    for (int j = 0; j < 2 * i; j++)
                        power *= x;

                    long fact = 1;
                    for (int j = 1; j <= i; j++)
                        fact *= j;

                    term = power / fact;
                    sum += term;
                    i++;

                } while (Math.Abs(term) >= epsilon);

                sum *= (1 + 2 * x * x);
                SS += sum;


                double exp_sum = 0;
                int k = 0;
                double exp_term;

                do
                {
                    double x2_power = 1;
                    for (int j = 0; j < k; j++)
                        x2_power *= x * x;

                    long k_fact = 1;
                    for (int j = 1; j <= k; j++)
                        k_fact *= j;

                    exp_term = x2_power / k_fact;
                    exp_sum += exp_term;
                    k++;

                } while (Math.Abs(exp_term) >= epsilon);

                double y = (1 + 2 * x * x) * exp_sum;
                SY += y;
            }

            SS = Math.Round(SS, 6);
            SY = Math.Round(SY, 6);

            // end

            return (SS, SY);
        }
    }
}