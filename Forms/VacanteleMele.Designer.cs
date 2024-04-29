namespace Turismul_de_pretutindeni.Forms
{
    partial class VacanteleMele
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
            this.dataGridViewRezervari = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervari)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRezervari
            // 
            this.dataGridViewRezervari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRezervari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRezervari.Location = new System.Drawing.Point(0, 3);
            this.dataGridViewRezervari.Name = "dataGridViewRezervari";
            this.dataGridViewRezervari.RowHeadersWidth = 82;
            this.dataGridViewRezervari.RowTemplate.Height = 33;
            this.dataGridViewRezervari.Size = new System.Drawing.Size(1598, 224);
            this.dataGridViewRezervari.TabIndex = 0;
            this.dataGridViewRezervari.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRezervari_CellContentClick);
            // 
            // VacanteleMele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1601, 306);
            this.Controls.Add(this.dataGridViewRezervari);
            this.Name = "VacanteleMele";
            this.Text = "VacanteleMele";
            this.Load += new System.EventHandler(this.VacanteleMele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRezervari;
    }
}