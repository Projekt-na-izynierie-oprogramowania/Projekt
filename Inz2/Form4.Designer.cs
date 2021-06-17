namespace Inz2
{
    partial class Form4
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
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.labelDay = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxPrzedmiot = new System.Windows.Forms.ComboBox();
            this.comboBoxGodzina = new System.Windows.Forms.ComboBox();
            this.buttonDodaj2 = new System.Windows.Forms.Button();
            this.labelAlert = new System.Windows.Forms.Label();
            this.buttonDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(372, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plan zajęć na";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.Location = new System.Drawing.Point(12, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 26);
            this.button1.TabIndex = 20;
            this.button1.Text = "Powrót";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(132, 418);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(149, 26);
            this.button5.TabIndex = 19;
            this.button5.Text = "Zgłoś problem techniczny";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(582, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "accesslvl";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Poziom dostępu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(655, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Dzienniczek Ucznia v0.1";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 109);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowTodayCircle = false;
            this.monthCalendar1.TabIndex = 21;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDay.Location = new System.Drawing.Point(558, 13);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(139, 33);
            this.labelDay.TabIndex = 0;
            this.labelDay.Text = "get.date()";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(305, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(461, 338);
            this.dataGridView1.TabIndex = 22;
            // 
            // comboBoxPrzedmiot
            // 
            this.comboBoxPrzedmiot.FormattingEnabled = true;
            this.comboBoxPrzedmiot.Location = new System.Drawing.Point(18, 336);
            this.comboBoxPrzedmiot.Name = "comboBoxPrzedmiot";
            this.comboBoxPrzedmiot.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPrzedmiot.TabIndex = 23;
            // 
            // comboBoxGodzina
            // 
            this.comboBoxGodzina.FormattingEnabled = true;
            this.comboBoxGodzina.Location = new System.Drawing.Point(145, 336);
            this.comboBoxGodzina.Name = "comboBoxGodzina";
            this.comboBoxGodzina.Size = new System.Drawing.Size(75, 21);
            this.comboBoxGodzina.TabIndex = 24;
            // 
            // buttonDodaj2
            // 
            this.buttonDodaj2.Location = new System.Drawing.Point(226, 336);
            this.buttonDodaj2.Name = "buttonDodaj2";
            this.buttonDodaj2.Size = new System.Drawing.Size(61, 23);
            this.buttonDodaj2.TabIndex = 25;
            this.buttonDodaj2.Text = "DODAJ";
            this.buttonDodaj2.UseVisualStyleBackColor = true;
            this.buttonDodaj2.Click += new System.EventHandler(this.buttonDodaj2_Click);
            // 
            // labelAlert
            // 
            this.labelAlert.AutoSize = true;
            this.labelAlert.Location = new System.Drawing.Point(142, 311);
            this.labelAlert.Name = "labelAlert";
            this.labelAlert.Size = new System.Drawing.Size(0, 13);
            this.labelAlert.TabIndex = 26;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(18, 306);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(121, 23);
            this.buttonDodaj.TabIndex = 27;
            this.buttonDodaj.Text = "Dodawanie Zajęć";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.labelAlert);
            this.Controls.Add(this.buttonDodaj2);
            this.Controls.Add(this.comboBoxGodzina);
            this.Controls.Add(this.comboBoxPrzedmiot);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Plan zajęć";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxPrzedmiot;
        private System.Windows.Forms.ComboBox comboBoxGodzina;
        private System.Windows.Forms.Button buttonDodaj2;
        private System.Windows.Forms.Label labelAlert;
        private System.Windows.Forms.Button buttonDodaj;
    }
}