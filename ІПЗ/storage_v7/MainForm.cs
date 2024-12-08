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
    public partial class MainForm : Form
    {
        string url = "http://localhost:8000";
        int allTovarCount = 0;
        string email = "";
        public MainForm(string userName, string userEmail)
        {
            InitializeComponent();
            labelUserName.Text = userName;
            email = userEmail;
           
            try
            {

                using (var webClient = new MyWebClient())
                {
                    var pars = new NameValueCollection();
                    pars.Add("data", "getAllProducts");
                    var response = webClient.UploadValues(url, pars);
                    string res = System.Text.Encoding.UTF8.GetString(response);
                    string result = res.Split(',')[0];
                    if (result == "true")
                    {
                        int count = 0;
                        labelSeachInfo.Text = "Товари на складі:";
                        dataGridView1.Rows.Clear();
                        string products = res.Split(',')[1];
                        if (products.Split('\n').Length != 0)
                        {
                            foreach (var goods in products.Split('\n'))
                            {
                                if (goods != "")
                                {
                                    dataGridView1.Rows.Add(goods.Split(' '));
                                    allTovarCount += 1;
                                }
                            }
                  
                            dataGridView1.ReadOnly = false;
                        }
                    }
                    else
                    {
                        dataGridView1.Rows.Add(".Немає даних.".Split('.'));
                    }

                }
            }
            catch (WebException ex)
            {
                MessageBox.Show("Час очікування відповіді від сервера вийшов\n Спробуйте пізніше");
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

        private void btnSearchById_Click(object sender, EventArgs e)
        {
            if(inputSearch.Text.Length == 0)
            {
                MessageBox.Show("Введіть ід товару");
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(inputSearch.Text, "[^0-9]"))
            {
                MessageBox.Show("Ід має складатись тільки з цифр");
                inputSearch.Text = "";
            }
            else
            {
                try
                {

                    using (var webClient = new MyWebClient())
                    {
                        var pars = new NameValueCollection();
                        pars.Add("data", "searchById id " + inputSearch.Text.Trim());
                        var response = webClient.UploadValues(url, pars);
                        string res = System.Text.Encoding.UTF8.GetString(response);
                        string result = res.Split(',')[0];
                        if (result == "true")
                        {
                            dataGridView1.Rows.Clear();
                            labelSeachInfo.Text = "Результат пошуку:";
                            dataGridView1.Rows.Add(res.Split(',')[1].Split(' '));
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


        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            if (inputSearch.Text.Length == 0)
            {
                MessageBox.Show("Введіть назву товару");
            } else
            {
                try
                {

                    using (var webClient = new MyWebClient())
                    {
                        var pars = new NameValueCollection();
                        pars.Add("data", "searchByName name " + inputSearch.Text.Trim().Replace(' ', '-'));
                        var response = webClient.UploadValues(url, pars);
                        string res = System.Text.Encoding.UTF8.GetString(response);
                        string result = res.Split(',')[0];
                        if (result == "true")
                        {
                            dataGridView1.Rows.Clear();
                            labelSeachInfo.Text = "Результат пошуку:";
                            dataGridView1.Rows.Add(res.Split(',')[1].Split(' '));
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


        private void btnShowAllGoods_Click(object sender, EventArgs e)
        {
            try
            {

                using (var webClient = new MyWebClient())
                {
                    var pars = new NameValueCollection();
                    pars.Add("data", "getAllProducts");
                    var response = webClient.UploadValues(url, pars);
                    string res = System.Text.Encoding.UTF8.GetString(response);
                    string result = res.Split(',')[0];
                    if (result == "true")
                    {
                        labelSeachInfo.Text = "Товари на складі:";
                        string products = res.Split(',')[1];
                        if (products.Split('\n').Length != 0)
                        {
                            foreach (var goods in products.Split('\n'))
                            {
                                if (goods != "")
                                {
                                    dataGridView1.Rows.Add(goods.Split(' '));
                                }
                            }
                        }
                    }
                    else
                    {
                        dataGridView1.Rows.Add(".Немає даних.".Split('.'));
                    }

                }
            }
            catch (WebException ex)
            {
                MessageBox.Show("Час очікування відповіді від сервера вийшов\n Спробуйте пізніше");
            }
        }

        private void btnAddNewGoods_Click(object sender, EventArgs e)
        {
            NewProduct newProductForm = new NewProduct(allTovarCount + 1);
            newProductForm.Show();
        }

        private void imgLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show(
               "Ви справді бажаєте вийти?",
                "Повідомлення",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            Console.Write(dialogresult);
            if (dialogresult == DialogResult.Yes)
            {
                try
                {
                    using (var webClient = new MyWebClient())
                    {
                        var pars = new NameValueCollection();
                        pars.Add("data", "logOut email " + email);
                        var response = webClient.UploadValues(url, pars);
                        string res = System.Text.Encoding.UTF8.GetString(response);
                        string result = res.Split(',')[0];
                        if (result == "true")
                        {
                            Authorisation authorisation = new Authorisation();
                            authorisation.Show();
                            authorisation.FormClosed += new FormClosedEventHandler(delegate { Close(); });
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult dialogresult = MessageBox.Show(
               "Ви справді бажаєте вийти?",
                "Повідомлення",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            Console.Write(dialogresult);
            if (dialogresult == DialogResult.Yes)
            {
                try
                {
                    using (var webClient = new MyWebClient())
                    {
                        var pars = new NameValueCollection();
                        pars.Add("data", "logOut email " + email);
                        var response = webClient.UploadValues(url, pars);
                        string res = System.Text.Encoding.UTF8.GetString(response);
                        string result = res.Split(',')[0];
                        if (result == "true")
                        {
                            Authorisation authorisation = new Authorisation();
                            authorisation.Show();
                            authorisation.FormClosed += new FormClosedEventHandler(delegate { Close(); });
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

        private void btnEditProducts_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Виберіть товар з списку");
            } else if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Виберіть тільки один товар з списку");
            }
            else
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                int count  = int.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                EditProduct edit = new EditProduct(id, name, count);
                edit.Show();
                dataGridView1.Rows.Clear();
            }
        }
    }
}
