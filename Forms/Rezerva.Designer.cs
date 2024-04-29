namespace Turismul_de_pretutindeni.Forms
{
    partial class Rezerva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rezerva));
            this.label1 = new System.Windows.Forms.Label();
            this.labelDetalii = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeInceput = new System.Windows.Forms.DateTimePicker();
            this.dateTimeSfarsit = new System.Windows.Forms.DateTimePicker();
            this.textBoxNr = new System.Windows.Forms.TextBox();
            this.textBoxSuma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonRezerva = new System.Windows.Forms.Button();
            this.buttonVerify = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalii vacanta:";
            // 
            // labelDetalii
            // 
            this.labelDetalii.Location = new System.Drawing.Point(28, 81);
            this.labelDetalii.Name = "labelDetalii";
            this.labelDetalii.Size = new System.Drawing.Size(205, 243);
            this.labelDetalii.TabIndex = 1;
            this.labelDetalii.Text = "         ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numar persoane:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data inceput:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data sfarsit:";
            // 
            // dateTimeInceput
            // 
            this.dateTimeInceput.Location = new System.Drawing.Point(522, 95);
            this.dateTimeInceput.Name = "dateTimeInceput";
            this.dateTimeInceput.Size = new System.Drawing.Size(397, 31);
            this.dateTimeInceput.TabIndex = 5;
            // 
            // dateTimeSfarsit
            // 
            this.dateTimeSfarsit.Location = new System.Drawing.Point(529, 232);
            this.dateTimeSfarsit.Name = "dateTimeSfarsit";
            this.dateTimeSfarsit.Size = new System.Drawing.Size(397, 31);
            this.dateTimeSfarsit.TabIndex = 6;
            // 
            // textBoxNr
            // 
            this.textBoxNr.Location = new System.Drawing.Point(284, 81);
            this.textBoxNr.Name = "textBoxNr";
            this.textBoxNr.Size = new System.Drawing.Size(100, 31);
            this.textBoxNr.TabIndex = 7;
            // 
            // textBoxSuma
            // 
            this.textBoxSuma.Location = new System.Drawing.Point(136, 431);
            this.textBoxSuma.Name = "textBoxSuma";
            this.textBoxSuma.Size = new System.Drawing.Size(147, 31);
            this.textBoxSuma.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pret total:";
            // 
            // buttonRezerva
            // 
            this.buttonRezerva.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonRezerva.Enabled = false;
            this.buttonRezerva.Location = new System.Drawing.Point(33, 484);
            this.buttonRezerva.Name = "buttonRezerva";
            this.buttonRezerva.Size = new System.Drawing.Size(250, 55);
            this.buttonRezerva.TabIndex = 10;
            this.buttonRezerva.Text = "Confirma rezervare";
            this.buttonRezerva.UseVisualStyleBackColor = false;
            this.buttonRezerva.Click += new System.EventHandler(this.buttonRezerva_Click);
            // 
            // buttonVerify
            // 
            this.buttonVerify.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonVerify.Location = new System.Drawing.Point(33, 349);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(250, 55);
            this.buttonVerify.TabIndex = 11;
            this.buttonVerify.Text = "Verificara rezervare";
            this.buttonVerify.UseVisualStyleBackColor = false;
            this.buttonVerify.Click += new System.EventHandler(this.buttonVerify_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Rezerva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(999, 600);
            this.Controls.Add(this.buttonVerify);
            this.Controls.Add(this.buttonRezerva);
            this.Controls.Add(this.textBoxSuma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNr);
            this.Controls.Add(this.dateTimeSfarsit);
            this.Controls.Add(this.dateTimeInceput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDetalii);
            this.Controls.Add(this.label1);
            this.Name = "Rezerva";
            this.Text = "            ";
            this.Load += new System.EventHandler(this.Rezerva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDetalii;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeInceput;
        private System.Windows.Forms.DateTimePicker dateTimeSfarsit;
        private System.Windows.Forms.TextBox textBoxNr;
        private System.Windows.Forms.TextBox textBoxSuma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonRezerva;
        private System.Windows.Forms.Button buttonVerify;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}