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
    public partial class Nom : Form
    {
        public Nom()
        {
            InitializeComponent();
        }
        public Nom(MF mainForm)
        {
            MF = mainForm;

        }

        public MF MF { get; }

        private void button1_Click(object sender, EventArgs e)
        {

            
            if (dp1.Text != "" && dp2.Text != "" && dp3.Text != "" && dp4.Text != "" && dp5.Text != "" && dp6.Text != "" && p1.Text != "" && p3.Text != "" )
            {
                
                    List<string> insertion_Customers1 = SQLRequests.SelectRequest(
            "INSERT INTO ДанныеПутевок2_old1 (СтранаПутевки, ТипОтеля, ТипНомера, Город, Улица, НазваниеОтеля) VALUES (@dp1, @dp2, @dp3, @dp4, @dp5, @dp6)", new string[] { "dp1", "dp2", "dp3", "dp4", "dp5", "dp6" }, new string[] { dp1.Text, dp2.Text, dp3.Text, dp4.Text, dp5.Text, dp6.Text });

                List<string> insertion_Customers = SQLRequests.SelectRequest(
                "INSERT INTO Путевки2_old (НаименованиеПутевки,ЦенаПутевки, ДатаНачала, ДатаОкончания) VALUES (@v1, @v2, @v3, @v4 )", new string[] { "v1", "v2", "v3", "v4" }, new string[] { p1.Text, p3.Text, p4.Text, p5.Text });



                MessageBox.Show("Регистрация 2 тура прошла успешно");
            }
            else
            {
                MessageBox.Show("Не все данные введены");
            }
        }

        private void Nom_Load(object sender, EventArgs e)
        {

        }
        

        private void p4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
