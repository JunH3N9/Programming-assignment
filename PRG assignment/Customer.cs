using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG_assignment
{
    internal class Customer
    {
        private string name { get; set; }
        public string Name { get; set; }

        private int memberId { get; set; }
        public int MemberId { get; set; }

        private DateTime dob { get; set; }
        public DateTime Dob { get; set; }

        public Order Currentorder { get; set; }

        public List<Order> OrderHistory { get; set; }

        public PointCard Rewards { get; set; }

        public Customer() { }

        public Customer(string name, int memberId, DateTime dob)
        {
            Name = name;
            MemberId = memberId;
            Dob = dob;
        }

        public Order MakeOrder(int orderId, DateTime timeReceived)
        {
            Order order = new Order(orderId, timeReceived);
            Currentorder = order;
            OrderHistory.Add(order);

            if (IsBirthday())
            {
                int birthdayCount = 0;
                foreach (Order customerOrder in OrderHistory)
                {
                    if (order.TimeReceived.Date == Dob.Date)
                    {
                        birthdayCount += 1;
                        if (birthdayCount > 1)
                        {
                            break;
                        }
                    }
                }
                if (birthdayCount == 1)
                {
                    double amount = 0;
                }
            }
            return order;
        }

        public bool IsBirthday()
        {
            return DateTime.Now.Month == Dob.Month && DateTime.Now.Day == Dob.Day;
        }
    }
}
