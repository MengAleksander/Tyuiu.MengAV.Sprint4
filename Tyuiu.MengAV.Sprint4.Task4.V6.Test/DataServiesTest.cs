using Tyuiu.MengAV.Sprint4.Task4.V6.Lib;

namespace Tyuiu.MengAV.Sprint4.Task4.V6.Test
{
    public class DataServiesTest
    {
        DataServies ds = new DataServies();
        [Fact]
        public void ReplaceOddNumbers()
        {
            int[,] matrix =
            {
            { 7, 6, 6, 6, 9 },
            { 4, 4, 4, 9, 4 },
            { 5, 5, 5, 6, 5 },
            { 4, 9, 5, 9, 7 },
            { 6, 9, 5, 6, 7 }
        };

            int[,] result = ds.Calculate(matrix);

            int[,] expected =
            {
            { 0, 6, 6, 6, 0 },
            { 4, 4, 4, 0, 4 },
            { 0, 0, 0, 6, 0 },
            { 4, 0, 0, 0, 0 },
            { 6, 0, 0, 6, 0 }
        };

            Assert.Equal(expected, result);
        }

        [Fact]
        public void KeepEvenNumbers()
        {
            int[,] matrix =
            {
            { 2, 4 },
            { 6, 8 }
        };

            int[,] result = ds.Calculate(matrix);

            Assert.Equal(matrix, result);
        }
    }
}