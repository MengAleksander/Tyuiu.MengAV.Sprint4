using Tyuiu.MengAV.Sprint4.Task7.V28.Lib;

namespace Tyuiu.MengAV.Sprint4.Task7.V28.Test
{
    public class DataServiesTest
    {
        DataServies ds = new DataServies();
        [Fact]
        public void MultiplyEvenNumbers()
        {
            Assert.Equal(4608, ds.Calculate(5, 3, "623351179845632"));
        }

        [Fact]
        public void NoEvenNumbers()
        {
            Assert.Equal(1, ds.Calculate(2, 2, "1357"));
        }
    }
}