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
    public partial class LinkPatientToDoctor : Form
    {
        public LinkPatientToDoctor()
        {
            InitializeComponent();
        }
        Point LastPoint;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void LinkPatientToDoctor_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet2.Patient". При необходимости она может быть перемещена или удалена.
            this.patientTableAdapter.Fill(this.hospitalDataSet2.Patient);

            string connStr = "server=localhost;user=sa;database=Hospital;password=SAsa;";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string SQLcom = String.Format("select d.ID,d.FirstName,d.LastName,d.experience,s.TitleSpecialization from doctor d inner join Specialization s on d.specialization_ID = s.ID");
            SqlCommand command = new SqlCommand(SQLcom, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(SQLcom, conn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            conn.Close();
        }

        private void Link_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Прикрепить выбранного пациента к доктору?", "Изменение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int Doctor_ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                int Patient_ID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                string connStr = "server=localhost;user=sa;database=Hospital;password=SAsa;";
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                string SQLcom = String.Format("insert into PatientReception (Patient_ID, Doctor_ID) values ('{0}','{1}')", Doctor_ID, Patient_ID);
                SqlCommand command = new SqlCommand(SQLcom, conn);
                command.ExecuteNonQuery();
                MessageBox.Show(String.Format("Пациент прикреплен к доктору."));
                this.patientTableAdapter.Fill(this.hospitalDataSet2.Patient);
                conn.Close();
            }
        }
    }
}
