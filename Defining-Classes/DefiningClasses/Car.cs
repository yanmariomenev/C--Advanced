using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
   public class Car
   {

       public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
           : this()
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            //TravelledDistance = travelledDistance;
        }

        public Car()
        {
            TravelledDistance = 0;
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public void Drive(double distance)
        {
            if (FuelConsumptionPerKilometer * distance > FuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                FuelAmount -= FuelConsumptionPerKilometer * distance;
                TravelledDistance += distance;
            }
        }

    }
}
