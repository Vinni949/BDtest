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
using Microsoft.VisualBasic;

namespace BDTest
{
    public partial class HospitalMenu : Form
    {
        public HospitalMenu()
        {
            InitializeComponent();
        }

        Point LastPoint;

        public void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=sa;database=Hospital;password=SAsa;";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string SQLcom = String.Format("select Number,Address,Name from Hospital h inner join HospitalType ht on h.HospitalType_ID=ht.ID");
            SqlCommand command = new SqlCommand(SQLcom, conn);
            command.ExecuteNonQuery();

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }

            reader.Close();

            conn.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        void otherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
       
        private void EditButton_Click(object sender, EventArgs e)
        {
            UpdateHospital otherForm = new UpdateHospital();
            otherForm.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
            this.Hide();
            otherForm.Show();
        }

        private void DoctorsToHospital_Click(object sender, EventArgs e)
        {
            DocToHosp otherForm = new DocToHosp();
            otherForm.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
            this.Hide();
            otherForm.Show();
        }
    }
}
