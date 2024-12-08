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
    public partial class NewProduct : Form
    {
        public NewProduct(int countId)
        {
            InitializeComponent();
            inputId.Text = countId.ToString();
        }

        private void inputId_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(inputId.Text, "[^0-9]"))
            {
                MessageBox.Show("Вводьте тільки цифри");
                inputId.Text = inputId.Text.Remove(inputId.Text.Length - 1);
            }
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

        private void inputCount_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(inputCount.Text, "[^0-9]"))
            {
                MessageBox.Show("Вводьте тільки цифри");
                inputCount.Text = inputCount.Text.Remove(inputCount.Text.Length - 1);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if(inputName.Text.Length < 10)
            {
                MessageBox.Show("Назва повинна бути не менше 10 символів");
            }
            else if(inputCount.Text != "" && inputId.Text != "")
            {
                 try
                {
                    string url = "http://localhost:8000";
                    using (var webClient = new MyWebClient())
                    {
                        var pars = new NameValueCollection();
                        pars.Add("data", "addProduct id " + inputId.Text.Trim() +  " name " + inputName.Text.Trim().Replace(' ', '-') + " count " + inputCount.Text.Trim());
                        var response = webClient.UploadValues(url, pars);
                        string res = System.Text.Encoding.UTF8.GetString(response);
                        string writeGood = res.Split(',')[0];
                        if (writeGood == "true")
                        {
                            MessageBox.Show(res.Split(',')[1]);
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
                    MessageBox.Show("Час очікування відповіді серверу вийшов\n Спробуйте пізніше");
                }
            }
        }
    }
}
