using System;
using System.Collections.Generic;
using System.Text;

namespace OBJ
{
    class Bike :Vehicles
    {
        private string Type;
        private string Speed;
        private string wheel;
        public Bike(int id, string type, string speed, string wheel, string make, string model, string year)
        {
            this.Id = id;
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Type = type;
            this.Speed = speed;
            this.wheel = wheel;
        }

        public string Type1 { get => Type; set => Type = value; }
        public string Speed1 { get => Speed; set => Speed = value; }
        public string Wheel { get => wheel; set => wheel = value; }

        public string toString()
        {
            return base.toString() + " Type : " +this.Type + " Speed : " +this.Speed +" Wheel : " + this.wheel;
        }
    }
}
