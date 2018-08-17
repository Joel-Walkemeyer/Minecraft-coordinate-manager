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
    public partial class TP_command : Form
    {
        string command;
        public TP_command(string com)
        {
            command = com;
            InitializeComponent();
        }

        private void TP_command_Load(object sender, EventArgs e)
        {
            TXT_com.Text = command;
        }

        private void BTN_copy_Click(object sender, EventArgs e)
        {
            MessageBox.Show(command);
            Clipboard.SetText(command);
        }

        private void BTN_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
