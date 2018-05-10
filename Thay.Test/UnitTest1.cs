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
            Item HealthPotion = new Item("has been added to your inventory.", "Potion of Healing.", 20.50f, 3, 10.0f, "Heals player.", "Potions made from ancient times.");

            Assert.AreEqual("has been added to your inventory.",HealthPotion.OnPickUp);
            
        }

        [TestMethod]
        public void ConsumablesInterfaceTest()
        {
            Consumables ABPotion = new Consumables("has been added to your inventory.", "Potion of strength.", 30.10f, 4, 12.0f, "Increases attack damage", " tonic once used to give the strength of gods to mortals.", 10);

            Assert.AreEqual(10, ABPotion.Duration);
        }
    }
}
