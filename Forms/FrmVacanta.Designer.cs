namespace Turismul_de_pretutindeni.Forms
{
    partial class FrmVacanta
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVacanta));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaAdminNouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaVacanteNoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacanteleMeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconectareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxShow = new System.Windows.Forms.PictureBox();
            this.buttonRezerva = new System.Windows.Forms.Button();
            this.buttonPoster = new System.Windows.Forms.Button();
            this.checkBoxAutoPlay = new System.Windows.Forms.CheckBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.timerShow = new System.Windows.Forms.Timer(this.components);
            this.labelDescriere = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.vacanteleMeleToolStripMenuItem,
            this.emailToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1115, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaAdminNouToolStripMenuItem,
            this.adaugaVacanteNoiToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(71, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // adaugaAdminNouToolStripMenuItem
            // 
            this.adaugaAdminNouToolStripMenuItem.Name = "adaugaAdminNouToolStripMenuItem";
            this.adaugaAdminNouToolStripMenuItem.Size = new System.Drawing.Size(363, 44);
            this.adaugaAdminNouToolStripMenuItem.Text = "Adauga Admin Nou";
            this.adaugaAdminNouToolStripMenuItem.Click += new System.EventHandler(this.adaugaAdminNouToolStripMenuItem_Click);
            // 
            // adaugaVacanteNoiToolStripMenuItem
            // 
            this.adaugaVacanteNoiToolStripMenuItem.Name = "adaugaVacanteNoiToolStripMenuItem";
            this.adaugaVacanteNoiToolStripMenuItem.Size = new System.Drawing.Size(363, 44);
            this.adaugaVacanteNoiToolStripMenuItem.Text = "Adauga Vacante Noi";
            this.adaugaVacanteNoiToolStripMenuItem.Click += new System.EventHandler(this.adaugaVacanteNoiToolStripMenuItem_Click);
            // 
            // vacanteleMeleToolStripMenuItem
            // 
            this.vacanteleMeleToolStripMenuItem.Name = "vacanteleMeleToolStripMenuItem";
            this.vacanteleMeleToolStripMenuItem.Size = new System.Drawing.Size(196, 36);
            this.vacanteleMeleToolStripMenuItem.Text = "Vacantele mele";
            this.vacanteleMeleToolStripMenuItem.Click += new System.EventHandler(this.vacanteleMeleToolStripMenuItem_Click);
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deconectareToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(91, 36);
            this.emailToolStripMenuItem.Text = "Email";
            // 
            // deconectareToolStripMenuItem
            // 
            this.deconectareToolStripMenuItem.Name = "deconectareToolStripMenuItem";
            this.deconectareToolStripMenuItem.Size = new System.Drawing.Size(281, 44);
            this.deconectareToolStripMenuItem.Text = "Deconectare";
            this.deconectareToolStripMenuItem.Click += new System.EventHandler(this.deconectareToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(281, 44);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // pictureBoxShow
            // 
            this.pictureBoxShow.Location = new System.Drawing.Point(359, 78);
            this.pictureBoxShow.Name = "pictureBoxShow";
            this.pictureBoxShow.Size = new System.Drawing.Size(392, 452);
            this.pictureBoxShow.TabIndex = 1;
            this.pictureBoxShow.TabStop = false;
            // 
            // buttonRezerva
            // 
            this.buttonRezerva.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonRezerva.Location = new System.Drawing.Point(441, 547);
            this.buttonRezerva.Name = "buttonRezerva";
            this.buttonRezerva.Size = new System.Drawing.Size(250, 55);
            this.buttonRezerva.TabIndex = 6;
            this.buttonRezerva.Text = "Rezerva acum";
            this.buttonRezerva.UseVisualStyleBackColor = false;
            this.buttonRezerva.Click += new System.EventHandler(this.buttonRezerva_Click);
            // 
            // buttonPoster
            // 
            this.buttonPoster.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonPoster.Location = new System.Drawing.Point(441, 608);
            this.buttonPoster.Name = "buttonPoster";
            this.buttonPoster.Size = new System.Drawing.Size(250, 55);
            this.buttonPoster.TabIndex = 7;
            this.buttonPoster.Text = "Poster";
            this.buttonPoster.UseVisualStyleBackColor = false;
            this.buttonPoster.Click += new System.EventHandler(this.buttonPoster_Click);
            // 
            // checkBoxAutoPlay
            // 
            this.checkBoxAutoPlay.AutoSize = true;
            this.checkBoxAutoPlay.Location = new System.Drawing.Point(799, 501);
            this.checkBoxAutoPlay.Name = "checkBoxAutoPlay";
            this.checkBoxAutoPlay.Size = new System.Drawing.Size(136, 29);
            this.checkBoxAutoPlay.TabIndex = 8;
            this.checkBoxAutoPlay.Text = "Auto Play";
            this.checkBoxAutoPlay.UseVisualStyleBackColor = true;
            this.checkBoxAutoPlay.CheckedChanged += new System.EventHandler(this.checkBoxAutoPlay_CheckedChanged);
            // 
            // buttonNext
            // 
            this.buttonNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNext.BackgroundImage")));
            this.buttonNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNext.Location = new System.Drawing.Point(786, 245);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(138, 134);
            this.buttonNext.TabIndex = 9;
            this.buttonNext.Text = "  ";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPrev.BackgroundImage")));
            this.buttonPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPrev.Location = new System.Drawing.Point(188, 245);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(138, 134);
            this.buttonPrev.TabIndex = 10;
            this.buttonPrev.Text = "  ";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // timerShow
            // 
            this.timerShow.Interval = 2000;
            this.timerShow.Tick += new System.EventHandler(this.timerShow_Tick);
            // 
            // labelDescriere
            // 
            this.labelDescriere.BackColor = System.Drawing.Color.Transparent;
            this.labelDescriere.Location = new System.Drawing.Point(395, 313);
            this.labelDescriere.Name = "labelDescriere";
            this.labelDescriere.Size = new System.Drawing.Size(319, 188);
            this.labelDescriere.TabIndex = 11;
            this.labelDescriere.Text = "    ";
            // 
            // FrmVacanta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1115, 683);
            this.Controls.Add(this.labelDescriere);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.checkBoxAutoPlay);
            this.Controls.Add(this.buttonPoster);
            this.Controls.Add(this.buttonRezerva);
            this.Controls.Add(this.pictureBoxShow);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmVacanta";
            this.Text = "FrmVacanta";
            this.Load += new System.EventHandler(this.FrmVacanta_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacanteleMeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaAdminNouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaVacanteNoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deconectareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxShow;
        private System.Windows.Forms.Button buttonRezerva;
        private System.Windows.Forms.Button buttonPoster;
        private System.Windows.Forms.CheckBox checkBoxAutoPlay;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Timer timerShow;
        private System.Windows.Forms.Label labelDescriere;
    }
}