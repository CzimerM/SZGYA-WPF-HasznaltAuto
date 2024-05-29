using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZGYA_WPF_HasznaltAuto
{
    enum Fuel
    {
        PETROL = 0,
        DIESEL = 1,
        ELECTRIC = 2
    }

    enum Form
    {
        CABRIO = 0,
        OFF_ROAD = 1,
        COUPE = 2,
        HATCHBACK = 3,
        WAGON = 4
    }

    internal class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public Form FormFactor { get; set; }
        public Fuel FuelType { get; set; }
        public int ReleaseYear { get; set; }
        public double Price { get; set; }   
        public string Description { get; set; }
        public string ImgPath { get; set; }

    }
}
