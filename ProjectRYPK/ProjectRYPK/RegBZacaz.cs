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
    public partial class RegBZacaz : Form
    {
        public RegBZacaz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox4.Text != "" && comboBox5.Text != "")
            {
                List<string> idfamil = SQLRequests.SelectRequest(
             "select КодКлиента from ИКлиент where Фамилия = @pass",
             new string[] { "pass" }, new string[] { comboBox1.Text });

                string a = idfamil[0];

                List<string> idturs = SQLRequests.SelectRequest(
                "select КодПутевки from Путевки2_old where НаименованиеПутевки = @nam",
                new string[] { "nam" }, new string[] { comboBox4.Text });

                string b = idturs[0];

                List<string> insertion_Customers = SQLRequests.SelectRequest(
                 "INSERT INTO Договор (КодАгента, КодКлиента, КодПутевки, Оплата, ДатаОформления) VALUES (@w1, @w2, @w3, @w4, @w5)",
                 new string[] { "w1", "w2", "w3", "w4", "w5" }, new string[] { NomClass.id, a, b, comboBox5.Text, dateTimePicker1.Text });
                MessageBox.Show("Регистрация прошла успешно");
            }
            else
            {
                MessageBox.Show("Не все данные введены");
            }
        }

        private void RegBZacaz_Load(object sender, EventArgs e)
        {

        }
    }
}
