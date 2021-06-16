
namespace Inz2
{
    partial class FormLogin
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
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxHaslo = new System.Windows.Forms.TextBox();
            this.buttonZaloguj = new System.Windows.Forms.Button();
            this.buttonWyjdz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelChecker = new System.Windows.Forms.Label();
            this.buttonlewa = new System.Windows.Forms.Button();
            this.buttonadmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(319, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "WITAJ";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLogin.Location = new System.Drawing.Point(293, 144);
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(200, 40);
            this.textBoxLogin.TabIndex = 1;
            // 
            // textBoxHaslo
            // 
            this.textBoxHaslo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.textBoxHaslo.Location = new System.Drawing.Point(293, 235);
            this.textBoxHaslo.Multiline = true;
            this.textBoxHaslo.Name = "textBoxHaslo";
            this.textBoxHaslo.Size = new System.Drawing.Size(200, 40);
            this.textBoxHaslo.TabIndex = 1;
            // 
            // buttonZaloguj
            // 
            this.buttonZaloguj.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZaloguj.Location = new System.Drawing.Point(307, 329);
            this.buttonZaloguj.Name = "buttonZaloguj";
            this.buttonZaloguj.Size = new System.Drawing.Size(170, 47);
            this.buttonZaloguj.TabIndex = 2;
            this.buttonZaloguj.Text = "ZALOGUJ SIE";
            this.buttonZaloguj.UseVisualStyleBackColor = true;
            this.buttonZaloguj.Click += new System.EventHandler(this.buttonZaloguj_Click);
            // 
            // buttonWyjdz
            // 
            this.buttonWyjdz.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWyjdz.Location = new System.Drawing.Point(687, 400);
            this.buttonWyjdz.Name = "buttonWyjdz";
            this.buttonWyjdz.Size = new System.Drawing.Size(101, 38);
            this.buttonWyjdz.TabIndex = 3;
            this.buttonWyjdz.Text = "WYJDŹ";
            this.buttonWyjdz.UseVisualStyleBackColor = true;
            this.buttonWyjdz.Click += new System.EventHandler(this.buttonWyjdz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Haslo";
            // 
            // labelChecker
            // 
            this.labelChecker.AutoSize = true;
            this.labelChecker.ForeColor = System.Drawing.Color.Red;
            this.labelChecker.Location = new System.Drawing.Point(304, 379);
            this.labelChecker.Name = "labelChecker";
            this.labelChecker.Size = new System.Drawing.Size(0, 13);
            this.labelChecker.TabIndex = 5;
            // 
            // buttonlewa
            // 
            this.buttonlewa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonlewa.Location = new System.Drawing.Point(78, 155);
            this.buttonlewa.Name = "buttonlewa";
            this.buttonlewa.Size = new System.Drawing.Size(125, 66);
            this.buttonlewa.TabIndex = 6;
            this.buttonlewa.Text = "lewandoski";
            this.buttonlewa.UseVisualStyleBackColor = true;
            this.buttonlewa.Click += new System.EventHandler(this.buttonlewa_Click);
            // 
            // buttonadmin
            // 
            this.buttonadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonadmin.Location = new System.Drawing.Point(78, 235);
            this.buttonadmin.Name = "buttonadmin";
            this.buttonadmin.Size = new System.Drawing.Size(125, 66);
            this.buttonadmin.TabIndex = 6;
            this.buttonadmin.Text = "admin";
            this.buttonadmin.UseVisualStyleBackColor = true;
            this.buttonadmin.Click += new System.EventHandler(this.buttonadmin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonadmin);
            this.Controls.Add(this.buttonlewa);
            this.Controls.Add(this.labelChecker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonWyjdz);
            this.Controls.Add(this.buttonZaloguj);
            this.Controls.Add(this.textBoxHaslo);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxHaslo;
        private System.Windows.Forms.Button buttonZaloguj;
        private System.Windows.Forms.Button buttonWyjdz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelChecker;
        private System.Windows.Forms.Button buttonlewa;
        private System.Windows.Forms.Button buttonadmin;
    }
}