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

        public MainMenu(List<Flight> flights,List<Passenger> passengers)
        {
            this.flights = flights;
            this.passengers = passengers;
            InitializeComponent();
        }
        
        private void buttonReservation_Click(object sender, EventArgs e)
        {
            FlightReservation flightReservation = new FlightReservation(flights,passengers);
            flightReservation.ShowDialog();
        }

        private void buttonPassengers_Click(object sender, EventArgs e)
        {
            ViewsPassengers viewsPassengers = new ViewsPassengers(flights,passengers);
            viewsPassengers.ShowDialog();
        }

        private void buttonFlights_Click(object sender, EventArgs e)
        {
            ViewsFlights viewsFlights = new ViewsFlights();
            viewsFlights.ShowDialog();
        }
    }
}
