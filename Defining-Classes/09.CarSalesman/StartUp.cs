using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace _09.CarSalesman
{
  public  class StartUp
    {
      public  static void Main(string[] args)
      {
          var engineCount = int.Parse(Console.ReadLine());
          var engines = new List<Engine>();

          for (int i = 0; i < engineCount; i++)
          {
              var input = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .ToArray();
              var engineModel = input[0];
              var enginePower = input[1];
              var engineDisplacement = string.Empty;
              var engineEfficiency = string.Empty;
              if (input.Length > 2 && !char.IsLetter(input[2][0]))
              {
                  engineDisplacement = input[2];
              }
              else if (input.Length > 3 && char.IsLetter(input[3][0]))
              {
                  engineDisplacement = input[2];
              }
              else
              {
                  engineDisplacement = "n/a";
              }

              if (input.Length > 2 && char.IsLetter(input[2][0]))
              {
                  engineEfficiency = input[2];
              }
              else if (input.Length > 3 && char.IsLetter(input[3][0]))
              {
                  engineEfficiency = input[3];
              }
              else
              {
                  engineEfficiency = "n/a";
              }
                Engine stats = new Engine(engineModel,enginePower,engineDisplacement,engineEfficiency);
              engines.Add(stats);
          }

          int carCount = int.Parse(Console.ReadLine());
          var cars = new List<Car>();

          for (int i = 0; i < carCount; i++)
          {
              var carInput = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .ToArray();

              var carModel = carInput[0];
              var carEngine = carInput[1];
              var carWeight = string.Empty;
              var carColor = string.Empty;

              if (carInput.Length > 2 && !char.IsLetter(carInput[2][0]))
              {
                  carWeight = carInput[2];
              }
              else if (carInput.Length > 3 && char.IsLetter(carInput[3][0]))
              {
                  carWeight = carInput[2];
              }
              else
              {
                  carWeight = "n/a";
              }
              
              if (carInput.Length > 2 && char.IsLetter(carInput[2][0]))
              {
                  carColor = carInput[2];
              }
              else if (carInput.Length > 3 && char.IsLetter(carInput[3][0]))
              {
                  carColor = carInput[3];
              }
              else
              {
                  carColor = "n/a";
              }
                Engine engine = engines.FirstOrDefault(e => e.Model == carEngine);
              var car = new Car(carModel,engine,carWeight,carColor);
              cars.Add(car);
          }

          foreach (var car in cars)
          {
              Console.WriteLine(car);
          }
      }
    }
}
