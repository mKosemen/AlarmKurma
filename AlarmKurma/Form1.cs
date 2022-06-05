using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace AlarmKurma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        SoundPlayer player = new SoundPlayer();
        PictureBox pbDurdur = new PictureBox();
        private void btnKur_Click(object sender, EventArgs e)
        {
            AlarmTimer.Start();
            lblMesaj.Text = "Alarm Kuruldu.";
            btnDurdur.Enabled = false;

            pbDurdur.SetBounds(228, 179, 90, 90);
            this.Controls.Add(pbDurdur);
            pbDurdur.Image = Properties.Resources.DilCikaranCocuk;
            pbDurdur.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDurdur.Visible = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            DateTime alarmTime = dtpTarih.Value;
            if (dateTime.Hour == alarmTime.Hour && dateTime.Minute == alarmTime.Minute && dateTime.Second == alarmTime.Second)
            {
                AlarmTimer.Stop();
                lblMesaj.Text = "Alarm Çalıyor...";
                btnDurdur.Enabled = true;
                Stream alarm = Properties.Resources.TavukAlarm;
                SoundPlayer cal = new SoundPlayer(alarm);
                cal.PlayLooping();
                ArkaPlanTimer.Start();
                pnlKontrol.Visible = false;
                pbDurdur.Visible = true;
            }
        }
        private void LocalTimer_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        Random r = new Random();
        private void ArkaPlanTimer_Tick(object sender, EventArgs e)
        {
            int x = rnd.Next(255);
            int y = rnd.Next(255);
            int z = rnd.Next(255);
            this.BackColor = Color.FromArgb(x, y, z);
            pbDurdur.Top = r.Next(0, this.Height - 50);
            pbDurdur.Left = r.Next(0, this.Width - 50);
        }
        private void PbDurdur_Click(Object sender, EventArgs e)
        {
            player.Stop();
            lblMesaj.Text = "Alarm Durduruldu.";
            btnKur.Enabled = true;
            ArkaPlanTimer.Stop();
            this.BackColor = Color.White;
            pnlKontrol.Visible = true;
            pbDurdur.Image = Properties.Resources.cocuk_hareketli_resim_0108;
            pbDurdur.SetBounds(228, 179, 120, 200);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LocalTimer.Start();
            pbDurdur.Click += new EventHandler(PbDurdur_Click);
        }

    }
}
