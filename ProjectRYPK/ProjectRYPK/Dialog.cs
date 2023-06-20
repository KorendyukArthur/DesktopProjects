using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace ProjectRYPK
{
    public partial class Dialog : Form
    {
        public Dialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            

            // строка подключения к БД
            string connStr = "server=localhost;port=3306;username=root;password=Sneg1123;database=databasenew;";
            // создаём объект для подключения к БД
            MySqlConnection conn = new MySqlConnection(connStr);
            // устанавливаем соединение с БД
            conn.Open();
            // запрос
            string sql = "SELECT id_user,min_text,full_text,date FROM databasenew.news_chat order by -date";
            // объект для выполнения SQL-запроса
            MySqlCommand command = new MySqlCommand(sql, conn);
            // объект для чтения ответа сервера
            MySqlDataReader reader = command.ExecuteReader();
            // читаем результат
            richTextBox1.Text = "";
            while (reader.Read())
            {
                richTextBox1.Text += (reader[0].ToString() + "\n" + reader[1].ToString() + "\n " + reader[2].ToString() + "\n" + reader[3].ToString()) +"\n" + "\n" + "\n" + "\n";

                //// элементы массива [] - это значения столбцов из запроса SELECT
                //Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString());
            }
            reader.Close(); // закрываем reader
            // закрываем соединение с БД
            conn.Close();









        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.txt";
            saveFile1.Filter = "Text Files (*.txt)|*.txt";

            if (richTextBox1.Text != "") 
            {
                if (saveFile1.ShowDialog() == DialogResult.OK && saveFile1.FileName.Length > 0)
                {
                    richTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
                    MessageBox.Show("Данные сохоранены успешно!");
                }
            }

            else
            {
                MessageBox.Show("Данные не найдены");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
