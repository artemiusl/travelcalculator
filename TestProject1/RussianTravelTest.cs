using NUnit.Framework;
using TravelLogicLayer;
namespace TestProject1
{
    public class RussianTravelTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RussianTravelTestPrice()
        {
            Travel travel = new RussianTravel();
            Assert.AreEqual(travel.getPrice(), 25000);
        }
        [Test]
        public void RussinExtremeTravleTestPrice()
        {
            Travel travel = new RussianTravel(1000);
            Assert.AreEqual(travel.getPrice(), 25750);
        }
        [Test]
        public void RussianTravelTestName()
        {
            Travel travel = new RussianTravel();
            Assert.True(travel.Name.Equals("Путешествие по РФ"));
        }
        [Test]
        public void RussianTravelTestNoVise()
        {
            Travel travel = new RussianTravel();
            Assert.AreEqual(travel.VisaPrice, 0);
        }
    }
}