using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class Graph
    {
        List<Node> nodeList;

        public Graph(FlightsList flights)
        {
            nodeList = new List<Node>();
            bool excistence = false;

            // Creando nodos
            foreach (Flight flight in flights)
            {
                foreach (Node n in nodeList)
                {
                    if (n.getCity().getName() == flight.getOriginCity())
                    {
                        excistence = true;
                        break;
                    }
                }
                if (!excistence)
                {
                    City city = new City(flight.getOriginCity(), /*positions*/)
                    Node node = new Node(city);
                    nodeList.Add(node);
                }

                excistence = false;
                foreach (Node n in nodeList)
                {
                    if (n.getCity().getName() == flight.getDestinationCity())
                    {
                        excistence = true;
                        break;
                    }
                }
                if (!excistence)
                {
                    City city = new City(flight.getOriginCity(), /*positions*/)
                    Node node2 = new Node(city);
                    nodeList.Add(node2);
                }
            }

            // Crea Adjacent
            foreach (Node n in nodeList)
            {
                foreach(Flight flight in flights)
                {
                    if (flight.getOriginCity() == n.getCity().getName())
                    {
                        foreach(Node nAux in nodeList)
                        {
                            if(nAux.getCity().getName() == flight.getDestinationCity())
                            {
                                Adjacent adjacent = new Adjacent(nAux);
                                n.insertAdjacent(adjacent);
                            }
                        }
                    }
                }
            }
        }

        public void addNode(FlightsList flights)
        {
            
        }

        public void addArista(FlightsList flights)
        {

        }


    }


    //inserat Arista
    //inserta nodo
    // contraparte

    public class Node
    {
        // class City Recomenadion del profe para posicion x y a la hora dibujar
        City city;
        List<Adjacent> adjacenceList;

        public Node(City city)
        {
            this.city = city;
            adjacenceList = new List<Adjacent>();

        }

        public City getCity()
        {
            return city;
        }

        public void insertAdjacent(Adjacent adjacent)
        {
            adjacenceList.Add(adjacent);
        }
    }

    public class Adjacent
    {
        // Podriamos hacer un tipo de dato para las ponderaciones
        int cost;
        int time;
        Node node;

        public Adjacent(Node node)
        {
            this.node = node;
        }
    }

    
    
}
