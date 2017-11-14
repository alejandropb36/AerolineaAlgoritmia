using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class ListaArista: List<Arista>
    {
        public void quickSort(int begin, int end)
        {
            int i = begin;
            int j = end;
            int half = (i + j) / 2;
            Arista pivote = this[half];

            do
            {
                while (this[i].compareTo(pivote) == -1)
                    i++;
                while (this[j].compareTo(pivote) == 1)
                    j--;

                if (i <= j)
                {
                    swap(i, j);
                    i++;
                    j--;
                }
            } while (i <= j);

            if (begin < j)
                quickSort(begin, j);
            if (i < end)
                quickSort(i, end);
        }

        private void swap(int i, int j)
        {
            Arista aux = new Arista();
            aux = this[i];
            this[i] = this[j];
            this[j] = aux;
        }
        
    }
}
