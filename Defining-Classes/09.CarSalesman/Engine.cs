using System;
using System.Collections.Generic;
using System.Text;

namespace _09.CarSalesman
{
   public class Engine
    {
        public Engine(string model ,  string power , string displacement, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }
        public string Model { get; set; }
        public string Power { get; set; }
        public string Displacement { get; set; }
        public string Efficiency { get; set; }

    }
}
