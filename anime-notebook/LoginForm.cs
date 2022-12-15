using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using MessageBox = System.Windows.MessageBox;

namespace anime_notebook
{
    public partial class LoginForm : Form
    {
        private bool isLogin = true;
        const string ConnectionString = @"Data Source=DESKTOP-VUJIJGT;Initial Catalog=anime_notebook_db;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private string email;
        private bool isDate = false;

        public LoginForm()
        {
            InitializeComponent();

            pictureBox_Email.Hide();
            panel_Email.Hide();
            textBox_Email.Size = new Size(0,18);
            label_Email.Hide();
        }

        private bool isValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
        private bool isEmailOrLoginExist()
        {
            SqlConnection sqlcon = new SqlConnection(ConnectionString);
            string select = $"SELECT login, email FROM User1";
            sqlcon.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(select, sqlcon);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            sqlcon.Close();

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                if(dataSet.Tables[0].Rows[i][0].ToString() == textBox_log.Text 
                    || dataSet.Tables[0].Rows[i][1].ToString() == textBox_Email.Text)
                    return true;
            }
            return false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            textBox_pass.Clear();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            textBox_log.Clear();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            textBox_Email.Clear();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (isLogin)
            {
                isLogin = false;
                label1.Text = "Register";

                pictureBox_Email.Show();
                panel_Email.Show();
                textBox_Email.Size = new Size(232, 18);
                label_Email.Show();
            }
            else
            {
                isLogin = true;
                label1.Text = "Login";

                pictureBox_Email.Hide();
                panel_Email.Hide();
                textBox_Email.Size = new Size(0, 18);
                label_Email.Hide();
            }

            button1.Text = label1.Text;
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isLogin)
            {
                SqlConnection sqlcon = new SqlConnection(ConnectionString);
                sqlcon.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(
                    $"SELECT email, subscription_date FROM User1 WHERE login = '{textBox_log.Text}' AND password = '{textBox_pass.Text}'"
                    , sqlcon);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                sqlcon.Close();

                if (dataSet.Tables[0].Rows.Count != 0)
                {
                    email = dataSet.Tables[0].Rows[0][0].ToString();
                    if (MessageBox.Show("You Have Logged in!", "Good", MessageBoxButton.OK, MessageBoxImage.Information) == MessageBoxResult.No)
                    {
                        
                    }
                    DateTime dateTime = Convert.ToDateTime(dataSet.Tables[0].Rows[0][1].ToString());
                    if(dateTime.Day - DateTime.Now.Day <= 7 && dateTime.Day - DateTime.Now.Day > 0)
                    {
                        isDate = true;
                    }
                    logIn();
                }
                else
                {
                    if (MessageBox.Show("Wrong Login Or Password!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning) == MessageBoxResult.No)
                    {

                    }
                }
            }
            else
            {
                if (isValidEmail(textBox_Email.Text))
                {
                    if (textBox_log.Text.Length >= 3)
                    {
                        if(textBox_pass.Text.Length >= 3)
                        {
                            if (!isEmailOrLoginExist())
                            {
                                SqlConnection sqlcon = new SqlConnection(ConnectionString);
                                sqlcon.Open();

                                SqlCommand sqlCommand = new SqlCommand();
                                sqlCommand.Connection = sqlcon;
                                sqlCommand.CommandText = $"INSERT INTO User1 (login, password, email, props, subscription_duration, subscription_date) VALUES ('{textBox_log.Text}', '{textBox_pass.Text}', '{textBox_Email.Text}', '0000-0000-0000-0000', 0, '{DateTime.Now}')";
                                sqlCommand.ExecuteNonQuery();
                                sqlcon.Close();

                                if (MessageBox.Show("Your Account Has Been Created!", "Good", MessageBoxButton.OK, MessageBoxImage.Information) == MessageBoxResult.No)
                                {
                                    
                                }

                                email = textBox_Email.Text;
                                logIn();
                            }
                            else
                            {
                                if (MessageBox.Show("This Login Or Email Already Exist!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning) == MessageBoxResult.No)
                                {
                                    //do no stuff
                                }
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("Invalid Password!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning) == MessageBoxResult.No)
                            {
                                //do no stuff
                            }
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Invalid Login!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning) == MessageBoxResult.No)
                        {
                            //do no stuff
                        }
                    }
                }
                else
                {
                    if (MessageBox.Show("Invalid Email!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning) == MessageBoxResult.No)
                    {
                        //do no stuff
                    }
                }
            }
        }

        private void logIn()
        {
            if (isDate)
            {
                var fromAddress = new MailAddress("oleh.khmelyk1@nure.ua", "Anime Notebook");
                var toAddress = new MailAddress(email);
                const string fromPassword = "OlehKhmelyk4573";
                const string subject = "Your subscribe period is ending!";
                string body;
                body = $"You must top up your balance!";
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword),


                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body

                })
                {
                    smtp.Send(message);
                }
            }
            Hide();
            var qe = new Main(textBox_log.Text);
            qe.Show();
        }
    }
}
