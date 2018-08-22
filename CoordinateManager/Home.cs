using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoordinateManager
{
    public partial class Home : Form
    {

        public List<string> instances = new List<string>();
        public bool edited;
        private Coordinate editingCrd;

        mcInstance mc = new mcInstance("MC", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".minecraft"));

        //Initial
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Editor
            BTN_Cancel.Text = "Cancel";
            BTN_Del.Text = "Delete";
            BTN_Edit.Text = "Save";
            BTN_TP.Text = "/TP command";
            BTN_New.Text = "New Coordinate";
            NUM_Xcoord.Minimum = -30000000;
            NUM_Ycoord.Minimum = 0;
            NUM_Zcoord.Minimum = -30000000;
            NUM_Xcoord.Maximum = 30000000;
            NUM_Ycoord.Maximum = 255;
            NUM_Zcoord.Maximum = 30000000;


            //World
            BTN_Save.Text = "Save";
            BTN_NewWorld.Text = "New World";
            BTN_Options.Text = "Settings";

            //Coords
            LVW_Coords.View = View.Details;
            LVW_Coords.Columns.Add("Place");
            LVW_Coords.Columns.Add("X");
            LVW_Coords.Columns.Add("Y");
            LVW_Coords.Columns.Add("Z");
            LVW_Coords.Columns.Add("Dimension");
            LVW_Coords.Columns.Add("Tag");
            LVW_Coords.Columns[0].Width = 120;
            LVW_Coords.Columns[4].Width = 80;
            LVW_Coords.Columns[5].Width = 100;
            for (int i = 1; i < 4; i++)
            {
                LVW_Coords.Columns[i].Width = 50;
            }
            LVW_Coords.HideSelection = false;

            CBX_WordlSel.DataSource = mc.worlds;
            CBX_DimSel.DataSource = Enum.GetNames(typeof(Coordinate.Dim));

            edited = false;
            PNL_Editor.BackColor = Color.FromKnownColor((KnownColor)Enum.Parse(typeof(KnownColor), Enum.GetNames(typeof(KnownColor))[0]));
            DisableEditor();
        }

        //Events

        private void LVW_Coords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LVW_Coords.SelectedItems.Count > 0)
            {
                editingCrd = (Coordinate)LVW_Coords.SelectedItems[0];
                EnableEditor(editingCrd);
            }
            else
            {
                DisableEditor();
            }
        }

        private void BTN_New_Click(object sender, EventArgs e)
        {
            if (LVW_Coords.SelectedItems.Count > 0)
            {
                LVW_Coords.SelectedItems[0].Selected = false;
            }
            editingCrd = new Coordinate();
            ((World)CBX_WordlSel.SelectedItem).coords.Add(editingCrd);
            EnableEditor(editingCrd);
        }

        private void BTN_Edit_Click(object sender, EventArgs e)
        {
            editingCrd.Name = TXT_Name.Text;
            editingCrd.X = (int)NUM_Xcoord.Value;
            editingCrd.Y = (int)NUM_Ycoord.Value;
            editingCrd.Z = (int)NUM_Zcoord.Value;
            editingCrd.dim = (Coordinate.Dim)Enum.Parse(typeof(Coordinate.Dim), CBX_DimSel.SelectedItem.ToString());
            UpdateList();

            editingCrd.Selected = true;
            PNL_Editor.Select();
        }

        private void CBX_WordlSel_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateList();
            if (e.ToString() == "")
            {
                BTN_NewWorld.Enabled = false;
            }
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            EnableEditor(editingCrd);
        }

        private void BTN_Del_Click(object sender, EventArgs e)
        {
            ((World)CBX_WordlSel.SelectedItem).coords.Remove(editingCrd);
            UpdateList();
            DisableEditor();
        }

        //Functions

        public void DisableEditor()
        {
            NUM_Xcoord.Controls[1].Text = "";
            NUM_Ycoord.Controls[1].Text = "";
            NUM_Zcoord.Controls[1].Text = "";

            TXT_Name.Text = "";
            CBX_DimSel.SelectedItem = null;
            CBX_TagSel.SelectedItem = null;

            BTN_Cancel.Enabled = false;
            BTN_Del.Enabled =    false;
            BTN_Edit.Enabled =   false;
            BTN_TP.Enabled =     false;
            TXT_Name.Enabled =   false;
            NUM_Xcoord.Enabled = false;
            NUM_Ycoord.Enabled = false;
            NUM_Zcoord.Enabled = false;
            CBX_DimSel.Enabled = false;
            CBX_TagSel.Enabled = false;
        }

        public void EnableEditor(Coordinate selectedCoord)
        {
            BTN_Cancel.Enabled = true;
            BTN_Del.Enabled =    true;
            BTN_Edit.Enabled =   true;
            BTN_TP.Enabled =     true;
            TXT_Name.Enabled =   true;
            NUM_Xcoord.Enabled = true;
            NUM_Ycoord.Enabled = true;
            NUM_Zcoord.Enabled = true;
            CBX_DimSel.Enabled = true;
            CBX_TagSel.Enabled = true;

            TXT_Name.Text = selectedCoord.Name;
            NUM_Xcoord.Controls[1].Text = selectedCoord.X.ToString();
            NUM_Ycoord.Controls[1].Text = selectedCoord.Y.ToString();
            NUM_Zcoord.Controls[1].Text = selectedCoord.Z.ToString();
            NUM_Xcoord.Value = selectedCoord.X;
            NUM_Ycoord.Value = selectedCoord.Y;
            NUM_Zcoord.Value = selectedCoord.Z;
            CBX_DimSel.SelectedItem = selectedCoord.dim.ToString();
        }

        public void UpdateList()
        {
            LVW_Coords.Items.Clear();
            LVW_Coords.Items.AddRange(((World)CBX_WordlSel.SelectedItem).coords.ToArray());
        }

        private DialogResult ConfirmClose()
        {
            return MessageBox.Show("Do you want to save your changes?", "Save changes?", MessageBoxButtons.YesNoCancel);
        }

        private void SaveWorld(string file)
        {
        }

        private void OpenWorld(string file)
        {
        }
    }
}
