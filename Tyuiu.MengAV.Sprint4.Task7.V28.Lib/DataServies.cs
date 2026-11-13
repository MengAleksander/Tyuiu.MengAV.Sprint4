using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MengAV.Sprint4.Task7.V28.Lib
{
    public class DataServies : ISprint4Task7V28
    {
        public int Calculate(int n, int m, string value)
        {
            if (value.Length != n * m)
            {
                throw new ArgumentException("Длина строки должна совпадать с количеством элементов матрицы.");
            }

            int[,] matrix = new int[n, m];
            int product = 1;

            for (int i = 0; i < value.Length; i++)
            {
                int number = value[i] - '0';
                matrix[i / m, i % m] = number;

                if (number % 2 == 0)
                {
                    product *= number;
                }
            }

            return product;
        }
    }
}
