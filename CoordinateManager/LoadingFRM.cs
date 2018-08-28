using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CoordinateManager
{
    public partial class FRM_Loading : Form
    {
        mcInstance inst = null;
        private int total;

        public FRM_Loading(int total, mcInstance instance)
        {
            inst = instance;
            this.total = total;
            InitializeComponent();
            PGB_Load.Value = 0;
        }

        private void LoadingFRM_Load(object sender, EventArgs e)
        {

        }

        public void LoadWorlds()
        {
            if (Directory.Exists(Path.Combine(inst.dir, "saves")))
            {
                PGB_Load.Maximum = Directory.GetDirectories(Path.Combine(inst.dir, "saves")).Length;
                foreach (string file in Directory.GetDirectories(Path.Combine(inst.dir, "saves")))
                {
                    if (!File.Exists(file))
                    {
                        inst.worlds.Add(new World(file));
                    }
                    PGB_Load.Value++;
                }
            }
        }

        private void FRM_Loading_Shown(object sender, EventArgs e)
        {
            LoadWorlds();
            Close();
        }
    }
}
