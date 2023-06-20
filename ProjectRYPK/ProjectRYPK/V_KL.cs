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
    public partial class V_KL : Form
    {
        public V_KL()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = " "; label2.Text = " "; label3.Text = " "; label4.Text = " ";
            label5.Text = " "; label6.Text = " "; label7.Text = " "; label8.Text = " ";
            label9.Text = " "; label10.Text = " "; label11.Text = " "; label12.Text = " "; label13.Text = " ";

            List<string> idfamil = SQLRequests.SelectRequest(
           "SELECT Путевки2_old.НаименованиеПутевки FROM  Путевки2_old right join  Договор on Договор.КодПутевки = Путевки2_old.КодПутевки left join ИКлиент on ИКлиент.КодКлиента = Договор.КодКлиента",
           new string[] { }, new string[] { });
            label1.Text = "Наименование путевки" + "\n";
            for (int i = 0; i < idfamil.Count; i++)
            {
                label1.Text += idfamil[i] + "\n";
            }


            List<string> idfamil1 = SQLRequests.SelectRequest(
           "SELECT ИКлиент.Фамилия FROM  Путевки2_old right join  Договор on Договор.КодПутевки = Путевки2_old.КодПутевки left join ИКлиент on ИКлиент.КодКлиента = Договор.КодКлиента",
           new string[] { }, new string[] { });
            label2.Text = "Фамилия клиента" + "\n";
            for (int i = 0; i < idfamil1.Count; i++)
            {
                label2.Text += idfamil1[i] + "\n";
            }

            List<string> idfamil2 = SQLRequests.SelectRequest(
           "SELECT Договор.КодДоговора FROM  Путевки2_old right join  Договор on Договор.КодПутевки = Путевки2_old.КодПутевки left join ИКлиент on ИКлиент.КодКлиента = Договор.КодКлиента",
           new string[] { }, new string[] { });
            label3.Text = "Код договора" + "\n";
            for (int i = 0; i < idfamil2.Count; i++)
            {
                label3.Text += idfamil2[i] + "\n";
            }


            List<string> idfamil3 = SQLRequests.SelectRequest(
          "SELECT Договор.Оплата FROM  Путевки2_old right join  Договор on Договор.КодПутевки = Путевки2_old.КодПутевки left join ИКлиент on ИКлиент.КодКлиента = Договор.КодКлиента",
          new string[] { }, new string[] { });
            label4.Text = "Оплата путевки" + "\n";
            for (int i = 0; i < idfamil3.Count; i++)
            {
                label4.Text += idfamil3[i] + "\n";
            }




            List<string> idfamil4 = SQLRequests.SelectRequest(
         "SELECT Договор.КоличествоДней FROM  Путевки2_old right join  Договор on Договор.КодПутевки = Путевки2_old.КодПутевки left join ИКлиент on ИКлиент.КодКлиента = Договор.КодКлиента",
         new string[] { }, new string[] { });
            label5.Text = "КоличествоДней" + "\n";
            for (int i = 0; i < idfamil4.Count; i++)
            {
                label5.Text += idfamil4[i] + "\n";
            }

            List<string> idfamil5 = SQLRequests.SelectRequest(
       "SELECT Договор.ДатаЗаезда FROM  Путевки2_old right join  Договор on Договор.КодПутевки = Путевки2_old.КодПутевки left join ИКлиент on ИКлиент.КодКлиента = Договор.КодКлиента",
       new string[] { }, new string[] { });
            label6.Text = "ДатаЗаезда" + "\n";
            for (int i = 0; i < idfamil5.Count; i++)
            {
                label6.Text += idfamil5[i] + "\n";
            }


            List<string> idfamil6 = SQLRequests.SelectRequest(
       "SELECT Договор.ДатаВыезда FROM  Путевки2_old right join  Договор on Договор.КодПутевки = Путевки2_old.КодПутевки left join ИКлиент on ИКлиент.КодКлиента = Договор.КодКлиента",
       new string[] { }, new string[] { });
            label7.Text = "ДатаВыезда" + "\n";
            for (int i = 0; i < idfamil6.Count; i++)
            {
                label7.Text += idfamil6[i] + "\n";
            }

            List<string> idfamil7 = SQLRequests.SelectRequest(
      "SELECT Договор.ОбщаяСтоимость FROM  Путевки2_old right join  Договор on Договор.КодПутевки = Путевки2_old.КодПутевки left join ИКлиент on ИКлиент.КодКлиента = Договор.КодКлиента",
      new string[] { }, new string[] { });
            label8.Text = "ОбщаяСтоимость" + "\n";
            for (int i = 0; i < idfamil7.Count; i++)
            {
                label8.Text += idfamil7[i] + "\n";
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // SELECT Имя, Фамилия, Адрес, ДанныеЗагранпаспорта 
            //    FROM Путевки, ИКлиент, Данные_клиента  WHERE 
            //    Данные_клиента.КодКлиента = ИКлиент.КодКлиентаы
            label1.Text = " "; label2.Text = " "; label3.Text = " "; label4.Text = " ";
            label5.Text = " "; label6.Text = " "; label7.Text = " "; label8.Text = " ";
            label9.Text = " "; label10.Text = " "; label11.Text = " "; label12.Text = " "; label13.Text = " ";

            label1.Text = "Фамилия клиента" + "\n";
            List<string> idfamil = SQLRequests.SelectRequest(
             "select Фамилия from Данные_клиента, ИКлиент WHERE Данные_клиента.КодКлиента  = ИКлиент.КодКлиента",
             new string[] { }, new string[] { });

            for (int i = 0; i < idfamil.Count; i++)
            {
                label1.Text += idfamil[i] + "\n";
            }


            label2.Text = "Имя " + "\n";
            List<string> idim1 = SQLRequests.SelectRequest(
             "select Имя from Данные_клиента, ИКлиент WHERE Данные_клиента.КодКлиента  = ИКлиент.КодКлиента",
             new string[] { }, new string[] { });

            for (int i = 0; i < idim1.Count; i++)
            {
                label2.Text += idim1[i] + "\n";
            }


            label3.Text = "Отчество " + "\n";
            List<string> idim2 = SQLRequests.SelectRequest(
            "select Отчество from Данные_клиента, ИКлиент WHERE Данные_клиента.КодКлиента  = ИКлиент.КодКлиента",
            new string[] { }, new string[] { });

            for (int i = 0; i < idim2.Count; i++)
            {
                label3.Text += idim2[i] + "\n";
            }

            label13.Text = "Возраст " + "\n";
            List<string> idim22 = SQLRequests.SelectRequest(
            "select Возраст from Данные_клиента, ИКлиент WHERE Данные_клиента.КодКлиента  = ИКлиент.КодКлиента",
            new string[] { }, new string[] { });

            for (int i = 0; i < idim22.Count; i++)
            {
                label13.Text += idim22[i] + "\n";
            }

            label4.Text = "ИНН клиента" + "\n";
            List<string> idim3 = SQLRequests.SelectRequest(
            "select ИННКлиента from Данные_клиента, ИКлиент WHERE Данные_клиента.КодКлиента  = ИКлиент.КодКлиента",
            new string[] { }, new string[] { });

            for (int i = 0; i < idim3.Count; i++)
            {
                label4.Text += idim3[i] + "\n";
            }


            label5.Text = "Номер телефона" + "\n";
            List<string> idim4 = SQLRequests.SelectRequest(
            "select НомерТелефона from Данные_клиента, ИКлиент WHERE Данные_клиента.КодКлиента  = ИКлиент.КодКлиента",
            new string[] { }, new string[] { });

            for (int i = 0; i < idim4.Count; i++)
            {
                label5.Text += idim4[i] + "\n";
            }


            label6.Text = "Адрес" + "\n";
            List<string> idim5 = SQLRequests.SelectRequest(
            "select Адрес from Данные_клиента, ИКлиент WHERE Данные_клиента.КодКлиента  = ИКлиент.КодКлиента",
            new string[] { }, new string[] { });

            for (int i = 0; i < idim5.Count; i++)
            {
                label6.Text += idim5[i] + "\n";
            }

            label7.Text = "Данные паспорта" + "\n";
            List<string> idim6 = SQLRequests.SelectRequest(
            "select ДанныеПаспорта from Данные_клиента, ИКлиент WHERE Данные_клиента.КодКлиента  = ИКлиент.КодКлиента",
            new string[] { }, new string[] { });

            for (int i = 0; i < idim6.Count; i++)
            {
                label7.Text += idim6[i] + "\n";
            }


            label8.Text = "Данные загранпаспорта" + "\n";
            List<string> idim7 = SQLRequests.SelectRequest(
           "select ДанныеЗагранпаспорта from Данные_клиента, ИКлиент WHERE Данные_клиента.КодКлиента  = ИКлиент.КодКлиента",
           new string[] { }, new string[] { });

            for (int i = 0; i < idim7.Count; i++)
            {
                label8.Text += idim7[i] + "\n";
            }

            label9.Text = "Почта" + "\n";
            List<string> idim8 = SQLRequests.SelectRequest(
           "select Почта from Данные_клиента, ИКлиент WHERE Данные_клиента.КодКлиента  = ИКлиент.КодКлиента",
           new string[] { }, new string[] { });

            for (int i = 0; i < idim8.Count; i++)
            {
                label9.Text += idim8[i] + "\n";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = " "; label2.Text = " "; label3.Text = " "; label4.Text = " ";
            label5.Text = " "; label6.Text = " "; label7.Text = " "; label8.Text = " ";
            label9.Text = " "; label10.Text = " "; label11.Text = " "; label12.Text = " "; label13.Text = " ";

            if (comboBox1.Text != "")
            {

                List<string> idfamil = SQLRequests.SelectRequest(
                 "select КодКлиента from ИКлиент where Фамилия = @pass",
                 new string[] { "pass" }, new string[] { comboBox1.Text });



                if (idfamil.Count == 0)
                {
                    MessageBox.Show("Данных нет в базе");
                    return;
                }
                string a = idfamil[0];


                label1.Text = "Фамилия клиента" + "\n";
                List<string> idfamil1 = SQLRequests.SelectRequest(
                 "select Фамилия from  ИКлиент WHERE ИКлиент.КодКлиента  = @pass1",
                 new string[] { "pass1" }, new string[] { a });

                label1.Text += idfamil1[0] + "\n";



                label2.Text = "Имя клиента" + "\n";
                List<string> idfamil2 = SQLRequests.SelectRequest(
                 "select Имя from  ИКлиент WHERE ИКлиент.КодКлиента  = @pass2",
                 new string[] { "pass2" }, new string[] { a });

                label2.Text += idfamil2[0] + "\n";

                label3.Text = "Отчество" + "\n";
                List<string> idfamil3 = SQLRequests.SelectRequest(
                 "select Отчество from  ИКлиент WHERE ИКлиент.КодКлиента  = @pass3",
                 new string[] { "pass3" }, new string[] { a });

                label3.Text += idfamil3[0] + "\n";



                label4.Text = "ИНН клиента" + "\n";
                List<string> idfamil4 = SQLRequests.SelectRequest(
                 "select  ИННКлиента from  Данные_клиента WHERE Данные_клиента.КодКлиента = @pass4",
                 new string[] { "pass4" }, new string[] { a });

                label4.Text += idfamil4[0] + "\n";


                label5.Text = "Номер телефона" + "\n";
                List<string> idfamil5 = SQLRequests.SelectRequest(
                 "select  НомерТелефона from  Данные_клиента WHERE Данные_клиента.КодКлиента = @pass5",
                 new string[] { "pass5" }, new string[] { a });

                label5.Text += idfamil5[0] + "\n";


                label6.Text = "Адрес" + "\n";
                List<string> idfamil6 = SQLRequests.SelectRequest(
                 "select  Адрес from  Данные_клиента WHERE Данные_клиента.КодКлиента = @pass6",
                 new string[] { "pass6" }, new string[] { a });

                label6.Text += idfamil6[0] + "\n";




                label7.Text = "Данные паспорта" + "\n";
                List<string> idfamil7 = SQLRequests.SelectRequest(
                 "select ДанныеПаспорта from  Данные_клиента WHERE Данные_клиента.КодКлиента = @pass7",
                 new string[] { "pass7" }, new string[] { a });

                label7.Text += idfamil7[0] + "\n";


                label8.Text = "Данные загранпаспорта" + "\n";
                List<string> idfamil8 = SQLRequests.SelectRequest(
                 "select ДанныеЗагранпаспорта from  Данные_клиента WHERE Данные_клиента.КодКлиента = @pass8",
                 new string[] { "pass8" }, new string[] { a });

                label8.Text += idfamil8[0] + "\n";


                label9.Text = "Почта" + "\n";
                List<string> idfamil9 = SQLRequests.SelectRequest(
                 "select Почта from  Данные_клиента WHERE Данные_клиента.КодКлиента = @pass9",
                 new string[] { "pass9" }, new string[] { a });

                label9.Text += idfamil9[0] + "\n";
            }
            else
            {
                MessageBox.Show("Нет данных в строке фамилия");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = " "; label2.Text = " "; label3.Text = " "; label4.Text = " ";
            label5.Text = " "; label6.Text = " "; label7.Text = " "; label8.Text = " ";
            label9.Text = " "; label10.Text = " "; label11.Text = " "; label12.Text = " "; label13.Text = " ";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> idfamil = SQLRequests.SelectRequest(
             "select КодКлиента from ИКлиент where Фамилия = @pass",
             new string[] { "pass" }, new string[] { textBox2.Text });

            if (idfamil.Count == 0)
            {
                MessageBox.Show("Данных нет в базе");
                return;
            }

            string kod = idfamil[0];




            List<string> insertion_Customers1 = SQLRequests.SelectRequest(
               "DELETE FROM ИКлиент Where Фамилия = @v1", new string[] { "v1" }, new string[]
               { textBox2.Text});

            List<string> insertion_Customers2 = SQLRequests.SelectRequest(
                "DELETE FROM Данные_клиента Where КодКлиента  = @d1", new string[] { "d1" }, new string[]
                { kod });

           
            //select Почта from Данные_клиента, ИКлиент 
            //  WHERE Данные_клиента.КодКлиента = ИКлиент.КодКлиента
            MessageBox.Show("Удаление прошло успешно");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void V_KL_Load(object sender, EventArgs e)
        {

        }
    }
}
