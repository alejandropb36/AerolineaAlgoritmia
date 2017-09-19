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
            const int routeLenght = 5;
            FlightsList filterFlightsList = new FlightsList();

            switch (option)
            {
                case 1:
                    {
                        for (int i = 0; i < this.Count; i++)
                        {
                            int j;
                            for (j = 0; j < data.Length && j < routeLenght; j++)
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
            const int routeLenght = 5;
            const int idLenght = 6;
            string route;
            int seat;
            switch (option)
            {
                case 1:
                    {
                        for (int i = 0; i < this.Count; i++)
                        {
                            int j;
                            for (j = 0; j < data.Length && j < routeLenght; j++)
                            {
                                if (data[j] != this[i].getRoute()[j])
                                    break;
                            }
                            if (j == data.Length)
                            {
                                filterFlightsList.Add(this[i]);

                            }
                                

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

            return filterPassengersList;
        }
    }
}
