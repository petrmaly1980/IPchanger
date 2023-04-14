using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPchanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDHCP_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", "/c netsh interface ip set address \"vEthernet (Internet)\" dhcp");
        }

        private void btnStatic_Click(object sender, EventArgs e)
        {
            string args = " /c netsh interface ip set address \"" + txtInterfaceName.Text + "\" static "
                + ip.Text//where IP is some IP address
                + " "
                + mask.Text;//where mask is some IP Mask
                //+ " set /p exitkey= \"Press any key to continue...\"";
            MessageBox.Show(args);
            System.Diagnostics.Process.Start("cmd", args);
        }
    }
}
