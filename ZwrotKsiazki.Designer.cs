namespace Biblioteka_program
{
    partial class ZwrotKsiazki
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
            this.btnBack = new System.Windows.Forms.Button();
            this.cBRents = new System.Windows.Forms.ComboBox();
            this.btnLend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Wybierz wypozyczenie:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(65, 127);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Powrot";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cBRents
            // 
            this.cBRents.FormattingEnabled = true;
            this.cBRents.Location = new System.Drawing.Point(30, 64);
            this.cBRents.Name = "cBRents";
            this.cBRents.Size = new System.Drawing.Size(356, 21);
            this.cBRents.TabIndex = 12;
            // 
            // btnLend
            // 
            this.btnLend.Location = new System.Drawing.Point(203, 127);
            this.btnLend.Name = "btnLend";
            this.btnLend.Size = new System.Drawing.Size(75, 23);
            this.btnLend.TabIndex = 11;
            this.btnLend.Text = "Zwróc";
            this.btnLend.UseVisualStyleBackColor = true;
            this.btnLend.Click += new System.EventHandler(this.btnLend_Click);
            // 
            // ZwrotKsiazki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cBRents);
            this.Controls.Add(this.btnLend);
            this.Name = "ZwrotKsiazki";
            this.Text = "ZwrotKsiazki";
            this.Load += new System.EventHandler(this.ZwrotKsiazki_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cBRents;
        private System.Windows.Forms.Button btnLend;
    }
}