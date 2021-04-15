using NUnit.Framework;
using NunitCoreNS;
using System;
namespace UnitTestProjectException
{
    public class StringBuilderExceptionTest
    {
        [Test]
        public void FirstStringNullException()
        {
            string value = null;
            StringBuilderException text = new StringBuilderException(value);
            value = "Ma Kota";
            try
            {
                text.Connect(value);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.Pass();
            }
        }
        public void AddedStringNullException()
        {
            string value = "Ala";
            StringBuilderException text = new StringBuilderException(value);
            value = null;
            try
            {
                text.Connect(value);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.Pass();
            }
        }
        [Test]
        public void BothStrings()
        {
            string value = "Ala";
            StringBuilderException text = new StringBuilderException(value);
            value = " ma kota";
            text.Connect(value);
            Assert.AreEqual("Ala ma kota", text.ReturnString(), "{0} jest różne od: Ala ma kota", text.ReturnString());
        }
    }
}
