
namespace AlarmKurma
{
    partial class Form1
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
            this.AlarmTimer = new System.Windows.Forms.Timer(this.components);
            this.LocalTimer = new System.Windows.Forms.Timer(this.components);
            this.ArkaPlanTimer = new System.Windows.Forms.Timer(this.components);
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblAlarm = new System.Windows.Forms.Label();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.btnKur = new System.Windows.Forms.Button();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.pnlKontrol = new System.Windows.Forms.Panel();
            this.pnlKontrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // AlarmTimer
            // 
            this.AlarmTimer.Interval = 1000;
            this.AlarmTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LocalTimer
            // 
            this.LocalTimer.Tick += new System.EventHandler(this.LocalTimer_Tick);
            // 
            // ArkaPlanTimer
            // 
            this.ArkaPlanTimer.Interval = 300;
            this.ArkaPlanTimer.Tick += new System.EventHandler(this.ArkaPlanTimer_Tick);
            // 
            // dtpTarih
            // 
            this.dtpTarih.CalendarTitleForeColor = System.Drawing.Color.YellowGreen;
            this.dtpTarih.CustomFormat = "";
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTarih.Location = new System.Drawing.Point(129, 16);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.ShowUpDown = true;
            this.dtpTarih.Size = new System.Drawing.Size(165, 20);
            this.dtpTarih.TabIndex = 5;
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("MS Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.Location = new System.Drawing.Point(278, 33);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(0, 21);
            this.lblSaat.TabIndex = 6;
            // 
            // lblAlarm
            // 
            this.lblAlarm.AutoSize = true;
            this.lblAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlarm.Location = new System.Drawing.Point(23, 16);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Size = new System.Drawing.Size(100, 16);
            this.lblAlarm.TabIndex = 1;
            this.lblAlarm.Text = "Alarm Zamanı : ";
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(233, 73);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 13);
            this.lblMesaj.TabIndex = 4;
            // 
            // btnKur
            // 
            this.btnKur.Location = new System.Drawing.Point(332, 13);
            this.btnKur.Name = "btnKur";
            this.btnKur.Size = new System.Drawing.Size(75, 23);
            this.btnKur.TabIndex = 2;
            this.btnKur.Text = "Alarm Kur";
            this.btnKur.UseVisualStyleBackColor = true;
            this.btnKur.Click += new System.EventHandler(this.btnKur_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.Enabled = false;
            this.btnDurdur.Location = new System.Drawing.Point(434, 13);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(107, 23);
            this.btnDurdur.TabIndex = 3;
            this.btnDurdur.Text = "Alarmı Durdur";
            this.btnDurdur.UseVisualStyleBackColor = true;
            // 
            // pnlKontrol
            // 
            this.pnlKontrol.Controls.Add(this.dtpTarih);
            this.pnlKontrol.Controls.Add(this.btnKur);
            this.pnlKontrol.Controls.Add(this.lblAlarm);
            this.pnlKontrol.Controls.Add(this.lblMesaj);
            this.pnlKontrol.Controls.Add(this.btnDurdur);
            this.pnlKontrol.Location = new System.Drawing.Point(26, 57);
            this.pnlKontrol.Name = "pnlKontrol";
            this.pnlKontrol.Size = new System.Drawing.Size(556, 120);
            this.pnlKontrol.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 397);
            this.Controls.Add(this.pnlKontrol);
            this.Controls.Add(this.lblSaat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlKontrol.ResumeLayout(false);
            this.pnlKontrol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer AlarmTimer;
        private System.Windows.Forms.Timer LocalTimer;
        private System.Windows.Forms.Timer ArkaPlanTimer;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblAlarm;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Button btnKur;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Panel pnlKontrol;
    }
}

