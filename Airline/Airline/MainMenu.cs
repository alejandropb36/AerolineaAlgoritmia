using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    public partial class MainMenu : Form
    {
        FlightsList flights;
        Graph graph;
        public MainMenu(FlightsList flights, Graph graph)
        {
            this.graph = graph;
            this.flights = flights;
            InitializeComponent();
        }

        

        private void passengersButton_Click(object sender, EventArgs e)
        {
            ViewsPassengers viewsPassengers = new ViewsPassengers(flights);
            viewsPassengers.ShowDialog();
        }

        private void flightsButton_Click(object sender, EventArgs e)
        {
            ViewsFlights viewsFlights = new ViewsFlights(flights, graph);
            viewsFlights.ShowDialog();
        }

        private void buttonGraph_Click(object sender, EventArgs e)
        {
            GraphForm graphForm = new GraphForm(false,graph);
            graphForm.ShowDialog();
        }
    }
}
