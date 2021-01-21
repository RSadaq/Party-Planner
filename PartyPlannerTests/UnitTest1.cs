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
            Assert.AreEqual(p.DrinksCost, 0);
            p.ItemSelected("drink", p.drinkPrices["Alcoholic"]);       
            Assert.IsNotNull(p.DrinksCost);
            Assert.AreEqual(p.CostOfParty(), 0);
            p.GetNoOfGuests(NUM_OF_GUESTS);
            Assert.AreEqual(p.CostOfParty(), p.DrinksCost * NUM_OF_GUESTS);

        }

        [TestMethod]
        public void TestMenuCostIsCorrect()
        {
            const int NUM_OF_GUESTS = 5;
            Party p = new Party();
            Assert.AreEqual(p.FoodCost, 0);
            Assert.AreEqual(p.CostOfParty(), 0);
            Assert.IsNotNull(p.foodPrices);
            p.ItemSelected("food", p.foodPrices["Vegan"]);
            p.GetNoOfGuests(NUM_OF_GUESTS);
            Assert.AreEqual(p.CostOfParty(), p.FoodCost * NUM_OF_GUESTS);
        }

        [TestMethod]
        public void TestEntertainmentCostIsCorrect()
        {
            Party p = new Party();
            Assert.IsNotNull(p.entertainmentPrices);
            Assert.AreEqual(p.CostOfParty(), 0);
            Assert.AreEqual(p.EntertainmentCost, 0);
            p.ItemSelected("entertainment", p.entertainmentPrices["DJ"]);
            Assert.AreEqual(p.CostOfParty(), p.EntertainmentCost);

        }

        [TestMethod]
        public void TotalCostCalculated()
        {
            const int NUM_OF_GUESTS = 5;
            Party p = new Party();
            p.ItemSelected("drink", p.drinkPrices["Alcoholic"]);
            p.ItemSelected("food", p.foodPrices["Vegan"]);
            p.ItemSelected("entertainment", p.entertainmentPrices["DJ"]);
            p.DecorationsRequired(true);
            p.GetNoOfGuests(NUM_OF_GUESTS); 
            Assert.AreEqual(p.CostOfParty(), (p.DrinksCost + p.FoodCost) * NUM_OF_GUESTS + p.EntertainmentCost + Party.decorationsCost);
        }
    }
}
