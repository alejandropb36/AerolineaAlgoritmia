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
            else
                kruskal();
            
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

            inicializaCandidatos(candidatos,1);
            candidatos.quickSort(0, candidatos.Count - 1);

            foreach(Arista candidato in candidatos)
            {
                seleccionKruskal(candidato, arbolRM);
                if(arbolRM.existence(candidato))

                    Console.WriteLine(candidato.getOrigin().getCity().getName() +
                        "->" + candidato.getDestinatin().getCity().getName() + " "
                        + candidato.getCost().ToString() + " SI");
                else
                    Console.WriteLine(candidato.getOrigin().getCity().getName() +
                        "->" + candidato.getDestinatin().getCity().getName() + " "
                        + candidato.getCost().ToString() + " NO");
            }




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

        private void seleccionKruskal(Arista candidato, ListaArista arbolRM)
        {
            bool agregar = false;
            if(arbolRM.Count == 0)
            {
                arbolRM.Add(candidato);
            }
            else
            {

                foreach (Arista arist in arbolRM)
                {

                    if (arist.getOrigin() == candidato.getOrigin())
                    {
                        if (arist.getDestinatin() != candidato.getDestinatin())
                            agregar = true;
                        else
                            agregar = false;
                    }
                    if (arist.getOrigin() == candidato.getDestinatin())
                    {
                        if (arist.getDestinatin() != candidato.getOrigin())
                            agregar = true;
                        else
                            agregar = false;
                    }
                    if (arist.getDestinatin() == candidato.getOrigin())
                    {
                        if (arist.getOrigin() != candidato.getDestinatin())
                            agregar = true;
                        else
                            agregar = false;
                    }
                    if (arist.getDestinatin() == candidato.getOrigin())
                    {
                        if (arist.getDestinatin() != candidato.getDestinatin())
                            agregar = true;
                        else
                            agregar = false;
                    }
                    if (arist.getOrigin() != candidato.getOrigin())
                    {
                        if (arist.getDestinatin() != candidato.getDestinatin())
                            agregar = true;
                    }
                    if (arist.getDestinatin() != candidato.getDestinatin())
                    {
                        if (arist.getOrigin() != candidato.getOrigin())
                            agregar = true;
                    }
                }

                if (agregar)
                    arbolRM.Add(candidato);
            }
            
        }



        public void prim()
        {
            ListaArista candidatos = new ListaArista();
            ListaArista ARM = new ListaArista();
            inicializaCandidatos(candidatos, 1);
            candidatos.quickSort(0, candidatos.Count - 1);

            //for (int i = 0; i < candidatos.Count; i++) ;
            //{
            //    if()
            //}


        }

        

       
    }
}
