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
        private List<Flight> flights;
        private List<Passenger> passengers;

        public MainMenu(ref List<Flight> flights,ref List<Passenger> passengers)
        {
            this.flights = flights;
            this.passengers = passengers;
            InitializeComponent();
        }
        
        private void buttonReservation_Click(object sender, EventArgs e)
        {
            FlightReservation flightReservation = new FlightReservation(ref flights, ref passengers);
            flightReservation.ShowDialog();
        }

        private void buttonPassengers_Click(object sender, EventArgs e)
        {
            ViewsPassengers viewsPassengers = new ViewsPassengers(ref flights, ref passengers);
            viewsPassengers.ShowDialog();
        }

        private void buttonFlights_Click(object sender, EventArgs e)
        {
            ViewsFlights viewsFlights = new ViewsFlights();
            viewsFlights.ShowDialog();
        }
    }
}
