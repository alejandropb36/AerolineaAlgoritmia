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
            List<Flight> flightList = new List<Flight>();
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

            flightList.Add(flight1);
            flightList.Add(flight2);
            flightList.Add(flight3);
            flightList.Add(flight4);
            flightList.Add(flight5);
            flightList.Add(flight6);
            flightList.Add(flight7);
            flightList.Add(flight8);
            flightList.Add(flight9);
            flightList.Add(flight10);
            flightList.Add(flight11);
            flightList.Add(flight12);
            flightList.Add(flight13);
            flightList.Add(flight14);
            flightList.Add(flight15);
            flightList.Add(flight16);
            flightList.Add(flight17);
            flightList.Add(flight18);
            flightList.Add(flight19);
            flightList.Add(flight20);
            flightList.Add(flight21);
            flightList.Add(flight22);
            flightList.Add(flight23);
            flightList.Add(flight24);
            flightList.Add(flight25);
            flightList.Add(flight26);
            flightList.Add(flight27);
            flightList.Add(flight28);
            flightList.Add(flight29);
            flightList.Add(flight30);
            flightList.Add(flight31);
            flightList.Add(flight32);
            flightList.Add(flight33);
            flightList.Add(flight34);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainMenu());
            MainMenu mainMenu = new MainMenu(ref flightList);
            mainMenu.ShowDialog();
        }
    }
}
