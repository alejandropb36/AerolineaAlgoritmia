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
            viewsPassengersUpdate(flights);
        }
        

        public void viewsPassengersUpdate(FlightsList flights)
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

        public void viewsPassengersUpdate2(List<Passenger> filterPassengers)
        {
            listViewPassengers.Items.Clear();
            string[] arrString = new string[6];
                foreach (Passenger passenger in filterPassengers)
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

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            List<Passenger> filterPassengers = new List<Passenger>();
            if (textBoxSearch.Text == "")
                viewsPassengersUpdate(flights);
            else
            {
                int option = 0;
                if (radioButtonID.Checked)
                    option = 1;
                else if (radioButtonRoute.Checked)
                    option = 2;
                else
                    option = 3;
                filterPassengers = flights.searchMatchesPassenger(textBoxSearch.Text, option);
                viewsPassengersUpdate2(filterPassengers);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string id;
            if (listViewPassengers.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listViewPassengers.SelectedItems)
                {
                    id = item.Text;
                    if (flights.passengerDelete(id))
                    {
                        MessageBox.Show("El pasajero se elimino correctamente", "Informacion",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        viewsPassengersUpdate(flights);
                    }
                    else
                        MessageBox.Show("El pasajero no existe", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //Console.WriteLine(listViewFlights.SelectedItems.ToString());
                MessageBox.Show("Seleccione un pasajero", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
