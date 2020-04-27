using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
   public class StartUp
    {
      public static void Main(string[] args)
      {
          int numberOfCars = int.Parse(Console.ReadLine());
          var cars = new List<Car>();
          for (int i = 0; i < numberOfCars; i++)
          {
              var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
              string model = input[0];
              var fuel = double.Parse(input[1]);
              var distance = double.Parse(input[2]);
                Car car = new Car(model, fuel, distance);
                cars.Add(car);
            }

          while (true)
          {
              var commands = Console.ReadLine().Split().ToArray();
              if (commands[0] == "End")
              {
                  break;
              }
              string model = commands[1];
              double distance = double.Parse(commands[2]);

              int indexOfCar = cars.IndexOf(cars.Find(x => x.Model == model));
              cars[indexOfCar].Drive(distance);
          }

          foreach (var car in cars)
          {
              Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
          //DateModifier datesInput = new DateModifier(DateTime.Parse(Console.ReadLine()), DateTime.Parse(Console.ReadLine()));
          //var firstDate = DateTime.Parse(Console.ReadLine());
          //var secondDate = DateTime.Parse(Console.ReadLine());
          //DateModifier datesInput = new DateModifier(firstDate, secondDate);

          //var diffrenceInDays = datesInput.DateDifferenceInDays();
          //Console.WriteLine(diffrenceInDays);

          //int familyMembersCount = int.Parse(Console.ReadLine());
          //Family family = new Family();

          //  for (int i = 0; i < familyMembersCount; i++)
          //{
          //    var memberData = Console.ReadLine().Split();
          //    string memberName = memberData[0];
          //    int memberAge = int.Parse(memberData[1]);

          //    Person member = new Person(memberName , memberAge);
          //    family.AddMember(member);
          //}

          //  Person oldestFamilyMember = family.GetOldestMember();
          //  Console.WriteLine($"{oldestFamilyMember.Name} {oldestFamilyMember.Age}");

          //int peopleCount = int.Parse(Console.ReadLine());
          //var collection = new List<Person>();
          //for (int i = 0; i < peopleCount; i++)
          //{
          //    var personalInformation = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
          //    var name = personalInformation[0];
          //    var age = int.Parse(personalInformation[1]);
          //    if (age > 30)
          //    {
          //      Person validPerson = new Person(name, age);
          //      collection.Add(validPerson);
          //      continue;
          //    }
          //}

          //foreach (var item in collection.OrderBy(n => n.Name))
          //{
          //    Console.WriteLine($"{item.Name} - {item.Age}");
          //}
      }
    }
}
