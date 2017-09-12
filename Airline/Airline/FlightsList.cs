using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class FlightsList : List<Flight>
    {
        public FlightsList buscaCoincidencias(string dato , int idex)
        {
            FlightsList filterFlightsList = new FlightsList();

            switch (idex)
            {
                case 1:
                    {
                        for (int i = 0; i < this.Count; i++)
                        {
                            int j;
                            for (j = 0; j < dato.Length; j++)
                            {
                                if (dato[j] != this[i].getRoute()[j])
                                    break;
                            }
                            if(j == dato.Length)
                                filterFlightsList.Add(this[i]);

                        }
                        break;
                    }


                case 2:
                    {
                        for (int i = 0; i < this.Count; i++)
                        {
                            if (dato == this[i].getOriginCity().ToString())
                                filterFlightsList.Add(this[i]);
                        }
                        break;
                    }

                case 3:
                    {
                        for (int i = 0; i < this.Count; i++)
                        {
                            if (dato == this[i].getDestinationCity().ToString())
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
