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
        bool create;
        int positionX, positionY;

        public GraphForm(bool create, Graph graph)
        {
            this.create = create;
            this.graph = graph;
            positionX = positionY = 0;
            InitializeComponent();
            initializeGraph();
            if (create)
                MessageBox.Show("Da click en la posicion de la nueva ciudad", "Informacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void initializeGraph()
        {
            Pen pen1 = new Pen(Color.Black, 2);
            Font drawFont = new Font("Impact", 12);
            SolidBrush drawBrush = new SolidBrush(Color.Purple);
            foreach (Node n in graph.getNodeList())
            {
               
                panelMap.CreateGraphics().DrawEllipse(pen1, n.getCity().getX(), n.getCity().getY(), 20, 20);
                //panelMap.CreateGraphics().DrawEllipse(pen1, X, Y, 20, 20);
                //panelMap.CreateGraphics().DrawString(n.getCity().getName(),drawFont,drawBrush, n.getCity().getX() + 10, n.getCity().getY() + 10);
            }
            AdjustableArrowCap bigArrow = new AdjustableArrowCap(6, 8);
            pen1.CustomEndCap = bigArrow;

            foreach (Node n in graph.getNodeList())
            {
                foreach (Adjacent adj in n.getAdjacentList())
                {
                    
                    int X = n.getCity().getX() + 10;
                    int Y = n.getCity().getY() + 10;
                    int J = adj.getNode().getCity().getX() + 10;
                    int K = adj.getNode().getCity().getY() + 10;
                    panelMap.CreateGraphics().DrawLine(pen1, X, Y, J, K);
                    int halfX = (X + J) / 2;
                    int halfY = (Y + K) / 2;
                    panelMap.CreateGraphics().DrawString(adj.getTime().ToString(), drawFont, drawBrush, halfX, halfY);
                }
            }

            foreach (Node n in graph.getNodeList())
            {
                panelMap.CreateGraphics().DrawString(n.getCity().getName(),drawFont,drawBrush, n.getCity().getX(), n.getCity().getY() - 15);
            }
        }

        private void panelMap_MouseClick(object sender, MouseEventArgs e)
        {
            if (create)
            {
                positionX = e.X - 10;
                positionY = e.Y - 10;
                MessageBox.Show("Punto almacenado", "Informacion ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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

        public int getY()
        {
            return positionY;
        }
    }
}
