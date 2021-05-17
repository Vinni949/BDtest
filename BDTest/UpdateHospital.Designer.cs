
namespace BDTest
{
    partial class UpdateHospital
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
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hospitalBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet3 = new BDTest.HospitalDataSet3();
            this.hospitalBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Deletedbutton = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.showHospitalType = new System.Windows.Forms.Button();
            this.hospitalTableAdapter1 = new BDTest.HospitalDataSet3TableAdapters.HospitalTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hospitalTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSet5 = new BDTest.HospitalDataSet5();
            this.hospitalTypeTableAdapter = new BDTest.HospitalDataSet5TableAdapters.HospitalTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dataGridView1.DataSource = this.hospitalBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(46, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 192);
            this.dataGridView1.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn9.HeaderText = "ID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Number";
            this.dataGridViewTextBoxColumn10.HeaderText = "Number";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn11.HeaderText = "Address";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "HospitalType_ID";
            this.dataGridViewTextBoxColumn12.HeaderText = "HospitalType_ID";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // hospitalBindingSource4
            // 
            this.hospitalBindingSource4.DataMember = "Hospital";
            this.hospitalBindingSource4.DataSource = this.hospitalDataSet3;
            // 
            // hospitalDataSet3
            // 
            this.hospitalDataSet3.DataSetName = "HospitalDataSet3";
            this.hospitalDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hospitalBindingSource3
            // 
            this.hospitalBindingSource3.DataMember = "Hospital";
            // 
            // hospitalBindingSource2
            // 
            this.hospitalBindingSource2.DataMember = "Hospital";
            // 
            // hospitalBindingSource1
            // 
            this.hospitalBindingSource1.DataMember = "Hospital";
            // 
            // hospitalBindingSource
            // 
            this.hospitalBindingSource.DataMember = "Hospital";
            // 
            // Deletedbutton
            // 
            this.Deletedbutton.Location = new System.Drawing.Point(228, 370);
            this.Deletedbutton.Name = "Deletedbutton";
            this.Deletedbutton.Size = new System.Drawing.Size(303, 23);
            this.Deletedbutton.TabIndex = 18;
            this.Deletedbutton.Text = "Удалить";
            this.Deletedbutton.UseVisualStyleBackColor = true;
            this.Deletedbutton.Click += new System.EventHandler(this.Deletedbutton_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(228, 399);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(303, 23);
            this.Back.TabIndex = 19;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click_1);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(228, 341);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(303, 23);
            this.EditButton.TabIndex = 20;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(228, 312);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(303, 23);
            this.Addbutton.TabIndex = 21;
            this.Addbutton.Text = "Добавить";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // showHospitalType
            // 
            this.showHospitalType.Location = new System.Drawing.Point(228, 283);
            this.showHospitalType.Name = "showHospitalType";
            this.showHospitalType.Size = new System.Drawing.Size(303, 23);
            this.showHospitalType.TabIndex = 22;
            this.showHospitalType.Text = "Показать типы госпиталей";
            this.showHospitalType.UseVisualStyleBackColor = true;
            this.showHospitalType.Click += new System.EventHandler(this.showHospitalType_Click_1);
            // 
            // hospitalTableAdapter1
            // 
            this.hospitalTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Update Hospital Data Base";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.hospitalTypeBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(495, 67);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(293, 192);
            this.dataGridView2.TabIndex = 34;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // hospitalTypeBindingSource
            // 
            this.hospitalTypeBindingSource.DataMember = "HospitalType";
            this.hospitalTypeBindingSource.DataSource = this.hospitalDataSet5;
            // 
            // hospitalDataSet5
            // 
            this.hospitalDataSet5.DataSetName = "HospitalDataSet5";
            this.hospitalDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hospitalTypeTableAdapter
            // 
            this.hospitalTypeTableAdapter.ClearBeforeFill = true;
            // 
            // UpdateHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showHospitalType);
            this.Controls.Add(this.Deletedbutton);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateHospital";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UpdateHospital_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hospitalBindingSource;
        private System.Windows.Forms.BindingSource hospitalBindingSource1;
        private System.Windows.Forms.Button Deletedbutton;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button showHospitalType;
        private System.Windows.Forms.BindingSource hospitalBindingSource2;
        private System.Windows.Forms.BindingSource hospitalBindingSource3;
        private HospitalDataSet3 hospitalDataSet3;
        private System.Windows.Forms.BindingSource hospitalBindingSource4;
        private HospitalDataSet3TableAdapters.HospitalTableAdapter hospitalTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private HospitalDataSet5 hospitalDataSet5;
        private System.Windows.Forms.BindingSource hospitalTypeBindingSource;
        private HospitalDataSet5TableAdapters.HospitalTypeTableAdapter hospitalTypeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}