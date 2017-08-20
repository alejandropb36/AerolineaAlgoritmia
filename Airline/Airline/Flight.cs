using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    class Flight
    {
        private char originCity;
        private string route;
        private int flightTime;
        private int cost;
        private char destinationCity;

        public Flight()
        {
        }

        public Flight(char originCity, string route, int flightTime, int cost, char destinationCity)
        {
            this.originCity = originCity;
            this.route = route;
            this.flightTime = flightTime;
            this.cost = cost;
            this.destinationCity = destinationCity;
        }

        public void setOriginCity(char originCity)
        {
            this.originCity = originCity;
        }

        public void setRoute(string route)
        {
            this.route = route;
        }

        public void setFlightTime(int flightTime)
        {
            this.flightTime = flightTime;
        }

        public void setCost(int cost)
        {
            this.cost = cost;
        }

        public void setDestinationCity(char destinationCity)
        {
            this.destinationCity = destinationCity;
        }

        public char getOriginCity()
        {
            return originCity;
        }

        public string getRoute()
        {
            return route;
        }

        public int getFlightTime()
        {
            return flightTime;
        }

        public int getCost()
        {
            return cost;
        }

        public char getDestinationCity()
        {
            return destinationCity;
        }

    }
}
