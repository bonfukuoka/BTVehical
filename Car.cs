using System;
using System.Collections.Generic;
using System.Text;

namespace OBJ
{
    class Car : Vehicles
    {
        private string Type;
        private string Speed;
        private string Wheel;
        public Car(int id, string type , string speed , string wheel , string make , string model , string year)
        {
            this.Id = id;
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Type1 = type;
            this.Speed1 = speed;
            this.Wheel1 = wheel;
        }

        public string Type1 { get => Type; set => Type = value; }
        public string Speed1 { get => Speed; set => Speed = value; }
        public string Wheel1 { get => Wheel; set => Wheel = value; }
        public string toString()
        {
            return base.toString() + "Type : " + this.Type + " Speed : " + this.Speed + " Wheel : " + this.Wheel;
        }
    }
    
}
