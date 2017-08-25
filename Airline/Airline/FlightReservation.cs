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

        private void buttonSell1_Click(object sender, EventArgs e)
        {
            sell = true;
            this.Close();
        }

        public void updateSeating()
        {
            //prueba de asintos
            flights[0].setSeating(0, false);
            flights[3].setSeating(3, false);

            List<Button> seatingButtons = new List<Button>(); ;
            int iterator = 0;

            seatingButtons.Add(buttonSeat1);
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
                if (flights[comboBoxFlights1.SelectedIndex].getSeating(iterator) == false)
                    buttonIterator.Enabled = false;
                else
                    buttonIterator.Enabled = true;
                iterator++;
            }
        }

        private void comboBoxFlights1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxFlights1.SelectedIndex >= 0)
            {
                updateSeating();
            }
        }
    }
}
