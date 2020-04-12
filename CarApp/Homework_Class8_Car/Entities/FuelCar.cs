using System;
using Homework_Class8_Car.Enums;

namespace Homework_Class8_Car.Entities
{
    public class FuelCar : Car
    {
        public FuelCar()
        {
            Type = EngineType.Petrol;
            FuelCapacity = 50;
        }
        private EngineType Type;
        private int FuelCapacity { get; set; }
        private int CurrentFuel { get; set; }

        public void Drive(int distance)
        {
            int UsedFuel = distance * (int)CarConsumption / 10;

            CurrentFuel = FuelCapacity - UsedFuel;

            if (UsedFuel > FuelCapacity)
                Console.WriteLine($"The car can't drive and use more then {FuelCapacity} litres");
            else if(CurrentFuel <= FuelCapacity)
                Console.WriteLine($"For {distance} km, used fuel: {UsedFuel} litres");
        }

        public void Refuel(int fuel)
        {
            int litresToRefuel = FuelCapacity - CurrentFuel;
            if (fuel > litresToRefuel)
                Console.WriteLine($"Can't refuel more than {litresToRefuel} litres");
            else if(fuel <= litresToRefuel)
                Console.WriteLine($"Your car's tank is refueled with {fuel} litres");
        }
    }
}
