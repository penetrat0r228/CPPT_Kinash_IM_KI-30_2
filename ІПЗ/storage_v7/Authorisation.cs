using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Collections.Specialized;

namespace storage_v7
{
    public partial class Authorisation : Form
    {
        public Authorisation()
        {
            InitializeComponent();
        }
        public class MyWebClient : WebClient
        {
            protected override WebRequest GetWebRequest(Uri uri)
            {
                WebRequest w = base.GetWebRequest(uri);
                w.Timeout = 3 * 1000;
                return w;
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (email.Text == "" || password.Text == "")
            {
                MessageBox.Show("Заповніть всі поля");
            }
            else if (email.Text.ToString().Length < 8)
            {
                MessageBox.Show("Логін повинен містити не менше 8 символів");
            }
            else if (password.Text.Length < 6)
            {
                MessageBox.Show("Пароль повинен містити не менше 6 символів");
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(email.Text, "@") == false)
            {
                MessageBox.Show("Е-пошта повинна містити символ @");
            }
            else
            {
                string url = "http://localhost:8000";
                string dataReq = "email " + email.Text + " password " + password.Text;
                try
                {
                    using (var webClient = new MyWebClient())
                    {
                        var pars = new NameValueCollection();
                        pars.Add("data", "logIn " + dataReq);
                        var response = webClient.UploadValues(url, pars);
                        string res = System.Text.Encoding.UTF8.GetString(response);
                        string loginSuccess = res.Split(',')[0];
                        if (loginSuccess == "true")
                        {
                            string userName = res.Split(',')[1];
                            MainForm mainForm = new MainForm(userName, email.Text);
                            mainForm.Show();
                            mainForm.FormClosed += new FormClosedEventHandler(delegate { Close(); });
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show(res.Split(',')[1]);
                        }
                    }
                }
                catch (WebException ex)
                {
                    MessageBox.Show("Час очікування відповіді від сервера вийшов\n Спробуйте пізніше");
                }
            }
        }

        private void registrationLink_Click(object sender, EventArgs e)
        {
            Registration  registrationForm = new Registration();
            registrationForm.Show();
            registrationForm.FormClosed += new FormClosedEventHandler(delegate { Close(); });
            this.Hide();
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(email.Text, "[\u0400-\u04FF]") == true)
            {
                MessageBox.Show("Е-пошта не може містити кирилицю");
            }
        }
    }
}
