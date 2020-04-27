using System;

namespace _02.Tuple
{
   public class Program
    {
      public  static void Main(string[] args)
      {
          var personInfo = Console.ReadLine()
              .Split();
          var beerInfo = Console.ReadLine()
              .Split();
          var numbersInfo = Console.ReadLine()
              .Split();
          var personName = personInfo[0] +" " + personInfo[1];
          var personStreet = personInfo[2];
          var personTown = personInfo[3];
          if (personInfo.Length > 4)
          {
              personTown = personInfo[3]+ " " + personInfo[4];
          }
          var personTuple = new Tuple<string, string , string>(personName, personStreet , personTown);

          var personBeerName = beerInfo[0];
          var amountOfBeer =int.Parse(beerInfo[1]);
          var drunkOrNot = string.Empty;

          if (beerInfo[2] == "drunk")
          {
              drunkOrNot = "True";
          }
          else
          {
              drunkOrNot = "False";
          }
          var personBeer = new Tuple<string , int , string>(personBeerName, amountOfBeer, drunkOrNot);

          string Myname = numbersInfo[0];
          var myDouble = double.Parse(numbersInfo[1]);
          var bankName = numbersInfo[2];
          var numbersTuple = new Tuple<string, double, string>(Myname,myDouble,bankName);

          Console.WriteLine(personTuple.GetInfo());
          Console.WriteLine(personBeer.GetInfo());
          Console.WriteLine(numbersTuple.GetInfo());
        }
    }
}
