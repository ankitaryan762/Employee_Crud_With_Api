using NUnit.Framework;
using QualityMeasurement;

namespace NUnit_QualityMeasurement
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Given_0_Feet_WhenAnalyze_Should_Return_Equal()
        {
            Feet feet = new Feet(10);
            double actual = feet.CheckForEqualValue();
            Assert.AreEqual(10, actual);
        }

        [Test]
        public void PerForm_TestCase_For_Null_Check()
        {
            Feet feet = new Feet();
            bool result = feet.Equals(null);
            Assert.IsTrue(result);
        }



    }
}