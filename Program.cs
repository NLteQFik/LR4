// See https://aka.ms/new-console-template for more information
using LR4;

CargoCompany ex1 = CargoCompany.GetInstanceCargoCompany();
CargoCompany ex2 = CargoCompany.GetInstanceCargoCompany(123.23, "RPS", 17);

Console.WriteLine("Profit of company {0} is {1}", ex1.CompanyName, ex1.calculateProfit());
Console.WriteLine("Profit of company {0} is {1}", ex2.CompanyName, ex2.calculateProfit());

ex1.CompanyName = "Gruzoperevozki";
ex1.Mass = 58.23;
ex1.CurrentTariffPrice = 101.3;

ex2.decreaseTariff(15.03);

Console.WriteLine("Profit of company {0} is {1}", ex1.CompanyName, ex1.calculateProfit());
Console.WriteLine("Profit of company {0} is {1}", ex2.CompanyName, ex2.calculateProfit());
