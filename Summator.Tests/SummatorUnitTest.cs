using NUnit.Framework;

namespace Summator.Tests
{
    public class SummatorTests
    {


        [Test]
        public void Test_Sum_TwoPossitiveNumber()
        {
            int actual = Summator.Sum(new int[] { 4, 3 });
            int expected = 7;
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Test_Sum_OnePositiveNumber()
        {
            int actual = Summator.Sum(new int[] { 8 });
            int expected = 8;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_Sum_EmptyArray()
        {
            int actual = Summator.Sum(new int[] { });
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Sum_TwoNegativeNumbers()
        {
            int actual = Summator.Sum(new int[] { -5, -3 });
            int expected = -8;
            Assert.That(actual == -8);
        }

        [Test]
        public void Test_Sum_PositiveAndNegativeNumbers()
        {
            int actual = Summator.Sum(new int[] { 8, -2 });
            int expected = 6;
            Assert.That(actual == expected);

        }

        [Test]
        public void Test_Sum_FirstElementInArray()
        {
            var nums = new int[] { -1, 5, -9 };
            var number = nums[0];
            Assert.AreEqual(-1, number);

        }
        [Test]
        public void Test_Sum_BigNumber()
        {
            var actual = Summator.Sum(new int[] { 1000000000, 1000000000 });
            var expected = 2000000000;
            Assert.That(actual == expected);
        }
        [Test]
        public void Test_AveragePositiveAndNegativeNumber()
        {
            double actual = Summator.Average(new long[] { 14, -7 });
            double expected = 3.5;
            Assert.AreEqual(actual, expected);


        }
        [Test]
        public void Test_AverageTwoNegativeNumber()
        {
            double actual = Summator.Average(new long[] { -27, -29, });
            double expected = -28;
            Assert.That(actual == -28);

        }
        [Test]
        public void Test_AverageTwoPositiveNumber()
        {
            double actual = Summator.Average(new long[] { 14, 16 });
            double expected = 15;
            Assert.AreEqual(actual, expected);

        }
        [Test]
        public void Test_Average_EmptyArray()
        {
            double actual = Summator.Average(new long[] { });
            double expected = double.NaN;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_Average_DecimalNumber()
        {
            double actual = Summator.Average(new long[] { 777777777777777, 777777777777777 });

            Assert.AreEqual(777777777777777, actual);

        }
        [Test]
        public void Test_Average_ZeroNumbers()
        {
            double actual = Summator.Average(new long[] { 0, 0, });
            double expected = 0;
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void Test_Average_ZeroAndOneNegativeNumbers()
        {
            double actual = Summator.Average(new long[] { 0, -10 });
            double expected = -5;
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void Test_Average_ZeroAndOnePositiveNumbers()
        {
            double actual = Summator.Average(new long[] { 0, 12 });
            double expected = 6;
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void Test_Average_ThreePositiveNumbers()
        {
            double actual = Summator.Average(new long[] { 60, 70, 80 });
            double expected = 70;
            Assert.AreEqual(expected, actual);
        }






    }


}