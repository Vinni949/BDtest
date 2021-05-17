
namespace BDTest
{
    partial class UpdateDoctors
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
            this.Deletedbutton = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.hospitalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doctorBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet1 = new BDTest.HospitalDataSet1();
            this.doctorBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.doctorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.doctorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specializationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.doctorTableAdapter = new BDTest.HospitalDataSet1TableAdapters.DoctorTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.hospitalTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet4 = new BDTest.HospitalDataSet4();
            this.hospitalTypeTableAdapter = new BDTest.HospitalDataSet4TableAdapters.HospitalTypeTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialization_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specializationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hospitalOfficeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hospitalIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hospitalDataSet6 = new BDTest.HospitalDataSet6();
            this.specializationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.specializationTableAdapter = new BDTest.HospitalDataSet6TableAdapters.SpecializationTableAdapter();
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleSpecialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Deletedbutton
            // 
            this.Deletedbutton.Location = new System.Drawing.Point(228, 365);
            this.Deletedbutton.Name = "Deletedbutton";
            this.Deletedbutton.Size = new System.Drawing.Size(303, 23);
            this.Deletedbutton.TabIndex = 25;
            this.Deletedbutton.Text = "Удалить";
            this.Deletedbutton.UseVisualStyleBackColor = true;
            this.Deletedbutton.Click += new System.EventHandler(this.Deletedbutton_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(228, 394);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(303, 23);
            this.Back.TabIndex = 26;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(228, 336);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(303, 23);
            this.EditButton.TabIndex = 27;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(228, 307);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(303, 23);
            this.Addbutton.TabIndex = 28;
            this.Addbutton.Text = "Добавить";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // hospitalBindingSource1
            // 
            this.hospitalBindingSource1.DataMember = "Hospital";
            // 
            // hospitalBindingSource
            // 
            this.hospitalBindingSource.DataMember = "Hospital";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FirstName,
            this.LastName,
            this.experience,
            this.specialization_ID,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.experienceDataGridViewTextBoxColumn,
            this.specializationIDDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.categoryIDDataGridViewTextBoxColumn,
            this.hospitalOfficeIDDataGridViewTextBoxColumn,
            this.hospitalIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.doctorBindingSource5;
            this.dataGridView1.Location = new System.Drawing.Point(75, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 192);
            this.dataGridView1.TabIndex = 24;
            // 
            // doctorBindingSource5
            // 
            this.doctorBindingSource5.DataMember = "Doctor";
            this.doctorBindingSource5.DataSource = this.hospitalDataSet1;
            // 
            // hospitalDataSet1
            // 
            this.hospitalDataSet1.DataSetName = "HospitalDataSet1";
            this.hospitalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorBindingSource4
            // 
            this.doctorBindingSource4.DataMember = "Doctor";
            // 
            // hospitalBindingSource2
            // 
            this.hospitalBindingSource2.DataMember = "Hospital";
            // 
            // doctorBindingSource2
            // 
            this.doctorBindingSource2.DataMember = "Doctor";
            // 
            // doctorBindingSource1
            // 
            this.doctorBindingSource1.DataMember = "Doctor";
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            // 
            // specializationBindingSource
            // 
            this.specializationBindingSource.DataMember = "Specialization";
            // 
            // doctorBindingSource3
            // 
            this.doctorBindingSource3.DataMember = "Doctor";
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.TitleSpecialization});
            this.dataGridView2.DataSource = this.specializationBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(524, 75);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 30;
            // 
            // hospitalTypeBindingSource
            // 
            this.hospitalTypeBindingSource.DataMember = "HospitalType";
            this.hospitalTypeBindingSource.DataSource = this.hospitalDataSet4;
            // 
            // hospitalDataSet4
            // 
            this.hospitalDataSet4.DataSetName = "HospitalDataSet4";
            this.hospitalDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hospitalTypeTableAdapter
            // 
            this.hospitalTypeTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(257, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Update Hospital Data Base";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            // 
            // experience
            // 
            this.experience.DataPropertyName = "experience";
            this.experience.HeaderText = "experience";
            this.experience.Name = "experience";
            // 
            // specialization_ID
            // 
            this.specialization_ID.DataPropertyName = "specialization_ID";
            this.specialization_ID.HeaderText = "specialization_ID";
            this.specialization_ID.Name = "specialization_ID";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // experienceDataGridViewTextBoxColumn
            // 
            this.experienceDataGridViewTextBoxColumn.DataPropertyName = "experience";
            this.experienceDataGridViewTextBoxColumn.HeaderText = "experience";
            this.experienceDataGridViewTextBoxColumn.Name = "experienceDataGridViewTextBoxColumn";
            // 
            // specializationIDDataGridViewTextBoxColumn
            // 
            this.specializationIDDataGridViewTextBoxColumn.DataPropertyName = "specialization_ID";
            this.specializationIDDataGridViewTextBoxColumn.HeaderText = "specialization_ID";
            this.specializationIDDataGridViewTextBoxColumn.Name = "specializationIDDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "category_ID";
            this.categoryIDDataGridViewTextBoxColumn.HeaderText = "category_ID";
            this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            // 
            // hospitalOfficeIDDataGridViewTextBoxColumn
            // 
            this.hospitalOfficeIDDataGridViewTextBoxColumn.DataPropertyName = "HospitalOffice_ID";
            this.hospitalOfficeIDDataGridViewTextBoxColumn.HeaderText = "HospitalOffice_ID";
            this.hospitalOfficeIDDataGridViewTextBoxColumn.Name = "hospitalOfficeIDDataGridViewTextBoxColumn";
            // 
            // hospitalIDDataGridViewTextBoxColumn
            // 
            this.hospitalIDDataGridViewTextBoxColumn.DataPropertyName = "Hospital_ID";
            this.hospitalIDDataGridViewTextBoxColumn.HeaderText = "Hospital_ID";
            this.hospitalIDDataGridViewTextBoxColumn.Name = "hospitalIDDataGridViewTextBoxColumn";
            // 
            // hospitalDataSet6
            // 
            this.hospitalDataSet6.DataSetName = "HospitalDataSet6";
            this.hospitalDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specializationBindingSource1
            // 
            this.specializationBindingSource1.DataMember = "Specialization";
            this.specializationBindingSource1.DataSource = this.hospitalDataSet6;
            // 
            // specializationTableAdapter
            // 
            this.specializationTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            this.iDDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // TitleSpecialization
            // 
            this.TitleSpecialization.DataPropertyName = "TitleSpecialization";
            this.TitleSpecialization.HeaderText = "TitleSpecialization";
            this.TitleSpecialization.Name = "TitleSpecialization";
            // 
            // UpdateDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.Deletedbutton);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateDoctors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpdateDoctors_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpdateDoctors_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Deletedbutton;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.BindingSource hospitalBindingSource1;
        private System.Windows.Forms.BindingSource hospitalBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.BindingSource doctorBindingSource1;
        private System.Windows.Forms.BindingSource doctorBindingSource2;
        private System.Windows.Forms.BindingSource doctorBindingSource3;
        private System.Windows.Forms.BindingSource specializationBindingSource;
        private System.Windows.Forms.BindingSource hospitalBindingSource2;
        private System.Windows.Forms.BindingSource doctorBindingSource4;
        private HospitalDataSet1 hospitalDataSet1;
        private System.Windows.Forms.BindingSource doctorBindingSource5;
        private HospitalDataSet1TableAdapters.DoctorTableAdapter doctorTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private HospitalDataSet4 hospitalDataSet4;
        private System.Windows.Forms.BindingSource hospitalTypeBindingSource;
        private HospitalDataSet4TableAdapters.HospitalTypeTableAdapter hospitalTypeTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn experience;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialization_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn experienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specializationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospitalOfficeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospitalIDDataGridViewTextBoxColumn;
        private HospitalDataSet6 hospitalDataSet6;
        private System.Windows.Forms.BindingSource specializationBindingSource1;
        private HospitalDataSet6TableAdapters.SpecializationTableAdapter specializationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleSpecialization;
    }
}