using Lab05Lib;
using System;

namespace Lab05
{
    public class MyClass
    {

        static void Main(string[] args)
        {
            Console.Write("Введiть назву краiни: ");
            string sCountry = Console.ReadLine();
            Console.Write("Введіть назву міста: ");
            string sCity = Console.ReadLine();
            Console.Write("Введiть назву континента: ");
            string sName = Console.ReadLine();
            Console.Write("Введiть назву регiону: ");
            string sRegion = Console.ReadLine();
            Console.Write("Введiть кiлькiсть населення: ");
            string sPopulation = Console.ReadLine();
            Console.Write("Введiть рiчний дохiд: ");
            string sYearIncome = Console.ReadLine();
            Console.Write("Введiть площу, кв. км: ");
            string sSquare = Console.ReadLine();
            Console.Write("Чи є у країна порт? (y-так, n-нi): ");
            ConsoleKeyInfo keyHasPort = Console.ReadKey();
            Console.WriteLine();
            Console.Write("Чи є у країна аеропорт? (y-так, n-нi): ");
            ConsoleKeyInfo keyHasAirport = Console.ReadKey();
            Console.WriteLine();
            Town OurTown = new Town();
            OurTown.Name = sName;
            OurTown.City = sCity;
            OurTown.Country = sCountry;
            OurTown.Region =
            sRegion;
            OurTown.Population = int.Parse(sPopulation);
            OurTown.YearIncome =
            double.Parse(sYearIncome);
            OurTown.Square = double.Parse(sSquare);
            OurTown.HasPort = keyHasPort.Key == ConsoleKey.Y ? true : false;
            OurTown.HasAirport = keyHasAirport.Key == ConsoleKey.Y ? true : false;
            double YearIncomePerInhabitant = OurTown.GetYearIncomePerInhabitant();
            Console.WriteLine();
            Console.WriteLine("     ");
            Console.WriteLine("Данi про об`ект: ");
            Console.WriteLine("Країна: " + OurTown.Country);
            Console.WriteLine("Місто: " + OurTown.City);
            Console.WriteLine("Континент: " + OurTown.Name);
            Console.WriteLine("Регiон: " + OurTown.Region);
            Console.WriteLine("Кiлькiсть населення:" + OurTown.Population.ToString());
            Console.WriteLine("Рiчний дохiд: " + OurTown.YearIncome.ToString(" 0.00 "));
            Console.WriteLine("Площа: " + OurTown.Square.ToString("0.000 "));
            Console.WriteLine(OurTown.HasPort ? "У країні є порт" : "У країні нема порту");
            Console.WriteLine(OurTown.HasAirport ? "У країні є аеропорт " : " У країні нема аеропорту");
            Console.ReadKey();
        }
        
    }

}