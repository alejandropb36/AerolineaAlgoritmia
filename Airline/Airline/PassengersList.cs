using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    [Serializable]
    public class PassengersList : List<Passenger>
    {
        public PassengersList searchMatches(string data, int option)
        {
            string route;
            int seat;
            const int routeLenght = 5;
            const int idLenght = 6;
            

            PassengersList filterPassengersList = new PassengersList();

            switch (option)
            {
                case 1:
                    {
                        for(int i = 0; i <  )
                        for (int i = 0; i < this.Count; i++)
                        {
                            int j;
                            for (j = 0; j < data.Length && j < routeLenght; j++)
                            {
                                if (data[j] != this[i].getRoute()[j])
                                    break;
                            }
                            if (j == data.Length)
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



            return filterPassengersList;
        }


    }
}
