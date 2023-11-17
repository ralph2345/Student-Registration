namespace FrmStudentRecord
{
    partial class StudentRecord
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
            this.registerBtn = new System.Windows.Forms.Button();
            this.findBtn = new System.Windows.Forms.Button();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBoxShowText = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Record";
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.Location = new System.Drawing.Point(412, 101);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(86, 44);
            this.registerBtn.TabIndex = 2;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // findBtn
            // 
            this.findBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.findBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findBtn.Location = new System.Drawing.Point(412, 167);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(86, 42);
            this.findBtn.TabIndex = 3;
            this.findBtn.Text = "Find";
            this.findBtn.UseVisualStyleBackColor = false;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // uploadBtn
            // 
            this.uploadBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.uploadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadBtn.Location = new System.Drawing.Point(412, 231);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(86, 39);
            this.uploadBtn.TabIndex = 4;
            this.uploadBtn.Text = "Upload";
            this.uploadBtn.UseVisualStyleBackColor = false;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBoxShowText
            // 
            this.listBoxShowText.FormattingEnabled = true;
            this.listBoxShowText.Location = new System.Drawing.Point(21, 89);
            this.listBoxShowText.Name = "listBoxShowText";
            this.listBoxShowText.Size = new System.Drawing.Size(354, 225);
            this.listBoxShowText.TabIndex = 5;
            // 
            // StudentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(520, 339);
            this.Controls.Add(this.listBoxShowText);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.label1);
            this.Name = "StudentRecord";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBoxShowText;
    }
}

