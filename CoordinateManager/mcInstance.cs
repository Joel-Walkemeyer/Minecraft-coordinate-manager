using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CoordinateManager
{
    class mcInstance
    {
        public string name, dir;
        public List<World> worlds = new List<World>();

        public mcInstance(string name, string dir)
        {
            this.name = name;
            this.dir = dir;

            foreach (string file in Directory.GetDirectories(Path.Combine(dir, "saves")))
            {
                if (!File.Exists(file))
                {
                    worlds.Add(new World(file));
                }
            }
        }
    }
}
