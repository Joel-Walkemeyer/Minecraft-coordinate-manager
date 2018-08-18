using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using fNbt;



namespace CoordinateManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static List<World> worlds = new List<World>();
        static string pth;

        [STAThread]
        static void Main()
        {
            pth = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".minecraft");

            ReadWorlds();
            ReadServers();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }

        private static void ReadWorlds()
        {
            string[] d = Directory.GetDirectories(Path.Combine(pth, @"saves"));

            foreach (string dir in d)
            {
                if (File.Exists(Path.Combine(dir, @"level.dat")))
                {
                    NbtFile worldFile = new NbtFile();
                    worldFile.LoadFromFile(Path.Combine(dir, @"level.dat"));
                    var tag = worldFile.RootTag;
                    string name = (tag.Get<NbtCompound>("Data").Get<NbtString>("LevelName").Value.ToString());
                    worlds.Add(new World(dir, name, World.type.singlePlayer));
                }
            }
        }

        private static void ReadServers()
        {
            if (!Directory.Exists(Path.Combine(pth + @"saves\coords")))
            {
                Directory.CreateDirectory(Path.Combine(pth + @"saves\coords"));
            }

            NbtFile serverFile = new NbtFile();
            serverFile.LoadFromFile(Path.Combine(pth, "servers.dat"));

            var servers = serverFile.RootTag.Get<NbtList>("servers");

            for (int i = 0; i < servers.Count; i++)
            {
                string serverName;
                serverName = servers.Get<NbtCompound>(i).Get<NbtString>("name").Value.ToString();
                worlds.Add(new World(Path.Combine(pth, @"saves\coords\", serverName + @".txt"), serverName, World.type.server));
            }
        }
    }
}
