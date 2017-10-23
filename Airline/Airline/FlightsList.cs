using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    [Serializable]
    public class FlightsList : List<Flight>
    {
        public FlightsList searchMatches(string data , int option)
        {
            FlightsList filterFlightsList = new FlightsList();

            switch (option)
            {
                case 1:
                    {
                        for (int i = 0; i < this.Count; i++)
                        {
                            int j;
                            for (j = 0; j < data.Length && j < this[i].getRoute().Length; j++)
                            {
                                if (data[j] != this[i].getRoute()[j])
                                    break;
                            }
                            if(j == data.Length)
                                filterFlightsList.Add(this[i]);

                        }
                        break;
                    }
                case 2:
                    {
                        for (int i = 0; i < this.Count; i++)
                        {
                            if (data == this[i].getOriginCity().ToString())
                                filterFlightsList.Add(this[i]);
                        }
                        break;
                    }
                case 3:
                    {
                        for (int i = 0; i < this.Count; i++)
                        {
                            if (data == this[i].getDestinationCity().ToString())
                                filterFlightsList.Add(this[i]);
                        }
                        break;
                    }
                default:
                    break;
            }


            return filterFlightsList;
        }

        public bool flightExistence(string route)
        {
            bool existence = false;
            for (int i = 0; i < this.Count; i++)
                if (route == this[i].getRoute())
                    existence = true;
            return existence;
        }

        public bool flightDelete(string route)
        {
            bool delete = false;
            for(int i = 0; i < this.Count; i++)
            {
                if (route == this[i].getRoute())
                {
                    this.RemoveAt(i);
                    delete = true;
                }
            }
            return delete;
        }

        public List<Passenger> searchMatchesPassenger(string data, int option)
        {
            List<Passenger> filterPassengersList = new List<Passenger>();
            switch (option)
            {
                case 1:
                    {
                        for (int i = 0; i < this.Count; i++)
                        {
                            foreach(Passenger passenger in this[i].getPassengers())
                            {
                                int j;
                                for (j = 0; j < data.Length && j < passenger.getId().Length; j++)
                                {
                                    if (data[j] != passenger.getId()[j])
                                        break;
                                }
                                if (j == data.Length)
                                    filterPassengersList.Add(passenger);
                            }
                        }
                        break;
                    }
                case 2:
                    {

                        for (int i = 0; i < this.Count; i++)
                        {
                            foreach (Passenger passenger in this[i].getPassengers())
                            {
                                int j;
                                for (j = 0; j < data.Length && j < passenger.getFlightRoute().Length; j++)
                                {
                                    if (data[j] != passenger.getFlightRoute()[j])
                                        break;
                                }
                                if (j == data.Length)
                                    filterPassengersList.Add(passenger);
                            }
                        }
                        break;
                    }
                case 3:
                    {
                        for (int i = 0; i < this.Count; i++)
                        {
                            foreach(Passenger passenger in this[i].getPassengers())
                            {
                                if (data == passenger.getName())
                                    filterPassengersList.Add(passenger);
                            }
                        }
                        break;
                    }
                default:
                    break;
            }

            return filterPassengersList;
        }

        public bool passengerDelete(string id)
        {
            bool delete = false;

            for (int i = 0; i < this.Count; i++)
            {
                int j = 0;
                foreach(Passenger passenger in this[i].getPassengers())
                {
                    if(id == passenger.getId())
                    {
                        this[i].getSeating()[passenger.getSeatNumber()] = true;
                        this[i].getPassengers().RemoveAt(j);
                        delete = true;
                        break;
                    }

                    j++;
                }
            }
            return delete;
        }

        public int getFlightIndex(string route)
        {
            int index = -1;

            for(int i = 0; i < this.Count; i++)
            {
                if (route == this[i].getRoute())
                    index = i;
            }

            return index;
        }

        public void quickSort(int begin, int end, int option)
        {
            int i = begin;
            int j = end;
            int half = (i + j) / 2;
            Flight pivote = this[half];

            do
            {
                switch(option)
                {
                    case 1: // Origin
                        while (this[i].compareOrigin(pivote) == -1)
                            i++;
                        while (this[j].compareOrigin(pivote) == 1)
                            j--;
                        break;
                    case 2: // Destination
                        while (this[i].compareDestination(pivote) == -1)
                            i++;
                        while (this[j].compareDestination(pivote) == 1)
                            j--;
                        break;
                    case 3: // Cost
                        while (this[i].compareCost(pivote) == -1)
                            i++;
                        while (this[j].compareCost(pivote) == 1)
                            j--;
                        break;
                    case 4: // Time
                        while (this[i].compareTime(pivote) == -1)
                            i++;
                        while (this[j].compareTime(pivote) == 1)
                            j--;
                        break;
                }
                if (i <= j)
                {
                    swap(i, j);
                    i++;
                    j--;
                }
            } while (i <= j);

            if (begin < j)
                quickSort(begin, j, option);
            if (i < end)
                quickSort(i, end, option);
        }

        private void swap(int i, int j)
        {
            Flight aux = new Flight();
            aux = this[i];
            this[i] = this[j];
            this[j] = aux;
        }
    }
}
