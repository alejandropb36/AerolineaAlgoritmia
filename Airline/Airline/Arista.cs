using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class Arista
    {
        string origin;
        string destination;
        int cost;

        public Arista ()
        {
            cost = -1;
        }

        public Arista(string origin, string destination, int cost)
        {
            this.origin = origin;
            this.destination = destination;
            this.cost = cost;
        }

        public void setOrigin(string origin)
        {
            this.origin = origin;
        }

        public void setDestination(string destination)
        {
            this.destination = destination;
        }

        public void setCost(int cost)
        {
            this.cost = cost;
        }

        public string getOrigin()
        {
            return origin;
        }

        public string getDestinatin()
        {
            return destination;
        }

        public int getCost()
        {
            return cost;
        }
    }
}
