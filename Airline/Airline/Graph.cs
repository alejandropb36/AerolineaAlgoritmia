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
            foreach (Flight flight in flights)
            {
                foreach(Node n in nodeList)
                {
                    if (n.getCity() == flight.getOriginCity())
                    {
                        excistence = true;
                        break;
                    } 
                }
                if(!excistence)
                {
                    string city = flight.getOriginCity();
                    Node node = new Node(city);
                    nodeList.Add(node);
                }

                excistence = false;
                foreach (Node n in nodeList)
                {
                    if (n.getCity() == flight.getDestinationCity())
                    {
                        excistence = true;
                        break;
                    }
                }
                if (!excistence)
                {
                    string city = flight.getDestinationCity();
                    Node node = new Node(city);
                    nodeList.Add(node);
                }
            }
            // Crea Adjacent
            foreach(Node n in nodeList)
            {
                foreach(Flight flight in flights)
                {
                    if (flight.getOriginCity() == n.getCity())
                    {
                        foreach(Node nAux in nodeList)
                        {
                            if(n.getCity() == flight.getDestinationCity())
                            {
                                Adjacent adjacent = new Adjacent(nAux);
                                n.insertAdjacent(adjacent);
                            }
                        }
                    }
                }
            }
        }
    }
    //inserat Arista
    //inserta nodo
    // contraparte

    public class Node
    {
        // class City Recomenadion del profe para posicion x y a la hora dibujar
        string city;
        List<Adjacent> adjacenceList;

        public Node(string city)
        {
            this.city = city;
            adjacenceList = new List<Adjacent>();

        }

        public string getCity()
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
