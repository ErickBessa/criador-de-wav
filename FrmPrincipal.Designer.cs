namespace CWav
{
    partial class CWav
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnPlayWav = new System.Windows.Forms.Button();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.lblValueTrackBar = new System.Windows.Forms.Label();
            this.trackBarF = new System.Windows.Forms.TrackBar();
            this.lblFrequence = new System.Windows.Forms.Label();
            this.txtSampleRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateWav = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarF)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(357, 228);
            this.txtLog.TabIndex = 0;
            this.txtLog.DoubleClick += new System.EventHandler(this.txtLog_DoubleClick);
            // 
            // btnPlayWav
            // 
            this.btnPlayWav.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPlayWav.Location = new System.Drawing.Point(0, 314);
            this.btnPlayWav.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPlayWav.Name = "btnPlayWav";
            this.btnPlayWav.Size = new System.Drawing.Size(357, 58);
            this.btnPlayWav.TabIndex = 1;
            this.btnPlayWav.Text = "PlayWav";
            this.btnPlayWav.UseVisualStyleBackColor = true;
            this.btnPlayWav.Click += new System.EventHandler(this.btnPlayWav_Click);
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(20, 155);
            this.trackBar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.trackBar.Maximum = 32767;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(427, 45);
            this.trackBar.TabIndex = 3;
            this.trackBar.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // lblValueTrackBar
            // 
            this.lblValueTrackBar.AutoSize = true;
            this.lblValueTrackBar.Location = new System.Drawing.Point(225, 170);
            this.lblValueTrackBar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblValueTrackBar.Name = "lblValueTrackBar";
            this.lblValueTrackBar.Size = new System.Drawing.Size(52, 18);
            this.lblValueTrackBar.TabIndex = 4;
            this.lblValueTrackBar.Text = "label1";
            // 
            // trackBarF
            // 
            this.trackBarF.Location = new System.Drawing.Point(20, 68);
            this.trackBarF.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.trackBarF.Maximum = 32767;
            this.trackBarF.Name = "trackBarF";
            this.trackBarF.Size = new System.Drawing.Size(397, 45);
            this.trackBarF.TabIndex = 5;
            this.trackBarF.ValueChanged += new System.EventHandler(this.trackBarF_ValueChanged);
            // 
            // lblFrequence
            // 
            this.lblFrequence.AutoSize = true;
            this.lblFrequence.Location = new System.Drawing.Point(358, 134);
            this.lblFrequence.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFrequence.Name = "lblFrequence";
            this.lblFrequence.Size = new System.Drawing.Size(52, 18);
            this.lblFrequence.TabIndex = 6;
            this.lblFrequence.Text = "label1";
            // 
            // txtSampleRate
            // 
            this.txtSampleRate.Location = new System.Drawing.Point(200, 232);
            this.txtSampleRate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSampleRate.Name = "txtSampleRate";
            this.txtSampleRate.Size = new System.Drawing.Size(65, 24);
            this.txtSampleRate.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 235);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "SampleRate:";
            // 
            // btnCreateWav
            // 
            this.btnCreateWav.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCreateWav.Location = new System.Drawing.Point(0, 256);
            this.btnCreateWav.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCreateWav.Name = "btnCreateWav";
            this.btnCreateWav.Size = new System.Drawing.Size(357, 58);
            this.btnCreateWav.TabIndex = 9;
            this.btnCreateWav.Text = "CreateWav";
            this.btnCreateWav.UseVisualStyleBackColor = true;
            this.btnCreateWav.Click += new System.EventHandler(this.button1_Click);
            // 
            // CWav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 372);
            this.Controls.Add(this.btnCreateWav);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSampleRate);
            this.Controls.Add(this.lblFrequence);
            this.Controls.Add(this.trackBarF);
            this.Controls.Add(this.lblValueTrackBar);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.btnPlayWav);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximumSize = new System.Drawing.Size(561, 425);
            this.Name = "CWav";
            this.Text = "CWav 1.0";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnPlayWav;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label lblValueTrackBar;
        private System.Windows.Forms.TrackBar trackBarF;
        private System.Windows.Forms.Label lblFrequence;
        private System.Windows.Forms.TextBox txtSampleRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateWav;
    }
}

