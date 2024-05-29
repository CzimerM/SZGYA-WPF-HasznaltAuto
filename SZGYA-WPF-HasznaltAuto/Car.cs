using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Markup;

namespace SZGYA_WPF_HasznaltAuto
{
    public enum Fuel
    {
        [Description("Mindegy")]
        ALL = 0,
        [Description("Benzin")]
        PETROL,
        [Description("Dízel")]
        DIESEL,
        [Description("Elektromos")]
        ELECTRIC 
    }

    public enum Form
    {
        [Description("Mindegy")]
        ALL = 0,
        [Description("Kabrió")]
        CABRIO,
        [Description("Terepjáró")]
        OFF_ROAD,
        [Description("Coupe")]
        COUPE,
        [Description("Ferdehátú")]
        HATCHBACK,
        [Description("Kombi")]
        WAGON,
    }
    

    internal class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public string Name { get; set; }

        public Form FormFactor { get; set; }
        public Fuel FuelType { get; set; }
        public int ReleaseYear { get; set; }
        public double Price { get; set; }   
        public string Description { get; set; }
        public string ImgPath { get; set; }

    }
}
