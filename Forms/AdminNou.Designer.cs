namespace Turismul_de_pretutindeni.Forms
{
    partial class AdminNou
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
            this.comboBoxEmails = new System.Windows.Forms.ComboBox();
            this.buttonSingIn = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "User: ";
            // 
            // comboBoxEmails
            // 
            this.comboBoxEmails.FormattingEnabled = true;
            this.comboBoxEmails.Location = new System.Drawing.Point(285, 50);
            this.comboBoxEmails.Name = "comboBoxEmails";
            this.comboBoxEmails.Size = new System.Drawing.Size(388, 33);
            this.comboBoxEmails.TabIndex = 1;
            // 
            // buttonSingIn
            // 
            this.buttonSingIn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonSingIn.Location = new System.Drawing.Point(370, 173);
            this.buttonSingIn.Name = "buttonSingIn";
            this.buttonSingIn.Size = new System.Drawing.Size(188, 68);
            this.buttonSingIn.TabIndex = 20;
            this.buttonSingIn.Text = "Inregistrare";
            this.buttonSingIn.UseVisualStyleBackColor = false;
            this.buttonSingIn.Click += new System.EventHandler(this.buttonSingIn_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonExit.Location = new System.Drawing.Point(66, 173);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(188, 68);
            this.buttonExit.TabIndex = 19;
            this.buttonExit.Text = "Renunta";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonAdmin.Location = new System.Drawing.Point(661, 173);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(188, 68);
            this.buttonAdmin.TabIndex = 22;
            this.buttonAdmin.Text = "Transforma in admin";
            this.buttonAdmin.UseVisualStyleBackColor = false;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // AdminNou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(879, 270);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.buttonSingIn);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.comboBoxEmails);
            this.Controls.Add(this.label1);
            this.Name = "AdminNou";
            this.Text = "AdminNou";
            this.Load += new System.EventHandler(this.AdminNou_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEmails;
        private System.Windows.Forms.Button buttonSingIn;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAdmin;
    }
}