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
    public partial class ViewsFlights : Form
    {
        FlightsList flights;

        public ViewsFlights(FlightsList flights)
        {
            InitializeComponent();
            this.flights = flights;
            viewsFlghtsUpdate();
        }

        public void viewsFlghtsUpdate()
        {
            listViewFlights1.Items.Clear();
            string[] arrString = new string[5];

            foreach (Flight flight in flights)
            {
                arrString[0] = flight.getRoute();
                arrString[1] = flight.getOriginCity().ToString();
                arrString[2] = flight.getDestinationCity().ToString();
                arrString[3] = flight.getFlightTime().ToString();
                arrString[4] = flight.getCost().ToString();
                ListViewItem item = new ListViewItem(arrString);
                listViewFlights1.Items.Add(item);
            }

        }
    }

   
}
