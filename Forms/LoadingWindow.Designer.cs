namespace LightsOut
{
    partial class frmLoadingWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoadingWindow));
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrLoading = new System.Windows.Forms.Timer(this.components);
            this.pnlPicture = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.progressBar_Loading = new System.Windows.Forms.ProgressBar();
            this.lblChar = new System.Windows.Forms.Label();
            this.elipForm1 = new ItachiUIBunifu.ElipForm();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblTitle1.Font = new System.Drawing.Font("Century Gothic", 51.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblTitle1.Location = new System.Drawing.Point(636, 315);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(254, 82);
            this.lblTitle1.TabIndex = 3;
            this.lblTitle1.Text = "LIGHTS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(629, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 126);
            this.label1.TabIndex = 4;
            this.label1.Text = "OUT";
            // 
            // tmrLoading
            // 
            this.tmrLoading.Enabled = true;
            this.tmrLoading.Interval = 1000;
            this.tmrLoading.Tick += new System.EventHandler(this.TImerForLoading);
            // 
            // pnlPicture
            // 
            this.pnlPicture.BackColor = System.Drawing.Color.Transparent;
            this.pnlPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPicture.BackgroundImage")));
            this.pnlPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPicture.Location = new System.Drawing.Point(678, 426);
            this.pnlPicture.Name = "pnlPicture";
            this.pnlPicture.Size = new System.Drawing.Size(35, 35);
            this.pnlPicture.TabIndex = 10;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // progressBar_Loading
            // 
            this.progressBar_Loading.BackColor = System.Drawing.Color.Red;
            this.progressBar_Loading.ForeColor = System.Drawing.Color.Cornsilk;
            this.progressBar_Loading.Location = new System.Drawing.Point(188, 756);
            this.progressBar_Loading.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar_Loading.Name = "progressBar_Loading";
            this.progressBar_Loading.Size = new System.Drawing.Size(1155, 12);
            this.progressBar_Loading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_Loading.TabIndex = 11;
            this.progressBar_Loading.UseWaitCursor = true;
            this.progressBar_Loading.Value = 60;
            // 
            // lblChar
            // 
            this.lblChar.AutoSize = true;
            this.lblChar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblChar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChar.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblChar.Location = new System.Drawing.Point(658, 771);
            this.lblChar.Name = "lblChar";
            this.lblChar.Size = new System.Drawing.Size(207, 21);
            this.lblChar.TabIndex = 12;
            this.lblChar.Text = "------------LOADING------------";
            // 
            // elipForm1
            // 
            this.elipForm1.CornerRadius = 30;
            this.elipForm1.TargetControl = this;
            // 
            // frmLoadingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1519, 818);
            this.Controls.Add(this.lblChar);
            this.Controls.Add(this.progressBar_Loading);
            this.Controls.Add(this.pnlPicture);
            this.Controls.Add(this.lblTitle1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLoadingWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lights Out";
            this.Load += new System.EventHandler(this.frmLoadingWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Timer tmrLoading;
        private System.Windows.Forms.Panel pnlPicture;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblChar;
        internal System.Windows.Forms.ProgressBar progressBar_Loading;
        private ItachiUIBunifu.ElipForm elipForm1;
    }
}