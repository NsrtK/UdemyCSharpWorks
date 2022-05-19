namespace udemy_cSharp_1
{
    partial class Form2
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
            this.lbxStudents = new System.Windows.Forms.ListBox();
            this.lblStudents = new System.Windows.Forms.Label();
            this.lblStudentAdd = new System.Windows.Forms.Label();
            this.tbxAddStudent = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxStudents
            // 
            this.lbxStudents.FormattingEnabled = true;
            this.lbxStudents.ItemHeight = 15;
            this.lbxStudents.Location = new System.Drawing.Point(72, 42);
            this.lbxStudents.Name = "lbxStudents";
            this.lbxStudents.Size = new System.Drawing.Size(126, 169);
            this.lbxStudents.TabIndex = 0;
            this.lbxStudents.SelectedIndexChanged += new System.EventHandler(this.lbxStudents_SelectedIndexChanged);
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Location = new System.Drawing.Point(103, 15);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(62, 15);
            this.lblStudents.TabIndex = 1;
            this.lblStudents.Text = "Öğrenciler";
            // 
            // lblStudentAdd
            // 
            this.lblStudentAdd.AutoSize = true;
            this.lblStudentAdd.Location = new System.Drawing.Point(302, 51);
            this.lblStudentAdd.Name = "lblStudentAdd";
            this.lblStudentAdd.Size = new System.Drawing.Size(73, 15);
            this.lblStudentAdd.TabIndex = 1;
            this.lblStudentAdd.Text = "Öğrenci  Adı";
            // 
            // tbxAddStudent
            // 
            this.tbxAddStudent.Location = new System.Drawing.Point(396, 43);
            this.tbxAddStudent.Name = "tbxAddStudent";
            this.tbxAddStudent.Size = new System.Drawing.Size(160, 23);
            this.tbxAddStudent.TabIndex = 2;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(438, 85);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(118, 23);
            this.btnAddStudent.TabIndex = 3;
            this.btnAddStudent.Text = "Ekle";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.Location = new System.Drawing.Point(72, 229);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(126, 23);
            this.btnRemoveStudent.TabIndex = 3;
            this.btnRemoveStudent.Text = "SİL";
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 303);
            this.Controls.Add(this.btnRemoveStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.tbxAddStudent);
            this.Controls.Add(this.lblStudentAdd);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.lbxStudents);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbxStudents;
        private Label lblStudents;
        private Label lblStudentAdd;
        private TextBox tbxAddStudent;
        private Button btnAddStudent;
        private Button btnRemoveStudent;
    }
}