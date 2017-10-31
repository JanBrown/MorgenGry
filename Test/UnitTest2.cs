using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MorgenGry;

namespace Test
{
    [TestClass]
    public class UnitTest2
    {
        Book b1, b2, b3;
        Amulet a11, a12, a13;
        Course c111, c112;


        [TestInitialize]
        public void Init()
        {
            b1 = new Book("1");
            b2 = new Book("2", "Falling in Love with Yourself");
            b3 = new Book("3", "Spirits in the Night", 123.55);

            a11 = new Amulet("11");
            a12 = new Amulet("12", Level.high);
            a13 = new Amulet("13", Level.low, "Capricorn");

            c111 = new Course("Eufori med røg");
            c112 = new Course("Nuru Massage using Chia Oil", 157);
        }

        [TestMethod]
        public void TestGetValueForBook()
        {
            Assert.AreEqual(Utility.GetValueOfBook(b1), 0.0);
            Assert.AreEqual(Utility.GetValueOfBook(b2), 0.0);
            Assert.AreEqual(Utility.GetValueOfBook(b3), 123.55);
        }

        [TestMethod]
        public void TestGetValueForAmulet()
        {
            Assert.AreEqual(Utility.GetValueOfAmulet(a11), 20.0);
            Assert.AreEqual(Utility.GetValueOfAmulet(a12), 27.5);
            Assert.AreEqual(Utility.GetValueOfAmulet(a13), 12.5);
        }
    }

}
