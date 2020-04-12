using System;
using Homework_Class8_Car.Enums;

namespace Homework_Class8_Car.Entities
{
    public class ElectricCar : Car
    {
        public ElectricCar()
        {
            Type = EngineType.Electric;
            BatteryCapacity = 100;
        }

        private EngineType Type;
        private int BatteryCapacity { get; set; }

        private int BatteryUsage { get; set; }

        public void Drive(int distance)
        {
            BatteryUsage = distance * (int)CarConsumption / 10;

            int batteryExceed = BatteryUsage - BatteryCapacity;

            if (BatteryUsage <= BatteryCapacity)
                Console.WriteLine($"You can drive! Battery Usage:{BatteryUsage}%");
            else if (BatteryUsage > BatteryCapacity)
                Console.WriteLine($"The car can't drive, " +
                    $"Battery will exceed: {batteryExceed}%");
        }

        public void Recharge(int minutes)
        {
            int percentageOfBatteryRecharge = minutes / 10;
            int batteryToRecharge = BatteryCapacity - BatteryUsage;

            int batteryExceed = BatteryUsage - BatteryCapacity;
            if (batteryExceed > 0)
                Console.WriteLine("You can't charge more then 100%");
            else if (percentageOfBatteryRecharge >= batteryToRecharge && BatteryUsage <= BatteryCapacity)
                Console.WriteLine($"Can't charge longer that {batteryToRecharge * 10} minutes");
            else
                Console.WriteLine($"Your battery is charged {percentageOfBatteryRecharge}%");
        }
    }
}
