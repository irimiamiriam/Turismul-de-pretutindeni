namespace Turismul_de_pretutindeni.Forms
{
    partial class FrmAutentificare
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.checkBoxRetine = new System.Windows.Forms.CheckBox();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.buttonSingIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(192, 77);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(382, 31);
            this.textBoxEmail.TabIndex = 2;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // textBoxParola
            // 
            this.textBoxParola.Location = new System.Drawing.Point(192, 169);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.PasswordChar = '*';
            this.textBoxParola.Size = new System.Drawing.Size(382, 31);
            this.textBoxParola.TabIndex = 3;
            // 
            // checkBoxRetine
            // 
            this.checkBoxRetine.AutoSize = true;
            this.checkBoxRetine.Location = new System.Drawing.Point(517, 255);
            this.checkBoxRetine.Name = "checkBoxRetine";
            this.checkBoxRetine.Size = new System.Drawing.Size(163, 29);
            this.checkBoxRetine.TabIndex = 4;
            this.checkBoxRetine.Text = "Retine email";
            this.checkBoxRetine.UseVisualStyleBackColor = true;
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonLogIn.Location = new System.Drawing.Point(111, 335);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(188, 68);
            this.buttonLogIn.TabIndex = 5;
            this.buttonLogIn.Text = "Autentificare";
            this.buttonLogIn.UseVisualStyleBackColor = false;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // buttonSingIn
            // 
            this.buttonSingIn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonSingIn.Location = new System.Drawing.Point(426, 335);
            this.buttonSingIn.Name = "buttonSingIn";
            this.buttonSingIn.Size = new System.Drawing.Size(188, 68);
            this.buttonSingIn.TabIndex = 6;
            this.buttonSingIn.Text = "Inregistrare";
            this.buttonSingIn.UseVisualStyleBackColor = false;
            this.buttonSingIn.Click += new System.EventHandler(this.buttonSingIn_Click);
            // 
            // FrmAutentificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(755, 505);
            this.Controls.Add(this.buttonSingIn);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.checkBoxRetine);
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAutentificare";
            this.Text = "FrmAutentificare";
            this.Load += new System.EventHandler(this.FrmAutentificare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.CheckBox checkBoxRetine;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Button buttonSingIn;
    }
}