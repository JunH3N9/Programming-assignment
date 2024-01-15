using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG_assignment
{
    internal class Order
    {
        private int id { get; set; }
        public int Id { get; set; }

        public DateTime TimeReceived { get; set; }

        public DateTime? TimeFulfilled { get; set; }

        public List<IceCream> IceCreamList { get; set; }

        public Order() { }

        public Order(int id, DateTime timeReceived)
        {
            Id = id;
            TimeReceived = timeReceived;
        }
    }
}
