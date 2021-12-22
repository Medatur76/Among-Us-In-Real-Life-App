using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Among_Us_APP.FOrms;

namespace Among_Us_APP.FOrms
{
    public partial class Tasks : Form
    {
        public Tasks(string role)
        {
            InitializeComponent();
            if (role == Role.imposterRole)
            {
                this.label1.Visible = true;
            }
            else if (role == Role.crewmateRole)
            {
                this.label2.Visible = true;
            }
            else
            {
                return;
            }
        }

        private void Tasks_Load(object sender, EventArgs e)
        {
            this.label1.Visible = false;
            this.label2.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            return;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            return;
        }
    }
}
