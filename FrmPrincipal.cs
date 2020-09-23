using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CWav
{
    public partial class CWav : Form
    {

        OpenFileDialog vAbreArq;

        public CWav()
        {
            InitializeComponent();
        }

        public void atualizaLog(string sMsg)
        {
            AddLog(sMsg);
        }

        public void AddLog(string Line)
        {
            string sMili = "000" + DateTime.Now.Millisecond.ToString();
            sMili = sMili.Substring(sMili.Length - 3, 3);
            string sLinha = String.Format("{0:HH:mm:ss}", DateTime.Now) + "." + sMili + " - " + Line;

            //Salva o log.
            //salvaLog(sLinha);

            if (txtLog.Lines.Length > 10)
                txtLog.Clear();
            txtLog.Text += sLinha.Replace("\0", "") + "\r\n";
            if (txtLog.Text.Length > 0)
            {
                txtLog.Select(txtLog.Text.Length - 1, 0);
                txtLog.ScrollToCaret();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (clsWav.CreateFileWav(clsWav.CreateSin(trackBar.Value,trackBarF.Value), true))
            //    atualizaLog("Arquivo Wav Criado !");
            vAbreArq = new OpenFileDialog();
            vAbreArq.Filter = "Excel Files|*.xls";
            if (vAbreArq.ShowDialog() == DialogResult.OK)
            {
                atualizaLog("Iniciando criação do arquivo Wav...");
                byte[] bSoundData = clsXls.ReadXls(vAbreArq.FileName);
                if (bSoundData != null)
                    if (clsWav.CreateFileWav(bSoundData, true))
                        atualizaLog("Arquivo Wav Criado !");
            }
        }

        private void btnPlayWav_Click(object sender, EventArgs e)
        {
            vAbreArq = new OpenFileDialog();
            vAbreArq.Filter = "All Media Files|*.wav";
            if (vAbreArq.ShowDialog() == DialogResult.OK)
                clsWav.PlaySimpleSound(vAbreArq.FileName);
        }

        private void playSimpleSound(string sFileWav)
        {
            SoundPlayer simpleSound = new SoundPlayer(sFileWav);
            simpleSound.Play();
        }

        private void txtLog_DoubleClick(object sender, EventArgs e)
        {
            txtLog.Clear();
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            lblValueTrackBar.Text = trackBar.Value.ToString();
        }

        private void trackBarF_ValueChanged(object sender, EventArgs e)
        {
            lblFrequence.Text = trackBarF.Value.ToString();
        }

        private void CWav_Load(object sender, EventArgs e)
        {

        }
    }
}
