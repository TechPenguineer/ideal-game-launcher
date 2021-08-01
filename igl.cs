using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace igl
{
    public partial class igl : Form
    {
        public igl()
        {
            InitializeComponent();
        }

        private void load(object sender, EventArgs e)
        {
            string version = System.Windows.Forms.Application.ProductVersion;

            versionLabel.Text = $"Version {version}";
           
        }
    }
}
