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
        private List<Flight> flightList;

        public MainMenu(ref List<Flight> flightList)
        {
            this.flightList = flightList;
            InitializeComponent();
        }
        
        private void buttonReservation_Click(object sender, EventArgs e)
        {
            FlightReservation flightReservation = new FlightReservation();
            flightReservation.ShowDialog();
        }
    }
}
