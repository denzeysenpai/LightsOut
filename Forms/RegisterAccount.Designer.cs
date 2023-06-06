namespace LightsOut.Forms
{
    partial class frmRegisterAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterAccount));
            this.pnlPage1 = new System.Windows.Forms.Panel();
            this.btnCreateAnAccount = new ItachiUIBunifu.ButtonBunifuItachi();
            this.lblTitle1 = new System.Windows.Forms.Label();
            this.move = new System.Windows.Forms.Timer(this.components);
            this.pnlPage2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlName = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnNext = new ItachiUIBunifu.ButtonBunifuItachi();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPage3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUsernameInput = new System.Windows.Forms.TextBox();
            this.btnNextAfterUsernameInput = new ItachiUIBunifu.ButtonBunifuItachi();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.pnlPage1.SuspendLayout();
            this.pnlPage2.SuspendLayout();
            this.pnlName.SuspendLayout();
            this.pnlPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPage1
            // 
            this.pnlPage1.BackColor = System.Drawing.Color.Cornsilk;
            this.pnlPage1.Controls.Add(this.btnCreateAnAccount);
            this.pnlPage1.Controls.Add(this.lblTitle1);
            this.pnlPage1.Location = new System.Drawing.Point(9, 450);
            this.pnlPage1.Name = "pnlPage1";
            this.pnlPage1.Size = new System.Drawing.Size(816, 414);
            this.pnlPage1.TabIndex = 0;
            // 
            // btnCreateAnAccount
            // 
            this.btnCreateAnAccount.BackColor = System.Drawing.Color.Firebrick;
            this.btnCreateAnAccount.BackgroundColor = System.Drawing.Color.Firebrick;
            this.btnCreateAnAccount.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCreateAnAccount.BorderRadius = 30;
            this.btnCreateAnAccount.BorderSize = 0;
            this.btnCreateAnAccount.FlatAppearance.BorderSize = 0;
            this.btnCreateAnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAnAccount.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAnAccount.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnCreateAnAccount.Location = new System.Drawing.Point(207, 194);
            this.btnCreateAnAccount.Name = "btnCreateAnAccount";
            this.btnCreateAnAccount.Size = new System.Drawing.Size(409, 61);
            this.btnCreateAnAccount.TabIndex = 18;
            this.btnCreateAnAccount.Text = "CREATE AN ACCOUNT!";
            this.btnCreateAnAccount.TextColor = System.Drawing.Color.Cornsilk;
            this.btnCreateAnAccount.UseVisualStyleBackColor = false;
            this.btnCreateAnAccount.Click += new System.EventHandler(this.btnCreateAnAccount_Click);
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = true;
            this.lblTitle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblTitle1.Font = new System.Drawing.Font("Century Gothic", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.ForeColor = System.Drawing.Color.Orange;
            this.lblTitle1.Location = new System.Drawing.Point(245, 121);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(323, 70);
            this.lblTitle1.TabIndex = 4;
            this.lblTitle1.Text = "Welcome!";
            // 
            // move
            // 
            this.move.Enabled = true;
            this.move.Interval = 10;
            this.move.Tick += new System.EventHandler(this.movePages);
            // 
            // pnlPage2
            // 
            this.pnlPage2.BackColor = System.Drawing.Color.Cornsilk;
            this.pnlPage2.Controls.Add(this.label2);
            this.pnlPage2.Controls.Add(this.pnlName);
            this.pnlPage2.Controls.Add(this.btnNext);
            this.pnlPage2.Controls.Add(this.label1);
            this.pnlPage2.Location = new System.Drawing.Point(6, 547);
            this.pnlPage2.Name = "pnlPage2";
            this.pnlPage2.Size = new System.Drawing.Size(816, 414);
            this.pnlPage2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(169, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(515, 47);
            this.label2.TabIndex = 20;
            this.label2.Text = "What should we call you?";
            // 
            // pnlName
            // 
            this.pnlName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pnlName.Controls.Add(this.txtName);
            this.pnlName.Location = new System.Drawing.Point(274, 222);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(285, 57);
            this.pnlName.TabIndex = 19;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.PeachPuff;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(0, 0);
            this.txtName.MaxLength = 12;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(285, 59);
            this.txtName.TabIndex = 0;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Firebrick;
            this.btnNext.BackgroundColor = System.Drawing.Color.Firebrick;
            this.btnNext.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNext.BorderRadius = 30;
            this.btnNext.BorderSize = 0;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnNext.Location = new System.Drawing.Point(207, 329);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(409, 61);
            this.btnNext.TabIndex = 18;
            this.btnNext.Text = "NEXT";
            this.btnNext.TextColor = System.Drawing.Color.Cornsilk;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(127, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 63);
            this.label1.TabIndex = 4;
            this.label1.Text = "Let\'s get to know you!";
            // 
            // pnlPage3
            // 
            this.pnlPage3.BackColor = System.Drawing.Color.Cornsilk;
            this.pnlPage3.Controls.Add(this.label3);
            this.pnlPage3.Controls.Add(this.panel2);
            this.pnlPage3.Controls.Add(this.btnNextAfterUsernameInput);
            this.pnlPage3.Controls.Add(this.lblGreeting);
            this.pnlPage3.Location = new System.Drawing.Point(-5, 27);
            this.pnlPage3.Name = "pnlPage3";
            this.pnlPage3.Size = new System.Drawing.Size(816, 414);
            this.pnlPage3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(69, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(427, 47);
            this.label3.TabIndex = 20;
            this.label3.Text = "Choose a Username!";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel2.Controls.Add(this.txtUsernameInput);
            this.panel2.Location = new System.Drawing.Point(271, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 57);
            this.panel2.TabIndex = 19;
            // 
            // txtUsernameInput
            // 
            this.txtUsernameInput.BackColor = System.Drawing.Color.PeachPuff;
            this.txtUsernameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsernameInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsernameInput.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameInput.Location = new System.Drawing.Point(0, 0);
            this.txtUsernameInput.MaxLength = 10;
            this.txtUsernameInput.Name = "txtUsernameInput";
            this.txtUsernameInput.Size = new System.Drawing.Size(285, 59);
            this.txtUsernameInput.TabIndex = 0;
            this.txtUsernameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNextAfterUsernameInput
            // 
            this.btnNextAfterUsernameInput.BackColor = System.Drawing.Color.Firebrick;
            this.btnNextAfterUsernameInput.BackgroundColor = System.Drawing.Color.Firebrick;
            this.btnNextAfterUsernameInput.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNextAfterUsernameInput.BorderRadius = 30;
            this.btnNextAfterUsernameInput.BorderSize = 0;
            this.btnNextAfterUsernameInput.FlatAppearance.BorderSize = 0;
            this.btnNextAfterUsernameInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextAfterUsernameInput.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextAfterUsernameInput.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnNextAfterUsernameInput.Location = new System.Drawing.Point(207, 329);
            this.btnNextAfterUsernameInput.Name = "btnNextAfterUsernameInput";
            this.btnNextAfterUsernameInput.Size = new System.Drawing.Size(409, 61);
            this.btnNextAfterUsernameInput.TabIndex = 18;
            this.btnNextAfterUsernameInput.Text = "NEXT";
            this.btnNextAfterUsernameInput.TextColor = System.Drawing.Color.Cornsilk;
            this.btnNextAfterUsernameInput.UseVisualStyleBackColor = false;
            this.btnNextAfterUsernameInput.Click += new System.EventHandler(this.btnNextAfterUsernameInput_Click);
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblGreeting.Font = new System.Drawing.Font("Century Gothic", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.ForeColor = System.Drawing.Color.Orange;
            this.lblGreeting.Location = new System.Drawing.Point(69, 20);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(581, 63);
            this.lblGreeting.TabIndex = 4;
            this.lblGreeting.Text = "Let\'s get to know you!";
            // 
            // frmRegisterAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(804, 453);
            this.Controls.Add(this.pnlPage2);
            this.Controls.Add(this.pnlPage1);
            this.Controls.Add(this.pnlPage3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegisterAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lights Out Register Account";
            this.Load += new System.EventHandler(this.frmRegisterAccount_Load);
            this.pnlPage1.ResumeLayout(false);
            this.pnlPage1.PerformLayout();
            this.pnlPage2.ResumeLayout(false);
            this.pnlPage2.PerformLayout();
            this.pnlName.ResumeLayout(false);
            this.pnlName.PerformLayout();
            this.pnlPage3.ResumeLayout(false);
            this.pnlPage3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPage1;
        private System.Windows.Forms.Label lblTitle1;
        internal ItachiUIBunifu.ButtonBunifuItachi btnCreateAnAccount;
        private System.Windows.Forms.Timer move;
        private System.Windows.Forms.Panel pnlPage2;
        internal ItachiUIBunifu.ButtonBunifuItachi btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtUsernameInput;
        internal ItachiUIBunifu.ButtonBunifuItachi btnNextAfterUsernameInput;
        private System.Windows.Forms.Label lblGreeting;
    }
}