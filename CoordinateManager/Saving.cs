using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoordinateManager
{
    public partial class Saving : Form
    {
        List<World> worlds;
        public Saving(List<World> unSavedWorlds)
        {
            InitializeComponent();
            worlds = unSavedWorlds;
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            foreach (World i in CLB_worlds.SelectedItems)
            {
                i.SaveWorld();
            }
            DialogResult = DialogResult.Yes;
        }

        private void Saving_Load(object sender, EventArgs e)
        {
            if (worlds.Count == 0)
            {
                DialogResult = DialogResult.Yes;
                Close();
            }

            LBL_msg.Text = "Select the worlds you want to save.";
            BTN_all.Text = "All";
            BTN_none.Text = "None";
            BTN_inv.Text = "Invert";
            BTN_Save.Text = "Save";
            BTN_Can.Text = "Cancel";

            CLB_worlds.CheckOnClick = true;
            CLB_worlds.Items.Clear();
            CLB_worlds.Items.AddRange(worlds.ToArray<World>());
        }

        private void Saving_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.Yes)
            {
                DialogResult = DialogResult.No;
            }
        }
    }
}
