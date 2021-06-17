namespace Inz2
{
    partial class Obecności
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
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxprzedmiot = new System.Windows.Forms.ComboBox();
            this.buttonNN = new System.Windows.Forms.Button();
            this.buttonNU = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.buttonO = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelAlert = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.Location = new System.Drawing.Point(23, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 26);
            this.button1.TabIndex = 15;
            this.button1.Text = "Powrót";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(143, 412);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(149, 26);
            this.button5.TabIndex = 14;
            this.button5.Text = "Zgłoś problem techniczny";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(549, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "accesslvl";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Poziom dostępu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(633, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Dzienniczek Ucznia v0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(389, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 33);
            this.label1.TabIndex = 16;
            this.label1.Text = "Obecności";
            // 
            // comboBoxprzedmiot
            // 
            this.comboBoxprzedmiot.FormattingEnabled = true;
            this.comboBoxprzedmiot.Location = new System.Drawing.Point(23, 45);
            this.comboBoxprzedmiot.Name = "comboBoxprzedmiot";
            this.comboBoxprzedmiot.Size = new System.Drawing.Size(153, 21);
            this.comboBoxprzedmiot.TabIndex = 23;
            this.comboBoxprzedmiot.Text = "Wybierz przedmiot";
            this.comboBoxprzedmiot.SelectedIndexChanged += new System.EventHandler(this.comboBoxprzedmiot_SelectedIndexChanged);
            // 
            // buttonNN
            // 
            this.buttonNN.Location = new System.Drawing.Point(35, 317);
            this.buttonNN.Name = "buttonNN";
            this.buttonNN.Size = new System.Drawing.Size(124, 50);
            this.buttonNN.TabIndex = 24;
            this.buttonNN.Text = "Nieob. nieuspr.";
            this.buttonNN.UseVisualStyleBackColor = true;
            this.buttonNN.Click += new System.EventHandler(this.buttonNN_Click);
            // 
            // buttonNU
            // 
            this.buttonNU.Location = new System.Drawing.Point(35, 241);
            this.buttonNU.Name = "buttonNU";
            this.buttonNU.Size = new System.Drawing.Size(124, 50);
            this.buttonNU.TabIndex = 25;
            this.buttonNU.Text = "Nieob. uspr.";
            this.buttonNU.UseVisualStyleBackColor = true;
            this.buttonNU.Click += new System.EventHandler(this.buttonNU_Click);
            // 
            // buttonS
            // 
            this.buttonS.Location = new System.Drawing.Point(35, 168);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(124, 50);
            this.buttonS.TabIndex = 26;
            this.buttonS.Text = "Spóźnienie";
            this.buttonS.UseVisualStyleBackColor = true;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // buttonO
            // 
            this.buttonO.Location = new System.Drawing.Point(35, 94);
            this.buttonO.Name = "buttonO";
            this.buttonO.Size = new System.Drawing.Size(124, 50);
            this.buttonO.TabIndex = 27;
            this.buttonO.Text = "Obecność";
            this.buttonO.UseVisualStyleBackColor = true;
            this.buttonO.Click += new System.EventHandler(this.buttonO_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(205, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(553, 349);
            this.dataGridView1.TabIndex = 29;
            // 
            // labelAlert
            // 
            this.labelAlert.AutoSize = true;
            this.labelAlert.ForeColor = System.Drawing.Color.Red;
            this.labelAlert.Location = new System.Drawing.Point(340, 425);
            this.labelAlert.Name = "labelAlert";
            this.labelAlert.Size = new System.Drawing.Size(0, 13);
            this.labelAlert.TabIndex = 30;
            // 
            // Obecności
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 450);
            this.Controls.Add(this.labelAlert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonO);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.buttonNU);
            this.Controls.Add(this.buttonNN);
            this.Controls.Add(this.comboBoxprzedmiot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "Obecności";
            this.Text = "Obecności";
            this.Load += new System.EventHandler(this.Obecności_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxprzedmiot;
        private System.Windows.Forms.Button buttonNN;
        private System.Windows.Forms.Button buttonNU;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Button buttonO;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelAlert;
    }
}