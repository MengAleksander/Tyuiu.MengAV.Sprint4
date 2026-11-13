using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MengAV.Sprint4.Task3.V11.Lib
{
    public class DataServies : ISprint4Task3V11
    {
        public int Calculate(int[,] array)
        {
            int count = 0;

            foreach (int element in array)
            {
                if (element % 2 != 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
