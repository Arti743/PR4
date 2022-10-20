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

namespace PR4
{
    public partial class MemberCircleForm : Form
    {
        DataSet data;
        SqlDataAdapter adap;
        SqlCommandBuilder command;
        //Строка подключения к SQL Server'у
        string connectionString = @"Data Source=192.168.0.7, 3306; Initial Catalog=DK; Integrated Security=True";
        string sql = "SELECT * FROM Member_circle";


        public MemberCircleForm()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adap = new SqlDataAdapter(sql, connection);

                data = new DataSet();
                adap.Fill(data);
                dataGridView1.DataSource = data.Tables[0];
            }
        }

        //Кнопка сохранения
        private void button_Save_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adap = new SqlDataAdapter(sql, connection);
                command = new SqlCommandBuilder(adap);
                adap.InsertCommand = new SqlCommand("ADD_Member_Circle", connection);
                adap.InsertCommand.CommandType = CommandType.StoredProcedure;
                adap.InsertCommand.Parameters.Add(new SqlParameter("@FIO_m", SqlDbType.VarChar, 100, "FIO_m"));
                adap.InsertCommand.Parameters.Add(new SqlParameter("@Year_of_brith", SqlDbType.VarChar, 20, "Name_type"));
                adap.InsertCommand.Parameters.Add(new SqlParameter("@Number_phone", SqlDbType.VarChar, 14, "Number_phone"));
                adap.InsertCommand.Parameters.Add(new SqlParameter("@id_Circle", SqlDbType.Int, 0, "id_Circle"));



                adap.Update(data);
            }
        }

        //Кнопка уадления выделенной строки
        private void button_Del_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }
        //Кнопка добавления новой строки
        private void button_Add_Click(object sender, EventArgs e)
        {
            DataRow row = data.Tables[0].NewRow();
            data.Tables[0].Rows.Add(row);
        }

        void openchild(Panel pen, Form empryF)
        {
            empryF.TopLevel = false;
            empryF.FormBorderStyle = FormBorderStyle.None;
            empryF.Dock = DockStyle.Fill;
            pen.Controls.Add(empryF);
            empryF.BringToFront();
            empryF.Show();
        }

        //Кнопка обновления таблицы
        private void button_Refresh_Click(object sender, EventArgs e)
        {
            openchild(panel1, new MemberCircleForm());
        }
    }
}
