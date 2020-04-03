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
            UnitCheck feet = new UnitCheck("Feet", 10);
            double actual = feet.CheckForEqualValue();
            Assert.AreEqual(10, actual);
        }

        [Test]
        public void PerForm_TestCase_Null_Check()
        {
            UnitCheck feet = new UnitCheck("Feet");
            bool result = feet.Equals(null);
            Assert.IsTrue(result);
        }

        [Test]
        public void Perform_TestCase_Ref_Check()
        {
            UnitCheck feet = new UnitCheck("Feet");
            bool result = feet.Equals(feet);
            Assert.IsTrue(result);
        }

        [Test]
        public void Perform_TestCase_Type_Check()
        {
            UnitCheck feet = new UnitCheck("Feet");
            bool result = feet.Equals(new UnitCheck());
            Assert.IsTrue(result);
        }

        [Test]
        public void Perform_Test_Value_Check()
        {
            UnitCheck feet = new UnitCheck("Feet", 10);
            double actual = feet.CheckForEqualValue();
            Assert.AreEqual(10, actual);
        }

        [Test]
        public void Give_0_Inch_Return_Equal()
        {
            UnitCheck inch = new UnitCheck("Inch", 15);
            double result = inch.CheckForEqualValue();
            Assert.AreEqual(15, result);
        }

        [Test]
        public void PerForm_Test_For_Inch_Null_Check()
        {
            UnitCheck inch = new UnitCheck("Inch", 0);
            bool result = inch.Equals(null);
            Assert.IsTrue(result);
        }

        [Test]
        public void Perform_Test_Inch_Ref_Check()
        {
            UnitCheck inch = new UnitCheck("Inch");
            bool result = inch.Equals(inch);
            Assert.IsTrue(result);
        }

        [Test]
        public void Perform_Test_Inch_Type_Check()
        {
            UnitCheck inch = new UnitCheck("Inch");
            bool result = inch.Equals(new UnitCheck());
            Assert.IsTrue(result);
        }

        [Test]
        public void Perform_Test__Ref_Check()
        {
            UnitCheck inch = new UnitCheck("Inch", 16);
            double result = inch.CheckForEqualValue();
            Assert.AreEqual(16, result);
        }

    }
}