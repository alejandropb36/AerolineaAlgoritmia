﻿using System;
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
            Pen pen1 = new Pen(Color.Purple, 3);
            foreach (Node n in graph.getNodeList())
            {
                panelMap.CreateGraphics().DrawEllipse(pen1, n.getCity().getX(), n.getCity().getY(), 15, 15);
                //panelMap.CreateGraphics().DrawString(n.getCity().getName(),,, n.getCity().getX(), n.getCity().getY());
            }
            AdjustableArrowCap bigArrow = new AdjustableArrowCap(3, 6);
            pen1.Color = Color.Black;
            pen1.CustomEndCap = bigArrow;

            foreach (Node n in graph.getNodeList())
            {
                foreach (Adjacent adj in n.getAdjacentList())
                {
                    panelMap.CreateGraphics().DrawLine(pen1, n.getCity().getX() + 10, n.getCity().getY() + 10,
                        adj.getNode().getCity().getX() + 10, adj.getNode().getCity().getY() + 10);
                }
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
