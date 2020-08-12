using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDK
{
    class Play : Ticket
    {
        bool additionalPopcorn = false;

        public Play(string name, string person, int seat, int code, DateTime date, bool popcorn) 
            :base(name, person, seat, code, date)
        {
            AdditionalPopcorn = popcorn;
        }

        public bool AdditionalPopcorn 
        {
            get { return additionalPopcorn; }
            set { additionalPopcorn = value; }
        }


        public override string ToString()
        {
            return base.ToString() +
                "\n\tDo you want popcorn?\t" + AdditionalPopcorn;

            //return "Destination: " + Destination +
            //   "\nTotal Miles: " + DistanceTraveled +
            //    "\nFuel Consumed: " + GallonsConsumed.ToString("f1") + " gallons" +
            //    "\nCost: " + FuelCost.ToString("c") +
            //    "\nMPG: " + MilesPerGallon().ToString("f0") +
            //    "\nCost Per Mile: " + CostPerMile().ToString("c");
        }
    }
}
