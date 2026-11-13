using Tyuiu.MengAV.Sprint4.Task5.V4.Lib;

namespace Tyuiu.MengAV.Sprint4.Task5.V4.Test
{
    public class DataServiesTest
    {
        DataServies ds = new DataServies();
        [Fact]
        public void CountPositive()
        {
            int[,] matrix =
            {
            { -4, 1, 0, 6, -2 },
            { 3, -1, 2, 0, -3 }
        };

            Assert.Equal(4, ds.Calculate(matrix));
        }

        [Fact]
        public void NoPositive()
        {
            int[,] matrix =
            {
            { -4, 0 },
            { -1, 0 }
        };

            Assert.Equal(0, ds.Calculate(matrix));
        }
    }
}