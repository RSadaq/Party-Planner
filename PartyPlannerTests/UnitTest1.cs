using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartyPlanner;

namespace PartyPlannerTest
{
    [TestClass]
    
    public class UnitTest1
    {
        [TestMethod]
        public void TestDrinkCostIsCorrect()
        {
            const int NUM_OF_GUESTS = 2;
            Party p = new Party();
            p.drinksCost = p.drinkPrices["Alcoholic"];
            Assert.IsNotNull(p.drinksCost);
            Assert.AreEqual(p.CostOfParty(), 0);
            p.noOfGuests = NUM_OF_GUESTS;
            Assert.AreEqual(p.CostOfParty(), p.drinksCost * NUM_OF_GUESTS);

        }

        [TestMethod]
        public void TestMenuCostIsCorrect()
        {
            const int NUM_OF_GUESTS = 5;
            Party p = new Party();
            p.foodCost = p.foodPrices["Meat"];
            Assert.IsNotNull(p.foodCost);
            Assert.AreEqual(p.CostOfParty(), 0);
            p.noOfGuests = NUM_OF_GUESTS;
            Assert.AreEqual(p.CostOfParty(), p.foodCost * NUM_OF_GUESTS);
        }

        [TestMethod]
        public void TestEntertainmentCostIsCorrect()
        {
            Party p = new Party();
            p.entertainmentCost = p.entertainmentPrices["DJ"];
            Assert.IsNotNull(p.entertainmentCost);
            Assert.AreEqual(p.CostOfParty(), p.entertainmentCost);

        }

        [TestMethod]
        public void TotalCostCalculated()
        {
            const int NUM_OF_GUESTS = 5;
            Party p = new Party();
            p.drinksCost = p.drinkPrices["Alcoholic"];
            p.foodCost = p.foodPrices["Meat"];
            p.entertainmentCost = p.entertainmentPrices["DJ"];
            p.decorations = true;
            p.noOfGuests = NUM_OF_GUESTS;
            Assert.AreEqual(p.CostOfParty(), (p.drinksCost + p.foodCost) * NUM_OF_GUESTS + p.entertainmentCost + Party.decorationsCost);

        }
    }
}
