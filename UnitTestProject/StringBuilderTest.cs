using NUnit.Framework;
using NunitNS;

namespace UnitTestProject
{
    public class StringBuilderExceptionTest
    {
        [Test]
        public void FirstStringNull()
        {
            string value = null;
            StringBuilder text = new StringBuilder(value);
            value = "Ala";
            text.Connect(value);
            Assert.IsNull(text.ReturnString(), "{0} Nie jest nullem.",text.ReturnString());
        }
        [Test]
        public void SecondStringNull()
        {
            string value = "Ala";
            StringBuilder text = new StringBuilder(value);
            value = null;
            text.Connect(value);
            Assert.IsNull(text.ReturnString(), "{0} Nie jest nullem.", text.ReturnString());
        }
        [Test]
        public void BothStrings()
        {
            string value = "Ala";
            StringBuilder text = new StringBuilder(value);
            value = " ma kota";
            text.Connect(value);
            Assert.AreEqual("Ala ma kota", text.ReturnString(), "{0} jest ró¿ne od: Ala ma kota", text.ReturnString());
        }
    }
}
