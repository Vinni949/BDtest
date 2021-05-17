using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDTest
{
    public partial class UpdateHospital : Form
    {
        public UpdateHospital()
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

        private void UpdateHospital_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet5.HospitalType". При необходимости она может быть перемещена или удалена.
            this.hospitalTypeTableAdapter.Fill(this.hospitalDataSet5.HospitalType);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet3.Hospital". При необходимости она может быть перемещена или удалена.
            this.hospitalTableAdapter1.Fill(this.hospitalDataSet3.Hospital);
           
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Добавить выбранную больницу?", "Добавление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                string Number = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string Address = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                int HospitalType_ID = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[3].Value);
                string connStr = "server=localhost;user=sa;database=Hospital;password=SAsa;";
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                string SQLcom = String.Format("insert into Hospital(Number,Address,HospitalType_ID) values ('{0}','{1}','{2}')", Number, Address, HospitalType_ID);
                SqlCommand command = new SqlCommand(SQLcom, conn);
                command.ExecuteNonQuery();
                MessageBox.Show(String.Format("Добавлен госпиталь."));
                this.hospitalTableAdapter1.Fill(this.hospitalDataSet3.Hospital);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("изменить выбранную больницу?", "Изменение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                string Number = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string Address = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                int HospitalType_ID = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[3].Value);
                string connStr = "server=localhost;user=sa;database=Hospital;password=SAsa;";
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                string SQLcom = "update Hospital set Number = @Number, Address = @Address, HospitalType_ID = @HospitalType_ID where id=@id";
                SqlCommand command = new SqlCommand(SQLcom, conn);
                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@Number", Number),
                    new SqlParameter("@Address", Address),
                    new SqlParameter("@HospitalType_ID",HospitalType_ID),
                    new SqlParameter("@id",id)
                };
                command.Parameters.AddRange(param);
                command.ExecuteNonQuery();
                MessageBox.Show(String.Format("Изменен госпиталь."));
                this.hospitalTableAdapter1.Fill(this.hospitalDataSet3.Hospital);
            }
        }

        private void Deletedbutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows.Count > 1)
                {

                    if (MessageBox.Show("Удалить выбранные больницы?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow r in dataGridView1.SelectedRows)
                        {
                            int id = Convert.ToInt32(r.Cells[0].Value);
                            string connStr = "server=localhost;user=sa;database=Hospital;password=SAsa;";
                            SqlConnection conn = new SqlConnection(connStr);
                            conn.Open();
                            string SQLcom = String.Format("DELETE FROM Hospital WHERE ID = {0}", id);
                            SqlCommand command = new SqlCommand(SQLcom, conn);
                            command.ExecuteNonQuery();
                            MessageBox.Show(String.Format("Госпиталь ID № " + id + "  удален."));
                            this.hospitalTableAdapter1.Fill(this.hospitalDataSet3.Hospital);

                        }
                    }
                }

                else
                {
                    if (MessageBox.Show("Удалить выбранную больницу?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        int id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
                        string connStr = "server=localhost;user=sa;database=Hospital;password=SAsa;";
                        SqlConnection conn = new SqlConnection(connStr);
                        conn.Open();
                        string SQLcom = String.Format("DELETE FROM Hospital WHERE ID = {0}", id);
                        SqlCommand command = new SqlCommand(SQLcom, conn);
                        command.ExecuteNonQuery();
                        MessageBox.Show(String.Format("Госпиталь №  " + id + "  удален."));
                        this.hospitalTableAdapter1.Fill(this.hospitalDataSet3.Hospital);

                    }
                }
            }
            else
                MessageBox.Show("Для удаления необходимо выделить строку.");
            this.hospitalTableAdapter1.Fill(this.hospitalDataSet3.Hospital);

        }

        private void Back_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showHospitalType_Click_1(object sender, EventArgs e)
        {
            
            string connStr = "server=localhost;user=sa;database=Hospital;password=SAsa;";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string SQLcom = String.Format("select * FROM HospitalType");
            SqlCommand command = new SqlCommand(SQLcom, conn);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string ID = reader.GetFieldValue<int>(0).ToString();
                    string Name = reader.GetFieldValue<string>(1);
                    MessageBox.Show(String.Format(ID+" "+Name));
                }
            }
        }
    }
}
