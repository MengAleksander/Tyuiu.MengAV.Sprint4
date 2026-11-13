using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MengAV.Sprint4.Task4.V6.Lib
{
    public class DataServies : ISprint4Task4V6
    {
        public int[,] Calculate(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    if (matrix[row, column] % 2 != 0)
                    {
                        matrix[row, column] = 0;
                    }
                }
            }

            return matrix;
        }
    }
}
