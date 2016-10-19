namespace Assignment_2
{
    partial class frmAssignment2
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
            this.lblEnterMarks = new System.Windows.Forms.Label();
            this.lblMark1 = new System.Windows.Forms.Label();
            this.lblMark2 = new System.Windows.Forms.Label();
            this.lblMark3 = new System.Windows.Forms.Label();
            this.txtMark1 = new System.Windows.Forms.TextBox();
            this.txtMark2 = new System.Windows.Forms.TextBox();
            this.txtMark3 = new System.Windows.Forms.TextBox();
            this.lblMark4 = new System.Windows.Forms.Label();
            this.txtMark4 = new System.Windows.Forms.TextBox();
            this.lblMark5 = new System.Windows.Forms.Label();
            this.txtMark5 = new System.Windows.Forms.TextBox();
            this.btnAverage = new System.Windows.Forms.Button();
            this.lblAverage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnterMarks
            // 
            this.lblEnterMarks.AutoSize = true;
            this.lblEnterMarks.Location = new System.Drawing.Point(13, 13);
            this.lblEnterMarks.Name = "lblEnterMarks";
            this.lblEnterMarks.Size = new System.Drawing.Size(86, 13);
            this.lblEnterMarks.TabIndex = 0;
            this.lblEnterMarks.Text = "Enter your marks";
            // 
            // lblMark1
            // 
            this.lblMark1.AutoSize = true;
            this.lblMark1.Location = new System.Drawing.Point(262, 13);
            this.lblMark1.Name = "lblMark1";
            this.lblMark1.Size = new System.Drawing.Size(40, 13);
            this.lblMark1.TabIndex = 1;
            this.lblMark1.Text = "Mark 1";
            // 
            // lblMark2
            // 
            this.lblMark2.AutoSize = true;
            this.lblMark2.Location = new System.Drawing.Point(262, 49);
            this.lblMark2.Name = "lblMark2";
            this.lblMark2.Size = new System.Drawing.Size(40, 13);
            this.lblMark2.TabIndex = 2;
            this.lblMark2.Text = "Mark 2";
            // 
            // lblMark3
            // 
            this.lblMark3.AutoSize = true;
            this.lblMark3.Location = new System.Drawing.Point(262, 86);
            this.lblMark3.Name = "lblMark3";
            this.lblMark3.Size = new System.Drawing.Size(40, 13);
            this.lblMark3.TabIndex = 3;
            this.lblMark3.Text = "Mark 3";
            // 
            // txtMark1
            // 
            this.txtMark1.Location = new System.Drawing.Point(353, 10);
            this.txtMark1.Name = "txtMark1";
            this.txtMark1.Size = new System.Drawing.Size(100, 20);
            this.txtMark1.TabIndex = 4;
            // 
            // txtMark2
            // 
            this.txtMark2.Location = new System.Drawing.Point(353, 46);
            this.txtMark2.Name = "txtMark2";
            this.txtMark2.Size = new System.Drawing.Size(100, 20);
            this.txtMark2.TabIndex = 5;
            // 
            // txtMark3
            // 
            this.txtMark3.Location = new System.Drawing.Point(353, 83);
            this.txtMark3.Name = "txtMark3";
            this.txtMark3.Size = new System.Drawing.Size(100, 20);
            this.txtMark3.TabIndex = 6;
            // 
            // lblMark4
            // 
            this.lblMark4.AutoSize = true;
            this.lblMark4.Location = new System.Drawing.Point(262, 125);
            this.lblMark4.Name = "lblMark4";
            this.lblMark4.Size = new System.Drawing.Size(40, 13);
            this.lblMark4.TabIndex = 7;
            this.lblMark4.Text = "Mark 4";
            // 
            // txtMark4
            // 
            this.txtMark4.Location = new System.Drawing.Point(353, 122);
            this.txtMark4.Name = "txtMark4";
            this.txtMark4.Size = new System.Drawing.Size(100, 20);
            this.txtMark4.TabIndex = 8;
            // 
            // lblMark5
            // 
            this.lblMark5.AutoSize = true;
            this.lblMark5.Location = new System.Drawing.Point(262, 167);
            this.lblMark5.Name = "lblMark5";
            this.lblMark5.Size = new System.Drawing.Size(40, 13);
            this.lblMark5.TabIndex = 9;
            this.lblMark5.Text = "Mark 5";
            // 
            // txtMark5
            // 
            this.txtMark5.Location = new System.Drawing.Point(353, 164);
            this.txtMark5.Name = "txtMark5";
            this.txtMark5.Size = new System.Drawing.Size(100, 20);
            this.txtMark5.TabIndex = 10;
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(265, 212);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(188, 23);
            this.btnAverage.TabIndex = 11;
            this.btnAverage.Text = "press here to calculate average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.Location = new System.Drawing.Point(265, 264);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(188, 146);
            this.lblAverage.TabIndex = 12;
            // 
            // frmAssignment2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 538);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.txtMark5);
            this.Controls.Add(this.lblMark5);
            this.Controls.Add(this.txtMark4);
            this.Controls.Add(this.lblMark4);
            this.Controls.Add(this.txtMark3);
            this.Controls.Add(this.txtMark2);
            this.Controls.Add(this.txtMark1);
            this.Controls.Add(this.lblMark3);
            this.Controls.Add(this.lblMark2);
            this.Controls.Add(this.lblMark1);
            this.Controls.Add(this.lblEnterMarks);
            this.Name = "frmAssignment2";
            this.Text = "Assignment 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterMarks;
        private System.Windows.Forms.Label lblMark1;
        private System.Windows.Forms.Label lblMark2;
        private System.Windows.Forms.Label lblMark3;
        private System.Windows.Forms.TextBox txtMark1;
        private System.Windows.Forms.TextBox txtMark2;
        private System.Windows.Forms.TextBox txtMark3;
        private System.Windows.Forms.Label lblMark4;
        private System.Windows.Forms.TextBox txtMark4;
        private System.Windows.Forms.Label lblMark5;
        private System.Windows.Forms.TextBox txtMark5;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Label lblAverage;
    }
}

