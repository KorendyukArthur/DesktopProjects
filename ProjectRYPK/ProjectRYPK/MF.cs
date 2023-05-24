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
    public partial class MF : Form
    {
        public MF()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kl opn1 = new Kl();
            this.Hide();
            opn1.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Nom opn3 = new Nom();
            this.Hide();
            opn3.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            RegBZacaz opn2 = new RegBZacaz();
            this.Hide();
            opn2.ShowDialog();
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            V_KL opn5 = new V_KL();
            this.Hide();
            opn5.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            V_Nom opn4 = new V_Nom();
            this.Hide();
            opn4.ShowDialog();
            this.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Agent opn6 = new Agent();
            this.Hide();
            opn6.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Создание отчета прошло успешно! По данным договоров и клиентов был сформирован отчет и передан администратору");

        }

        private void MF_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            Dialog opn7 = new Dialog();
            this.Hide();
            opn7.ShowDialog();
            this.Show();
        }
    }
}
