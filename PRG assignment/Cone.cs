using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG_assignment
{
    internal class Cone: IceCream
    {
        private bool dipped;
        public bool Dipped { get; set; }

        public Cone() { }   
        public Cone(string _option, int _scoops, List<Flavour> _flavours, List<Topping> _toppings,bool _dipped) 
        { 
            Option = _option;
            Scoops = _scoops;
            Flavours = _flavours;
            Toppings = _toppings;
            Dipped = _dipped;
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
