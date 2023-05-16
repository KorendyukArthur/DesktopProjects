using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectRYPK
{
    public partial class MFAdmin : Form
    {
        public MFAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataA opn11 = new DataA();
            this.Hide();
            opn11.ShowDialog();
            this.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            V_Nom opn13 = new V_Nom();
            this.Hide();
            opn13.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Agent opn12 = new Agent();
            this.Hide();
            opn12.ShowDialog();
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MFAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
