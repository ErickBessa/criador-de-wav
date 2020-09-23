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
            this.button1 = new System.Windows.Forms.Button();
            this.btnPlayWav = new System.Windows.Forms.Button();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.lblValueTrackBar = new System.Windows.Forms.Label();
            this.trackBarF = new System.Windows.Forms.TrackBar();
            this.lblFrequence = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarF)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(327, 191);
            this.txtLog.TabIndex = 0;
            this.txtLog.DoubleClick += new System.EventHandler(this.txtLog_DoubleClick);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(327, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "CreateWav";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPlayWav
            // 
            this.btnPlayWav.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPlayWav.Location = new System.Drawing.Point(0, 195);
            this.btnPlayWav.Name = "btnPlayWav";
            this.btnPlayWav.Size = new System.Drawing.Size(327, 42);
            this.btnPlayWav.TabIndex = 2;
            this.btnPlayWav.Text = "Play Wav";
            this.btnPlayWav.UseVisualStyleBackColor = true;
            this.btnPlayWav.Click += new System.EventHandler(this.btnPlayWav_Click);
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(12, 112);
            this.trackBar.Maximum = 32767;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(256, 45);
            this.trackBar.TabIndex = 3;
            this.trackBar.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // lblValueTrackBar
            // 
            this.lblValueTrackBar.AutoSize = true;
            this.lblValueTrackBar.Location = new System.Drawing.Point(128, 178);
            this.lblValueTrackBar.Name = "lblValueTrackBar";
            this.lblValueTrackBar.Size = new System.Drawing.Size(35, 13);
            this.lblValueTrackBar.TabIndex = 4;
            this.lblValueTrackBar.Text = "label1";
            // 
            // trackBarF
            // 
            this.trackBarF.Location = new System.Drawing.Point(12, 49);
            this.trackBarF.Maximum = 32767;
            this.trackBarF.Name = "trackBarF";
            this.trackBarF.Size = new System.Drawing.Size(238, 45);
            this.trackBarF.TabIndex = 5;
            this.trackBarF.ValueChanged += new System.EventHandler(this.trackBarF_ValueChanged);
            // 
            // lblFrequence
            // 
            this.lblFrequence.AutoSize = true;
            this.lblFrequence.Location = new System.Drawing.Point(215, 178);
            this.lblFrequence.Name = "lblFrequence";
            this.lblFrequence.Size = new System.Drawing.Size(35, 13);
            this.lblFrequence.TabIndex = 6;
            this.lblFrequence.Text = "label1";
            // 
            // CWav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 279);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.lblFrequence);
            this.Controls.Add(this.trackBarF);
            this.Controls.Add(this.lblValueTrackBar);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.btnPlayWav);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(343, 318);
            this.Name = "CWav";
            this.Text = "CWav 1.0";
            this.Load += new System.EventHandler(this.CWav_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPlayWav;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label lblValueTrackBar;
        private System.Windows.Forms.TrackBar trackBarF;
        private System.Windows.Forms.Label lblFrequence;
    }
}

