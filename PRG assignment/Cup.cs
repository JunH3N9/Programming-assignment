using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG_assignment
{
    internal class Cup : IceCream
    {
        public Cup() { }

        public Cup(string option, int scoops, List<Flavour> Flavours, List<Topping> Topping) 
        {
            Option = option;
            Scoops = scoops;
            

        }
    }
}
