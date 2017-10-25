using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    [Serializable]
    public class Flight
    {
        string originCity;
        string route;
        int flightTime;
        int cost;
        string destinationCity;
        PassengersList passengers;
        bool[] seating;

        public Flight()
        {
            seating = new bool[18];
            for (int i = 0; i < seating.Length; i++)
            {
                seating[i] = true;
            }
            passengers = new PassengersList();
        }

        public Flight(string originCity, string destinationCity, int flightTime, int cost)
        {
            seating = new bool[18];
            this.originCity = originCity;
            this.destinationCity = destinationCity;
            this.flightTime = flightTime;
            this.cost = cost;;
            this.route = "SK1" + originCity + destinationCity;
            for (int i = 0; i < seating.Length; i++)
            {
                seating[i] = true;
            }
            passengers = new PassengersList();
        }

        public override string ToString()
        {
            return route;
        }

        public void setOriginCity(string originCity)
        {
            this.originCity = originCity;
        }

        public void setDestinationCity(string destinationCity)
        {
            this.destinationCity = destinationCity;
        }

        public void setFlightTime(int flightTime)
        {
            this.flightTime = flightTime;
        }

        public void setCost(int cost)
        {
            this.cost = cost;
        }

        public void setRoute(string route)
        {
            this.route = route;
        }

        public void setSeating(int i, bool status)
        {
            seating[i] = status;
        }

        public string getOriginCity()
        {
            return originCity;
        }

        public string getDestinationCity()
        {
            return destinationCity;
        }

        public int getFlightTime()
        {
            return flightTime;
        }

        public int getCost()
        {
            return cost;
        }

        public string getRoute()
        {
            return route;
        }

        public ref PassengersList getPassengers()
        {
            return ref passengers;
        }

        public bool[] getSeating()
        {
            return seating;
        }

        public int compareTo(Flight value, int option)
        {
            if(option == 1)
                return this.originCity.CompareTo(value.originCity);
            if (option == 2)
                return this.destinationCity.CompareTo(value.destinationCity);
            if (option == 3)
                return this.cost.CompareTo(value.cost);
            if (option == 4)
                return this.flightTime.CompareTo(value.flightTime);
            return 0;
        }
    }
}
