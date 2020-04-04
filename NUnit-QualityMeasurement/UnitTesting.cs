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
            LengthConversion lengthConversion = new LengthConversion("Feet", 10);
            Feet feet = new Feet(10);
            double expected = feet.CheckForEqualValue();
            double actual = lengthConversion.CheckForEqualValue();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PerForm_TestCase_Null_Check()
        {
            LengthConversion lengthConversion = new LengthConversion("Feet");
            bool result = lengthConversion.Equals(null);
            Assert.IsTrue(result);
        }

        [Test]
        public void Perform_TestCase_Ref_Check()
        {
            LengthConversion lengthConversion = new LengthConversion("Feet");
            bool result = lengthConversion.Equals(lengthConversion);
            Assert.IsTrue(result);
        }

        [Test]
        public void Perform_TestCase_Type_Check()
        {
            LengthConversion lengthConversion = new LengthConversion("Feet");
            bool result = lengthConversion.Equals(new LengthConversion());
            Assert.IsTrue(result);
        }

        [Test]
        public void Perform_Test_Value_Check()
        {
            LengthConversion lengthConversion = new LengthConversion("Feet", 10);
            Feet feet = new Feet(10);
            double actual = lengthConversion.CheckForEqualValue();
            double expected = feet.CheckForEqualValue();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Give_0_Inch_Return_Equal()
        {
            LengthConversion lengthConversion = new LengthConversion("Inch", 55);
            Inch inch = new Inch(55);
            double expected = inch.CheckForEqualValue();
            double actual = lengthConversion.CheckForEqualValue();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PerForm_Test_For_Inch_Null_Check()
        {
            LengthConversion lengthConversion = new LengthConversion("Inch", 0);
            bool result = lengthConversion.Equals(null);
            Assert.IsTrue(result);
        }

        [Test]
        public void Perform_Test_Ref_Check()
        {
            LengthConversion lengthConversion = new LengthConversion("Inch");
            bool result = lengthConversion.Equals(lengthConversion);
            Assert.IsTrue(result);
        }

    }
}