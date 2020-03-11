using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Odbc;


namespace WinGAI
{
    public partial class Autorization : Form
    {
        int a = 0, b = 15, s = 0, d = 15;

        public Autorization()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            b--;
            LabelMessage.Text = ("Вы использовали 3 неверные попытки. Пожалуйста подождите:" + b);
            if (b == 0)
            { timer1.Enabled = false; //деактивируем таймер
                ButInput.Enabled = true; //активируем кнопку входа
                LabelMessage.Visible = false; //деактивируем сообщение о блокировке 
                LabelMessage.Text = "";
                TextBoxLog.Enabled = true; //активируем поле ввода логина 
                TextBoxPass.Enabled = true; //активируем поле ввода пароля
                b = d; //обратно возвращаем значение 15 для следующего раза

            }

            private void ButOutput_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void ButInput_Click(object sender, EventArgs e)
            {
                SqlConnection connection = new SqlConnection(@"Data Source=ВАЛЯ; Initial Catalog=GAI; Integrated Security=True");
                try
                {
                    string commandManager = "SELECT*FROM Users WHERE login='" + TextBoxLog.Text + "'AND password='" + TextBoxPass.Text + "'AND role='inspector'";
                    SqlCommand checkManager = new SqlCommand(commandManager, connection);

                    connection.Open();
                    if (checkManager.ExecuteScalar() != null)
                    {
                        Form formInspector = new FormInspector();
                        formInspector.ShowDialog();
                        this.Hide();
                    }
                    else

                    {
                        MessageBox.Show("Пожалуйста проверьте ещё раз введеные данные!", "Вы ввели неверный логин или пароль!");
                        a++;
                        if (a == 3)
                        {

                            timer1.Enabled = true; //активируем таймер
                            LabelMessage.Visible = true; //активируем сообщение о блокировке 
                            ButInput.Enabled = false; //блокируем кнопку входа
                            TextBoxLog.Enabled = false; //блокируем поле ввода логина 
                            TextBoxPass.Enabled = false; //блокируем поле ввода пароля
                            a = 0; //обнуляем счетчик
                        }
                    }
                }

                catch
                {
                    MessageBox.Show("Возникло исключение!");
                    connection.Close();
                }
            }
            private void ButtonExit_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }
        }
    }
}

        


