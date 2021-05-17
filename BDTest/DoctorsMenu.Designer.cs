
namespace BDTest
{
    partial class DoctorsMenu
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
            this.Back = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.InformationAboutDoctors = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.LinkAPatientToADoctor = new System.Windows.Forms.Button();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DoctorHospitalLink = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(204, 377);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(303, 23);
            this.Back.TabIndex = 7;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(204, 348);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(303, 23);
            this.EditButton.TabIndex = 8;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // InformationAboutDoctors
            // 
            this.InformationAboutDoctors.Location = new System.Drawing.Point(204, 261);
            this.InformationAboutDoctors.Name = "InformationAboutDoctors";
            this.InformationAboutDoctors.Size = new System.Drawing.Size(303, 23);
            this.InformationAboutDoctors.TabIndex = 9;
            this.InformationAboutDoctors.Text = "Информация по врачам";
            this.InformationAboutDoctors.UseVisualStyleBackColor = true;
            this.InformationAboutDoctors.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(121, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(470, 218);
            this.dataGridView1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(256, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Doctors Data Base";
            // 
            // LinkAPatientToADoctor
            // 
            this.LinkAPatientToADoctor.Location = new System.Drawing.Point(204, 290);
            this.LinkAPatientToADoctor.Name = "LinkAPatientToADoctor";
            this.LinkAPatientToADoctor.Size = new System.Drawing.Size(303, 23);
            this.LinkAPatientToADoctor.TabIndex = 6;
            this.LinkAPatientToADoctor.Text = "Привязать пациента к врачу";
            this.LinkAPatientToADoctor.UseVisualStyleBackColor = true;
            this.LinkAPatientToADoctor.Click += new System.EventHandler(this.LinkAPatientToADoctor_Click);
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            // 
            // DoctorHospitalLink
            // 
            this.DoctorHospitalLink.Location = new System.Drawing.Point(204, 319);
            this.DoctorHospitalLink.Name = "DoctorHospitalLink";
            this.DoctorHospitalLink.Size = new System.Drawing.Size(303, 23);
            this.DoctorHospitalLink.TabIndex = 6;
            this.DoctorHospitalLink.Text = "Связь Врач-больница";
            this.DoctorHospitalLink.UseVisualStyleBackColor = true;
            this.DoctorHospitalLink.Click += new System.EventHandler(this.DoctorHospitalLink_Click);
            // 
            // DoctorsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DoctorHospitalLink);
            this.Controls.Add(this.LinkAPatientToADoctor);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.InformationAboutDoctors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorsMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.DoctorsMenu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button InformationAboutDoctors;
        private System.Windows.Forms.DataGridView dataGridView1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn experienceDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn specializationIDDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn hospitalOfficeIDDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn hospitalIDDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LinkAPatientToADoctor;
        private System.Windows.Forms.Button DoctorHospitalLink;
    }
}