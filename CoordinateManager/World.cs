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
        public bool changed;
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
            if (File.Exists(Path.Combine(dir, "coords.dat")))
            {
                OpenWorld();
            }
        }

        public override string ToString()
        {
            return name;
        }

        public void RemoveCoord(Coordinate crd)
        {
            coords.Remove(crd);
        }

        public void OpenWorld()
        {
            NbtFile file = new NbtFile();
            file.LoadFromFile(Path.Combine(dir, "coords.dat"));
            NbtList clist = file.RootTag.Get<NbtList>("DATA");
            foreach (NbtCompound c in clist)
            {
                string Name = (c.Get<NbtString>("Name")).Value;
                int X = c.Get<NbtInt>("X").Value;
                int Y = c.Get<NbtInt>("Y").Value;
                int Z = c.Get<NbtInt>("Z").Value;
                int Dim = c.Get<NbtInt>("Dim").Value;
                coords.Add(new Coordinate(Name, X, Y, Z, (Coordinate.Dim)Dim));
            }
        }
        
        public void SaveWorld()
        {
            NbtFile file = new NbtFile();
            try
            {
                file.RootTag.Clear();
            }
            catch { }

            NbtList cList = new NbtList("DATA");
            foreach (Coordinate c in coords)
            {
                NbtCompound cData = new NbtCompound();
                cData.Add(new NbtString("Name", c.Name));
                cData.Add(new NbtInt("X", c.X));
                cData.Add(new NbtInt("Y", c.Y));
                cData.Add(new NbtInt("Z", c.Z));
                cData.Add(new NbtInt("Dim", (int)c.dim));
                cList.Add(cData);
            }

            file.RootTag.Add(cList);
            file.SaveToFile(Path.Combine(dir, "coords.dat"), NbtCompression.None);
        }
    }
}
