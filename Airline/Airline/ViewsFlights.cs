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
        FlightsList filterFlightsList;

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
                arrString[1] = flight.getOriginCity();
                arrString[2] = flight.getDestinationCity();
                arrString[3] = flight.getFlightTime().ToString();
                arrString[4] = flight.getCost().ToString();
                ListViewItem item = new ListViewItem(arrString);
                listViewFlights.Items.Add(item);
            }

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if(textBoxSearch.Text == "")
                viewsFlghtsUpdate(flights);
            else
            {
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Flight newflight;
            string route;
            bool parseInt;
            int time, cost;
            if (textBoxOrigin.Text != "")
            {
                if (textBoxOrigin.Text.Length == 1)
                {
                    if (textBoxDestination.Text != "")
                    {
                        if (textBoxDestination.Text.Length == 1)
                        {
                            if (textBoxTime.Text != "")
                            {
                                parseInt = int.TryParse(textBoxTime.Text, out time);
                                if(parseInt)
                                {
                                    if (textBoxCost.Text != "")
                                    {
                                        parseInt = int.TryParse(textBoxCost.Text, out cost);
                                        if (parseInt)
                                        {
                                            route = "SK1" + textBoxOrigin.Text + textBoxDestination.Text;
                                            if(!flights.flightExistence(route))
                                            {
                                                newflight = new Flight(textBoxOrigin.Text, textBoxDestination.Text, time, cost);
                                                flights.Add(newflight);
                                                MessageBox.Show("Vuelo agregado exitosamente", "Informacion",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                textBoxOrigin.Text = "";
                                                textBoxDestination.Text = "";
                                                textBoxTime.Text = "";
                                                textBoxCost.Text = "";
                                                viewsFlghtsUpdate(flights);
                                            }
                                            else
                                                MessageBox.Show("El vuelo ya existe", "Error",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else
                                            MessageBox.Show("Introduzca un costo valido", "Advertencia",
                                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                    else
                                        MessageBox.Show("Introduzca el costo", "Advertencia",
                                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                                else
                                    MessageBox.Show("Introduzca un timepo valido", "Advertencia",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                                MessageBox.Show("Introduzca el Tiempo", "Advertencia",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                            MessageBox.Show("Destino no valido", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                        MessageBox.Show("Introduzca un Destino", "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("Origen no valido", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Introduzca un Origen", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string route;
            if(textBoxDelete.Text != "")
            {
                route = textBoxDelete.Text;
                if (flights.flightDelete(route))
                {
                    MessageBox.Show("El vuelo se elimino correctamente", "Informacion",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxDelete.Text = "";
                    viewsFlghtsUpdate(flights);
                }
                else
                    MessageBox.Show("El vuelo no existe", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Console.WriteLine(listViewFlights.SelectedItems.ToString());
                MessageBox.Show("Escribe una ruta", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
