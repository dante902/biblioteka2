namespace Biblioteka_program
{
    partial class WypoczyczKsiazke
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
            this.cBBooks = new System.Windows.Forms.ComboBox();
            this.btnLend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cBReader = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Wybierz ksiazke:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(47, 207);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Powrot";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cBBooks
            // 
            this.cBBooks.FormattingEnabled = true;
            this.cBBooks.Location = new System.Drawing.Point(12, 144);
            this.cBBooks.Name = "cBBooks";
            this.cBBooks.Size = new System.Drawing.Size(283, 21);
            this.cBBooks.TabIndex = 8;
            // 
            // btnLend
            // 
            this.btnLend.Location = new System.Drawing.Point(185, 207);
            this.btnLend.Name = "btnLend";
            this.btnLend.Size = new System.Drawing.Size(75, 23);
            this.btnLend.TabIndex = 7;
            this.btnLend.Text = "Wypozycz";
            this.btnLend.UseVisualStyleBackColor = true;
            this.btnLend.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Wybierz czytelnika:";
            // 
            // cBReader
            // 
            this.cBReader.FormattingEnabled = true;
            this.cBReader.Location = new System.Drawing.Point(28, 62);
            this.cBReader.Name = "cBReader";
            this.cBReader.Size = new System.Drawing.Size(232, 21);
            this.cBReader.TabIndex = 11;
            // 
            // WypoczyczKsiazke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBReader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cBBooks);
            this.Controls.Add(this.btnLend);
            this.Name = "WypoczyczKsiazke";
            this.Text = "WypoczyczKsiazke";
            this.Load += new System.EventHandler(this.WypoczyczKsiazke_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cBBooks;
        private System.Windows.Forms.Button btnLend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBReader;
    }
}