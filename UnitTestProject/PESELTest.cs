using NUnit.Framework;
using NunitCore;
using System;
namespace UnitTestProject
{
    class PESELTest
    {
        
        [Test]
        public void IsInBetween()
        { 
            string pesel = "98010305721";
            DiscountFromPeselComputer mss = new DiscountFromPeselComputer();
            Assert.IsTrue(mss.HasDiscount(pesel), "I should not get a discount");
        }
        [Test]
        public void MoreThan65()
        {
            string pesel = "23010305721";
            DiscountFromPeselComputer mss = new DiscountFromPeselComputer();
            Assert.IsFalse(mss.HasDiscount(pesel), "I should get a discount");
        }
        
        [Test]
        public static void Below18()//ten test nie przechodzi dla przykladowego, poniewaz gdy ktos sie urodzil po 2000 roku, jest inny format daty (+20 do miesiaca)
        {
            string pesel = "04271405721";
            DiscountFromPeselComputer mss = new DiscountFromPeselComputer();
            Assert.IsFalse(mss.HasDiscount(pesel), "I should get a discount");
        }
    }
}
