using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    class Passenger
    {
        private string name;
        private string lastname;
        private int age;
        private int id;
        // Vuelo
        // Asiento

        public Passenger()
        {
        }

        public Passenger(string name, string lastname, int age, int id)
        {
            this.name = name;
            this.lastname = lastname;
            this.age = age;
            this.id = id;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setLastname(string lastname)
        {
            this.lastname = lastname;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public string getName()
        {
            return name;
        }

        public string getLastname()
        {
            return lastname;
        }

        public int getAge()
        {
            return age;
        }
        public int getId()
        {
            return id;
        }
    }
}
