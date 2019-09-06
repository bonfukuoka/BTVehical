using System;
using System.Collections.Generic;
using System.Text;

namespace OBJ
{
    class Vehicles
    {
        private string _make;
        private string _model;
        private string _year;
        private int _id;
        public Vehicles()
        {

        }
        public Vehicles(int id, string make, string model, string year)
        {
            _id = id;
            _make = make;
            _model = model;
            _year = year;
        }

        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }
        public string Year { get => _year; set => _year = value; }
        public int Id { get => _id; set => _id = value; }

        public string toString()
        {
            return "ID : " +this._id + " Make in : " + this.Make + " Model : " + this.Model + " Year : " + this.Year;
        }
    }
}
