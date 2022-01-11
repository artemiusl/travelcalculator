using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelLogicLayer
{
    public class OutSideTravel:Travel
    {
        public OutSideTravel() : base()
        {
            Name = "путешествие по США";
            LifePrice = 100000;
            TransportPrice = 100000 - (100000 / 100) * 5;
            ExcurPrice = 50000;
            VisaPrice = 15000;
        }
        public OutSideTravel(double insurancePrice) : base()
        {
            Name = "Экстрим путешествие по США";
            LifePrice = 100000;
            TransportPrice = 100000 - (100000 / 100) * 5;
            ExcurPrice = 50000;
            VisaPrice = 15000;
            InsurancePrice = insurancePrice;
        }
        public OutSideTravel(string name, double lifePrice, double transportPrice, double excurPrice, double visaPrice, double insurancePrice) : base()
        {
            Name = name.Length > 0 ? name : "Путешествие в США";
            LifePrice = lifePrice;
            TransportPrice = transportPrice;
            ExcurPrice = excurPrice;
            VisaPrice = visaPrice;
            InsurancePrice = insurancePrice;
        }

    }
}

