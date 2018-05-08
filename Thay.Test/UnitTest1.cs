using System;
using TheDungeonsOfThay;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Thay.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ItemInterfaceTest()
        {
            Item HealthPotion = new Item("Potion of Healing", 20.50f, 3, 10.0f, "Heals player", "Potions made from ancient times");

            Assert.AreEqual(20.50f,HealthPotion.GoldValue);
            
        }
    }
}
