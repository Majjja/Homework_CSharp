using System;
using Homework_Class8_Car.Entities;
using Homework_Class8_Car.Enums;


namespace Homework_Class8_Car
{
    class Program
    {
        static void Main(string[] args)
        {
            var electricCar = new ElectricCar()
            {
                Brand = "i3",
                Model = "BMW",
                Doors = 5,
                TopSpeed = 150,
                CarConsumption = Consumption.Medium
            };

            electricCar.InfoAboutTheCar();
            electricCar.Drive(400);
            electricCar.Recharge(350);

            Console.WriteLine("---------------------------------------");

            var fuelCar = new FuelCar()
            {
                Brand = "A4",
                Model = "Audi",
                Doors = 5,
                TopSpeed = 200,
                CarConsumption = Consumption.High
            };

            fuelCar.InfoAboutTheCar();
            fuelCar.Drive(150);
            fuelCar.Refuel(47);

        }
    }
}
