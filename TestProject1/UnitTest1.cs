using ConsoleApp1;
using NUnit.Framework;

namespace TestProject1

{
    public class Tests
    {
        private MathHelper _math;
        [SetUp]
        public void Setup()
        {
            _math = new MathHelper();
        }

        [Test]
        public void Test1()
        {
            int result = _math.Add(2, 3);
            Assert.That(result, Is.EqualTo(5));

        }
        [TestCase(1, 2, 3)]
        [TestCase(-5, 5, 1)]
        [TestCase(0, 0, 0)]
        public void Add_WithVariousInputs_ReturnsExpectedSum(int a, int b, int expected)
        {
            int result = _math.Add(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Multiply_WithPositiveNumbers_ReturnsProduct()
        {
            int result = _math.Multiply(4, 5);
            Assert.That(result, Is.EqualTo(20));
        }

        [TestCase(0, 5, 0)]
        [TestCase(-1, 3, -3)]
        [TestCase(7, -6, -42)]
        public void Multiply_WithVariousInputs_ReturnsExpectedProduct(int a, int b, int expected)
        {
            int result = _math.Multiply(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}