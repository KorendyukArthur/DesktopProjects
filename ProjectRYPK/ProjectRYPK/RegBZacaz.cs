using MySql.Data.MySqlClient;
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            {
                // SELECT Имя, Фамилия, Адрес, ДанныеЗагранпаспорта 
                //    FROM Путевки, ИКлиент, Данные_клиента  WHERE 
                //    Данные_клиента.КодКлиента = ИКлиент.КодКлиентаы


                label14.Text = "Фамилия клиента" + "\n";
                List<string> idfamil = SQLRequests.SelectRequest(
                 "select Фамилия from Данные_клиента, ИКлиент WHERE Данные_клиента.КодКлиента  = ИКлиент.КодКлиента",
                 new string[] { }, new string[] { });

                for (int i = 0; i < idfamil.Count; i++)
                {
                    label14.Text += idfamil[i] + "\n";
                }


                label12.Text = "Имя " + "\n";
                List<string> idim1 = SQLRequests.SelectRequest(
                 "select Имя from Данные_клиента, ИКлиент WHERE Данные_клиента.КодКлиента  = ИКлиент.КодКлиента",
                 new string[] { }, new string[] { });

                for (int i = 0; i < idim1.Count; i++)
                {
                    label12.Text += idim1[i] + "\n";
                }


                label11.Text = "Отчество " + "\n";
                List<string> idim2 = SQLRequests.SelectRequest(
                "select Отчество from Данные_клиента, ИКлиент WHERE Данные_клиента.КодКлиента  = ИКлиент.КодКлиента",
                new string[] { }, new string[] { });

                for (int i = 0; i < idim2.Count; i++)
                {
                    label11.Text += idim2[i] + "\n";
                }


                label10.Text = "ИНН клиента" + "\n";
                List<string> idim3 = SQLRequests.SelectRequest(
                "select ИННКлиента from Данные_клиента, ИКлиент WHERE Данные_клиента.КодКлиента  = ИКлиент.КодКлиента",
                new string[] { }, new string[] { });

                for (int i = 0; i < idim3.Count; i++)
                {
                    label10.Text += idim3[i] + "\n";
                }


                label5.Text = "Номер телефона" + "\n";
                List<string> idim4 = SQLRequests.SelectRequest(
                "select НомерТелефона from Данные_клиента, ИКлиент WHERE Данные_клиента.КодКлиента  = ИКлиент.КодКлиента",
                new string[] { }, new string[] { });

                for (int i = 0; i < idim4.Count; i++)
                {
                    label5.Text += idim4[i] + "\n";
                }


                label2.Text = "Адрес" + "\n";
                List<string> idim5 = SQLRequests.SelectRequest(
                "select Адрес from Данные_клиента, ИКлиент WHERE Данные_клиента.КодКлиента  = ИКлиент.КодКлиента",
                new string[] { }, new string[] { });

                for (int i = 0; i < idim5.Count; i++)
                {
                    label2.Text += idim5[i] + "\n";
                }

                label8.Text = "Данные паспорта" + "\n";
                List<string> idim6 = SQLRequests.SelectRequest(
                "select ДанныеПаспорта from Данные_клиента, ИКлиент WHERE Данные_клиента.КодКлиента  = ИКлиент.КодКлиента",
                new string[] { }, new string[] { });

                for (int i = 0; i < idim6.Count; i++)
                {
                    label8.Text += idim6[i] + "\n";
                }



                label16.Text = "Почта" + "\n";
                List<string> idim8 = SQLRequests.SelectRequest(
               "select Почта from Данные_клиента, ИКлиент WHERE Данные_клиента.КодКлиента  = ИКлиент.КодКлиента",
               new string[] { }, new string[] { });

                for (int i = 0; i < idim8.Count; i++)
                {
                    label16.Text += idim8[i] + "\n";
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            

            l1.Text = "Наименование путевки" + "\n";
            List<string> idfamil1 = SQLRequests.SelectRequest(
             "select НаименованиеПутевки FROM Путевки2_old, ДанныеПутевок2_old1 WHERE Путевки2_old.КодПутевки = ДанныеПутевок2_old1.КодПутевки",
             new string[] {  }, new string[] {  });

            for (int i = 0; i < idfamil1.Count; i++)
            {
                l1.Text += idfamil1[i] + "\n";
            }

            l2.Text = "Цена путевки" + "\n";
            List<string> idfamil2 = SQLRequests.SelectRequest(
             "select ЦенаПутевки FROM Путевки2_old, ДанныеПутевок2_old1 WHERE Путевки2_old.КодПутевки = ДанныеПутевок2_old1.КодПутевки",
             new string[] {  }, new string[] {  });

            for (int i = 0; i < idfamil2.Count; i++)
            {
                l2.Text += idfamil2[i] + "\n";
            }


            l3.Text = "Дата начала" + "\n";
            List<string> idfamil3 = SQLRequests.SelectRequest(
             "select ДатаНачала FROM Путевки2_old, ДанныеПутевок2_old1 WHERE Путевки2_old.КодПутевки = ДанныеПутевок2_old1.КодПутевки",
             new string[] {  }, new string[] { });
            
            for (int i = 0; i < idfamil3.Count; i++)
            {
                l3.Text += idfamil3[i] + "\n";
            }


            l4.Text = "Дата окончания" + "\n";
            List<string> idfamil4 = SQLRequests.SelectRequest(
             "select  ДатаОкончания FROM Путевки2_old, ДанныеПутевок2_old1 WHERE Путевки2_old.КодПутевки = ДанныеПутевок2_old1.КодПутевки",
             new string[] {  }, new string[] { });
            

            for (int i = 0; i < idfamil4.Count; i++)
            {
                l4.Text += idfamil4[i] + "\n";
            }

            l5.Text = "Страна путевки" + "\n";
            List<string> idfamil5 = SQLRequests.SelectRequest(
             "select СтранаПутевки FROM Путевки2_old, ДанныеПутевок2_old1 WHERE Путевки2_old.КодПутевки = ДанныеПутевок2_old1.КодПутевки",
             new string[] {  }, new string[] {  });
            

            for (int i = 0; i < idfamil5.Count; i++)
            {
                l5.Text += idfamil5[i] + "\n";
            }


            l6.Text = "Тип номера" + "\n";
            List<string> idfamil7 = SQLRequests.SelectRequest(
             "select ТипНомера FROM Путевки2_old, ДанныеПутевок2_old1 WHERE Путевки2_old.КодПутевки = ДанныеПутевок2_old1.КодПутевки",
             new string[] {  }, new string[] {  });

            for (int i = 0; i < idfamil7.Count; i++)
            {
                l6.Text += idfamil7[i] + "\n";
            }


            l7.Text = "Город" + "\n";
            List<string> idfamil8 = SQLRequests.SelectRequest(
             "select Город FROM Путевки2_old, ДанныеПутевок2_old1 WHERE Путевки2_old.КодПутевки = ДанныеПутевок2_old1.КодПутевки",
             new string[] {  }, new string[] { });
            for (int i = 0; i < idfamil8.Count; i++)
            {
                l7.Text += idfamil8[i] + "\n";
            }



            l8.Text = "Название отеля" + "\n";
            List<string> idfamil10 = SQLRequests.SelectRequest(
             "select НазваниеОтеля FROM Путевки2_old, ДанныеПутевок2_old1 WHERE Путевки2_old.КодПутевки = ДанныеПутевок2_old1.КодПутевки",
             new string[] {  }, new string[] {  });
            
            for (int i = 0; i < idfamil10.Count; i++)
            {
                l8.Text += idfamil10[i] + "\n";
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

            // строка подключения к БД
            string connStr = "server=localhost;port=3306;username=root;password=Sneg1123;database=databasenew;";
            // создаём объект для подключения к БД
            MySqlConnection conn = new MySqlConnection(connStr);
            // устанавливаем соединение с БД
            conn.Open();
            // запрос
            string sql = "SELECT name_tur,surname_user,name_user,surname_2_user,number_user,date_z,date_v,number_human,date_message FROM databasenew.news_chatbron";
            // объект для выполнения SQL-запроса
            MySqlCommand command = new MySqlCommand(sql, conn);
            // объект для чтения ответа сервера
            MySqlDataReader reader = command.ExecuteReader();
            // читаем результат
            richTextBox1.Text = "";
            while (reader.Read())
            {
                richTextBox1.Text += ("Название путевки: " + reader[0].ToString() + "\n" + "Фамилия клиента: "  + reader[1].ToString() + "\n" + "Имя клиента: " + reader[2].ToString() + "\n" + "Отчество клиента: " + reader[3].ToString() + "\n" + "Номер телефона: " + reader[4].ToString() + "\n" + "Дата заезда: " + reader[5].ToString() + "\n" + "Дата выезда: " + reader[6].ToString() + "\n" + "Количество человек: " + reader[7].ToString() + "\n" + "Время отправки сообщения:  " + reader[8].ToString()) + "\n" + "\n" + "\n" + "\n";

                //// элементы массива [] - это значения столбцов из запроса SELECT
                //Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString());
            }
            reader.Close(); // закрываем reader
            // закрываем соединение с БД
            conn.Close();
        }
    }
}
