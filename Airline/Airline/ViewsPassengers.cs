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
    public partial class ViewsPassengers : Form
    {
        FlightsList flights;
        public ViewsPassengers(FlightsList flights)
        {
            InitializeComponent();
            this.flights = flights;
            viewsPassengersUpdate();
        }
        

        public void viewsPassengersUpdate()
        {
            listViewPassengers.Items.Clear();
            string[] arrString = new string[6];
            
            foreach (Flight flight in flights)
            {
                foreach(Passenger passenger in flight.getPassengers())
                {
                    arrString[0] = passenger.getId();
                    arrString[1] = passenger.getFlightRoute();
                    arrString[2] = passenger.getName();
                    arrString[3] = passenger.getLastname();
                    arrString[4] = Convert.ToString(passenger.getAge());
                    arrString[5] = Convert.ToString(passenger.getSeatNumber() + 1);
                    ListViewItem item = new ListViewItem(arrString);
                    listViewPassengers.Items.Add(item);
                }
            }

        }
    }
}
