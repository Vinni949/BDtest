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
    public partial class UpdateDoctors : Form
    {
        public UpdateDoctors()
        {
            InitializeComponent();
        }

        Point LastPoint;

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet6.Specialization". При необходимости она может быть перемещена или удалена.
            this.specializationTableAdapter.Fill(this.hospitalDataSet6.Specialization);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet4.HospitalType". При необходимости она может быть перемещена или удалена.
            this.hospitalTypeTableAdapter.Fill(this.hospitalDataSet4.HospitalType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet1.Doctor". При необходимости она может быть перемещена или удалена.
            this.doctorTableAdapter.Fill(this.hospitalDataSet1.Doctor);

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.doctorTableAdapter.Fill(this.hospitalDataSet1.Doctor);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Добавить нового доктора?", "Добавление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string FirstName = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string LastName = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                int experience = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[3].Value);
                int specialization_ID= Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[4].Value);
                int salary = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[5].Value);
                string connStr = "server=localhost;user=sa;database=Hospital;password=SAsa;";
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                string SQLcom = String.Format("insert into Doctor(FirstName, LastName, experience, specialization_ID,salary) values ('{0}','{1}','{2}','{3}','{4}')", FirstName, LastName, experience, specialization_ID, salary);
                SqlCommand command = new SqlCommand(SQLcom, conn);
                command.ExecuteNonQuery();
                MessageBox.Show(String.Format("Добавлен доктор."));
                this.doctorTableAdapter.Fill(this.hospitalDataSet1.Doctor);
            }
        }

      

        private void EditButton_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("изменить выбранного доктора?", "Изменение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                string FirstName = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string LastName = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                int experience = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[3].Value);
                int specialization_ID = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[4].Value);
                int salary = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[5].Value);
                string connStr = "server=localhost;user=sa;database=Hospital;password=SAsa;";
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                string SQLcom = String.Format("update Doctor set FirstName = @FirstName, LastName = @LastName, experience = @experience,specialization_ID=@specialization_ID,salary=@salary where id=@id");
                SqlCommand command = new SqlCommand(SQLcom, conn);
                SqlParameter[] param = new SqlParameter[]
               {
                    new SqlParameter("@FirstName", FirstName),
                    new SqlParameter("@LastName", LastName),
                    new SqlParameter("@experience",experience),
                   new SqlParameter("@specialization_ID",specialization_ID),
                   new SqlParameter("@salary",salary),
                    new SqlParameter("@id",id)
               };
                command.Parameters.AddRange(param);
                command.ExecuteNonQuery();
                MessageBox.Show(String.Format("Изменен доктор."));
                this.doctorTableAdapter.Fill(this.hospitalDataSet1.Doctor);
                conn.Close();
            }
        }

        private void Deletedbutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows.Count > 1)
                {

                    if (MessageBox.Show("Удалить выбранных докторов?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow r in dataGridView1.SelectedRows)
                        {
                            int id = Convert.ToInt32(r.Cells[0].Value);
                            string connStr = "server=localhost;user=sa;database=Hospital;password=SAsa;";
                            SqlConnection conn = new SqlConnection(connStr);
                            conn.Open();
                            string SQLcom = String.Format("DELETE FROM Doctor WHERE ID = {0}", id);
                            SqlCommand command = new SqlCommand(SQLcom, conn);
                            command.ExecuteNonQuery();
                            MessageBox.Show(String.Format("доктор ID № " + id + "  удален."));
                            this.doctorTableAdapter.Fill(this.hospitalDataSet1.Doctor);

                        }
                    }
                }

                else
                {
                    if (MessageBox.Show("Удалить выбранного доктора?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        int id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
                        string connStr = "server=localhost;user=sa;database=Hospital;password=SAsa;";
                        SqlConnection conn = new SqlConnection(connStr);
                        conn.Open();
                        string SQLcom = String.Format("DELETE FROM Doctor WHERE ID = {0}", id);
                        SqlCommand command = new SqlCommand(SQLcom, conn);
                        command.ExecuteNonQuery();
                        MessageBox.Show(String.Format("доктор №  " + id + "  удален.")); 
                        this.doctorTableAdapter.Fill(this.hospitalDataSet1.Doctor);

                    }
                }
            }
            else
                MessageBox.Show("Для удаления необходимо выделить строку.");
            this.doctorTableAdapter.Fill(this.hospitalDataSet1.Doctor);
        }

        private void UpdateDoctors_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void UpdateDoctors_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
    }
}

