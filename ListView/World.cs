using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordinateManager
{
    public class World
    {
        public enum type{ other = 0, singlePlayer, server };
        private string worldType;
        public string dir;
        public string name;
        public List<Coordinate> coords = new List<Coordinate>();

        public World(string directory, string worldName, type worldType = type.other)
        {
            this.worldType = worldType.ToString();
            dir = directory;
            name = worldName;
        }

        public override string ToString()
        {
            string s = "";
            s += worldType;
            s += " ".PadRight(15, ' ') + "> ";
            s += name;
            return s;
        }
    }
}
