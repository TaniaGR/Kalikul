using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Zara
{
    public partial class podkl_bd : Form
    {
        podklclss _CCC;
        public podkl_bd()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.Text == "")
                {
                    MessageBox.Show("Выберите сервер для получения источника данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        SqlConnection conect_server = new SqlConnection("Data Source =" + comboBox1.Text + ";Initial Catalog = master; Persist Security Info = True; User ID = " + textBox1.Text + ";Password = \"" + textBox2.Text + "\"");
                        conect_server.Open();
                        SqlDataAdapter BsAdpt = new SqlDataAdapter("exec sp_helpdb", conect_server);
                        DataSet BDst = new DataSet();
                        BsAdpt.Fill(BDst, "db");
                        comboBox2.DataSource = BDst.Tables[0];
                        comboBox2.DisplayMember = "name";
                        label4.Visible = true;
                        comboBox2.Visible = true;
                        button2.Visible = true;
                }
                    catch
                    {
                        MessageBox.Show("Ошибка при подключении." + "\n" + "Повторите попытку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && textBox1.Text != "" && textBox2.Text != "" && comboBox2.Text != "")
            {
                _CCC = new podklclss();
                _CCC.Register_set(comboBox1.Text, textBox1.Text, textBox2.Text, comboBox2.Text);
                avtoriz avtoriz = new avtoriz();
                this.Hide();
                avtoriz.Show();
            }
            else
            {
                MessageBox.Show("Заполните все данные");
            }
        }

        private void podkl_bd_Load(object sender, EventArgs e)
        {
            SqlDataSourceEnumerator sse = SqlDataSourceEnumerator.Instance;
            DataTable dt = sse.GetDataSources();
            foreach (DataRow r in dt.Rows)
            {
                comboBox1.Items.Add(r[0] + "\\" + r[1]);
            }
        }

        private void podkl_bd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
   
}
