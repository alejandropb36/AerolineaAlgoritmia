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
        FlightsList flights;
        int seatNumber;
        bool sell;


        public FlightReservation(FlightsList flights)
        {
            InitializeComponent();
            this.flights = flights;
            seatNumber = -1;
            sell = false;
            foreach(Flight flight in flights)
            {
                comboBoxFlights.Items.Add(flight);
            }
        }

        public bool getSell()
        {
            return sell;
        }

        public void seatsUpdate()
        {
            //prueba de asientos
            //flights[0].setSeating(0, false);
            //flights[3].setSeating(3, false);

            List<Button> seatingButtons = new List<Button>(); ;
            int iterator = 0;

            seatingButtons.Add(seatButton1);
            seatingButtons.Add(buttonSeat2);
            seatingButtons.Add(buttonSeat3);
            seatingButtons.Add(buttonSeat4);
            seatingButtons.Add(buttonSeat5);
            seatingButtons.Add(buttonSeat6);
            seatingButtons.Add(buttonSeat7);
            seatingButtons.Add(buttonSeat8);
            seatingButtons.Add(buttonSeat9);
            seatingButtons.Add(buttonSeat10);
            seatingButtons.Add(buttonSeat11);
            seatingButtons.Add(buttonSeat12);
            seatingButtons.Add(buttonSeat13);
            seatingButtons.Add(buttonSeat14);
            seatingButtons.Add(buttonSeat15);
            seatingButtons.Add(buttonSeat16);
            seatingButtons.Add(buttonSeat17);
            seatingButtons.Add(buttonSeat18);

            foreach (Button buttonIterator in seatingButtons)
            {
                if (flights[comboBoxFlights.SelectedIndex].getSeating(iterator) == false)
                {
                    buttonIterator.Enabled = false;
                    buttonIterator.BackColor = Color.IndianRed;
                }
                else
                {
                    buttonIterator.Enabled = true;
                    buttonIterator.BackColor = Color.LightGreen;
                }
                    
                iterator++;
            }
        }

        private void comboBoxFlights1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxFlights.SelectedIndex >= 0)
            {
                seatsUpdate();
            }
        }

        private void buttonSeat1_Click(object sender, EventArgs e)
        {
            seatNumber = 0;
            labelSeatNumber.Text = (seatNumber + 1).ToString();
        }

        private void buttonSeat2_Click(object sender, EventArgs e)
        {
            seatNumber = 1;
            labelSeatNumber.Text = (seatNumber + 1).ToString();
        }

        private void buttonSeat3_Click(object sender, EventArgs e)
        {
            seatNumber = 2;
            labelSeatNumber.Text = (seatNumber + 1).ToString();
        }

        private void buttonSeat4_Click(object sender, EventArgs e)
        {
            seatNumber = 3;
            labelSeatNumber.Text = (seatNumber + 1).ToString();
        }

        private void buttonSeat5_Click(object sender, EventArgs e)
        {
            seatNumber = 4;
            labelSeatNumber.Text = (seatNumber + 1).ToString();
        }

        private void buttonSeat6_Click(object sender, EventArgs e)
        {
            seatNumber = 5;
            labelSeatNumber.Text = (seatNumber + 1).ToString();
        }

        private void buttonSeat7_Click(object sender, EventArgs e)
        {
            seatNumber = 6;
            labelSeatNumber.Text = (seatNumber + 1).ToString();
        }

        private void buttonSeat8_Click(object sender, EventArgs e)
        {
            seatNumber = 7;
            labelSeatNumber.Text = (seatNumber + 1).ToString();
        }

        private void buttonSeat9_Click(object sender, EventArgs e)
        {
            seatNumber = 8;
            labelSeatNumber.Text = (seatNumber + 1).ToString();
        }

        private void buttonSeat10_Click(object sender, EventArgs e)
        {
            seatNumber = 9;
            labelSeatNumber.Text = (seatNumber + 1).ToString();
        }

        private void buttonSeat11_Click(object sender, EventArgs e)
        {
            seatNumber = 10;
            labelSeatNumber.Text = (seatNumber + 1).ToString();
        }

        private void buttonSeat12_Click(object sender, EventArgs e)
        {
            seatNumber = 11;
            labelSeatNumber.Text = (seatNumber + 1).ToString();
        }

        private void buttonSeat13_Click(object sender, EventArgs e)
        {
            seatNumber = 12;
            labelSeatNumber.Text = (seatNumber + 1).ToString();
        }

        private void buttonSeat14_Click(object sender, EventArgs e)
        {
            seatNumber = 13;
            labelSeatNumber.Text = (seatNumber + 1).ToString();
        }

        private void buttonSeat15_Click(object sender, EventArgs e)
        {
            seatNumber = 14;
            labelSeatNumber.Text = (seatNumber + 1).ToString();
        }

        private void buttonSeat16_Click(object sender, EventArgs e)
        {
            seatNumber = 15;
            labelSeatNumber.Text = (seatNumber + 1).ToString();
        }

        private void buttonSeat17_Click(object sender, EventArgs e)
        {
            seatNumber = 16;
            labelSeatNumber.Text = (seatNumber + 1).ToString();
        }

        private void buttonSeat18_Click(object sender, EventArgs e)
        {
            seatNumber = 17;
            labelSeatNumber.Text = (seatNumber + 1).ToString();
        }


        private void buttonSell1_Click(object sender, EventArgs e)
        {
            string name, lastname, route, id;
            int age;
            Passenger passenger;
            bool ageFlag;
            if (comboBoxFlights.SelectedIndex >= 0)
            {
                if (textBoxPassengerName.Text != "")
                {
                    if (textBoxPassengerLastName.Text != "")
                    {
                        if(textBoxPassengerAge.Text != "")
                        {
                            ageFlag = int.TryParse(textBoxPassengerAge.Text, out age);
                            if (ageFlag)
                            {
                                if (seatNumber > -1)
                                {
                                    name = textBoxPassengerName.Text;
                                    lastname = textBoxPassengerLastName.Text;
                                    route = flights[comboBoxFlights.SelectedIndex].getRoute();
                                    flights[comboBoxFlights.SelectedIndex].setSeating(seatNumber, false);
                                    id = route;
                                    id += Convert.ToString(seatNumber + 1);
                                    passenger = new Passenger(name, lastname, age, id, seatNumber, route);
                                    flights[comboBoxFlights.SelectedIndex].getPassengers().Add(passenger);
                                    sell = true;
                                    MessageBox.Show("El ID de pasajero es: " + id, "ID", 
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                    MessageBox.Show("Sellecione un asiento", "Advertencia",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                                MessageBox.Show("Introduzca una edad valida!", "Advertencia",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                            MessageBox.Show("Introduzca una edad", "Advertencia",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                        MessageBox.Show("Introduzca un apellido", "Advertencia",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    MessageBox.Show("Introduzca un nombre!", "Advertencia",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Seleccione un vuelo!", "Advertencia",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
