using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Welcome
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string oradb = "Data Source=localhost:1521/XE;User Id = students; Password = students; ";
                OracleConnection conn = new OracleConnection(oradb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();

                {
                    cmd.CommandText = "insert into students (rollno , name, dept, sem_year, address, phoneno) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";


                    cmd.Connection = conn;

                    int rowsUpdated = cmd.ExecuteNonQuery();
                    if (rowsUpdated == 0)
                    {
                        MessageBox.Show("Record not inserted");
                    }
                    else
                    {
                        MessageBox.Show("Success!");

                        Form1 login = new Form1();
                        login.Show();
                    }
                    conn.Dispose();

                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                string oradb = "Data Source=localhost:1521/XE;User Id = students; Password = students; ";
                OracleConnection conn = new OracleConnection(oradb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();

                {
                    cmd.CommandText = "delete from students where rollno ='" + textBox1.Text + "'";

                    cmd.Connection = conn;

                    int rowsUpdated = cmd.ExecuteNonQuery();
                    if (rowsUpdated == 0)
                    {
                        MessageBox.Show("Record not deleted");
                    }
                    else
                    {
                        MessageBox.Show("Deleted successfully");

                        Form1 login = new Form1();
                        login.Show();
                    }
                    conn.Dispose();

                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                string oradb = "Data Source=localhost:1521/XE;User Id = students; Password = students; ";
                OracleConnection conn = new OracleConnection(oradb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();

                {
                    cmd.CommandText = "update students set dept ='" + textBox3.Text + "' where rollno='" + textBox1.Text + "'";

                    cmd.Connection = conn;

                    int rowsUpdated = cmd.ExecuteNonQuery();
                    if (rowsUpdated == 0)
                    {
                        MessageBox.Show("Record not updated");
                    }
                    else
                    {
                        MessageBox.Show("Updated successfully");

                        Form1 login = new Form1();
                        login.Show();
                    }
                    conn.Dispose();

                }

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
        }
    }
}
