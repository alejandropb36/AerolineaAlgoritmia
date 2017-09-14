using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class Passenger
    {
        string name;
        string lastname;
        int age;
        string id;
        int seatNumber;
        string flightRoute;

        public Passenger()
        {
        }

        public Passenger(string name, string lastname, int age, int seatNumber, string flightRoute)
        {
            this.name = name;
            this.lastname = lastname;
            this.age = age;
            this.seatNumber = seatNumber;
            this.flightRoute = flightRoute;
            id = flightRoute + (seatNumber + 1).ToString();
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setLastname(string lastname)
        {
            this.lastname = lastname;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public void setId(string id)
        {
            this.id = id;
        }
        
        public void setSeatNumber(int seatNumber)
        {
            this.seatNumber = seatNumber;
        }

        public void setFlightRoute(string flightRoute)
        {
            this.flightRoute = flightRoute;
        }

        public string getName()
        {
            return name;
        }

        public string getLastname()
        {
            return lastname;
        }

        public int getAge()
        {
            return age;
        }
        public string getId()
        {
            return id;
        }

        public int getSeatNumber()
        {
            return seatNumber;
        }

        public string getFlightRoute()
        {
            return flightRoute;
        }
    }
}
