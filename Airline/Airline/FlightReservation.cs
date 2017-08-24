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
    public partial class FlightReservation : Form
    {
        private List<Flight> flights;
        private List<Passenger> passengers;
        private int seat;
        private bool sell;

        public FlightReservation(ref List<Flight> flights, ref List<Passenger> passengers)
        {
            this.passengers = passengers;
            this.flights = flights;
            InitializeComponent();
            seat = -1;
            sell = false;
            foreach(Flight flight in flights)
            {
                comboBoxFlights1.Items.Add(flight);
            }
            
        }

        public bool getSell()
        {
            return sell;
        }

        public void updateSeating()
        {
            
        }

        private void buttonSell1_Click(object sender, EventArgs e)
        {
            sell = true;
            this.Close();
        }
    }
}
