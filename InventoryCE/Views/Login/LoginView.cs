using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using InventoryCE.Properties;
using InventoryCE.Presenters;
using InventoryCE.Models;
using System.Threading;

namespace InventoryCE.Views.Login
{
    public partial class LoginView : Form, ILogin
    {

        public event EventHandler<EventArgs> OnButtonLoadClick;

        public event EventHandler<EventArgs> OnNextClick;


        public LoginView()
        {
            InitializeComponent();
            var _presenter = new LoginPresenter(this);
        }


        private void bLoad_Click(object sender, EventArgs e)
        {
            if (OnButtonLoadClick != null) OnButtonLoadClick.Invoke(sender, e);
        }

        private void tServiceIp_LostFocus(object sender, EventArgs e)
        {

        }



        public string ServiceIp
        {
            get
            {
                return tServiceIp.Text;
            }
            set
            {
                tServiceIp.Text = value;
            }
        }

        public ProjectResult[] ProjectDataSource
        {
            get
            {
                return cProject.DataSource as ProjectResult[];
            }
            set
            {
                cProject.ValueMember = "id";
                cProject.DisplayMember = "title";
                cProject.DataSource = value;
            }
        }

        public string ProjectId
        {
            get
            {
                return cProject.SelectedValue != null ? cProject.SelectedValue.ToString() : string.Empty;
            }
        }

        public string ProjectName
        {
            get
            {
                return cProject.Text != null ? cProject.Text : string.Empty;
            }
        }

        public string AppVersion
        {
            set
            {
                lAppVersion.Text = value;
            }
        }

        private void bNExt_Click(object sender, EventArgs e)
        {
            if (OnNextClick != null) OnNextClick.Invoke(sender, e);
        }

        public string LoadProducts
        {
            set
            {
                lblLoadProducts.Text = value;
                lblLoadProducts.Update();
            }
        }

        public bool ActivateButtons {

            set
            {
                bLoad.Visible = value;
                bNExt.Visible = value;
                pbLoader.Visible = !value;
                lblLoadProducts.Visible = !value;

                bLoad.Update();
                pbLoader.Update();
                bNExt.Update();
                lblLoadProducts.Update();
                this.Update();
            }
        }


        public int MaxProgress
        {

            set
            {
                pbLoader.Maximum = value;
                pbLoader.Update();
            }
        }

        public int Progress
        {
            set
            {
                pbLoader.Value = value;
                pbLoader.Update();
            }
        }
    }
}