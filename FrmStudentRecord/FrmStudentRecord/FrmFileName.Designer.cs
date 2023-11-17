namespace FrmStudentRecord
{
    partial class FrmFileName
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.okyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter File Name";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(95, 93);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(188, 20);
            this.txtFileName.TabIndex = 1;
            // 
            // okyBtn
            // 
            this.okyBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.okyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okyBtn.Location = new System.Drawing.Point(149, 140);
            this.okyBtn.Name = "okyBtn";
            this.okyBtn.Size = new System.Drawing.Size(95, 36);
            this.okyBtn.TabIndex = 2;
            this.okyBtn.Text = "Okay";
            this.okyBtn.UseVisualStyleBackColor = false;
            this.okyBtn.Click += new System.EventHandler(this.okyBtn_Click);
            // 
            // FrmFileName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(410, 213);
            this.Controls.Add(this.okyBtn);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label1);
            this.Name = "FrmFileName";
            this.Text = "FrmFileName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button okyBtn;
    }
}