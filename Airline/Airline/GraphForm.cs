using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    public partial class GraphForm : Form
    {
        Graph graph;
        FlightsList flights;
        int create;
        int positionX, positionY;
        string citySelect;
        int cost;

        public GraphForm(int create, Graph graph, FlightsList flights)
        {
            this.create = create;
            this.graph = graph;
            this.flights = flights;
            positionX = positionY = 0;
            InitializeComponent();
            initializeGraph();
            if (create == 1)
                MessageBox.Show("Selecciona posicion de las nuevas ciudades", "Informacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            updateOriDesti();

        }

        public void updateOriDesti()
        {
            comboBoxOrigin.Items.Clear();
            comboBoxDestination.Items.Clear();
            foreach (Node node in graph.getNodeList())
            {
                comboBoxOrigin.Items.Add(node.getCity().getName());
                comboBoxDestination.Items.Add(node.getCity().getName());

            }
        }

        public void initializeGraph()
        {
            Pen pen1 = new Pen(Color.Red, 2);
            Font drawFont = new Font("Arial Rounded MT", 12);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            foreach (Node n in graph.getNodeList())
            {
               
                panelMap.CreateGraphics().DrawEllipse(pen1, n.getCity().getX(), n.getCity().getY(), 20, 20);
                //panelMap.CreateGraphics().DrawEllipse(pen1, X, Y, 20, 20);
                //panelMap.CreateGraphics().DrawString(n.getCity().getName(),drawFont,drawBrush, n.getCity().getX() + 10, n.getCity().getY() + 10);
            }
            pen1.Color = Color.DarkSlateBlue;
            AdjustableArrowCap bigArrow = new AdjustableArrowCap(5, 5);
            pen1.CustomEndCap = bigArrow;

            
            foreach (Node n in graph.getNodeList())
            {
                int i = 0;
                foreach (Adjacent adj in n.getAdjacentList())
                {
                    int X = n.getCity().getX() + 10;
                    int Y = n.getCity().getY() + 10;
                    int J = adj.getNode().getCity().getX() + 10;
                    int K = adj.getNode().getCity().getY() + 10;
                    panelMap.CreateGraphics().DrawLine(pen1, X, Y, J, K);
                    int halfX, halfY;
                    if (i % 2 == 0)
                    {
                        halfX = ((X + J) / 2) + 6;
                        halfY = ((Y + K) / 2) + 6;
                    }
                    else
                    {
                        halfX = ((X + J) / 2) - 6;
                        halfY = ((Y + K) / 2) - 6;
                    }
                    panelMap.CreateGraphics().DrawString(adj.getTime().ToString(), drawFont, drawBrush, halfX, halfY );
                    i++;
                }

            }

            foreach (Node n in graph.getNodeList())
            {
                panelMap.CreateGraphics().DrawString(n.getCity().getName(),drawFont,drawBrush, n.getCity().getX(), n.getCity().getY() - 15);
            }
        }

        private void panelMap_MouseClick(object sender, MouseEventArgs e)
        {
            if (create == 1)
            {
                positionX = e.X - 10;
                positionY = e.Y - 10;
                MessageBox.Show("Punto almacenado", "Informacion ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            if (create == 2)
            {
                positionX = e.X - 10;
                positionY = e.Y - 10;
                labelCity.Text = citySelect = "";
                foreach(Node n in graph.getNodeList())
                {
                    if(n.getCity().getX() > positionX - 13 && n.getCity().getX() < positionX + 13)
                    {
                        if (n.getCity().getY() > positionY - 13 && n.getCity().getY() < positionY + 13)
                            citySelect = n.getCity().getName();
                    }
                }
                labelCity.Text = citySelect;
                
            }
        }

        public int getX()
        {
            return positionX;
        }

        private void GraphForm_Paint(object sender, PaintEventArgs e)
        {
            initializeGraph();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (citySelect != "")
            {
                graph.removeCity(citySelect);
                flights.removeFlights(citySelect);
                this.Refresh();
                labelCity.Text = "";
                updateOriDesti();
            }
            else
                MessageBox.Show("Selecciona una ciudad", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        public int getY()
        {
            return positionY;
        }

        public void kruskal()
        {
            ListaArista candidatos = new ListaArista();
            ListaArista arbolRM = new ListaArista();
            List<string> componentes = new List<string>();

            inicializaComponentes(componentes);
            inicializaCandidatos(candidatos,1);
            candidatos.quickSort(0, candidatos.Count - 1);

            foreach(Arista candidato in candidatos)
            {
                seleccionKruskal(candidato, componentes, arbolRM);
                if(arbolRM.existence(candidato))

                    Console.WriteLine(candidato.getOrigin().getCity().getName() +
                        "->" + candidato.getDestination().getCity().getName() + " "
                        + candidato.getCost().ToString() + " SI");
                else
                    Console.WriteLine(candidato.getOrigin().getCity().getName() +
                        "->" + candidato.getDestination().getCity().getName() + " "
                        + candidato.getCost().ToString() + " NO");
            }
            Console.WriteLine("");
            dibujaARM(arbolRM);
        }

        private void inicializaComponentes(List<string> componentes)
        {
            foreach(Node node in graph.getNodeList())
                componentes.Add(node.getCity().getName());
        }

        private void inicializaCandidatos(ListaArista candidatos, int option)
        {
            foreach (Node node in graph.getNodeList())
            {
                foreach (Adjacent ady in node.getAdjacentList())
                {
                    Arista arista = new Arista();
                    arista.setOrigin(node);
                    arista.setDestination(ady.getNode());
                    if (option == 1)
                    {
                        arista.setCost(ady.getTime());
                    }
                    else if (option == 2)
                    {
                        arista.setCost(ady.getCost());
                    }
                    candidatos.Add(arista);
                }
            }
        }

        private void seleccionKruskal(Arista candidato, List<string> componentes, ListaArista arbolRM)
        {
            int borrar = -1;
            string origen, destino;

            origen = candidato.getOrigin().getCity().getName();
            destino = candidato.getDestination().getCity().getName();
            for(int i = 0; i < componentes.Count; i++)
            {
                if (componentes[i].Contains(origen))
                {
                    for(int j = 0; j < componentes.Count; j++)
                    {
                        if (componentes[j].Contains(destino))
                        {
                            if(i != j)
                            {
                                borrar = j;
                                componentes[i] += componentes[j];
                                arbolRM.Add(candidato);
                            }
                        }
                    }
                }
            }
            if(borrar > -1)
                componentes.RemoveAt(borrar);
        }

        private void dibujaARM(ListaArista arbolRM)
        {
            Pen pen2 = new Pen(Color.Green, 3);
            AdjustableArrowCap bigArrow = new AdjustableArrowCap(5, 5);
            pen2.CustomEndCap = bigArrow;
            int X, Y, J, K;

            cost = 0;
            foreach (Arista arista in arbolRM)
            {
                cost += arista.getCost();
                X = arista.getOrigin().getCity().getX() + 10;
                Y = arista.getOrigin().getCity().getY() + 10;
                J = arista.getDestination().getCity().getX() + 10;
                K = arista.getDestination().getCity().getY() + 10;
                panelMap.CreateGraphics().DrawLine(pen2, X, Y, J, K);
            }
        }


        public void prim()
        {
            ListaArista candidatos = new ListaArista();
            ListaArista arbolRM = new ListaArista();
            List<string> componentes = new List<string>();
            string origen = labelCity.Text;

            inicializaComponentes(componentes);
            inicializaCandidatos(candidatos, 2);
            candidatos.quickSort(0, candidatos.Count - 1);

            seleccionPrim(candidatos, origen, arbolRM);
            dibujaARM(arbolRM);
        }

        private void seleccionPrim(ListaArista candidatos, string origenPrim, ListaArista arbolRM)
        {
            bool repetir;
            string origen, destino;

            while (origenPrim.Length < graph.getNodeList().Count )
            {
                repetir = false;
                for (int i = 0; i < candidatos.Count; i++)
                {
                    origen = candidatos[i].getOrigin().getCity().getName();
                    destino = candidatos[i].getDestination().getCity().getName();

                    if (origenPrim.Contains(origen))
                    {
                        if (!origenPrim.Contains(destino))
                        {
                            arbolRM.Add(candidatos[i]);
                            int cost = candidatos[i].getCost();
                            Console.WriteLine(origen + "->" + destino + " " + cost.ToString() + " SI");
                            origenPrim += destino;
                            candidatos.RemoveAt(i);
                            repetir = true;
                            break;
                        }
                    }
                    if (origenPrim.Contains(destino))
                    {
                        if (!origenPrim.Contains(origen))
                        {
                            arbolRM.Add(candidatos[i]);
                            int cost = candidatos[i].getCost();
                            Console.WriteLine(origen + "->" + destino + " " + cost.ToString() + " SI");
                            origenPrim += origen;
                            candidatos.RemoveAt(i);
                            repetir = true;
                            break;
                        }
                    }
                    if (origenPrim.Contains(origen))
                    {
                        if (origenPrim.Contains(destino))
                        {
                            candidatos.RemoveAt(i);
                            repetir = true;
                            break;
                        }
                    }
                    if (origenPrim.Contains(destino))
                    {
                        if (origenPrim.Contains(origen))
                        {
                            candidatos.RemoveAt(i);
                            repetir = true;
                            break;
                        }
                    }
                }
                if (!repetir)
                {
                    for (int i = 0; i < candidatos.Count; i++)
                    {
                        origen = candidatos[i].getOrigin().getCity().getName();
                        destino = candidatos[i].getDestination().getCity().getName();
                        
                        if (!origenPrim.Contains(origen))
                        {
                            if (!origenPrim.Contains(destino))
                            {
                                arbolRM.Add(candidatos[i]);
                                int cost = candidatos[i].getCost();
                                Console.WriteLine(origen + "->" + destino + " " + cost.ToString() + " SI");
                                origenPrim += origen;
                                origenPrim += destino;
                                candidatos.RemoveAt(i);
                                repetir = true;
                                break;
                            }
                        }
                        if (!origenPrim.Contains(destino))
                        {
                            if (!origenPrim.Contains(origen))
                            {
                                arbolRM.Add(candidatos[i]);
                                int cost = candidatos[i].getCost();
                                Console.WriteLine(origen + "->" + destino + " " + cost.ToString() + " SI");
                                origenPrim += destino;
                                origenPrim += origen;
                                candidatos.RemoveAt(i);
                                repetir = true;
                                break;
                            }
                        }
                    }
                }
            }

            Console.WriteLine("");
        }

        public void Dijkstra(Node inicial, int option)
        {
            List<DijkstraObject> listaDijkstra = new List<DijkstraObject>();
            int pesoActual = 0;
            Node seleccionado = inicial;

            iniciaListaDijkstra(listaDijkstra,inicial);
            foreach(DijkstraObject dobj in listaDijkstra)
            {
                actualizaPeso(listaDijkstra, seleccionado, graph, pesoActual, option);
                sigDefinitivo(listaDijkstra, ref seleccionado, ref pesoActual);
            }

            resultados(listaDijkstra, inicial);
        }

        public void Dijkstra(Node inicial, int option,string final)
        {
            List<DijkstraObject> listaDijkstra = new List<DijkstraObject>();
            int pesoActual = 0;
            Node seleccionado = inicial;

            iniciaListaDijkstra(listaDijkstra, inicial);
            foreach (DijkstraObject dobj in listaDijkstra)
            {
                actualizaPeso(listaDijkstra, seleccionado, graph, pesoActual, option);
                sigDefinitivo(listaDijkstra, ref seleccionado, ref pesoActual);
            }

            resultados(listaDijkstra, inicial,final);
        }

        private void iniciaListaDijkstra(List<DijkstraObject> listaDijkstra, Node inicial)
        {
            foreach(Node node in graph.getNodeList())
            {
                DijkstraObject dijkstraObject = new DijkstraObject();
                dijkstraObject.setNodo(node);
                if(node == inicial)
                {
                    dijkstraObject.setPeso(0);
                    dijkstraObject.setDefinitivo(true);
                }
                listaDijkstra.Add(dijkstraObject);
            }
        }

        private void actualizaPeso(List<DijkstraObject> listaDijkstra, Node selec, Graph grafo, int pesoAct, int op)
        {
            DijkstraObject proveniente = getProveniente(listaDijkstra,selec);
            foreach(Node node in grafo.getNodeList())
            {
                if(node == selec)
                {
                    foreach(Adjacent adj in node.getAdjacentList())
                    {
                        foreach(DijkstraObject dijkstraObj in listaDijkstra)
                        {
                            if (dijkstraObj.getNodo() == selec)
                                proveniente = dijkstraObj;
                            if(!dijkstraObj.getDefinitivo())
                            {
                                if (dijkstraObj.getNodo() == adj.getNode())
                                {
                                    if (op == 1)
                                    {
                                        if ((pesoAct + adj.getTime()) < dijkstraObj.getPeso())
                                        {
                                            dijkstraObj.setPeso((pesoAct + adj.getTime()));
                                            dijkstraObj.setProveniente(proveniente);
                                        }
                                    }
                                    else if (op == 2)
                                    {
                                        if ((pesoAct + adj.getCost()) < dijkstraObj.getPeso())
                                        {
                                            dijkstraObj.setPeso((pesoAct + adj.getCost()));
                                            dijkstraObj.setProveniente(proveniente);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private DijkstraObject getProveniente(List<DijkstraObject> listaDijkstra, Node seleccionado)
        {
            DijkstraObject nulo = new DijkstraObject();
            foreach(DijkstraObject dijkstraObj in listaDijkstra)
            {
                if (dijkstraObj.getNodo() == seleccionado)
                    return dijkstraObj;
            }

            return nulo;
        }

        private void sigDefinitivo(List<DijkstraObject> listaDijkstra, ref Node selec,ref int pesoAct)
        {
            int min = 1000000000;
            int def = -1;

            for (int i = 0; i < listaDijkstra.Count; i++)
            {
                if (!listaDijkstra[i].getDefinitivo())
                {
                    if (listaDijkstra[i].getPeso() < min)
                    {
                        min = listaDijkstra[i].getPeso();
                        def = i;
                    }
                }
            }
            if(def > -1)
            {
                listaDijkstra[def].setDefinitivo(true);
                selec = listaDijkstra[def].getNodo();
                pesoAct = listaDijkstra[def].getPeso();
            }
        }

        private void resultados(List<DijkstraObject> listaDijkstra, Node inicial)
        {
            foreach (DijkstraObject dijkstraObj in listaDijkstra)
            {
                if (dijkstraObj.getPeso() != 1000000000 && dijkstraObj.getPeso() != 0)
                {
                    //origen, destino, peso, recorrido
                    string recorrido = "";
                    string agregar = "";
                    DijkstraObject proveniente = dijkstraObj;
                    string[] arrString = new string[4];
                    arrString[0] = inicial.getCity().getName();
                    arrString[1] = dijkstraObj.getNodo().getCity().getName();
                    arrString[2] = dijkstraObj.getPeso().ToString();

                    while (proveniente.getNodo() != inicial)
                    {
                        agregar = proveniente.getNodo().getCity().getName();
                        recorrido += agregar;
                        recorrido += "<-";
                        //recorrido.Insert(0, agregar);
                        //recorrido.Insert(0, "->");
                        proveniente = proveniente.getProveniente();
                    }
                    recorrido += inicial.getCity().getName();
                    arrString[3] = recorrido;
                    ListViewItem items = new ListViewItem(arrString);
                    listViewDijkstra.Items.Add(items);
                }
            }
        }

        private void resultados(List<DijkstraObject> listaDijkstra, Node inicial, string final)
        {
            bool existe = false;
            foreach (DijkstraObject dijkstraObj in listaDijkstra)
            {
                if (dijkstraObj.getPeso() != 1000000000 && dijkstraObj.getPeso() != 0)
                {
                    //origen, destino, peso, recorrido
                    string recorrido = "";
                    string agregar = "";
                    DijkstraObject proveniente = dijkstraObj;
                    string[] arrString = new string[4];
                    arrString[0] = inicial.getCity().getName();
                    arrString[1] = dijkstraObj.getNodo().getCity().getName();
                    arrString[2] = dijkstraObj.getPeso().ToString();

                    while (proveniente.getNodo() != inicial)
                    {
                        agregar = proveniente.getNodo().getCity().getName();
                        recorrido += agregar;
                        recorrido += "<-";
                        //recorrido.Insert(0, agregar);
                        //recorrido.Insert(0, "->");
                        proveniente = proveniente.getProveniente();
                    }
                    recorrido += inicial.getCity().getName();
                    arrString[3] = recorrido;
                    ListViewItem items = new ListViewItem(arrString);
                    if(recorrido.Contains(final))
                    {
                        existe = true;
                        listViewDijkstra.Items.Add(items);
                        break;
                    }
                        
                }
            }
            if(!existe)
            {
                MessageBox.Show("No existe ruta", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonKruskal_Click(object sender, EventArgs e)
        {
            kruskal();
            labelCostResult.Text = cost.ToString();
        }

        private void buttonDijkstra_Click(object sender, EventArgs e)
        {
            int option = 0;
            string inicio, fin;
            Node inicial;
            listViewDijkstra.Items.Clear();
            if(radioButtonTime.Enabled)
            {
                option = 1;
            }
            else if(radioButtonCost.Enabled)
            {
                option = 2;
            }

            if(comboBoxOrigin.SelectedIndex >= 0)
            {
                if(comboBoxDestination.SelectedIndex < 0)
                {
                    inicio = comboBoxOrigin.SelectedItem.ToString();
                    foreach(Node node in graph.getNodeList())
                    {
                        if(node.getCity().getName() == inicio)
                        {
                            inicial = node;
                            Dijkstra(inicial, option);
                            break;
                        }
                    }
                    
                }
                else
                {
                    inicio = comboBoxOrigin.SelectedItem.ToString();
                    fin = comboBoxDestination.SelectedItem.ToString();
                    if(inicio != fin)
                    {
                        foreach (Node node in graph.getNodeList())
                        {
                            if (node.getCity().getName() == inicio)
                            {
                                inicial = node;
                                Dijkstra(inicial, option, fin);
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puede seleccionar el origen", "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            
        }

        private void buttonPrim_Click(object sender, EventArgs e)
        {
            if (citySelect != "")
            {
                prim();
                labelCostResult.Text = cost.ToString();
            }
            else
                MessageBox.Show("Selecciona una ciudad", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
