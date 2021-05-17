
namespace BDTest
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.HospitalsButton = new System.Windows.Forms.Button();
            this.DoctorsButton = new System.Windows.Forms.Button();
            this.PatientButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HospitalsButton
            // 
            this.HospitalsButton.Location = new System.Drawing.Point(98, 61);
            this.HospitalsButton.Name = "HospitalsButton";
            this.HospitalsButton.Size = new System.Drawing.Size(137, 23);
            this.HospitalsButton.TabIndex = 1;
            this.HospitalsButton.Text = "Hospitals";
            this.HospitalsButton.UseVisualStyleBackColor = true;
            this.HospitalsButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DoctorsButton
            // 
            this.DoctorsButton.Location = new System.Drawing.Point(98, 105);
            this.DoctorsButton.Name = "DoctorsButton";
            this.DoctorsButton.Size = new System.Drawing.Size(137, 23);
            this.DoctorsButton.TabIndex = 2;
            this.DoctorsButton.Text = "Doctors";
            this.DoctorsButton.UseVisualStyleBackColor = true;
            this.DoctorsButton.Click += new System.EventHandler(this.DoctorsButton_Click);
            // 
            // PatientButton
            // 
            this.PatientButton.Location = new System.Drawing.Point(98, 152);
            this.PatientButton.Name = "PatientButton";
            this.PatientButton.Size = new System.Drawing.Size(137, 23);
            this.PatientButton.TabIndex = 3;
            this.PatientButton.Text = "Patient";
            this.PatientButton.UseVisualStyleBackColor = true;
            this.PatientButton.Click += new System.EventHandler(this.PatientButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(98, 200);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(137, 23);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Data Base Test";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(328, 235);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PatientButton);
            this.Controls.Add(this.DoctorsButton);
            this.Controls.Add(this.HospitalsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown_1);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button HospitalsButton;
        private System.Windows.Forms.Button DoctorsButton;
        private System.Windows.Forms.Button PatientButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
    }
}

