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
        static readonly string pth = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft";

        [STAThread]
        static void Main()
        {
            string[] d = Directory.GetDirectories(pth + @"\saves");

            foreach (string dir in d)
            {
                if (File.Exists(dir + @"\level.dat"))
                {
                    NbtFile worldFile = new NbtFile();
                    worldFile.LoadFromFile(dir + @"\level.dat");
                    var tag = worldFile.RootTag;
                    string name = (tag.Get<NbtCompound>("Data").Get<NbtString>("LevelName").Value.ToString());
                    worlds.Add(new World(dir, name, World.type.singlePlayer));
                }



            }

            if (!Directory.Exists(pth + @"\saves\coords"))
            {
                Directory.CreateDirectory(pth + @"\saves\coords");
            }



            NbtFile serverFile = new NbtFile();
            serverFile.LoadFromFile(pth + @"\servers.dat");

            var servers = serverFile.RootTag.Get<NbtList>("servers");

            for (int i = 0; i < servers.Count; i++)
            {
                string serverName;
                serverName = servers.Get<NbtCompound>(i).Get<NbtString>("name").Value.ToString();
                worlds.Add(new World(pth + @"\saves\coords\" + serverName + @".txt", serverName, World.type.server));
            }
                
            


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }
    }
}
