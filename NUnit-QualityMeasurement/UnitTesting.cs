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
        public void PerForm_TestCase_Null_Check()
        {
            Feet feet = new Feet();
            bool result = feet.Equals(null);
            Assert.IsTrue(result);
        }

        [Test]
        public void Perform_TestCase_Ref_Check()
        {
            Feet feet = new Feet();
            bool result = feet.Equals(feet);
            Assert.IsTrue(result);
        }

        [Test]
        public void Perform_TestCase_Type_Check()
        {
            Feet feet = new Feet();
            bool result = feet.Equals(new Feet());
            Assert.IsTrue(result);
        }

        [Test]
        public void Perform_Test_Value_Check()
        {
            Feet feet = new Feet(10);
            double actual = feet.CheckForEqualValue();
            Assert.AreEqual(10, actual);
        }

        [Test]
        public void Give_0_Inch_Return_Equal()
        {
            Inch inch = new Inch(10);
            double result = inch.CheckForEqualValue();
            Assert.AreEqual(10, result);
        }

        [Test]
        public void PerForm_Test_For_Inch_Null_Check()
        {
            Inch inch = new Inch (0);
            bool result = inch.Equals(null);
            Assert.IsTrue(result);
        }

        [Test]
        public void Perform_Test_Inch_Ref_Check()
        {
            Inch inch = new Inch();
            bool result = inch.Equals(inch);
            Assert.IsTrue(result);
        }

    }
}