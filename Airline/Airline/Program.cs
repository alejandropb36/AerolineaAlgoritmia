using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FlightsList flights = new FlightsList();
            Flight flight1 = new Flight('A', 50, 600, 'B');
            Flight flight2 = new Flight('A', 90, 1050, 'F');
            Flight flight3 = new Flight('A', 80, 1150, 'G');
            Flight flight4 = new Flight('B', 50, 600, 'A');
            Flight flight5 = new Flight('B', 40, 750, 'C');
            Flight flight6 = new Flight('B', 60, 650, 'D');
            Flight flight7 = new Flight('B', 70, 1850, 'E');
            Flight flight8 = new Flight('C', 35, 800, 'B');
            Flight flight9 = new Flight('C', 50, 850, 'E');
            Flight flight10 = new Flight('E', 45, 750, 'C');
            Flight flight11 = new Flight('E', 80, 1150, 'G');
            Flight flight12 = new Flight('E', 60, 1650, 'L');
            Flight flight13 = new Flight('E', 35, 700, 'D');
            Flight flight14 = new Flight('D', 45, 900, 'E');
            Flight flight15 = new Flight('D', 55, 700, 'B');
            Flight flight16 = new Flight('F', 65, 800, 'B');
            Flight flight17 = new Flight('F', 140, 2850, 'L');
            Flight flight18 = new Flight('G', 95, 1250, 'A');
            Flight flight19 = new Flight('G', 75, 1175, 'E');
            Flight flight20 = new Flight('G', 135, 2675, 'L');
            Flight flight21 = new Flight('G', 60, 1400, 'J');
            Flight flight22 = new Flight('G', 25, 450, 'H');
            Flight flight23 = new Flight('H', 30, 350, 'G');
            Flight flight24 = new Flight('H', 35, 400, 'I');
            Flight flight25 = new Flight('I', 30, 400, 'H');
            Flight flight26 = new Flight('I', 35, 400, 'K');
            Flight flight27 = new Flight('K', 35, 400, 'I');
            Flight flight28 = new Flight('K', 25, 300, 'J');
            Flight flight29 = new Flight('J', 40, 750, 'L');
            Flight flight30 = new Flight('J', 70, 1450, 'M');
            Flight flight31 = new Flight('L', 40, 650, 'M');
            Flight flight32 = new Flight('L', 70, 700, 'K');
            Flight flight33 = new Flight('L', 60, 1550, 'E');
            Flight flight34 = new Flight('M', 40, 700, 'L');

            flights.Add(flight1);
            flights.Add(flight2);
            flights.Add(flight3);
            flights.Add(flight4);
            flights.Add(flight5);
            flights.Add(flight6);
            flights.Add(flight7);
            flights.Add(flight8);
            flights.Add(flight9);
            flights.Add(flight10);
            flights.Add(flight11);
            flights.Add(flight12);
            flights.Add(flight13);
            flights.Add(flight14);
            flights.Add(flight15);
            flights.Add(flight16);
            flights.Add(flight17);
            flights.Add(flight18);
            flights.Add(flight19);
            flights.Add(flight20);
            flights.Add(flight21);
            flights.Add(flight22);
            flights.Add(flight23);
            flights.Add(flight24);
            flights.Add(flight25);
            flights.Add(flight26);
            flights.Add(flight27);
            flights.Add(flight28);
            flights.Add(flight29);
            flights.Add(flight30);
            flights.Add(flight31);
            flights.Add(flight32);
            flights.Add(flight33);
            flights.Add(flight34);
           

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainMenu());
            MainMenu mainMenu = new MainMenu(flights);
            mainMenu.ShowDialog();
        }
    }
}
