namespace Lab2
{
    public class Program
    {
        public static void Main()
        {
            int n = 3;
            double result = Fibanachi(n);
            Console.WriteLine($"Сумма первых {n} чисел Фибоначчи: {result}");
        }

        public static double Fibanachi(int n)
        {

            //0 1 1 2 3 
            int res = 0;

            int a = 0, b = 1;

            if (n <= 1)
                res = 0;
            else
            {
                for (int i = 2; i < n; i++)
                {
                    int a1 = b;
                    int b1 = a + b;

                    res += b1;

                    a = a1;
                    b = b1;
                }
            }

            return res;

        }
    }
}