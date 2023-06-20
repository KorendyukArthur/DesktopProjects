using Microsoft.Office.Interop.Excel;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace ProjectRYPK
{
    public partial class Agent : Form
    {
        public Agent()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tr1.Text != "" && tr2.Text != "" && tr3.Text != "" && textBox1.Text != "" && textBox2.Text != "" && ar1.Text != "" && ar2.Text != "" && ar3.Text != "" && ar4.Text != "" && ar5.Text != "" && ar6.Text != "")
            {

                List<string> idfamil11 = SQLRequests.SelectRequest(
            "select КодАгента FROM Агент where Фамилия = @pass",
            new string[] { "pass" }, new string[] { textBox4.Text });


                if (idfamil11.Count == 0)
                {
                    MessageBox.Show("Данных нет в базе");
                    return;
                }

                string kod = idfamil11[0];

                

                List<string> insertion_Customers1 = SQLRequests.SelectRequest(
                "UPDATE Агент SET Фамилия = @sn WHERE Агент.КодАгента = @id", new string[] { "sn", "id" }, new string[] { tr1.Text, kod });
                List<string> insertion_Customers2 = SQLRequests.SelectRequest(
                "UPDATE Агент SET Имя = @n WHERE Агент.КодАгента = @id", new string[] { "n", "id" }, new string[] { tr2.Text, kod });
                List<string> insertion_Customers3 = SQLRequests.SelectRequest(
                "UPDATE Агент SET Отчество = @o WHERE Агент.КодАгента = @id", new string[] { "o", "id" }, new string[] { tr2.Text, kod });
                List<string> insertion_Customers4 = SQLRequests.SelectRequest(
                "UPDATE Агент SET Логин = @l WHERE Агент.КодАгента = @id", new string[] { "l", "id" }, new string[] { textBox1.Text, kod });
                List<string> insertion_Customers5 = SQLRequests.SelectRequest(
                "UPDATE Агент SET Пароль = @p WHERE Агент.КодАгента = @id", new string[] { "p", "id" }, new string[] { textBox2.Text, kod });



                List<string> insertion_Customers6 = SQLRequests.SelectRequest(
                "UPDATE ДанныеАгента1_old SET АдресАгента = @aa WHERE ДанныеАгента1_old.КодАгента = @id", new string[] { "aa", "id" }, new string[] { ar1.Text, kod });
                List<string> insertion_Customers7 = SQLRequests.SelectRequest(
                "UPDATE ДанныеАгента1_old SET ДанныеПаспорта = @dp WHERE ДанныеАгента1_old.КодАгента = @id", new string[] { "dp", "id" }, new string[] { ar2.Text, kod });
                List<string> insertion_Customers8 = SQLRequests.SelectRequest(
                "UPDATE ДанныеАгента1_old SET Должность = @da WHERE ДанныеАгента1_old.КодАгента = @id", new string[] { "da", "id" }, new string[] { ar3.Text, kod });
                List<string> insertion_Customers9 = SQLRequests.SelectRequest(
                "UPDATE ДанныеАгента1_old SET НомерТелефона = @nt WHERE ДанныеАгента1_old.КодАгента = @id", new string[] { "nt", "id" }, new string[] { ar4.Text, kod });
                List<string> insertion_Customers10 = SQLRequests.SelectRequest(
                "UPDATE ДанныеАгента1_old SET Почта = @pa WHERE ДанныеАгента1_old.КодАгента = @id", new string[] { "pa", "id" }, new string[] { ar5.Text, kod });
                List<string> insertion_Customers11 = SQLRequests.SelectRequest(
              "UPDATE ДанныеАгента1_old SET ИННАгента = @inna WHERE ДанныеАгента1_old.КодАгента = @id", new string[] { "inna", "id" }, new string[] { ar6.Text, kod });

                MessageBox.Show("Обновление прошло успешно ");
            }
            else
            {
                MessageBox.Show("Не все поля заполнены");

            }
                
                 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text)
            {
                                                                                                                          
                if (tr1.Text != "" && tr2.Text != "" && tr3.Text != "" && textBox1.Text != "" && textBox2.Text != "" && ar1.Text != "" && ar2.Text != "" && ar3.Text != "" && ar4.Text != "" && ar5.Text != "" && ar6.Text != "")
                {


                    List<string> insertion_Customers1 = SQLRequests.SelectRequest(
               "INSERT INTO ДанныеАгента1_old (АдресАгента, ДанныеПаспорта, Должность, НомерТелефона, Почта, ИННАгента) VALUES (@a1, @a2, @a3, @a4, @a5, @a6)", new string[] { "a1", "a2", "a3", "a4", "a5", "a6" }, new string[] { ar1.Text, ar2.Text, ar3.Text, ar4.Text, ar5.Text, ar6.Text });

                    List<string> insertion_Customers = SQLRequests.SelectRequest(
                    "INSERT INTO Агент (Фамилия, Имя, Отчество, Логин, Пароль ) VALUES (@w1, @w2, @w3, @w4, @w5)", new string[] { "w1", "w2", "w3", "w4", "w5" }, new string[] { tr1.Text, tr2.Text, tr3.Text, textBox1.Text, textBox2.Text });

                    MessageBox.Show("Регистрация прошла успешно");
                }
                else
                {
                    MessageBox.Show("Не все данные введены");

                }
            }
            else
            {

                MessageBox.Show("Пароль не повторяется");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            List<string> idfamil1 = SQLRequests.SelectRequest(
           "SELECT Агент.Фамилия FROM  Агент ",
           new string[] { }, new string[] { });
            labels1.Text = "Фамилия Агента" + "\n";
            for (int i = 0; i < idfamil1.Count; i++)
            {
                labels1.Text += idfamil1[i] + "\n";
            }

            List<string> idfamil3 = SQLRequests.SelectRequest(
           "SELECT Агент.Имя FROM  Агент ",
           new string[] { }, new string[] { });
            labels2.Text = "Имя Агента" + "\n";
            for (int i = 0; i < idfamil3.Count; i++)
            {
                labels2.Text += idfamil3[i] + "\n";
            }


            List<string> idfamil2 = SQLRequests.SelectRequest(
           "SELECT ДанныеАгента1_old.Должность FROM  ДанныеАгента1_old right join  Агент on Агент.КодАгента = ДанныеАгента1_old.КодАгента",
           new string[] { }, new string[] { });
            labels3.Text = "Должность" + "\n";
            for (int i = 0; i < idfamil2.Count; i++)
            {
                labels3.Text += idfamil2[i] + "\n";
            }

            List<string> idfamil4 = SQLRequests.SelectRequest(
           "SELECT ДанныеАгента1_old.НомерТелефона FROM  ДанныеАгента1_old right join  Агент on Агент.КодАгента = ДанныеАгента1_old.КодАгента",
           new string[] { }, new string[] { });
            labels4.Text = "Номер телефона" + "\n";
            for (int i = 0; i < idfamil4.Count; i++)
            {
                labels4.Text += idfamil4[i] + "\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> idfamil = SQLRequests.SelectRequest(
            "select КодАгента FROM Агент where Фамилия = @pass",
            new string[] { "pass" }, new string[] { textBox4.Text });


            if (idfamil.Count == 0){
                MessageBox.Show("Данных нет в базе");
                return;
            }

            string kod = idfamil[0];
            
            
            MessageBox.Show(kod);
            
            MessageBox.Show("ДАННЫЕ УДАЛЕНЫ");
            List<string> insertion_Customers1 = SQLRequests.SelectRequest(
                "DELETE FROM Агент Where Фамилия = @v1", new string[] { "v1" }, new string[]
                { textBox4.Text});
            List<string> insertion_Customers2 = SQLRequests.SelectRequest(
                "DELETE FROM ДанныеАгента1_old Where КодАгента  = @d1", new string[] { "d1" }, new string[]
                { kod });
            //select Почта from Данные_клиента, ИКлиент 
            //  WHERE Данные_клиента.КодКлиента = ИКлиент.КодКлиента
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Agent_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {


            List<string> idfamil11 = SQLRequests.SelectRequest(
            "select КодАгента FROM Агент where Фамилия = @pass",
            new string[] { "pass" }, new string[] { textBox4.Text });


            if (idfamil11.Count == 0)
            {
                MessageBox.Show("Данных нет в базе");
                return;
            }

            string kod = idfamil11[0];


            List<string> idfamil = SQLRequests.SelectRequest(
            "select Фамилия FROM Агент where Фамилия = @pass",
            new string[] { "pass" }, new string[] { textBox4.Text });

            List<string> idfamil1 = SQLRequests.SelectRequest(
            "select Имя FROM Агент where Фамилия = @pass",
            new string[] { "pass" }, new string[] { textBox4.Text });

            List<string> idfamil2 = SQLRequests.SelectRequest(
            "select Отчество FROM Агент where Фамилия = @pass",
            new string[] { "pass" }, new string[] { textBox4.Text });

            List<string> idfamil3 = SQLRequests.SelectRequest(
            "select Логин FROM Агент where Фамилия = @pass",
            new string[] { "pass" }, new string[] { textBox4.Text });

            List<string> idfamil4 = SQLRequests.SelectRequest(
            "select Пароль FROM Агент where Фамилия = @pass",
            new string[] { "pass" }, new string[] { textBox4.Text });
            
            tr1.Text = Convert.ToString(idfamil[0]);
            tr2.Text = Convert.ToString(idfamil1[0]);
            tr3.Text = Convert.ToString(idfamil2[0]);
            textBox1.Text = Convert.ToString(idfamil3[0]);
            textBox2.Text = Convert.ToString(idfamil4[0]);
            textBox3.Text = Convert.ToString(idfamil4[0]);



            List<string> idfamil5 = SQLRequests.SelectRequest(
            "select АдресАгента FROM ДанныеАгента1_old where КодАгента = @pass",
            new string[] { "pass" }, new string[] { kod });

            List<string> idfamil6 = SQLRequests.SelectRequest(
            "select ДанныеПаспорта FROM ДанныеАгента1_old where КодАгента = @pass",
            new string[] { "pass" }, new string[] { kod });

            List<string> idfamil7 = SQLRequests.SelectRequest(
            "select Должность FROM ДанныеАгента1_old where КодАгента = @pass",
            new string[] { "pass" }, new string[] { kod });

            List<string> idfamil8 = SQLRequests.SelectRequest(
            "select НомерТелефона FROM ДанныеАгента1_old where КодАгента = @pass",
            new string[] { "pass" }, new string[] { kod });

            List<string> idfamil9 = SQLRequests.SelectRequest(
            "select Почта FROM ДанныеАгента1_old where КодАгента = @pass",
            new string[] { "pass" }, new string[] { kod });

            List<string> idfamil10 = SQLRequests.SelectRequest(
            "select ИННАгента FROM ДанныеАгента1_old where КодАгента = @pass",
            new string[] { "pass" }, new string[] { kod });

            ar1.Text = Convert.ToString(idfamil5[0]);
            ar2.Text = Convert.ToString(idfamil6[0]);
            ar3.Text = Convert.ToString(idfamil7[0]);
            ar4.Text = Convert.ToString(idfamil8[0]);
            ar5.Text = Convert.ToString(idfamil9[0]);
            ar6.Text = Convert.ToString(idfamil10[0]);

            







        }

        private void button9_Click(object sender, EventArgs e)
        {

            List<string> idfamil12 = SQLRequests.SelectRequest(
            "Select Агент.Фамилия From Агент ",
            new string[] {  }, new string[] {  });
            
            for (int i = 0; i < idfamil12.Count; i++)
            {
                labels1.Text += idfamil12[i] + "\n";
            }
            


        }
    }
}
