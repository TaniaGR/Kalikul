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
using Microsoft.Office.Interop.Excel;

namespace Zara
{
    public partial class prodazhi : Form
    {
        podklclss _CC;
        int nom_chek, summ;
        string nom_post, id_tov_zal, kol, cena;
        string id_ch;
        public prodazhi()
        {
            InitializeComponent();
        }

        public void tov_zal()
        {
            _CC = new podklclss();
            _CC.Set_Connection();
            SqlCommand tov_zal = new SqlCommand("select * from tov_zal_post", _CC.conection);
            _CC.conection.Open();
            SqlDataReader tov = tov_zal.ExecuteReader();
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Load(tov);
            dataGridView2.DataSource = dt;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].HeaderText = "Артикул";
            dataGridView2.Columns[2].HeaderText = "Наименование товара";
            dataGridView2.Columns[3].HeaderText = "Количество";
            dataGridView2.Columns[4].HeaderText = "Цена";
            dataGridView2.Columns[5].Visible = false;
            dataGridView2.Columns[6].HeaderText = "Номер поставки";
            _CC.conection.Close();
        }

        public void prod_ch()
        {
            _CC = new podklclss();
            _CC.Set_Connection();
            SqlCommand tov_prod = new SqlCommand("select artikyl, naim_tov_prod, kol_tov_prod, cena from tov_prod where chek_id = '" + id_ch + "'", _CC.conection);
            _CC.conection.Open();
            SqlDataReader tov = tov_prod.ExecuteReader();
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Load(tov);
            dataGridView1.DataSource = dt;            
            dataGridView1.Columns[0].HeaderText = "Артикул";
            dataGridView1.Columns[1].HeaderText = "Наименование товара";
            dataGridView1.Columns[2].HeaderText = "Количество";
            dataGridView1.Columns[3].HeaderText = "Цена";          
            _CC.conection.Close();
        }

        public void get_nom_chek()
        {
            _CC = new podklclss();
            _CC.Set_Connection();
            SqlCommand cmd = new SqlCommand("select count([nom_chek])+1 from [dbo].[chek]", _CC.conection);
            _CC.conection.Open();
            textBox5.Text = cmd.ExecuteScalar().ToString();
            nom_chek = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            _CC.conection.Close();
        }        

        public void chek()
        {
            string id_sotr;
            _CC = new podklclss();
            _CC.Set_Connection();
            SqlCommand get_tab_user = new SqlCommand("select id_sotr from sotrud where login ='" + Program.user_login + "'", _CC.conection);
            SqlCommand insert_chek = new SqlCommand("insert into [dbo].[chek](nom_chek, data_chek, sotr_chek_id) values(@nom_chek, @data_chek, @sotr_chek_id)", _CC.conection);
            _CC.conection.Open();
            SqlDataReader tab_user = get_tab_user.ExecuteReader();
            tab_user.Close();
            id_sotr = Convert.ToString(get_tab_user.ExecuteScalar());
            insert_chek.Parameters.AddWithValue("nom_chek", Convert.ToInt32(textBox5.Text));
            insert_chek.Parameters.AddWithValue("data_chek", maskedTextBox1.Text);
            insert_chek.Parameters.AddWithValue("sotr_chek_id", Convert.ToInt32(id_sotr));
            insert_chek.ExecuteNonQuery();
            _CC.conection.Close();
        }

