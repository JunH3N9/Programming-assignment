using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG_assignment
{
    internal class PointCard
    {
        private int points;
        public int Points { get; set; }

        private int punchcard;
        public int PunchCard { get; set; }

        private int tier;
        public string Tier { get; set; }

        public PointCard() { }

        public PointCard(int points, int punchCard)
        {
            points = Points;
            punchCard = PunchCard;
        }

        public void AddPoints(double amount)
        {
            int PointsEarned = (int)Math.Floor(amount * 0.72);
            MembershipUpgrade();
            Punch();
        }

        public double RedeemPoints(int RedeemPoints)
        {
            if (Tier == "Silver" && RedeemPoints > 0)
            {
                double discount = RedeemPoints * 0.02;
                Points -= RedeemPoints;
                return discount;
            }

            else if (Tier == "Gold" && RedeemPoints > 0)
            {
                double discount = RedeemPoints * 0.02;
                Points -= RedeemPoints;
                return discount;
            }

            else
            {
                return 0;
            }
        }

        public void MembershipUpgrade()
        {
            if (Points >= 100 && Tier != "Gold")
            {
                Tier = "Gold";
            }

            else if (Points >= 50 && Tier != "Silver")
            {
                Tier = "Silver";
            }
        }

        public void Punch()
        {
            PunchCard += 1;
            if (PunchCard == 10)
            {

                PunchCard = 0;
            }
            
        }
    }
}
