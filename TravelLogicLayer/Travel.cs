using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelLogicLayer
{
    public abstract class Travel:iTravel
    {
        private string name;
        private double lifePrice;
        private double transportPrice;
        private double visaPrice;
        private double insurancePrice;
        private double excursePrice;
        public Travel()
        {

        }

        public Travel(string name, double lifePrice, double transportPrice, double excursePrice, double visaPrice, double insurancePrice)
        {
            this.name = name;
            this.lifePrice = lifePrice;
            this.transportPrice = transportPrice;
            this.visaPrice = visaPrice;
            this.insurancePrice = insurancePrice;
            this.excursePrice = excursePrice;
        }
        public string Name { get => name; set => name = value; }
        public double LifePrice { get => lifePrice; set => lifePrice = value; }
        public double TransportPrice { get => transportPrice; set => transportPrice = value; }
        public double VisaPrice { get => visaPrice; set => visaPrice = value; }
        public double InsurancePrice { get => insurancePrice; set => insurancePrice = value; }
        public double ExcurPrice { get => excursePrice; set => excursePrice = value; }
        
        public double getPrice()
        {
            return lifePrice + transportPrice + visaPrice + insurancePrice;
        }
    }
}
