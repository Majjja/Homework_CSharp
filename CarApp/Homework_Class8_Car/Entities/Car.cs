using System;
using Homework_Class8_Car.Enums;
using GenerationOfId;

namespace Homework_Class8_Car.Entities
{
    public class Car
    {
        public Car()
        {
            GenerateId.RandomGenerateId();
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Doors { get; set; }
        public int TopSpeed { get; set; }

        public Consumption CarConsumption { get; set; }

        public void InfoAboutTheCar()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Doors: {Doors}, Top speed: {TopSpeed}" +
                $" Consumption: {CarConsumption}");
        }
    }
}
