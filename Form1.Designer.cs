namespace Biblioteka_program
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zwrotKsiazkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakonczToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNowegoCzytelnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ążkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usunCzytelnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usunKsiazkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyswietlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyswietlCzytelnikowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyswietlKsiazkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyswietlWypozyczeniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przegladajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przegladajUzytkownikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przegladajKsiazkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.dodajToolStripMenuItem,
            this.usunToolStripMenuItem,
            this.wyswietlToolStripMenuItem,
            this.przegladajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(358, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cosToolStripMenuItem,
            this.zwrotKsiazkiToolStripMenuItem,
            this.zakonczToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // cosToolStripMenuItem
            // 
            this.cosToolStripMenuItem.Name = "cosToolStripMenuItem";
            this.cosToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.cosToolStripMenuItem.Text = "Wypozycz Ksiazke Czytelnikowi";
            this.cosToolStripMenuItem.Click += new System.EventHandler(this.cosToolStripMenuItem_Click);
            // 
            // zwrotKsiazkiToolStripMenuItem
            // 
            this.zwrotKsiazkiToolStripMenuItem.Name = "zwrotKsiazkiToolStripMenuItem";
            this.zwrotKsiazkiToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.zwrotKsiazkiToolStripMenuItem.Text = "Zwrot ksiazki";
            this.zwrotKsiazkiToolStripMenuItem.Click += new System.EventHandler(this.zwrotKsiazkiToolStripMenuItem_Click);
            // 
            // zakonczToolStripMenuItem
            // 
            this.zakonczToolStripMenuItem.Name = "zakonczToolStripMenuItem";
            this.zakonczToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.zakonczToolStripMenuItem.Text = "Zakoncz";
            this.zakonczToolStripMenuItem.Click += new System.EventHandler(this.zakonczToolStripMenuItem_Click);
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNowegoCzytelnikaToolStripMenuItem,
            this.ążkeToolStripMenuItem});
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            // 
            // dodajNowegoCzytelnikaToolStripMenuItem
            // 
            this.dodajNowegoCzytelnikaToolStripMenuItem.Name = "dodajNowegoCzytelnikaToolStripMenuItem";
            this.dodajNowegoCzytelnikaToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.dodajNowegoCzytelnikaToolStripMenuItem.Text = "Dodaj nowego czytelnika";
            this.dodajNowegoCzytelnikaToolStripMenuItem.Click += new System.EventHandler(this.dodajNowegoCzytelnikaToolStripMenuItem_Click);
            // 
            // ążkeToolStripMenuItem
            // 
            this.ążkeToolStripMenuItem.Name = "ążkeToolStripMenuItem";
            this.ążkeToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.ążkeToolStripMenuItem.Text = "Dodaj ksiażkę";
            this.ążkeToolStripMenuItem.Click += new System.EventHandler(this.ążkeToolStripMenuItem_Click);
            // 
            // usunToolStripMenuItem
            // 
            this.usunToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usunCzytelnikaToolStripMenuItem,
            this.usunKsiazkeToolStripMenuItem});
            this.usunToolStripMenuItem.Name = "usunToolStripMenuItem";
            this.usunToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.usunToolStripMenuItem.Text = "Usun";
            // 
            // usunCzytelnikaToolStripMenuItem
            // 
            this.usunCzytelnikaToolStripMenuItem.Name = "usunCzytelnikaToolStripMenuItem";
            this.usunCzytelnikaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.usunCzytelnikaToolStripMenuItem.Text = "Usun czytelnika";
            this.usunCzytelnikaToolStripMenuItem.Click += new System.EventHandler(this.usunCzytelnikaToolStripMenuItem_Click);
            // 
            // usunKsiazkeToolStripMenuItem
            // 
            this.usunKsiazkeToolStripMenuItem.Name = "usunKsiazkeToolStripMenuItem";
            this.usunKsiazkeToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.usunKsiazkeToolStripMenuItem.Text = "Usun ksiazke";
            this.usunKsiazkeToolStripMenuItem.Click += new System.EventHandler(this.usunKsiazkeToolStripMenuItem_Click);
            // 
            // wyswietlToolStripMenuItem
            // 
            this.wyswietlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wyswietlCzytelnikowToolStripMenuItem,
            this.wyswietlKsiazkiToolStripMenuItem,
            this.wyswietlWypozyczeniaToolStripMenuItem});
            this.wyswietlToolStripMenuItem.Name = "wyswietlToolStripMenuItem";
            this.wyswietlToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.wyswietlToolStripMenuItem.Text = "Wyswietl";
            // 
            // wyswietlCzytelnikowToolStripMenuItem
            // 
            this.wyswietlCzytelnikowToolStripMenuItem.Name = "wyswietlCzytelnikowToolStripMenuItem";
            this.wyswietlCzytelnikowToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.wyswietlCzytelnikowToolStripMenuItem.Text = "Wyswietl czytelnikow";
            // 
            // wyswietlKsiazkiToolStripMenuItem
            // 
            this.wyswietlKsiazkiToolStripMenuItem.Name = "wyswietlKsiazkiToolStripMenuItem";
            this.wyswietlKsiazkiToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.wyswietlKsiazkiToolStripMenuItem.Text = "Wyswietl ksiazki";
            // 
            // wyswietlWypozyczeniaToolStripMenuItem
            // 
            this.wyswietlWypozyczeniaToolStripMenuItem.Name = "wyswietlWypozyczeniaToolStripMenuItem";
            this.wyswietlWypozyczeniaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.wyswietlWypozyczeniaToolStripMenuItem.Text = "Wyswietl wypozyczenia";
            // 
            // przegladajToolStripMenuItem
            // 
            this.przegladajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.przegladajUzytkownikaToolStripMenuItem,
            this.przegladajKsiazkiToolStripMenuItem});
            this.przegladajToolStripMenuItem.Name = "przegladajToolStripMenuItem";
            this.przegladajToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.przegladajToolStripMenuItem.Text = "Przegladaj";
            // 
            // przegladajUzytkownikaToolStripMenuItem
            // 
            this.przegladajUzytkownikaToolStripMenuItem.Name = "przegladajUzytkownikaToolStripMenuItem";
            this.przegladajUzytkownikaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.przegladajUzytkownikaToolStripMenuItem.Text = "Przegladaj uzytkownika";
            // 
            // przegladajKsiazkiToolStripMenuItem
            // 
            this.przegladajKsiazkiToolStripMenuItem.Name = "przegladajKsiazkiToolStripMenuItem";
            this.przegladajKsiazkiToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.przegladajKsiazkiToolStripMenuItem.Text = "Przegladaj ksiazki";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 109);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Biblioteka";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zwrotKsiazkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakonczToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyswietlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przegladajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNowegoCzytelnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ążkeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usunCzytelnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usunKsiazkeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyswietlCzytelnikowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyswietlKsiazkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyswietlWypozyczeniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przegladajUzytkownikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przegladajKsiazkiToolStripMenuItem;


    }
}

