﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class Flight
    {
        string originCity;
        string route;
        int flightTime;
        int cost;
        string destinationCity;
        List<Passenger> passengers;
        bool[] seating;

        public Flight()
        {
            seating = new bool[18];
            for (int i = 0; i < seating.Length; i++)
            {
                seating[i] = true;
            }
            passengers = new List<Passenger>();
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
            passengers = new List<Passenger>();
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

        public ref List<Passenger> getPassengers()
        {
            return ref passengers;
        }

        public bool getSeating(int i)
        {
            return seating[i];
        }
    }
}
