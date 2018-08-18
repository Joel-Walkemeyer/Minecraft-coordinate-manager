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

        public Coordinate(string place = "", int x = 0, int y = 64, int z = 0, Dim dimension = Dim.Overworld)
        {
            Name = place;

            SubItems.Add(new ListViewSubItem(this, x.ToString()));
            SubItems.Add(new ListViewSubItem(this, y.ToString()));
            SubItems.Add(new ListViewSubItem(this, z.ToString()));
            SubItems.Add(new ListViewSubItem(this, dimension.ToString()));

            Text = Name;
        }


        public Coordinate(string data)
        {
            string[] datas = data.Split(';');

            Name = datas[0];

            SubItems.Add(new ListViewSubItem(this, datas[1]));
            SubItems.Add(new ListViewSubItem(this, datas[2]));
            SubItems.Add(new ListViewSubItem(this, datas[3]));
            SubItems.Add(new ListViewSubItem(this, datas[4]));

            Text = Name;
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
