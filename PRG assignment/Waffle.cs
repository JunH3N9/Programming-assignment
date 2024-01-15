using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace PRG_assignment
{
    internal class Waffle: IceCream
    {
        private string waffleFlavour;
        public string WaffleFlavour { get; set; }

        public Waffle() { }
        public Waffle(string _option, int _scoops, List<Flavour> _flavours, List<Topping> _toppings, string _waffle)
        {
            Option = _option;
            Scoops = _scoops;
            Flavours = _flavours;
            Toppings = _toppings;
            WaffleFlavour = _waffle;
        }
        public override double CalculatePrice()
        {
            return 0;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
