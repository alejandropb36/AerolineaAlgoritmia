using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class Arista
    {
        Node origin;
        Node destination;
        int cost;

        public Arista ()
        {
            cost = -1;
        }

        public Arista(Node origin, Node destination, int cost)
        {
            this.origin = origin;
            this.destination = destination;
            this.cost = cost;
        }

        public void setOrigin(Node origin)
        {
            this.origin = origin;
        }

        public void setDestination(Node destination)
        {
            this.destination = destination;
        }

        public void setCost(int cost)
        {
            this.cost = cost;
        }

        public Node getOrigin()
        {
            return origin;
        }

        public Node getDestinatin()
        {
            return destination;
        }

        public int getCost()
        {
            return cost;
        }

        public int compareTo(Arista compare)
        {
            return cost.CompareTo(compare.cost);
        }
    }
}
