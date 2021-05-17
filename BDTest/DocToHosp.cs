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

namespace BDTest
{
    public partial class DocToHosp : Form
    {
        public DocToHosp()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DocToHosp_Load_1(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=sa;database=Hospital;password=SAsa;";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string SQLcom = String.Format("select h.Number,h.Address,d.FirstName,d.LastName,s.TitleSpecialization from Hospital h inner join Doctor d on h.ID"
                + " = d.Hospital_ID inner join Specialization s on d.specialization_ID = s.ID");
            SqlDataAdapter adapter = new SqlDataAdapter(SQLcom, conn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            conn.Close();

        }

        private void DoctorsToHospital_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=sa;database=Hospital;password=SAsa;";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string SQLcom = String.Format("select h.Number,h.Address,d.FirstName,d.LastName,s.TitleSpecialization from Hospital h inner join Doctor d on h.ID"
                + " = d.Hospital_ID inner join Specialization s on d.specialization_ID = s.ID");
            SqlDataAdapter adapter = new SqlDataAdapter(SQLcom, conn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            conn.Close();
        }

        private void Deletedbutton_Click(object sender, EventArgs e)
        {

            string connStr = "server=localhost;user=sa;database=Hospital;password=SAsa;";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string SQLcom = String.Format("select h.Number, Sum(d.Salary) as 'Затраты на сотрудников больницы' from Doctor d inner join Hospital h on d.Hospital_ID = h.ID Group BY h.Number, d.Salary");
            SqlCommand command = new SqlCommand(SQLcom, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(SQLcom, conn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            conn.Close();
        }


        private void QuantityDoctorsToHospitals_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=sa;database=Hospital;password=SAsa;";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string SQLcom = String.Format("select h.Number, Count(h.Number) as 'колличество сотрудников' from Doctor d inner join Hospital h on d.Hospital_ID = h.ID Group BY h.Number");
            SqlCommand command = new SqlCommand(SQLcom, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(SQLcom, conn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            conn.Close();
        }

        private void QuantityPatientToHospitals_Click(object sender, EventArgs e)
        {

            string connStr = "server=localhost;user=sa;database=Hospital;password=SAsa;";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string SQLcom = String.Format("Select h.Number, count(h.Number) as 'Колличество пациэнтов в госпитале' from Patient p inner join PatientReception pr on"
                + " p.ID = pr.Patient_ID inner join Doctor d on pr.Doctor_ID = d.ID inner join Hospital h on d.Hospital_ID = h.ID Group by h.Number");
            SqlCommand command = new SqlCommand(SQLcom, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(SQLcom, conn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            conn.Close();
        }

        Point LastPoint;

        private void DocToHosp_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void DocToHosp_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
    }
}

