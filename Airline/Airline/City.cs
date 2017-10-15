using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    [Serializable]
    public class City
    {
        string name;
        int x, y;

        public City(string name)
        {
            this.name = name;
        }

        public City(string name, int x, int y)
        {
            this.name = name;
            this.x = x;
            this.y = y;
        }

        public string getName()
        {
            return name;
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }
    }
}
