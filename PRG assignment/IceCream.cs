using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG_assignment
{
    internal class IceCream
    {
        private string option { get; set; }
        public string Option { get; set; }

        private int scoops { get; set; } 
        public int Scoops { get; set; }

        public List<Flavour> Flavours { get; set; }

        public List<Topping> Toppings { get; set; }

        public IceCream() { }

        public IceCream(string option, int scoops, List<Flavour> flavours, List<Topping> toppings)
        {
            Option = option;
            Scoops = scoops;
            Flavours = flavours;
            Toppings = toppings;
        }

        public double CalculatePrice()
        {
            return 0;
        }
    }
}