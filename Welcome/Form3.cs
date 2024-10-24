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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Welcome
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string oradb = "Data Source=localhost:1521/XE;User Id = students; Password = students; ";
                OracleConnection conn = new OracleConnection(oradb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                {
                    cmd.CommandText = "insert into course (rollno , dept, course_name) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
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

        private void button6_Click(object sender, EventArgs e)
        {

            Form4 frm4 = new Form4();
            frm4.Show();
        }
    }
}
