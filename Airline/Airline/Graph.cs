using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    [Serializable]
    public class Graph
    {
        List<Node> nodeList;
        //FlightsList flights;

        public Graph()
        {
            nodeList = new List<Node>();
        }

        // este constructor de momento no me sirve
        //public Graph(FlightsList flights)
        //{
        //   // this.flights = flights;
        //    nodeList = new List<Node>();
        //    bool excistence = false;

        //    // Creando nodos
        //    foreach (Flight flight in flights)
        //    {
        //        foreach (Node n in nodeList)
        //        {
        //            if (n.getCity().getName() == flight.getOriginCity())
        //            {
        //                excistence = true;
        //                break;
        //            }
        //        }
        //        if (!excistence)
        //        {
        //            City city = new City(flight.getOriginCity());
        //            Node node = new Node(city);
        //            nodeList.Add(node);
        //        }

        //        excistence = false;
        //        foreach (Node n in nodeList)
        //        {
        //            if (n.getCity().getName() == flight.getDestinationCity())
        //            {
        //                excistence = true;
        //                break;
        //            }
        //        }
        //        if (!excistence)
        //        {
        //            City city = new City(flight.getOriginCity());
        //            Node node2 = new Node(city);
        //            nodeList.Add(node2);
        //        }
        //    }

        //    // Crea Adjacent
        //    foreach (Node n in nodeList)
        //    {
        //        foreach(Flight flight in flights)
        //        {
        //            if (flight.getOriginCity() == n.getCity().getName())
        //            {
        //                foreach(Node nAux in nodeList)
        //                {
        //                    if(nAux.getCity().getName() == flight.getDestinationCity())
        //                    {
        //                        Adjacent adjacent = new Adjacent(nAux,flight.getCost(),flight.getFlightTime());
        //                        n.insertAdjacent(adjacent);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        public void addRoute(Flight flight, int x1, int y1, int x2, int y2)
        {
            bool excistence = false;
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
                City city = new City(flight.getOriginCity(), x1, y1);
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
                City city = new City(flight.getOriginCity(), x2, y2);
                Node node2 = new Node(city);
                nodeList.Add(node2);
            }

            foreach (Node node in nodeList)
            {
                if (node.getCity().getName() == flight.getOriginCity())
                {
                    for (int i = 0; i < nodeList.Count; i++)
                    {
                        if(nodeList[i].getCity().getName() == flight.getDestinationCity())
                        {
                            Adjacent adjacent = new Adjacent(nodeList[i], flight.getCost(), flight.getFlightTime());
                            node.insertAdjacent(adjacent);
                        }
                    }
                    //foreach (Node nodeAux in nodeList)
                    //{
                    //    if (nodeAux.getCity().getName() == flight.getDestinationCity())
                    //    {
                    //        Adjacent adjacent = new Adjacent(nodeAux, flight.getCost(), flight.getFlightTime());
                    //        node.insertAdjacent(adjacent);
                    //    }
                    //}
                }
            }
        }

        public bool excistenceCity(string name)
        {
            foreach(Node n in nodeList)
            {
                if (n.getCity().getName() == name)
                    return true;
            }

            return false;
        }

        public void removeRoute(Flight flight)
        {

        }

        public List<Node> getNodeList()
        {
            return nodeList;
        }


    }


    //inserat Arista
    //inserta nodo
    // contraparte
    [Serializable]
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

        public List<Adjacent> getAdjacentList()
        {
            return adjacenceList;
        }
    }

    [Serializable]
    public class Adjacent
    {
        // Podriamos hacer un tipo de dato para las ponderaciones
        int cost;
        int time;
        Node node;

        public Adjacent(Node node, int cost, int time)
        {
            this.node = node;
            this.cost = cost;
            this.time = time;
        }

        public Node getNode()
        {
            return node;
        }
    }

    
    
}
