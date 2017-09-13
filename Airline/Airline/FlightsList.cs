using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class FlightsList : List<Flight>
    {
        public FlightsList searchMatches(string data , int option)
        {
            const int routeLenght= 5;
            FlightsList filterFlightsList = new FlightsList();

            switch (option)
            {
                case 1:
                    {
                        for (int i = 0; i < this.Count; i++)
                        {
                            int j;
                            for (j = 0; j < routeLenght; j++)
                            {
                                if (data[j] != this[i].getRoute()[j])
                                    break;
                            }
                            if(j == routeLenght)
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
    }
}
