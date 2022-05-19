namespace udemy_csharp_2
{
    partial class Form1
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
            this.lbxCars = new System.Windows.Forms.ListBox();
            this.dgrwCars = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgrwCars)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxCars
            // 
            this.lbxCars.FormattingEnabled = true;
            this.lbxCars.Location = new System.Drawing.Point(66, 40);
            this.lbxCars.Name = "lbxCars";
            this.lbxCars.Size = new System.Drawing.Size(120, 186);
            this.lbxCars.TabIndex = 0;
            // 
            // dgrwCars
            // 
            this.dgrwCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrwCars.Location = new System.Drawing.Point(233, 40);
            this.dgrwCars.Name = "dgrwCars";
            this.dgrwCars.Size = new System.Drawing.Size(431, 186);
            this.dgrwCars.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgrwCars);
            this.Controls.Add(this.lbxCars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrwCars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCars;
        private System.Windows.Forms.DataGridView dgrwCars;
    }
}

