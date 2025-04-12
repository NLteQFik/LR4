using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    internal class CargoCompany
    {
        private Tariff currentTariff;
        private string companyName;
        private double mass;

        public double CurrentTariffPrice
        {
            get { return currentTariff.Price; }
            set { currentTariff.Price = value; }
        }

        public string CompanyName
        { 
            get { return companyName; }
            set { companyName = value; }
        }

        public double Mass
        {
            get { return mass; }
            set { mass = value; }
        }

        private CargoCompany()
        { 
            currentTariff = new Tariff();
            companyName = string.Empty;
            mass = 0;
        }

        private CargoCompany(double price, string companyName, double mass)
        {
            currentTariff = new Tariff(price);
            this.companyName = companyName;
            this.mass = mass;
        }

        public static CargoCompany GetInstanceCargoCompany()
        {
            return new CargoCompany();
        }

        public static CargoCompany GetInstanceCargoCompany(double price, string companyName, double mass)
        {
            return new CargoCompany(price, companyName, mass);
        }

        public void increaseTariff(double amount)
        {
            currentTariff.increaseTariff(amount);
        }

        public void decreaseTariff(double amount)
        {
            currentTariff.decreaseTariff(amount);
        }

        public double calculateProfit()
        {
            return currentTariff.Price * mass;
        }
    }
}
