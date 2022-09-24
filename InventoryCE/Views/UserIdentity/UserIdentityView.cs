using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using InventoryCE.Properties;
using InventoryCE.Presenters;


namespace InventoryCE.Views.UserIdentity
{
    public partial class UserIdentityView : Form, IUserIdentity
    {
        public event EventHandler<EventArgs> OnEnterClick;
        string _project;

        public UserIdentityView(string project)
        {
            InitializeComponent();
            _project = project;
            var _presenter = new UserIdentityPresenter(this);
        }

        public string AppVersion
        {
            set
            {
                lAppVersion.Text = value;
            }
        }

        private void bEnter_Click(object sender, EventArgs e)
        {
            if (OnEnterClick != null)
                OnEnterClick.Invoke(sender, e);
        }
    }

}