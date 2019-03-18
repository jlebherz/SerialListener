using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialListener
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            dotNET_Version.Text = ".NET Framework Version: " + Environment.Version.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.systemhaus-lebherz.de");
        }
    }
}
