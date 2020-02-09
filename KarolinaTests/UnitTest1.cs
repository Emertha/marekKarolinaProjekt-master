using NUnit.Framework;
using System;
using marekKarolinaProjekt;


namespace KarolinaTests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Specyfiction_Empty_All_String_Throws_Exception()
        {
            Assert.Throws<ArgumentException>(
            () =>
            {
                new Specyfication(
                    "", " ", " "," "
                  );
            }
            );
        }

        [Test]
        public void TestMethod2()
        {
        }

        [Test]
        public void TestMethod3()
        {
        }
    }
}
