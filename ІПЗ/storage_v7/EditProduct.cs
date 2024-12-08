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
    public partial class EditProduct : Form
    {
        int tovarCount = 0;
        string checkedElem = "Відправка";
        string id;
        string nameProduct = "";
        int countProduct = 0;
        public EditProduct( string id1 , string name1, int count)
        {
            InitializeComponent();
            nameProduct = name1;
           id = id1;
            nameLabel.Text = name1;
            countProduct = count;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(inputCount.Text == "")
            {
                MessageBox.Show("Заповніть кількість товару для зміни");
            }
            else
            {
                bool flag = true;

                int countChange = int.Parse(inputCount.Text);
                if(checkedElem == "Відправка")
                {
                    if (countProduct - countChange < 0)
                    {
                        flag = false;
                        MessageBox.Show("Кількість відправки не може бути більша за кількість товару на складі");
                    }
                    else
                    {
                        countProduct = countProduct - countChange;
                    }
                }
                else
                {
                    countProduct += countChange;
                }

                if (flag)
                {
                    try
                    {
                        string url = "http://localhost:8000";
                        using (var webClient = new MyWebClient())
                        {
                            var pars = new NameValueCollection();
                            pars.Add("data", "editProduct" + " id " + id + " count " + countProduct);
                            var response = webClient.UploadValues(url, pars);
                            string res = System.Text.Encoding.UTF8.GetString(response);
                            string writeGood = res.Split(',')[0];
                            if (writeGood == "true")
                            {
                                MessageBox.Show("Товар успішно редаговано");
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            checkedElem = "Поставка";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            checkedElem = "Відправка";
        }
    }
}
