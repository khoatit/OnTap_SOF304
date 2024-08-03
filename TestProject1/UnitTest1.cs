using OnTap_SOF304;

namespace TestProject1
{
    [TestFixture]
    public class Test_Phan1
    {
        [Test]
        public void Test1()
        {
            int[] numbers = new int[0];
            int result = Phan1.Array(numbers);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Test2()
        {
            int[] numbers = { 5 };
            int result = Phan1.Array(numbers);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Test3()
        {
            int[] numbers = { 2, 3, 4 };
            int result = Phan1.Array(numbers);
            Assert.AreEqual(24, result);
        }

        [Test]
        public void Test4()
        {
            int[] numbers = { -2, -3, -4 };
            int result = Phan1.Array(numbers);
            Assert.AreEqual(-24, result);
        }

        [Test]
        public void Test5()
        {
            int[] numbers = { -2, 3, -4 };
            int result = Phan1.Array(numbers);
            Assert.AreEqual(24, result);
        }

        [Test]
        public void Test6()
        {
            int[] numbers = { 2, 3, 0, 4 };
            int result = Phan1.Array(numbers);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Test7()
        {
            int[] numbers = { 2, 3 };
            int result = Phan1.Array(numbers);
            Assert.AreEqual(6, result);
        }

        [Test]
        public void Test8()
        {
            int[] numbers = new int[100];
            for (int i = 0; i < 100; i++)
            {
                numbers[i] = i + 1;
            }
            int result = Phan1.Array(numbers);
            Assert.AreEqual(0, result);
        }
    }
}