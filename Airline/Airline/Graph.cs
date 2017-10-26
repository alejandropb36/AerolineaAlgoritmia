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
        FlightsList flights;

        public Graph(FlightsList flights)
        {
            this.flights = flights;
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
                City city = new City(flight.getDestinationCity(), x2, y2);
                Node node2 = new Node(city);
                nodeList.Add(node2);
            }

            foreach (Node node in nodeList)
            {
                if (node.getCity().getName() == flight.getOriginCity())
                {
                    foreach (Node nodeAux in nodeList)
                    {
                        if (nodeAux.getCity().getName() == flight.getDestinationCity())
                        {
                            Adjacent adjacent = new Adjacent(nodeAux, flight.getCost(), flight.getFlightTime());
                            node.insertAdjacent(adjacent);
                        }
                    }
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

        public void removeRoute(string routeFlight)
        {
            bool del = false;
            Node nodeDel = new Node();
            //Remove adjacent
            foreach (Node node in nodeList)
            {
                if (node.getCity().getName() == routeFlight[3].ToString())
                {
                    foreach (Adjacent adj in node.getAdjacentList())
                    {
                        if (adj.getNode().getCity().getName() == routeFlight[4].ToString())
                        {
                            node.getAdjacentList().Remove(adj);
                            break;
                        }
                    }
                }
            }
            // Origin
            foreach (Node node in nodeList)
            {
                if (node.getCity().getName() == routeFlight[3].ToString())
                {
                    if (node.getAdjacentList().Count == 0)
                    {
                        nodeDel = node;
                        del = true;
                    }
                }
            }
            foreach (Node node in nodeList)
            {
                foreach (Adjacent adj in node.getAdjacentList())
                {
                    if (adj.getNode().getCity().getName() == routeFlight[3].ToString())
                    {
                        del = false;

                    }
                }
            }
            if (del)
            {
                nodeList.Remove(nodeDel);
            }
            // Destination
            del = false;
            foreach (Node node in nodeList)
            {
                if (node.getCity().getName() == routeFlight[4].ToString())
                {
                    if (node.getAdjacentList().Count == 0)
                    {
                        nodeDel = node;
                        del = true;
                    }
                }
            }
            foreach (Node node in nodeList)
            {
                foreach (Adjacent adj in node.getAdjacentList())
                {
                    if (adj.getNode().getCity().getName() == routeFlight[4].ToString())
                    {
                        del = false;

                    }
                }
            }
            if (del)
            {
                nodeList.Remove(nodeDel);
            }
        }

        public List<Node> getNodeList()
        {
            return nodeList;
        }
        
        public void removeCity(string cityName)
        {
            flights.removeFlights(cityName);
            List<Node> nodeListDel = new List<Node>();
            //Remove adjacent
            foreach (Node node in nodeList)
            {
                foreach (Adjacent adj in node.getAdjacentList())
                {
                    if (adj.getNode().getCity().getName() == cityName)
                    {
                        node.getAdjacentList().Remove(adj);
                        break;
                    }
                }
                if(node.getAdjacentList().Count == 0)
                {
                    nodeListDel.Add(node);
                }
            }
            foreach (Node node in nodeList)
            {
                if (node.getCity().getName() == cityName)
                {
                    nodeListDel.Add(node);
                    break;
                }
            }
            foreach (Node nodeDel  in nodeListDel)
            {
                nodeList.Remove(nodeDel);
            }
            
        }

    }


    
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

        public Node()
        {
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

        public int getCost()
        {
            return cost;
        }

        public int getTime()
        {
            return time;
        }
    }

    
    
}
