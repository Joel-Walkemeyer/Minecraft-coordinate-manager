using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CoordinateManager
{
    public class Coordinate : ListViewItem
    {
        public enum Dim { Nether = -1, Overworld, End };
        public enum Prop { name = 0, x, y, z, dim };

        public int X
        {
            get { return Convert.ToInt32(SubItems[(int)Prop.x].Text); }
            set { SubItems[(int)Prop.x] = new ListViewSubItem(this, value.ToString()); }
        }

        public int Y
        {
            get { return Convert.ToInt32(SubItems[(int)Prop.y].Text); }
            set { SubItems[(int)Prop.y] = new ListViewSubItem(this, value.ToString()); }
        }

        public int Z
        {
            get { return Convert.ToInt32(SubItems[(int)Prop.z].Text); }
            set { SubItems[(int)Prop.z] = new ListViewSubItem(this, value.ToString()); }
        }

        public Dim dim
        {
            get { return (Dim)(Enum.Parse(typeof(Dim), SubItems[(int)Prop.dim].Text)); }
            set { SubItems[(int)Prop.dim] = new ListViewSubItem(this, value.ToString()); }
        }

        public string Name
        {
            get { return Text;}
            set { Text = value;}
        }

        public Coordinate(string place = "New coordinate", int x = 0, int y = 64, int z = 0, Dim dimension = Dim.Overworld)
        {
            UseItemStyleForSubItems = false;
            Text = place;

            SubItems.Add(new ListViewSubItem(this, x.ToString()));
            SubItems.Add(new ListViewSubItem(this, y.ToString()));
            SubItems.Add(new ListViewSubItem(this, z.ToString()));
            SubItems.Add(new ListViewSubItem(this, dimension.ToString()));
        }

        public override string ToString()
        {
            string[] strarr = { SubItems[0].Text, SubItems[1].Text, SubItems[2].Text, SubItems[3].Text, SubItems[4].Text };
            string st = "";
            foreach (string s in strarr)
            {
                st += s + ";";
            }
            st = st.Remove(st.Length-1);
            return st;
        }
    }
}
