using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProjectRYPK
{
    public partial class OpenMain : Form
    {
        public OpenMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            string loginUser = textBox1.Text;
            string passUser = textBox2.Text;

            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM auth_user WHERE username = @uL ", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            //command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {

                MessageBox.Show("Подключено к MySql");


            }

            else
                MessageBox.Show("Пользователь не найден");



















            bool flag = false;



            //код для БД MS SQL
            List<string> password = SQLRequests.SelectRequest(
            "select Пароль from Агент where Логин = @pass",
           new string[] { "pass" }, new string[] { textBox1.Text });

            List<string> idtur = SQLRequests.SelectRequest(
               "select КодАгента from Агент where Логин = @pass",
               new string[] { "pass" }, new string[] { textBox1.Text });

            if (password.Count == 0)
            {
                MessageBox.Show("нет логина");
                return;
            }
            NomClass.id = idtur[0];

            if (password[0] != textBox2.Text)
            {
                MessageBox.Show("Пароль неправильный");
                return;
            }
            else
            {
                MessageBox.Show("Подключено к MS SQL");
                MF KLform = new MF();
                this.Hide();
                KLform.ShowDialog();
                this.Show();
                flag = true;
            }

      
            
            //if (textBox1.Text == "sysadmin" & textBox2.Text == "123")
            //{
            //    MF KLform = new MF();
            //    this.Hide();
            //    KLform.ShowDialog();
            //    this.Show();
            //    flag = true;

            //}
            
            //if (flag == false)
            //{
            //    MessageBox.Show("No");
            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //string loginUser = textBox1.Text;
            //string passUser = textBox2.Text;

            //DB db = new DB();

            //DataTable table = new DataTable();
            //MySqlDataAdapter adapter = new MySqlDataAdapter();

            //MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE login = @uL AND pass = @uP ", db.getConnection());
            //command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            //command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;



            //adapter.SelectCommand = command;
            //adapter.Fill(table);


            //bool flag = false;
            //if (table.Rows.Count > 0)
            //{

            //    MessageBox.Show("Пользователь найден");

            //    MF KLform = new MF();
            //    this.Hide();
            //    KLform.ShowDialog();
            //    this.Show();
            //}

            //else
            //    MessageBox.Show("Пользователь не найден");

            //Код для базы MS SQL
            bool flag = false;
            if (textBox1.Text == "sadmins" & textBox2.Text == "sneg1123")
            {
                MFAdmin opn = new MFAdmin();
                this.Hide();
                opn.ShowDialog();
                this.Show();
                flag = true;
            }

            if (textBox1.Text == " " && textBox2.Text == " ")
            {

                MessageBox.Show("Данные введены не до конца");
                return;
            }

            if (flag == false)
            {
                MessageBox.Show("Вход не выполнен");
            }


        }

        private void OpenMain_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
