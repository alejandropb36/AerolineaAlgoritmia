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

        public Graph()
        {
            nodeList = new List<Node>();
        }

        public void addRoute(Flight flight, int x1, int y1, int x2, int y2)
        {
            City city1 = new City(flight.getOriginCity(), x1, y1);
            City city2 = new City(flight.getDestinationCity(), x2, y2);

            addNode(city1);
            addNode(city2);
            addAdjacent(flight);
        }

        private void addNode(City newCity)
        {
            bool excistence = false;

            foreach (Node n in nodeList)
            {
                if (n.getCity().getName() == newCity.getName())
                {
                    excistence = true;
                    break;
                }
            }
            if (!excistence)
            {
                Node node = new Node(newCity);
                nodeList.Add(node);
            }
        }

        private void addAdjacent(Flight flight)
        {
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
            removeAdjacent(routeFlight);
            removeNode(routeFlight[3].ToString());
            removeNode(routeFlight[4].ToString());
        }


        private void removeAdjacent(string routeFlight)
        {
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
        }

        private void removeNode(string nodeName)
        {
            bool del = false;
            Node nodeDel = new Node();

            foreach (Node node in nodeList)
            {
                if (node.getCity().getName() == nodeName)
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
                    if (adj.getNode().getCity().getName() == nodeName)
                        del = false;
                }
            }

            if (del)
                nodeList.Remove(nodeDel);
        }

        public List<Node> getNodeList()
        {
            return nodeList;
        }
        
        public void removeCity(string cityName)
        {
            int max = nodeList.Count;

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
            }

            foreach (Node node in nodeList)
            {
                if(node.getCity().getName() == cityName)
                {
                    nodeList.Remove(node);
                    break;
                }
            }

            for (int i = 0; i < max; i++)
            {
                removeNode(nodeList[i].getCity().getName());
                if(nodeList.Count < max)
                {
                    max = nodeList.Count;
                    i--;
                }
            }
        }

    }

    [Serializable]
    public class Node
    {
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
