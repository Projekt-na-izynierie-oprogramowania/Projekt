
namespace Inz2
{
    partial class FormDodajOcene
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
            this.comboBoxUczen = new System.Windows.Forms.ComboBox();
            this.buttonDodajSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTest = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxOcena = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxUczen
            // 
            this.comboBoxUczen.FormattingEnabled = true;
            this.comboBoxUczen.Location = new System.Drawing.Point(112, 83);
            this.comboBoxUczen.Name = "comboBoxUczen";
            this.comboBoxUczen.Size = new System.Drawing.Size(224, 21);
            this.comboBoxUczen.TabIndex = 0;
            // 
            // buttonDodajSubmit
            // 
            this.buttonDodajSubmit.Location = new System.Drawing.Point(184, 242);
            this.buttonDodajSubmit.Name = "buttonDodajSubmit";
            this.buttonDodajSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonDodajSubmit.TabIndex = 2;
            this.buttonDodajSubmit.Text = "DODAJ";
            this.buttonDodajSubmit.UseVisualStyleBackColor = true;
            this.buttonDodajSubmit.Click += new System.EventHandler(this.buttonDodajSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Uczeń";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ocena";
            // 
            // comboBoxTest
            // 
            this.comboBoxTest.FormattingEnabled = true;
            this.comboBoxTest.Location = new System.Drawing.Point(112, 129);
            this.comboBoxTest.Name = "comboBoxTest";
            this.comboBoxTest.Size = new System.Drawing.Size(224, 21);
            this.comboBoxTest.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Test";
            // 
            // comboBoxOcena
            // 
            this.comboBoxOcena.FormattingEnabled = true;
            this.comboBoxOcena.Location = new System.Drawing.Point(184, 204);
            this.comboBoxOcena.Name = "comboBoxOcena";
            this.comboBoxOcena.Size = new System.Drawing.Size(75, 21);
            this.comboBoxOcena.TabIndex = 5;
            // 
            // FormDodajOcene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 307);
            this.Controls.Add(this.comboBoxOcena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDodajSubmit);
            this.Controls.Add(this.comboBoxTest);
            this.Controls.Add(this.comboBoxUczen);
            this.Name = "FormDodajOcene";
            this.Text = "Dodawanie Oceny";
            this.Load += new System.EventHandler(this.FormDodajOcene_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUczen;
        private System.Windows.Forms.Button buttonDodajSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxOcena;
    }
}