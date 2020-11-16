using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WarGames;


namespace JustTests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethoAxeLoosesDurabilityAfterAttackd1()
        {
            Axe axe = new Axe(10);
            Dummy dummy = new Dummy(10);

            axe.Attack(dummy);

            Assert.AreEqual(axe.DurabilityPoints, 9,"Axe Durability doesn't change after attack.");

        }

        [TestMethod]
        public void DummyTests()
        {
            Axe axe = new Axe(8);
            Dummy dummy = new Dummy(1);

            axe.Attack(dummy);
            axe.Attack(dummy);
            axe.Attack(dummy);
            Assert.AreEqual(axe.DurabilityPoints, 9, "Axe Durability doesn't change after attack.");
        }
    }
}
