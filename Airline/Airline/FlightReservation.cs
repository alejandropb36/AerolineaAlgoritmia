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
        public FlightReservation(ref List<Flight> flights)
        {
            this.flights = flights;
            InitializeComponent();

            foreach(Flight flight in flights)
            {
                comboBoxFlights1.Items.Add(flight);
            }
            
        }
    }
}
