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
    public partial class DoctorsMenu : Form
    {
        public DoctorsMenu()
        {
            InitializeComponent();
        }
        Point LastPoint;

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);

        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DoctorsMenu_Load(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=sa;database=Hospital;password=SAsa;";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string SQLcom = String.Format("select d.LastName,d.FirstName,d.experience,c.TitleСategory,s.TitleSpecialization, d.Salary from "
            + "Category c inner join Doctor d on c.ID = d.category_ID inner join Specialization s on d.specialization_ID = s.ID");
            SqlCommand command = new SqlCommand(SQLcom, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(SQLcom, conn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            conn.Close();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=sa;database=Hospital;password=SAsa;";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string SQLcom = String.Format("select d.LastName,d.FirstName,d.experience,c.TitleСategory,s.TitleSpecialization, d.Salary from "
            + "Category c inner join Doctor d on c.ID = d.category_ID inner join Specialization s on d.specialization_ID = s.ID");
            SqlCommand command = new SqlCommand(SQLcom, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(SQLcom, conn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            conn.Close();
        }
        void otherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            UpdateDoctors otherForm = new UpdateDoctors();
            otherForm.FormClosed += new FormClosedEventHandler(otherForm_FormClosed);
            this.Hide();
            otherForm.Show();
        }

        private void DoctorHospitalLink_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=sa;database=Hospital;password=SAsa;";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string SQLcom = String.Format("select d.FirstName,d.LastName,d.experience,s.TitleSpecialization,h.Number from Hospital h inner join Doctor d"
                + " on d.Hospital_ID = h.ID inner join Specialization s on d.specialization_ID = s.ID");
            SqlCommand command = new SqlCommand(SQLcom, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(SQLcom, conn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            conn.Close();
        }

        private void LinkAPatientToADoctor_Click(object sender, EventArgs e)
        {
            LinkPatientToDoctor otherForm = new LinkPatientToDoctor();
            otherForm.Show();
        }
    }
}
