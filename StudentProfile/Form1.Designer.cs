namespace StudentProfile
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrint = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(110, 41);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(99, 43);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(132, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Enter Laboratory:";
            // 
            // lblPrint
            // 
            this.lblPrint.AutoSize = true;
            this.lblPrint.Location = new System.Drawing.Point(62, 97);
            this.lblPrint.Name = "lblPrint";
            this.lblPrint.Size = new System.Drawing.Size(0, 20);
            this.lblPrint.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(153, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(168, 26);
            this.txtName.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 141);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPrint);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnEnter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrint;
        private System.Windows.Forms.TextBox txtName;
    }
}

