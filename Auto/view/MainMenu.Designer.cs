namespace Autokauppa.view
{
    partial class MainMenu
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testaaYhteysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbmittarilukema = new System.Windows.Forms.TextBox();
            this.tbtilavuus = new System.Windows.Forms.TextBox();
            this.tbhinta = new System.Windows.Forms.TextBox();
            this.cbmerkki = new System.Windows.Forms.ComboBox();
            this.cbmalli = new System.Windows.Forms.ComboBox();
            this.btuusitietue = new System.Windows.Forms.Button();
            this.bttallenna = new System.Windows.Forms.Button();
            this.btpoista = new System.Windows.Forms.Button();
            this.btedellinen = new System.Windows.Forms.Button();
            this.btseuraava = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbpolttoaine = new System.Windows.Forms.ComboBox();
            this.cbvari = new System.Windows.Forms.ComboBox();
            this.lbPolttoaine = new System.Windows.Forms.Label();
            this.lbVari = new System.Windows.Forms.Label();
            this.Dtp = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(925, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(84, 32);
            this.fileToolStripMenuItem.Text = "Valikko";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem2});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.exitToolStripMenuItem.Text = "File";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(141, 34);
            this.exitToolStripMenuItem2.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testaaYhteysToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // testaaYhteysToolStripMenuItem
            // 
            this.testaaYhteysToolStripMenuItem.Name = "testaaYhteysToolStripMenuItem";
            this.testaaYhteysToolStripMenuItem.Size = new System.Drawing.Size(219, 34);
            this.testaaYhteysToolStripMenuItem.Text = "Testaa Yhteys";
            this.testaaYhteysToolStripMenuItem.Click += new System.EventHandler(this.testaaYhteysToolStripMenuItem_Click);
            // 
            // tbmittarilukema
            // 
            this.tbmittarilukema.Location = new System.Drawing.Point(141, 209);
            this.tbmittarilukema.Name = "tbmittarilukema";
            this.tbmittarilukema.Size = new System.Drawing.Size(100, 26);
            this.tbmittarilukema.TabIndex = 1;
            this.tbmittarilukema.TextChanged += new System.EventHandler(this.tbmittarilukema_TextChanged);
            // 
            // tbtilavuus
            // 
            this.tbtilavuus.Location = new System.Drawing.Point(307, 208);
            this.tbtilavuus.Name = "tbtilavuus";
            this.tbtilavuus.Size = new System.Drawing.Size(100, 26);
            this.tbtilavuus.TabIndex = 2;
            this.tbtilavuus.TextChanged += new System.EventHandler(this.tbtilavuus_TextChanged);
            // 
            // tbhinta
            // 
            this.tbhinta.Location = new System.Drawing.Point(496, 209);
            this.tbhinta.Name = "tbhinta";
            this.tbhinta.Size = new System.Drawing.Size(100, 26);
            this.tbhinta.TabIndex = 3;
            this.tbhinta.TextChanged += new System.EventHandler(this.tbhinta_TextChanged);
            // 
            // cbmerkki
            // 
            this.cbmerkki.FormattingEnabled = true;
            this.cbmerkki.Location = new System.Drawing.Point(141, 94);
            this.cbmerkki.Name = "cbmerkki";
            this.cbmerkki.Size = new System.Drawing.Size(121, 28);
            this.cbmerkki.TabIndex = 4;
            this.cbmerkki.SelectedIndexChanged += new System.EventHandler(this.LisaaMallit);
            this.cbmerkki.Click += new System.EventHandler(this.cbmerkki_Click);
            // 
            // cbmalli
            // 
            this.cbmalli.FormattingEnabled = true;
            this.cbmalli.Location = new System.Drawing.Point(338, 93);
            this.cbmalli.Name = "cbmalli";
            this.cbmalli.Size = new System.Drawing.Size(121, 28);
            this.cbmalli.TabIndex = 5;
            this.cbmalli.SelectedIndexChanged += new System.EventHandler(this.cbmalli_SelectedIndexChanged);
            // 
            // btuusitietue
            // 
            this.btuusitietue.Location = new System.Drawing.Point(67, 305);
            this.btuusitietue.Name = "btuusitietue";
            this.btuusitietue.Size = new System.Drawing.Size(90, 36);
            this.btuusitietue.TabIndex = 6;
            this.btuusitietue.Text = "Uusitietue";
            this.btuusitietue.UseVisualStyleBackColor = true;
            this.btuusitietue.Click += new System.EventHandler(this.btuusitietue_Click);
            // 
            // bttallenna
            // 
            this.bttallenna.Location = new System.Drawing.Point(180, 305);
            this.bttallenna.Name = "bttallenna";
            this.bttallenna.Size = new System.Drawing.Size(100, 36);
            this.bttallenna.TabIndex = 7;
            this.bttallenna.Text = "Tallenna";
            this.bttallenna.UseVisualStyleBackColor = true;
            this.bttallenna.Click += new System.EventHandler(this.bttallenna_Click);
            // 
            // btpoista
            // 
            this.btpoista.Location = new System.Drawing.Point(307, 305);
            this.btpoista.Name = "btpoista";
            this.btpoista.Size = new System.Drawing.Size(100, 36);
            this.btpoista.TabIndex = 8;
            this.btpoista.Text = "Poista";
            this.btpoista.UseVisualStyleBackColor = true;
            this.btpoista.Click += new System.EventHandler(this.btpoista_Click);
            // 
            // btedellinen
            // 
            this.btedellinen.Location = new System.Drawing.Point(429, 305);
            this.btedellinen.Name = "btedellinen";
            this.btedellinen.Size = new System.Drawing.Size(105, 36);
            this.btedellinen.TabIndex = 9;
            this.btedellinen.Text = "Edellenin";
            this.btedellinen.UseVisualStyleBackColor = true;
            this.btedellinen.Click += new System.EventHandler(this.btedellinen_Click);
            // 
            // btseuraava
            // 
            this.btseuraava.Location = new System.Drawing.Point(574, 305);
            this.btseuraava.Name = "btseuraava";
            this.btseuraava.Size = new System.Drawing.Size(127, 36);
            this.btseuraava.TabIndex = 10;
            this.btseuraava.Text = "Seuraava";
            this.btseuraava.UseVisualStyleBackColor = true;
            this.btseuraava.Click += new System.EventHandler(this.btseuraava_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mittarinlukema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Moottorintilavuus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hinta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Merkki";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Malli";
            // 
            // cbpolttoaine
            // 
            this.cbpolttoaine.FormattingEnabled = true;
            this.cbpolttoaine.Location = new System.Drawing.Point(529, 93);
            this.cbpolttoaine.Name = "cbpolttoaine";
            this.cbpolttoaine.Size = new System.Drawing.Size(121, 28);
            this.cbpolttoaine.TabIndex = 16;
            // 
            // cbvari
            // 
            this.cbvari.FormattingEnabled = true;
            this.cbvari.Location = new System.Drawing.Point(714, 92);
            this.cbvari.Name = "cbvari";
            this.cbvari.Size = new System.Drawing.Size(121, 28);
            this.cbvari.TabIndex = 17;
            // 
            // lbPolttoaine
            // 
            this.lbPolttoaine.AutoSize = true;
            this.lbPolttoaine.Location = new System.Drawing.Point(529, 39);
            this.lbPolttoaine.Name = "lbPolttoaine";
            this.lbPolttoaine.Size = new System.Drawing.Size(80, 20);
            this.lbPolttoaine.TabIndex = 18;
            this.lbPolttoaine.Text = "Polttoaine";
            // 
            // lbVari
            // 
            this.lbVari.AutoSize = true;
            this.lbVari.Location = new System.Drawing.Point(714, 40);
            this.lbVari.Name = "lbVari";
            this.lbVari.Size = new System.Drawing.Size(37, 20);
            this.lbVari.TabIndex = 19;
            this.lbVari.Text = "Vari";
            // 
            // Dtp
            // 
            this.Dtp.CustomFormat = "yyyy-MM-dd";
            this.Dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp.Location = new System.Drawing.Point(685, 155);
            this.Dtp.Name = "Dtp";
            this.Dtp.Size = new System.Drawing.Size(139, 26);
            this.Dtp.TabIndex = 20;
            this.Dtp.ValueChanged += new System.EventHandler(this.Dtp_ValueChanged);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 549);
            this.Controls.Add(this.Dtp);
            this.Controls.Add(this.lbVari);
            this.Controls.Add(this.lbPolttoaine);
            this.Controls.Add(this.cbvari);
            this.Controls.Add(this.cbpolttoaine);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btseuraava);
            this.Controls.Add(this.btedellinen);
            this.Controls.Add(this.btpoista);
            this.Controls.Add(this.bttallenna);
            this.Controls.Add(this.btuusitietue);
            this.Controls.Add(this.cbmalli);
            this.Controls.Add(this.cbmerkki);
            this.Controls.Add(this.tbhinta);
            this.Controls.Add(this.tbtilavuus);
            this.Controls.Add(this.tbmittarilukema);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testaaYhteysToolStripMenuItem;
        private System.Windows.Forms.TextBox tbmittarilukema;
        private System.Windows.Forms.TextBox tbtilavuus;
        private System.Windows.Forms.TextBox tbhinta;
        private System.Windows.Forms.ComboBox cbmerkki;
        private System.Windows.Forms.ComboBox cbmalli;
        private System.Windows.Forms.Button btuusitietue;
        private System.Windows.Forms.Button bttallenna;
        private System.Windows.Forms.Button btpoista;
        private System.Windows.Forms.Button btedellinen;
        private System.Windows.Forms.Button btseuraava;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbpolttoaine;
        private System.Windows.Forms.ComboBox cbvari;
        private System.Windows.Forms.Label lbPolttoaine;
        private System.Windows.Forms.Label lbVari;
        private System.Windows.Forms.DateTimePicker Dtp;
    }
}