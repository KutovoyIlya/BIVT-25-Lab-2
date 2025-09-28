using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Lab2
{
    public class Blue
    {
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;

            // code here
            for (int i = 1; i <= n; i++)
            {
                answer += Math.Sin(i * x) / Math.Pow(x, i-1);
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double answer = 0;

            // code here
            int minusOne = -1; // -1, которую мы возводим в степень n
            double five = 5; //пятерка, которую мы возводим в степень
            double factorialN = 1;
            
            for (int i = 1; i <= n; i++) //нач. с n = 1
            {
                factorialN *= i; //умножаем факт. на пред. знач.
                answer += (double) minusOne * five/ factorialN; //считаем по формуле
                five *= 5; //возводим 5 в степень +1 к изнач.
                minusOne *= -1; 
            }
            // end

            return answer;
        }
        public long Task3(int n)
        {
            long answer = 0;
            // code here
            long current = 1; // текущее знач. числа
            long previous = 0; //предыдущее число
            
            for (int i = 0; i < n; i++)
            {
                answer += previous; //ответ равен предыдущему члену последовательности
                long sum = previous + current; //сумма предыд. и тек.
                previous = current; //значение предыдущ. теперь равно знач. текущего
                current = sum; //текущий вычисляется как сумма предыдущего и текущего
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;
            // code here
            int sum = 0;
            int n = 1;
            while (sum <= L)
            {
                sum += (a + (n - 1) * h);
                n++;
            }
            answer = n - 2;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double ch = 0;
            double zn = 1;
            double elem = ch / zn;
            int i = 1;
            do
            {
                ch += i;
                zn *= x;
                answer += elem;
                elem = ch / zn;
                i++;
            } while (elem > 0.0001);
            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here
            int count = 0;
            int hours = 0;
            while (S < L)
            {
                hours += h;
                S *= 2;
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
            double total = 0; // Путь суммарный
            double daily = S;
            for (int i = 0; i < 7; i++)
            {
                total += daily; // Прибавляем дневной к сум.
                daily += daily * I / 100.0; //На сколько км больше в следующий раз
            }
            a = total;
            
            int day = 0;
            total = 0;
            daily = S;
            while (total < 100)
            {
                total += daily;
                daily += daily * I / 100.0;
                day++;
            }

            b = day;
            
            day = 0;
            total = 0;
            daily = S;
            while (daily <= 42)
            {
                total += daily;
                daily += daily * I / 100.0;
                day++;
            }

            c = day;
            // end

            return (a, b, c);
        }
        
        private long Factorial(int n)
        {
            long factorial = 1;
            for (int z = 1; z <= n; z++)
            {
                factorial *= z;
            }
            return factorial;
        }
        
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here
            const double E = 0.0001;
            for (double x = a; x <= b; x += h)
            {
                SY += (1 + (2 * x * x)) * Math.Exp(x * x); // Нашли функцию Y

                double factorial = 1;
                
                double item = 1;
                int i = 0;
                
                while (Math.Abs(item) >= E)
                {
                    double xPow = 1;
                    for (int y = 0; y < 2*i; y++)
                    {
                        xPow *= x;
                    }
                    item = (double)((2 * i + 1) * xPow)/Factorial(i);
                    i++;
                    SS += item;
                }

            }
            // end

            return (SS, SY);
        }
    }
}