        private void торговыйЗалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prodant examp = new prodant();
            examp.Show();
            this.Close();
        }

        private void вернутьсяВГлавноеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            glav_menu examp = new glav_menu();
            examp.Show();
            this.Close();
        }       

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.RowCount; i++) //row-строка
            {
                dataGridView2.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    if (dataGridView2.Rows[i].Cells[j].Value != null)
                        if (dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView2.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void prodazhi_Load(object sender, EventArgs e)
        {
            const string message ="Вы хотите оформить чек?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);            
            if (result == DialogResult.Yes)
            {
                maskedTextBox1.Text = Convert.ToString(DateTime.Today);
                tov_zal();
                get_nom_chek();
                chek();
                summ = 0;
            }
            else
            {
                prodant examp = new prodant();
                examp.Show();
                this.Close();
            }          
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            ExcelApp.Application.Workbooks.Add(Type.Missing);
            ExcelApp.Columns.ColumnWidth = 25;
            ExcelApp.Cells[1, 1] = "Дата: "+maskedTextBox1.Text; 
            ExcelApp.Cells[1, 2] = "Номер чека: " + textBox5.Text;
            ExcelApp.Cells[1, 3] = "Сумма: " + textBox2.Text;

            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    ExcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[j].Cells[i].Value;
                }
            }
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;

            prodant examp = new prodant();
            examp.Show();
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
            {
                e.Handled = true;
            }
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                MessageBox.Show("Выберите товар");
            }
            else
            {
                if (Convert.ToInt32(textBox3.Text) > Convert.ToInt32(kol))
                {
                    MessageBox.Show("Кол-во товара превышено");
                }
                else
                {
                    int q, k;
                    _CC = new podklclss();
                    _CC.Set_Connection();
                    SqlCommand get_id_chek = new SqlCommand("select id_chek from chek where nom_chek ='" + textBox5.Text + "'", _CC.conection);
                    SqlCommand insert_tov_prod = new SqlCommand("insert into [dbo].[tov_prod](artikyl, naim_tov_prod, kol_tov_prod,cena,chek_id) values(@artikyl, @naim_tov_prod, @kol_tov_prod,@cena,@chek_id)", _CC.conection);
                    _CC.conection.Open();
                    SqlDataReader id_chek = get_id_chek.ExecuteReader();
                    id_chek.Close();
                    id_ch = Convert.ToString(get_id_chek.ExecuteScalar());

                    insert_tov_prod.Parameters.AddWithValue("artikyl", textBox8.Text);
                    insert_tov_prod.Parameters.AddWithValue("naim_tov_prod", textBox4.Text);
                    insert_tov_prod.Parameters.AddWithValue("kol_tov_prod", textBox3.Text);
                    insert_tov_prod.Parameters.AddWithValue("cena", textBox6.Text);
                    insert_tov_prod.Parameters.AddWithValue("chek_id", id_ch);
                    insert_tov_prod.ExecuteNonQuery();
                    _CC.conection.Close();
                    textBox8.Text = "";
                    textBox4.Text = "";
                    k = Convert.ToInt32(textBox3.Text);
                    textBox6.Text = "";
                    q = (Convert.ToInt32(kol) - k);                    
                    summ = (summ + (k*(Convert.ToInt32(cena))));
                    textBox2.Text = Convert.ToString(summ);
                    if (q < 1)
                    {
                        SqlConnection con = new SqlConnection("Data Source=DESKTOP-AG8AKLU;initial catalog=Zara_base2;Persist Security info = True; User ID = SA; Password = qweqweqwe123");
                        con.Open();
                        SqlCommand delete_tov_zal = new SqlCommand("[dbo].delete_tov_zal", con);
                        delete_tov_zal.CommandType = CommandType.StoredProcedure;
                        delete_tov_zal.Parameters.AddWithValue("@id_tov_zal", Convert.ToInt32(id_tov_zal));
                        delete_tov_zal.ExecuteNonQuery();
                        MessageBox.Show("Это был последний");
                        tov_zal();
                    }
                    else
                    {
                        try
                        {
                            _CC = new podklclss();
                            _CC.Set_Connection();
                            SqlCommand update_tov_zal_k = new SqlCommand("update tov_zal set [kol_tov_zal] = @kol_tov_zal where [id_tov_zal] = @id_tov_zal", _CC.conection);
                            _CC.conection.Open();
                            update_tov_zal_k.Parameters.AddWithValue("id_tov_zal", id_tov_zal);
                            update_tov_zal_k.Parameters.AddWithValue("kol_tov_zal", q);
                            update_tov_zal_k.ExecuteNonQuery();
                            _CC.conection.Close();
                            kol = Convert.ToString((Convert.ToInt32(kol) - 1));
                            tov_zal();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            prod_ch();
        }

        private void главноеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            glav_menu examp = new glav_menu();
            examp.Show();
            this.Close();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_tov_zal = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox8.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox4.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            kol = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            textBox6.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            cena = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            nom_post = dataGridView2.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
