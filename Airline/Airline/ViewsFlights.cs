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
            viewsFlghtsUpdate(flights);
        }

        public void viewsFlghtsUpdate(FlightsList flightsList)
        {
            listViewFlights.Items.Clear();
            string[] arrString = new string[5];

            foreach (Flight flight in flightsList)
            {
                arrString[0] = flight.getRoute();
                arrString[1] = flight.getOriginCity().ToString();
                arrString[2] = flight.getDestinationCity().ToString();
                arrString[3] = flight.getFlightTime().ToString();
                arrString[4] = flight.getCost().ToString();
                ListViewItem item = new ListViewItem(arrString);
                listViewFlights.Items.Add(item);
            }

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            FlightsList filterFlightsList;
            int option = 0;
            if (radioButtonRoute.Checked)
                option = 1;
            else if (radioButtonOrigin.Checked)
                option = 2;
            else
                option = 3;
            filterFlightsList = flights.searchMatches(textBoxSearch.Text, option);
            viewsFlghtsUpdate(filterFlightsList);
        }
    }

   
}
