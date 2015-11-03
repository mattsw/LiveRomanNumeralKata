namespace LiveDevKata.Tests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class RomanConverterTests
    {
        [TestFixture]
        public class ConvertToRoman
        {
            private Func<int, string> methodToTest;

            [TestFixtureSetUp]
            public void Setup()
            {
                methodToTest = new RomanConverter().ConvertToRoman;
            }
            
            [TestCase(1, "I")]
            [TestCase(2, "II")]
            [TestCase(3, "III")]
            [TestCase(4, "IV")]
            [TestCase(5, "V")]
            [TestCase(7, "VII")]
            public void IntegerInput_ShouldReturnRomanString(int input, string expected)
            {
                Assert.AreEqual(expected, methodToTest(input));
            }
        }
    }
}
