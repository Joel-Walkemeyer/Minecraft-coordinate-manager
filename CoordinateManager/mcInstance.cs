using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CoordinateManager
{
    public class mcInstance
    {
        public int worldCount;
        public string name, dir;
        public List<World> worlds = new List<World>();

        public mcInstance(string name, string dir)
        {
            this.name = name;
            this.dir = dir;
            FRM_Loading load = new FRM_Loading(worldCount, this);
            load.ShowDialog();
            /*
            if (Directory.Exists(Path.Combine(dir, "saves")))
            {
                worldCount = Directory.GetDirectories(Path.Combine(dir, "saves")).Length;
                foreach (string file in Directory.GetDirectories(Path.Combine(dir, "saves")))
                {
                    if (!File.Exists(file))
                    {
                        worlds.Add(new World(file));
                        load.count++;
                    }
                }
            }
            */
        }
    }
}
