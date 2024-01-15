using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG_assignment
{
    internal class Topping
    {
        private string type { get; set; }
        public string Type { get; set; }

        public Topping() { }

        public Topping(string type) { this.type = type;}

        public override string ToString() { return type;}

        
    }
}
