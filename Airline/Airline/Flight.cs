using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class Flight
    {
        private char originCity;
        private string route;
        private int flightTime;
        private int cost;
        private char destinationCity;
        private bool[] seating = new bool[18];
        private List<Passenger> passengers;

        public Flight()
        {
            for (int i = 0; i < seating.Length; i++)
            {
                seating[i] = false;
            }
            passengers = new List<Passenger>();
        }

        public Flight(char originCity, int flightTime, int cost, char destinationCity)
        {
            this.originCity = originCity;
            this.route = "SK1" + originCity + destinationCity; 
            this.flightTime = flightTime;
            this.cost = cost;
            this.destinationCity = destinationCity;
            for (int i = 0; i < seating.Length; i++)
            {
                seating[i] = false;
            }
            passengers = new List<Passenger>();
        }

        public override string ToString()
        {
            return route;
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

        public ref List<Passenger> getPassengers()
        {
            return ref passengers;
        }

        public ref bool[] getSeats()
        {
            return ref seating;
        }
    }
}
