using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelLogicLayer;

namespace WFTravelSolution
{
    public partial class Form1 : Form
    {

        Travel travel;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (comboBox1.Text)
            {
                case "РФ":
                    travel = new RussianTravel();
                    break;
                case "Зарубеж":
                    travel = new OutSideTravel();
                    break;
                case "Экстрим зарубеж":
                    travel = new OutSideTravel(3000);
                    break;
                case "Экстрим РФ":
                    travel = new RussianTravel(1000);
                    break;
            }
            outToUserInfo(travel);
        }

        private void outToUserInfo(Travel travel)
        {
            nameTravel.Text = travel.Name;
            lifeLabel.Text = travel.LifePrice.ToString();
            transportLabel.Text = travel.TransportPrice.ToString();
            excursLabel.Text = travel.ExcurPrice.ToString();
            visaLabel.Text = travel.VisaPrice > 0 ? travel.VisaPrice.ToString() : "0";
            insuranceLabel.Text = travel.InsurancePrice > 0 ? travel.InsurancePrice.ToString() : "0";
            priceTravelLabel.Text = travel.getPrice().ToString();
        }
    }
}
