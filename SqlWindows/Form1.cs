using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SqlWindows
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;

        MySqlConnection sqlConn = new MySqlConnection();
        MySqlCommand sqlCmd = new MySqlCommand();
        DataTable sqlDt = new DataTable();
        string sqlQuery;
        MySqlDataAdapter DtA = new MySqlDataAdapter();
        MySqlDataReader sqlRd;

        DataSet DS = new DataSet();

        string server = "localhost";
        string username = "root";
        string password = "";
        string database = "windowapp";

        public Form1()
        {
            InitializeComponent();
        }

        private void upLoadData()
        {
            sqlConn.ConnectionString = "server=localhost;" + "user id=root;" +
                "password=;" + "database=windowapp";


            sqlConn.Open();
            sqlCmd.Connection = sqlConn;
            sqlCmd.CommandText = "SELECT * FROM windowapp.students";

            sqlRd = sqlCmd.ExecuteReader();
            sqlDt.Load(sqlRd);
            sqlRd.Close();
            sqlConn.Close();
            dataGridView1.DataSource = sqlDt;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = "server=" + ";" + "user id=" + ";" +
               "password=" + password + ";" + "database" + database;

            try
            {
                sqlConn.Open();
                sqlQuery = "insert into windowapp.students (StudentID, Firstname, Lastname, Adress, Postcode, Telephone)" +
                    "values('" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox5.Text + "')";

                sqlCmd = new MySqlCommand(sqlQuery, sqlConn);
                sqlRd = sqlCmd.ExecuteReader();

                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
            upLoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            DialogResult iExit;
            try
            {

                iExit = MessageBox.Show("Haluatko varmasti sulkea", "Opiskelija tietokanta",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control c in panel4.Controls)
                {
                    if (c is TextBox)
                        ((TextBox)c).Clear();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            try
            {
                int height = dataGridView1.Height;
                dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
                bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
                dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                printPreviewDialog1.ShowDialog();
                dataGridView1.Height = height;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawImage(bitmap, 0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            upLoadData();
        }

        private void update_Click(object sender, EventArgs e)
        {
            sqlConn.ConnectionString = "server=" + ";" + "user id=" + ";" +
                "password=" + password + ";" + "database" + database;
            sqlConn.Open();

            try
            {
                MySqlCommand sqlCmd = new MySqlCommand();
                sqlCmd.Connection = sqlConn;

                sqlCmd.CommandText = "Update stucon.stucon set Studentid = @Studentid, Firstname=@Firstname," +
                "Surname= @Surname,Adress = @Adress,Postcode = @Postcode,Telephone = @Telephone " +
                "where Studentid = @Studentid";

                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@Studentid", textBox1.Text);
                sqlCmd.Parameters.AddWithValue("@Firstname", textBox1.Text);
                sqlCmd.Parameters.AddWithValue("@Surname", textBox1.Text);
                sqlCmd.Parameters.AddWithValue("@Adress", textBox1.Text);
                sqlCmd.Parameters.AddWithValue("@Postcode", textBox1.Text);
                sqlCmd.Parameters.AddWithValue("@Telephone", textBox1.Text);

                sqlCmd.ExecuteNonQuery();
                sqlConn.Close();
                upLoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


    }
}