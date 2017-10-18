using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            List<City> cities = new List<City>();
            FlightsList flights = new FlightsList();
            Graph graph = new Graph(flights);

            if (File.Exists("Flights.bin"))
            {
                using (Stream s = File.Open("Flights.bin", FileMode.Open))
                {
                    var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    flights = (FlightsList)formatter.Deserialize(s);
                    s.Close();
                }
            }
            //else
            //{
            //    Flight flight1 = new Flight("A", "B", 50, 600);
            //    Flight flight2 = new Flight("A", "F", 90, 1050);
            //    Flight flight3 = new Flight("A", "G", 80, 1150);
            //    Flight flight4 = new Flight("B", "A", 50, 600);
            //    Flight flight5 = new Flight("B", "C", 40, 750);
            //    Flight flight6 = new Flight("B", "D", 60, 650);
            //    Flight flight7 = new Flight("B", "E", 70, 1850);
            //    Flight flight8 = new Flight("C", "B", 35, 800);
            //    Flight flight9 = new Flight("C", "E", 50, 850);
            //    Flight flight10 = new Flight("E", "C", 45, 750);
            //    Flight flight11 = new Flight("E", "G", 80, 1150);
            //    Flight flight12 = new Flight("E", "L", 60, 1650);
            //    Flight flight13 = new Flight("E", "D", 35, 700);
            //    Flight flight14 = new Flight("D", "E", 45, 900);
            //    Flight flight15 = new Flight("D", "B", 55, 700);
            //    Flight flight16 = new Flight("F", "B", 65, 800);
            //    Flight flight17 = new Flight("F", "L", 140, 2850);
            //    Flight flight18 = new Flight("G", "A", 95, 1250);
            //    Flight flight19 = new Flight("G", "E", 75, 1175);
            //    Flight flight20 = new Flight("G", "L", 135, 2675);
            //    Flight flight21 = new Flight("G", "J", 60, 1400);
            //    Flight flight22 = new Flight("G", "H", 25, 450);
            //    Flight flight23 = new Flight("H", "G", 30, 350);
            //    Flight flight24 = new Flight("H", "I", 35, 400);
            //    Flight flight25 = new Flight("I", "H", 30, 400);
            //    Flight flight26 = new Flight("I", "K", 35, 400);
            //    Flight flight27 = new Flight("K", "I", 35, 400);
            //    Flight flight28 = new Flight("K", "J", 25, 300);
            //    Flight flight29 = new Flight("J", "L", 40, 750);
            //    Flight flight30 = new Flight("J", "M", 70, 1450);
            //    Flight flight31 = new Flight("L", "M", 40, 650);
            //    Flight flight32 = new Flight("L", "K", 70, 700);
            //    Flight flight33 = new Flight("L", "E", 60, 1550);
            //    Flight flight34 = new Flight("M", "L", 40, 700);

            //    flights.Add(flight1);
            //    flights.Add(flight2);
            //    flights.Add(flight3);
            //    flights.Add(flight4);
            //    flights.Add(flight5);
            //    flights.Add(flight6);
            //    flights.Add(flight7);
            //    flights.Add(flight8);
            //    flights.Add(flight9);
            //    flights.Add(flight10);
            //    flights.Add(flight11);
            //    flights.Add(flight12);
            //    flights.Add(flight13);
            //    flights.Add(flight14);
            //    flights.Add(flight15);
            //    flights.Add(flight16);
            //    flights.Add(flight17);
            //    flights.Add(flight18);
            //    flights.Add(flight19);
            //    flights.Add(flight20);
            //    flights.Add(flight21);
            //    flights.Add(flight22);
            //    flights.Add(flight23);
            //    flights.Add(flight24);
            //    flights.Add(flight25);
            //    flights.Add(flight26);
            //    flights.Add(flight27);
            //    flights.Add(flight28);
            //    flights.Add(flight29);
            //    flights.Add(flight30);
            //    flights.Add(flight31);
            //    flights.Add(flight32);
            //    flights.Add(flight33);
            //    flights.Add(flight34);
            //}
            
            if (File.Exists("Graph.bin"))
            {
                using (Stream s = File.Open("Graph.bin", FileMode.Open))
                {
                    var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    graph = (Graph)formatter.Deserialize(s);
                    s.Close();
                }
            }
            //else
            //{
            //    graph = new Graph(flights);
            //}
           

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainMenu());
            MainMenu mainMenu = new MainMenu(flights, graph);
            mainMenu.ShowDialog();

            File.Delete("Flights.bin");
            using (Stream s = File.Create("Flights.bin"))
            {
                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                formatter.Serialize(s, flights);
                s.Close();
            }

            File.Delete("Graph.bin");
            using (Stream s = File.Create("Graph.bin"))
            {
                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                formatter.Serialize(s, graph);
                s.Close();
            }
        }
    }
}
