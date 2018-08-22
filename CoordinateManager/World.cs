using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fNbt;
using System.IO;

namespace CoordinateManager
{
    public class World
    {
        public string dir;
        public string name
        {
            get
            {
                NbtFile file = new NbtFile();
                file.LoadFromFile(Path.Combine(dir, "level.dat"));
                return file.RootTag.Get<NbtCompound>("Data").Get<NbtString>("LevelName").Value.ToString();
            }
        }

        public List<Coordinate> coords = new List<Coordinate>();

        public World(string directory)
        {
            dir = directory;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
