using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MengAV.Sprint4.Task5.V4.Lib
{
    public class DataServies : ISprint4Task5V4
    {
        public int Calculate(int[,] matrix)
        {
            int count = 0;

            foreach (int element in matrix)
            {
                if (element > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
