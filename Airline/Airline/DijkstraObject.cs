using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class DijkstraObject
    {
        int peso;
        Node nodo;
        bool definitivo;
        DijkstraObject proveniente;

        public DijkstraObject()
        {
            peso = 1000000000;
            definitivo = false;
        }

        public void setPeso(int peso)
        {
            this.peso = peso;
        }

        public void setNodo(Node nodo)
        {
            this.nodo = nodo;
        }

        public void setDefinitivo(bool definitivo)
        {
            this.definitivo = definitivo;
        }

        public void setProveniente(DijkstraObject proveniente)
        {
            this.proveniente = proveniente;
        }

        public int getPeso()
        {
            return peso;
        }

        public Node getNodo()
        {
            return nodo;
        }

        public bool getDefinitivo()
        {
            return definitivo;
        }

        public DijkstraObject getProveniente()
        {
            return proveniente;
        }
    }
}
