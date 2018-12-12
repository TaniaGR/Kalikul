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
    public partial class glav_menu : Form
    {
        podklclss _CC;
        public glav_menu()
        {
            InitializeComponent();           
        }

        private void отделКадровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kadr_sotr examp = new kadr_sotr();
            examp.Show();
            this.Hide();
        }

        private void складToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ychet_sklad examp = new ychet_sklad();
            examp.Show();
            this.Close();
        }

        private void продажиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prodant examp = new prodant();
            examp.Show();
            this.Close();
        }

        public void get_level_access_user()
        {
            _CC = new podklclss();
            _CC.Set_Connection();
            SqlCommand get_level_access = new SqlCommand("select dolzh_id from sotrud where login ='" + Program.user_login + "'", _CC.conection);
            _CC.conection.Open();
            SqlDataReader read_level = get_level_access.ExecuteReader();
            read_level.Close();
            Program.level_access = Convert.ToInt32(get_level_access.ExecuteScalar());
            _CC.conection.Close();
        }

        public void get_name_user()
        {
            _CC = new podklclss();
            _CC.Set_Connection();
            SqlCommand get_fam_user = new SqlCommand("select familia from sotrud where login ='" + Program.user_login + "'", _CC.conection);
            SqlCommand get_name_user = new SqlCommand("select imya from sotrud where login ='" + Program.user_login + "'", _CC.conection);
            SqlCommand get_otch_user = new SqlCommand("select otchestvo from sotrud where login ='" + Program.user_login + "'", _CC.conection);
            _CC.conection.Open();
            SqlDataReader fam_user = get_fam_user.ExecuteReader();
            fam_user.Close();
            Program.fam_user = Convert.ToString(get_fam_user.ExecuteScalar());
            SqlDataReader name_user = get_name_user.ExecuteReader();
            name_user.Close();
            Program.name_user = Convert.ToString(get_name_user.ExecuteScalar());
            SqlDataReader otch_user = get_otch_user.ExecuteReader();
            otch_user.Close();
            Program.otch_user = Convert.ToString(get_otch_user.ExecuteScalar());
            _CC.conection.Close();
        }

        private void glav_menu_Load(object sender, EventArgs e)
        {
            get_name_user();
            get_level_access_user();
            toolStripStatusLabel1.Text = ("Сотрудник: " + Program.fam_user + " " + Program.name_user + " " + Program.otch_user);
            toolStripStatusLabel2.Text = ("Ваш код должности: " + Program.level_access);
            switch (Program.level_access)
            {
                case 1:
                    
                    отделКадровToolStripMenuItem.Enabled = true;
                    складToolStripMenuItem.Enabled = true;                    
                    продажиToolStripMenuItem .Enabled = true;
                    break;
                case 2:
                    отделКадровToolStripMenuItem.Enabled = true;
                    break;
                case 3:
                    складToolStripMenuItem.Enabled = true;
                    продажиToolStripMenuItem.Enabled = true;
                    break;
                case 4:
                    складToolStripMenuItem.Enabled = true;
                    break;
                default:
                    MessageBox.Show("У вас нет прав для доступа", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }

            
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }       

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            avtoriz examp = new avtoriz();
            examp.Show();
            this.Close();
        }

        private void выходИзПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void glav_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void glav_menu_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("exit?", "info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                Application.Exit();
            }
           
        }
    }
}
