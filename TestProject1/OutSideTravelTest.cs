using NUnit.Framework;
using TravelLogicLayer;

namespace TestProject1
{
    public class OutSideTravelTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void OutSideTravelTestPrice()
        {
            Travel travel = new OutSideTravel();
            Assert.AreEqual(travel.getPrice(), 210000);
        }
        [Test]
        public void OutSideTravelTestPriceExtreme()
        {
            Travel travel = new OutSideTravel(3000);
            Assert.AreEqual(travel.getPrice(), 213000);
        }
        [Test]
        public void OutSideTravelTestName()
        {
            Travel travel = new OutSideTravel();
            Assert.True(travel.Name.Equals("путешествие по США"));
        }
        [Test]
        public void OutSideTravelTestVise()
        {
            Travel travel = new OutSideTravel();
            Assert.True(travel.VisaPrice > 0);
        }
    }
}
