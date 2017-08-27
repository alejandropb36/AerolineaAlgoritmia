﻿using System;
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
        private int seatNumber;
        private bool sell;

        public FlightReservation(ref List<Flight> flights, ref List<Passenger> passengers)
        {
            this.passengers = passengers;
            this.flights = flights;
            InitializeComponent();
            seatNumber = -1;
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
            //prueba de asientos
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

        private void buttonSeat1_Click(object sender, EventArgs e)
        {
            seatNumber = 0;
        }

        private void buttonSeat2_Click(object sender, EventArgs e)
        {
            seatNumber = 1;
        }

        private void buttonSeat3_Click(object sender, EventArgs e)
        {
            seatNumber = 2;
        }

        private void buttonSeat4_Click(object sender, EventArgs e)
        {
            seatNumber = 3;
        }

        private void buttonSeat5_Click(object sender, EventArgs e)
        {
            seatNumber = 4;
        }

        private void buttonSeat6_Click(object sender, EventArgs e)
        {
            seatNumber = 5;
        }

        private void buttonSeat7_Click(object sender, EventArgs e)
        {
            seatNumber = 6;
        }

        private void buttonSeat8_Click(object sender, EventArgs e)
        {
            seatNumber = 7;
        }

        private void buttonSeat9_Click(object sender, EventArgs e)
        {
            seatNumber = 8;
        }

        private void buttonSeat10_Click(object sender, EventArgs e)
        {
            seatNumber = 9;
        }

        private void buttonSeat11_Click(object sender, EventArgs e)
        {
            seatNumber = 10;
        }

        private void buttonSeat12_Click(object sender, EventArgs e)
        {
            seatNumber = 11;
        }

        private void buttonSeat13_Click(object sender, EventArgs e)
        {
            seatNumber = 12;
        }

        private void buttonSeat14_Click(object sender, EventArgs e)
        {
            seatNumber = 13;
        }

        private void buttonSeat15_Click(object sender, EventArgs e)
        {
            seatNumber = 14;
        }

        private void buttonSeat16_Click(object sender, EventArgs e)
        {
            seatNumber = 15;
        }

        private void buttonSeat17_Click(object sender, EventArgs e)
        {
            seatNumber = 16;
        }

        private void buttonSeat18_Click(object sender, EventArgs e)
        {
            seatNumber = 17;
        }
    }
}
