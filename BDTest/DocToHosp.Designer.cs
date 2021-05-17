
namespace BDTest
{
    partial class DocToHosp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.QuantityDoctorsToHospitals = new System.Windows.Forms.Button();
            this.QuantityPatientToHospitals = new System.Windows.Forms.Button();
            this.ExpensesToDoctors = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.DoctorsToHospital = new System.Windows.Forms.Button();
            this.hospitalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(153, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(494, 192);
            this.dataGridView1.TabIndex = 14;
            // 
            // QuantityDoctorsToHospitals
            // 
            this.QuantityDoctorsToHospitals.Location = new System.Drawing.Point(254, 311);
            this.QuantityDoctorsToHospitals.Name = "QuantityDoctorsToHospitals";
            this.QuantityDoctorsToHospitals.Size = new System.Drawing.Size(303, 23);
            this.QuantityDoctorsToHospitals.TabIndex = 7;
            this.QuantityDoctorsToHospitals.Text = "Колличество сотрудников по госпеталям";
            this.QuantityDoctorsToHospitals.UseVisualStyleBackColor = true;
            this.QuantityDoctorsToHospitals.Click += new System.EventHandler(this.QuantityDoctorsToHospitals_Click);
            // 
            // QuantityPatientToHospitals
            // 
            this.QuantityPatientToHospitals.Location = new System.Drawing.Point(254, 340);
            this.QuantityPatientToHospitals.Name = "QuantityPatientToHospitals";
            this.QuantityPatientToHospitals.Size = new System.Drawing.Size(303, 23);
            this.QuantityPatientToHospitals.TabIndex = 8;
            this.QuantityPatientToHospitals.Text = "Колличество пациентов по госпиталям";
            this.QuantityPatientToHospitals.UseVisualStyleBackColor = true;
            this.QuantityPatientToHospitals.Click += new System.EventHandler(this.QuantityPatientToHospitals_Click);
            // 
            // ExpensesToDoctors
            // 
            this.ExpensesToDoctors.Location = new System.Drawing.Point(254, 282);
            this.ExpensesToDoctors.Name = "ExpensesToDoctors";
            this.ExpensesToDoctors.Size = new System.Drawing.Size(303, 23);
            this.ExpensesToDoctors.TabIndex = 9;
            this.ExpensesToDoctors.Text = "Затраты госпиталей на сотрудников";
            this.ExpensesToDoctors.UseVisualStyleBackColor = true;
            this.ExpensesToDoctors.Click += new System.EventHandler(this.Deletedbutton_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(254, 369);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(303, 23);
            this.Back.TabIndex = 10;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // DoctorsToHospital
            // 
            this.DoctorsToHospital.Location = new System.Drawing.Point(254, 253);
            this.DoctorsToHospital.Name = "DoctorsToHospital";
            this.DoctorsToHospital.Size = new System.Drawing.Size(303, 23);
            this.DoctorsToHospital.TabIndex = 12;
            this.DoctorsToHospital.Text = "Прикрепленные доктора";
            this.DoctorsToHospital.UseVisualStyleBackColor = true;
            this.DoctorsToHospital.Click += new System.EventHandler(this.DoctorsToHospital_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(224, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Mansagment Hospital Data Base";
            // 
            // DocToHosp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.QuantityDoctorsToHospitals);
            this.Controls.Add(this.QuantityPatientToHospitals);
            this.Controls.Add(this.ExpensesToDoctors);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.DoctorsToHospital);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DocToHosp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DocToHosp_Load_1);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DocToHosp_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DocToHosp_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button QuantityDoctorsToHospitals;
        private System.Windows.Forms.Button QuantityPatientToHospitals;
        private System.Windows.Forms.Button ExpensesToDoctors;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button DoctorsToHospital;
        private System.Windows.Forms.BindingSource hospitalDataSetBindingSource;
        private System.Windows.Forms.Label label1;
    }
}