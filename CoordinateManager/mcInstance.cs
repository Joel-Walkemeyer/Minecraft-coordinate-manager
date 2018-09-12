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
        }
        
        public bool UnLoad()
        {
            List<World> changedWorlds = new List<World>();
            foreach (World world in worlds)
            {
                if (world.changed)
                {
                    changedWorlds.Add(world);
                }
            }
            if (changedWorlds.Count > 0)
            {
                Saving f = new Saving(changedWorlds);
                DialogResult t = f.ShowDialog();
                return t == DialogResult.Yes;
            }
            else
            {
                return true;
            }
        }
    }
}
