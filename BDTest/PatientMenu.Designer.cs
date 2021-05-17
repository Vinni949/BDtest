
namespace BDTest
{
    partial class PatientMenu
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
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complaintsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet2 = new BDTest.HospitalDataSet2();
            this.patientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Back = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.hospitalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Delletedbutton1 = new System.Windows.Forms.Button();
            this.AddPatient = new System.Windows.Forms.Button();
            this.patientTableAdapter = new BDTest.HospitalDataSet2TableAdapters.PatientTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.lastNameDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.complaintsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.patientBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 192);
            this.dataGridView1.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn3.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // complaintsDataGridViewTextBoxColumn
            // 
            this.complaintsDataGridViewTextBoxColumn.DataPropertyName = "complaints";
            this.complaintsDataGridViewTextBoxColumn.HeaderText = "complaints";
            this.complaintsDataGridViewTextBoxColumn.Name = "complaintsDataGridViewTextBoxColumn";
            // 
            // patientBindingSource2
            // 
            this.patientBindingSource2.DataMember = "Patient";
            this.patientBindingSource2.DataSource = this.hospitalDataSet2;
            // 
            // hospitalDataSet2
            // 
            this.hospitalDataSet2.DataSetName = "HospitalDataSet2";
            this.hospitalDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientBindingSource1
            // 
            this.patientBindingSource1.DataMember = "Patient";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(254, 398);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(303, 23);
            this.Back.TabIndex = 8;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(254, 340);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(303, 23);
            this.EditButton.TabIndex = 9;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // hospitalBindingSource
            // 
            this.hospitalBindingSource.DataMember = "Hospital";
            // 
            // Delletedbutton1
            // 
            this.Delletedbutton1.Location = new System.Drawing.Point(254, 369);
            this.Delletedbutton1.Name = "Delletedbutton1";
            this.Delletedbutton1.Size = new System.Drawing.Size(303, 23);
            this.Delletedbutton1.TabIndex = 12;
            this.Delletedbutton1.Text = "Удалить";
            this.Delletedbutton1.UseVisualStyleBackColor = true;
            this.Delletedbutton1.Click += new System.EventHandler(this.Delletedbutton1_Click);
            // 
            // AddPatient
            // 
            this.AddPatient.Location = new System.Drawing.Point(254, 311);
            this.AddPatient.Name = "AddPatient";
            this.AddPatient.Size = new System.Drawing.Size(303, 23);
            this.AddPatient.TabIndex = 11;
            this.AddPatient.Text = "Добавить";
            this.AddPatient.UseVisualStyleBackColor = true;
            this.AddPatient.Click += new System.EventHandler(this.AddPatient_Click);
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(280, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Patrinet Data Base";
            // 
            // PatientMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddPatient);
            this.Controls.Add(this.Delletedbutton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PatientMenu";
            this.Load += new System.EventHandler(this.PatientMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.BindingSource hospitalBindingSource;
        private System.Windows.Forms.Button Delletedbutton1;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.BindingSource patientBindingSource1;
        private System.Windows.Forms.Button AddPatient;
        private HospitalDataSet2 hospitalDataSet2;
        private System.Windows.Forms.BindingSource patientBindingSource2;
        private HospitalDataSet2TableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complaintsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}