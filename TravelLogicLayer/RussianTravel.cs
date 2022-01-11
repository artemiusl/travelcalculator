using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelLogicLayer
{
    public class RussianTravel:Travel
    {
       public RussianTravel() : base(){
            Name = "Путешествие по РФ";
            LifePrice = 20000;
            TransportPrice = 5000;
            ExcurPrice = 10000;
        }
        public RussianTravel(double insurancePrice) : base()
        {
            Name = "Экстрим путешествие по РФ";
            LifePrice = 20000;
            TransportPrice = 5000 - (5000/100)*5;
            ExcurPrice = 10000;
            InsurancePrice = insurancePrice;
        }
        public RussianTravel(string name, double lifePrice, double transportPrice, double excurPrice, double insurancePrice) : base()
        {
            Name = name.Length > 0 ? name : "Путешествие по РФ";
            LifePrice = lifePrice;
            TransportPrice = transportPrice;
            ExcurPrice = excurPrice;
            InsurancePrice = insurancePrice;
        }

    }
}
