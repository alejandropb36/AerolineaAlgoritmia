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
        public void quickSort(int begin, int end, int option)
        {
            int i = begin;
            int j = end;
            int half = (i + j) / 2;
            Passenger pivote = this[half];

            do
            {
                while (this[i].compareTo(pivote, option) == -1)
                    i++;
                while (this[j].compareTo(pivote, option) == 1)
                    j--;

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
            Passenger aux = new Passenger();
            aux = this[i];
            this[i] = this[j];
            this[j] = aux;
        }
    }
}

