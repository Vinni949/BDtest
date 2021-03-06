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
    public partial class PatientMenu : Form
    {
        public PatientMenu()
        {
            InitializeComponent();
        }

        private void PatientMenu_Load(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=sa;database=Hospital;password=SAsa;";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string SQLcom = String.Format("Select p.ID, p.FirstName as 'Фамилия пациента',p.LastName as 'Имя пациента',p.Age as 'Возраст пациента',p.Adress as 'Адрес пациента',d.FirstName "
                +"as 'Фамилия доктора',d.LastName as 'Имя доктора', s.TitleSpecialization as 'Специализация', p.complaints as 'Диагноз' from patient p "
                +"inner join PatientReception pr on p.ID = pr.Patient_ID inner join Doctor d on d.ID = pr.Doctor_ID inner join Specialization s on d.specialization_ID = s.ID");
            SqlDataAdapter adapter = new SqlDataAdapter(SQLcom, conn);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            conn.Close();

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("изменить выбранного пациента?", "Изменение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                string FirstName = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string LastName = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                string Address = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                int Age = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[4].Value);
                string complaints = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                string connStr = "server=localhost;user=sa;database=Hospital;password=SAsa;";
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                string SQLcom = String.Format("update Patient set FirstName = @FirstName, LastName = @LastName, Adress = @Adress,Age=@Age,complaints=@complaints where id=@id");
                SqlCommand command = new SqlCommand(SQLcom, conn);
                SqlParameter[] param = new SqlParameter[]
               {
                    new SqlParameter("@FirstName", FirstName),
                    new SqlParameter("@LastName", LastName),
                    new SqlParameter("@Adress",Address),
                   new SqlParameter("@Age",Age),
                   new SqlParameter("@complaints",complaints),
                    new SqlParameter("@id",id)
               };
                command.ExecuteNonQuery();
                MessageBox.Show(String.Format("."));
                MessageBox.Show(String.Format("Пациент изменен."));
       
                conn.Close();

            }
        }

        private void AddPatient_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Добавить введенного пациента?", "Добавление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string FirstName = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string LastName = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string Address = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                int Age = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[2].Value);
                string complaints= this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
                string connStr = "server=localhost;user=sa;database=Hospital;password=SAsa;";
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                string SQLcom = String.Format("insert into Patient(FirstName, LastName, Adress, Age, complaints) values "
                    +"('{0}','{1}','{2}','{3}','{4}')", FirstName, LastName, Address, Age, complaints);
                SqlCommand command = new SqlCommand(SQLcom, conn);
                command.ExecuteNonQuery();
                MessageBox.Show(String.Format("Добавлен пациент."));
                conn.Close();
            }
        }

        private void Delletedbutton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows.Count > 1)
                {

                    if (MessageBox.Show("Удалить выбранных пациентов?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow r in dataGridView1.SelectedRows)
                        {
                            int id = Convert.ToInt32(r.Cells[0].Value);
                            string connStr = "server=localhost;user=sa;database=Hospital;password=SAsa;";
                            SqlConnection conn = new SqlConnection(connStr);
                            conn.Open();
                            string SQLcom = String.Format("DELETE FROM Patient WHERE ID = {0}", id);
                            SqlCommand command = new SqlCommand(SQLcom, conn);
                            command.ExecuteNonQuery();
                            MessageBox.Show(String.Format(" пациент № " + id + "  удален."));
                            conn.Close();
                        }
                    }
                }

                else
                {
                    if (MessageBox.Show("Удалить выбранного пациента?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        int id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
                        string connStr = "server=localhost;user=sa;database=Hospital;password=SAsa;";
                        SqlConnection conn = new SqlConnection(connStr);
                        conn.Open();
                        string SQLcom = String.Format("DELETE FROM Patient WHERE ID = {0}", id);
                        SqlCommand command = new SqlCommand(SQLcom, conn);
                        command.ExecuteNonQuery();
                        MessageBox.Show(String.Format("Пациент №  " + id + "  удален."));
                        conn.Close();
                    }
                }
            }
            else
                MessageBox.Show("Для удаления необходимо выделить строку.");
        }
    }
}
