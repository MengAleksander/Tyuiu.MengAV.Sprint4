using Tyuiu.MengAV.Sprint4.Task3.V11.Lib;

namespace Tyuiu.MengAV.Sprint4.Task3.V11.Test
{
    public class DataServiesTest
    {
        DataServies ds = new DataServies();
        [Fact]
        public void CountOddNumbers()
        {
            int[,] array =
            {
            { 8, 6, 9, 4, 5 },
            { 9, 4, 8, 5, 6 },
            { 9, 7, 9, 8, 4 },
            { 4, 6, 5, 7, 8 },
            { 6, 6, 7, 6, 4 }
            };

            Assert.Equal(10, ds.Calculate(array));
        }

        [Fact]
        public void NoOddNumbers()
        {
            int[,] array =
            {
            { 2, 4 },
            { 6, 8 }
            };

            Assert.Equal(0, ds.Calculate(array));
        }
    }
}