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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        string url = "http://localhost:8000";
        public class MyWebClient : WebClient
        {
            protected override WebRequest GetWebRequest(Uri uri)
            {
                WebRequest w = base.GetWebRequest(uri);
                w.Timeout = 3 * 1000;
                return w;
            }
        }

        private void registrationBtn_Click(object sender, EventArgs e)
        {
            string nameValue = name.Text.Trim();
            string emailValue = email.Text.Trim();
            string passwordValue = password.Text.Trim();
            string repasswordValue = repassword.Text.Trim();
            if (nameValue.Length == 0 || emailValue.Length == 0 || passwordValue.Length == 0 || repasswordValue.Length == 0)
            {
                MessageBox.Show("Заповніть всі поля");
            }
            else if(emailValue.Length < 8)
            {
                MessageBox.Show("Е-пошта повинна містити не менше 8 символів");
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(emailValue, "@") == false)
            {
                MessageBox.Show("Е-пошта повинна містити символ @");
            }
            else if (emailValue.Split('@')[1].Length == 0)
            {
                MessageBox.Show("Е-пошта не коректна після символа @");
            }
            else if (passwordValue != repasswordValue)
            {
                MessageBox.Show("Паролі не співпадають");
            }
            else {
                string dataReq = "name " + nameValue  + " email " + emailValue + " password " + passwordValue;
                try
                {
                    using (var webClient = new MyWebClient())
                    {
                        var pars = new NameValueCollection();
                        pars.Add("data", "createUser " + dataReq);
                        var response = webClient.UploadValues(url, pars);
                        string res = System.Text.Encoding.UTF8.GetString(response);
                        string registration = res.Split(',')[0];
                        if (registration == "true")
                        {
                            MessageBox.Show(res.Split(',')[1]);
                            MainForm mainForm = new MainForm(nameValue, emailValue);
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

        private void authorisationLink_Click(object sender, EventArgs e)
        {
            Authorisation authorisationForm = new Authorisation();
            authorisationForm.Show();
            authorisationForm.FormClosed += new FormClosedEventHandler(delegate { Close(); });
            this.Hide();
        }
    }
}
