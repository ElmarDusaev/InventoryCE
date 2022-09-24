namespace InventoryCE.Views.UserIdentity
{
    partial class UserIdentityView
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
            this.iLogo = new System.Windows.Forms.Label();
            this.bEnter = new System.Windows.Forms.Button();
            this.ltUserId = new System.Windows.Forms.Label();
            this.tUserID = new System.Windows.Forms.TextBox();
            this.lAppVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // iLogo
            // 
            this.iLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.iLogo.Font = new System.Drawing.Font("Tahoma", 26F, System.Drawing.FontStyle.Bold);
            this.iLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.iLogo.Location = new System.Drawing.Point(0, 11);
            this.iLogo.Name = "iLogo";
            this.iLogo.Size = new System.Drawing.Size(418, 49);
            this.iLogo.Text = "REVIZOR";
            this.iLogo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bEnter
            // 
            this.bEnter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.bEnter.ForeColor = System.Drawing.Color.White;
            this.bEnter.Location = new System.Drawing.Point(34, 158);
            this.bEnter.Name = "bEnter";
            this.bEnter.Size = new System.Drawing.Size(350, 30);
            this.bEnter.TabIndex = 25;
            this.bEnter.Text = "ВОЙТИ";
            this.bEnter.Click += new System.EventHandler(this.bEnter_Click);
            // 
            // ltUserId
            // 
            this.ltUserId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ltUserId.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.ltUserId.Location = new System.Drawing.Point(34, 96);
            this.ltUserId.Name = "ltUserId";
            this.ltUserId.Size = new System.Drawing.Size(350, 17);
            this.ltUserId.Text = "Введите номер пользователя";
            // 
            // tUserID
            // 
            this.tUserID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tUserID.BackColor = System.Drawing.Color.White;
            this.tUserID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.tUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tUserID.Location = new System.Drawing.Point(34, 116);
            this.tUserID.Name = "tUserID";
            this.tUserID.Size = new System.Drawing.Size(350, 26);
            this.tUserID.TabIndex = 24;
            // 
            // lAppVersion
            // 
            this.lAppVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lAppVersion.ForeColor = System.Drawing.Color.Gray;
            this.lAppVersion.Location = new System.Drawing.Point(0, 423);
            this.lAppVersion.Name = "lAppVersion";
            this.lAppVersion.Size = new System.Drawing.Size(418, 18);
            this.lAppVersion.Text = "REVIZOR 0.0.0";
            this.lAppVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UserIdentityView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(418, 455);
            this.Controls.Add(this.lAppVersion);
            this.Controls.Add(this.bEnter);
            this.Controls.Add(this.ltUserId);
            this.Controls.Add(this.tUserID);
            this.Controls.Add(this.iLogo);
            this.Name = "UserIdentityView";
            this.Text = "Пользователь";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label iLogo;
        private System.Windows.Forms.Button bEnter;
        private System.Windows.Forms.Label ltUserId;
        private System.Windows.Forms.TextBox tUserID;
        private System.Windows.Forms.Label lAppVersion;

    }
}

