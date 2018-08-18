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
        public bool edited;
        public int currentWorldID;

        //Initial
        
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LVW_List.View = View.Details;

            CBX_WorldSelect.DataSource = Program.worlds;

            UpdateList();
            edited = false;
        }

        //Events

        private void BTN_new_Click(object sender, EventArgs e)
        {
            Coordinate ncrd = new Coordinate();
            Program.worlds[currentWorldID].coords.Add(ncrd);
            EditCoord(Program.worlds[currentWorldID].coords.IndexOf(ncrd));
        }

        private void BTN_del_Click(object sender, EventArgs e)
        {
            Program.worlds[currentWorldID].coords.RemoveAt(Program.worlds[currentWorldID].coords.IndexOf((Coordinate)LVW_List.SelectedItems[0]));
            UpdateList();
        }

        private void BTN_edit_Click(object sender, EventArgs e)
        {
            EditCoord(Program.worlds[currentWorldID].coords.IndexOf((Coordinate)LVW_List.SelectedItems[0]));
        }

        private void BTN_TP_Click(object sender, EventArgs e)
        {
            ListViewItem.ListViewSubItemCollection loc = ((Coordinate)LVW_List.SelectedItems[0]).SubItems;
            TP_command frm = new TP_command(String.Format("/execute in {0} run tp {1} {2} {3}", loc[(int)Coordinate.Prop.dim].Text.ToLower(), loc[(int)Coordinate.Prop.x].Text, loc[(int)Coordinate.Prop.y].Text, loc[(int)Coordinate.Prop.z].Text));
            frm.ShowDialog();
            string s = LVW_List.SelectedItems[0].ToString();
        }

        private void LVW_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckSelection();
        }

        private void CBX_WorldSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (edited)
            {
                DialogResult num = ConfirmClose();

                switch (num)
                {
                    case DialogResult.None:
                        CBX_WorldSelect.SelectedIndex = currentWorldID;
                        return;
                    case DialogResult.Cancel:
                        CBX_WorldSelect.SelectedIndex = currentWorldID;
                        return;
                    case DialogResult.Yes:
                        Save(Program.worlds[currentWorldID].dir);
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }
            }

            currentWorldID = CBX_WorldSelect.SelectedIndex;
            Open((Program.worlds[currentWorldID].dir));
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (edited)
            {
                DialogResult num = ConfirmClose();

                switch (num)
                {
                    case DialogResult.None:
                        e.Cancel = true;
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                    case DialogResult.Yes:
                        Save(((World)CBX_WorldSelect.SelectedItem).dir);
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }
            }
        }

        //Functions

        public void CheckSelection()
        {
            if (LVW_List.SelectedItems.Count == 0)
            {
                BTN_del.Enabled = false;
                BTN_edit.Enabled = false;
                BTN_TP.Enabled = false;
            }
            else
            {
                BTN_del.Enabled = true;
                BTN_edit.Enabled = true;
                BTN_TP.Enabled = true;
            }
        }

        private void EditCoord(int crd)
        {
            Coordinate_Editor frm = new Coordinate_Editor(crd, this);
            frm.ShowDialog();
        }


        public void UpdateList()
        {
            edited = true;

            LVW_List.Items.Clear();
            LVW_List.Items.AddRange(Program.worlds[currentWorldID].coords.ToArray());
            LVW_List.Update();

            CheckSelection();
        }

        public void DeselectCoord()
        {
            if (LVW_List.SelectedItems.Count > 0)
            {
                LVW_List.SelectedItems[0].Selected = false;
            }
        }

        private DialogResult ConfirmClose()
        {
            return MessageBox.Show("Do you want to save your changes?", "Save changes?", MessageBoxButtons.YesNoCancel);
        }

        private void Save(string file)
        {
            if (!File.Exists(file))
            {
                File.Create(file);
            }

            List<string> coordStrings = new List<string>();
            foreach (Coordinate c in Program.worlds[currentWorldID].coords)
            {
                coordStrings.Add(c.ToString());
            }

            File.WriteAllLines(file, coordStrings.ToArray());
        }

        private void Open(string file)
        {
            if (File.Exists(file))
            {
                string[] newcoords = File.ReadAllLines(file);   
                foreach (string c in newcoords)
                {
                    Program.worlds[currentWorldID].coords.Add(new Coordinate(c));
                }
            }
            UpdateList();
        }
    }
}
