namespace InventoryCE.Views.Login
{
    partial class LoginView
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
            this.bLoad = new System.Windows.Forms.Button();
            this.labelProject = new System.Windows.Forms.Label();
            this.lAppVersion = new System.Windows.Forms.Label();
            this.labelIp = new System.Windows.Forms.Label();
            this.tServiceIp = new System.Windows.Forms.TextBox();
            this.cProject = new System.Windows.Forms.ComboBox();
            this.bNExt = new System.Windows.Forms.Button();
            this.lblLoadProducts = new System.Windows.Forms.Label();
            this.pbLoader = new System.Windows.Forms.ProgressBar();
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
            this.iLogo.Size = new System.Drawing.Size(638, 49);
            this.iLogo.Text = "REVIZOR";
            this.iLogo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bLoad
            // 
            this.bLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.bLoad.ForeColor = System.Drawing.Color.White;
            this.bLoad.Location = new System.Drawing.Point(25, 160);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(591, 30);
            this.bLoad.TabIndex = 13;
            this.bLoad.Text = "ЗАГРУЗИТЬ ПРОЕКТЫ";
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // labelProject
            // 
            this.labelProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProject.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.labelProject.Location = new System.Drawing.Point(25, 104);
            this.labelProject.Name = "labelProject";
            this.labelProject.Size = new System.Drawing.Size(591, 17);
            this.labelProject.Text = "Выберите проект";
            // 
            // lAppVersion
            // 
            this.lAppVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lAppVersion.ForeColor = System.Drawing.Color.Gray;
            this.lAppVersion.Location = new System.Drawing.Point(0, 423);
            this.lAppVersion.Name = "lAppVersion";
            this.lAppVersion.Size = new System.Drawing.Size(638, 18);
            this.lAppVersion.Text = "REVIZOR 0.0.0";
            this.lAppVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelIp
            // 
            this.labelIp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.labelIp.Location = new System.Drawing.Point(25, 54);
            this.labelIp.Name = "labelIp";
            this.labelIp.Size = new System.Drawing.Size(591, 17);
            this.labelIp.Text = "Введите IP";
            // 
            // tServiceIp
            // 
            this.tServiceIp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tServiceIp.BackColor = System.Drawing.Color.White;
            this.tServiceIp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.tServiceIp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tServiceIp.Location = new System.Drawing.Point(25, 75);
            this.tServiceIp.Name = "tServiceIp";
            this.tServiceIp.Size = new System.Drawing.Size(591, 26);
            this.tServiceIp.TabIndex = 11;
            this.tServiceIp.LostFocus += new System.EventHandler(this.tServiceIp_LostFocus);
            // 
            // cProject
            // 
            this.cProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cProject.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.cProject.Location = new System.Drawing.Point(25, 124);
            this.cProject.Name = "cProject";
            this.cProject.Size = new System.Drawing.Size(591, 26);
            this.cProject.TabIndex = 18;
            // 
            // bNExt
            // 
            this.bNExt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bNExt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.bNExt.ForeColor = System.Drawing.Color.White;
            this.bNExt.Location = new System.Drawing.Point(25, 196);
            this.bNExt.Name = "bNExt";
            this.bNExt.Size = new System.Drawing.Size(591, 30);
            this.bNExt.TabIndex = 23;
            this.bNExt.Text = "ЗАГРУЗИТЬ БАЗУ ДАННЫХ";
            this.bNExt.Click += new System.EventHandler(this.bNExt_Click);
            // 
            // lblLoadProducts
            // 
            this.lblLoadProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoadProducts.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.lblLoadProducts.Location = new System.Drawing.Point(25, 195);
            this.lblLoadProducts.Name = "lblLoadProducts";
            this.lblLoadProducts.Size = new System.Drawing.Size(591, 29);
            this.lblLoadProducts.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblLoadProducts.Visible = false;
            // 
            // pbLoader
            // 
            this.pbLoader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLoader.Location = new System.Drawing.Point(25, 160);
            this.pbLoader.Name = "pbLoader";
            this.pbLoader.Size = new System.Drawing.Size(591, 32);
            this.pbLoader.Visible = false;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.bNExt);
            this.Controls.Add(this.cProject);
            this.Controls.Add(this.bLoad);
            this.Controls.Add(this.labelProject);
            this.Controls.Add(this.lAppVersion);
            this.Controls.Add(this.labelIp);
            this.Controls.Add(this.tServiceIp);
            this.Controls.Add(this.iLogo);
            this.Controls.Add(this.pbLoader);
            this.Controls.Add(this.lblLoadProducts);
            this.Name = "LoginView";
            this.Text = "Вход";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label iLogo;
        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.Label labelProject;
        private System.Windows.Forms.Label lAppVersion;
        private System.Windows.Forms.Label labelIp;
        private System.Windows.Forms.TextBox tServiceIp;
        private System.Windows.Forms.ComboBox cProject;
        private System.Windows.Forms.Button bNExt;
        private System.Windows.Forms.Label lblLoadProducts;
        private System.Windows.Forms.ProgressBar pbLoader;

    }
}

