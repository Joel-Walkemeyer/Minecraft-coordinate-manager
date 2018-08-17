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
    public partial class Coordinate_Editor : Form
    {
        int coordID;
        Home home;

        public Coordinate_Editor(int crdID, Home home)
        {
            InitializeComponent();

            this.home = home;
            coordID = crdID;
        }

        private void Coordinate_Editor_Load(object sender, EventArgs e)
        {
            CBX_DimSelect.DataSource = Enum.GetValues(typeof(Coordinate.Dim));

            TXT_name.Text = Program.worlds[home.currentWorldID].coords[coordID].SubItems[(int)Coordinate.Prop.name].Text;
            NUM_x.Value = int.Parse(Program.worlds[home.currentWorldID].coords[coordID].SubItems[(int)Coordinate.Prop.x].Text);
            NUM_y.Value = int.Parse(Program.worlds[home.currentWorldID].coords[coordID].SubItems[(int)Coordinate.Prop.y].Text);
            NUM_z.Value = int.Parse(Program.worlds[home.currentWorldID].coords[coordID].SubItems[(int)Coordinate.Prop.z].Text);
            CBX_DimSelect.SelectedItem = Enum.Parse(typeof(Coordinate.Dim), Program.worlds[home.currentWorldID].coords[coordID].SubItems[(int)Coordinate.Prop.dim].Text);
        }

        private void BTN_save_Click(object sender, EventArgs e)
        {
            Program.worlds[home.currentWorldID].coords[coordID] = new Coordinate(TXT_name.Text, (int)NUM_x.Value, (int)NUM_y.Value, (int)NUM_z.Value, (Coordinate.Dim)CBX_DimSelect.SelectedItem);
            Close();
        }

        private void BTN_del_Click(object sender, EventArgs e)
        {
            Program.worlds[home.currentWorldID].coords.Remove(Program.worlds[home.currentWorldID].coords[coordID]);
            Close();
        }

        private void BTN_can_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Coordinate_Editor_FormClosed(object sender, FormClosedEventArgs e)
        {
            home.DeselectCoord();
            home.UpdateList();
        }
    }
}
