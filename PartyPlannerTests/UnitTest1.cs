using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartyPlanner;

namespace PartyPlannerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDrinkChosenMatchesProperty()
        {
            Party p = new Party();
            p.Drink = "Alcoholic";
            Assert.IsNotNull(p.Drink);
            Assert.AreEqual(p.Drink, "Alcoholic");
            Assert.AreEqual(p.CostOfParty(), 0);
            p.NoOfGuests = 1;
            Assert.AreEqual(p.CostOfParty(), 7.95M);

            p.Drink = "Non-Alcoholic";
            Assert.AreEqual(p.Drink, "Non-Alcoholic");
            p.NoOfGuests = 0;
            Assert.AreEqual(p.CostOfParty(), 0);
            p.NoOfGuests = 1;
            Assert.AreEqual(p.CostOfParty(), 4.5M);
        }

        [TestMethod]
        public void MenuChosenMatchesProperty()
        {
            Party p = new Party();
            p.Menu = "Non-Vegan";
            Assert.IsNotNull(p.Menu);
            Assert.AreEqual(p.Menu, "Non-Vegan");
            p.NoOfGuests = 0;
            Assert.AreEqual(p.CostOfParty(), 0);
            p.NoOfGuests = 1;
            Assert.AreEqual(p.CostOfParty(), 12.95M);

            p.Menu = "Vegan";
            Assert.IsNotNull(p.Menu);
            Assert.AreEqual(p.Menu, "Vegan");
            p.NoOfGuests = 0;
            Assert.AreEqual(p.CostOfParty(), 0);
            p.NoOfGuests = 1;
            Assert.AreEqual(p.CostOfParty(), 9.95M);

            p.Menu = "Snacks";
            Assert.IsNotNull(p.Menu);
            Assert.AreEqual(p.Menu, "Snacks");
            p.NoOfGuests = 0;
            Assert.AreEqual(p.CostOfParty(), 0);
            p.NoOfGuests = 3;
            Assert.AreEqual(p.CostOfParty(), 10.5M);

        }

        [TestMethod]
        public void EntertainmentChosenMatchesProperty()
        {
            Party p = new Party();
            p.Entertainment = "DJ";
            Assert.IsNotNull(p.Entertainment);
            Assert.AreEqual(p.Entertainment, "DJ");
            Assert.AreEqual(p.CostOfParty(), 300M);

            p.Entertainment = "Live Entertainment";
            Assert.IsNotNull(p.Entertainment);
            Assert.AreEqual(p.Entertainment, "Live Entertainment");
            Assert.AreEqual(p.CostOfParty(), 751M);

            p.Entertainment = "Not required";
            Assert.IsNotNull(p.Entertainment);
            Assert.AreEqual(p.Entertainment, "Not required");
            Assert.AreEqual(p.CostOfParty(), 0);

        }

        [TestMethod]
        public void DecorationsChosenMatchProperty()
        {
            Party p = new Party();
            p.DecorationOption = "Yes";
            Assert.IsNotNull(p.DecorationOption);
            Assert.AreEqual(p.DecorationOption, "Yes");
            Assert.AreEqual(p.CostOfParty(), 200M);

            p.DecorationOption = "No";
            Assert.IsNotNull(p.DecorationOption);
            Assert.AreEqual(p.DecorationOption, "No");
            Assert.AreEqual(p.CostOfParty(), 0);

        }

        [TestMethod]
        public void TotalCostCalculated()
        {
            Party p = new Party();
            p.Drink = "Alcoholic";
            p.Menu = "Non-Vegan";
            p.Entertainment = "DJ";
            p.DecorationOption = "Yes";
            p.NoOfGuests = 0;
            Assert.AreEqual(p.CostOfParty(), 500M);
            p.NoOfGuests = 1;
            Assert.AreEqual(p.CostOfParty(), 520.9M);
            p.NoOfGuests = 5;
            Assert.AreEqual(p.CostOfParty(), 604.5M);
        }
    }
}
