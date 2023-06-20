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
    public partial class Kl : Form
    {
        public Kl()
        {
            InitializeComponent();
        }

        private void Kl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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


            MessageBox.Show("Операция удаления прошла успешно");



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

            if (t1.Text != "" && t2.Text != "" && t3.Text != "" && textBox1.Text != "" && a1.Text != "" && a2.Text != "" && a3.Text != "" && a4.Text != "" && a5.Text != "" && a6.Text != "" && e1.Text != "" && e2.Text != "" && e3.Text != "")
            {

                List<string> insertion_Customers = SQLRequests.SelectRequest(
            "INSERT INTO ИКлиент (Фамилия, Имя, Отчество,Возраст, ЛогинКСайту,ПарольКСайту) VALUES (@v1, @v2, @v3, @v4, @v5, @v6)", new string[] { "v1", "v2", "v3", "v4", "v5","v6" }, new string[] { t1.Text, t2.Text, t3.Text, textBox1.Text, e1.Text, e2.Text });


                List<string> insertion_Customers1 = SQLRequests.SelectRequest(
                "INSERT INTO Данные_клиента (Адрес, ДанныеПаспорта, ДанныеЗагранпаспорта, НомерТелефона, Почта, ИННКлиента) VALUES (@a1, @a2, @a3, @a4, @a5, @a6)", new string[] { "a1", "a2", "a3", "a4", "a5", "a6" }, new string[] { a1.Text, a2.Text, a3.Text, a4.Text, a5.Text, a6.Text });









                MessageBox.Show("Регистрация прошла успешно");
            }
            else
            {
                MessageBox.Show("Не все данные введены");

            }





        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> idfamil = SQLRequests.SelectRequest(
         "SELECT Путевки2_old.НаименованиеПутевки FROM  Путевки2_old right join  Договор on Договор.КодПутевки = Путевки2_old.КодПутевки left join ИКлиент on ИКлиент.КодКлиента = Договор.КодКлиента",
         new string[] { }, new string[] { });
            labels1.Text = "Наименование путевки" + "\n";
            for (int i = 0; i < idfamil.Count; i++)
            {
                labels1.Text += idfamil[i] + "\n";
            }


            List<string> idfamil1 = SQLRequests.SelectRequest(
           "SELECT ИКлиент.Фамилия FROM  Путевки2_old right join  Договор on Договор.КодПутевки = Путевки2_old.КодПутевки left join ИКлиент on ИКлиент.КодКлиента = Договор.КодКлиента",
           new string[] { }, new string[] { });
            labels2.Text = "Фамилия клиента" + "\n";
            for (int i = 0; i < idfamil1.Count; i++)
            {
                labels2.Text += idfamil1[i] + "\n";
            }

            List<string> idfamil2 = SQLRequests.SelectRequest(
           "SELECT Договор.КодДоговора FROM  Путевки2_old right join  Договор on Договор.КодПутевки = Путевки2_old.КодПутевки left join ИКлиент on ИКлиент.КодКлиента = Договор.КодКлиента",
           new string[] { }, new string[] { });
            labels3.Text = "Код договора" + "\n";
            for (int i = 0; i < idfamil2.Count; i++)
            {
                labels3.Text += idfamil2[i] + "\n";
            }


            List<string> idfamil3 = SQLRequests.SelectRequest(
          "SELECT Договор.Оплата FROM  Путевки2_old right join  Договор on Договор.КодПутевки = Путевки2_old.КодПутевки left join ИКлиент on ИКлиент.КодКлиента = Договор.КодКлиента",
          new string[] { }, new string[] { });
            labels4.Text = "Оплата путевки" + "\n";
            for (int i = 0; i < idfamil3.Count; i++)
            {
                labels4.Text += idfamil3[i] + "\n";
            }

            List<string> idfamil4 = SQLRequests.SelectRequest(
         "SELECT Договор.КоличествоДней FROM  Путевки2_old right join  Договор on Договор.КодПутевки = Путевки2_old.КодПутевки left join ИКлиент on ИКлиент.КодКлиента = Договор.КодКлиента",
         new string[] { }, new string[] { });
            label16.Text = "Количество дней" + "\n";
            for (int i = 0; i < idfamil4.Count; i++)
            {
                label16.Text += idfamil4[i] + "\n";
            }

            List<string> idfamil5 = SQLRequests.SelectRequest(
       "SELECT Договор.ОбщаяСтоимость FROM  Путевки2_old right join  Договор on Договор.КодПутевки = Путевки2_old.КодПутевки left join ИКлиент on ИКлиент.КодКлиента = Договор.КодКлиента",
       new string[] { }, new string[] { });
            label17.Text = "Общая стоимость" + "\n";
            for (int i = 0; i < idfamil5.Count; i++)
            {
                label17.Text += idfamil5[i] + "\n";
            }


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
            string sql = "SELECT last_name , first_name , father_name_user_ap , job_title , number_phone , uploaded_at1  FROM databasenew.news_appprof1;";
            // объект для выполнения SQL-запроса
            MySqlCommand command = new MySqlCommand(sql, conn);
            // объект для чтения ответа сервера
            MySqlDataReader reader = command.ExecuteReader();
            // читаем результат
            richTextBox1.Text = "";
            while (reader.Read())
            {
                richTextBox1.Text += ("Фамилия пользователя: " + reader[0].ToString() + "\n" + "Имя: " + reader[1].ToString() + "\n" + "Отчество: " + reader[2].ToString() + "\n" + "Должность: " + reader[3].ToString() + "\n" + "Номер телефона: " + reader[4].ToString() + "\n" + "Дата отправки: " + reader[5].ToString() + "\n"  + "\n" + "\n");

                //// элементы массива [] - это значения столбцов из запроса SELECT
                //Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString());
            }
            reader.Close(); // закрываем reader
            // закрываем соединение с БД
            conn.Close();
        }
    }
}

