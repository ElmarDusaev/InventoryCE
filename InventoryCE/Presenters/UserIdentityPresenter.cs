using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using InventoryCE.Views.UserIdentity;
using System.Reflection;
using InventoryCE.Views.Main;

namespace InventoryCE.Presenters
{
    public class UserIdentityPresenter
    {
        IUserIdentity _view;

        public UserIdentityPresenter(IUserIdentity view)
        {
            _view = view;
            _view.OnEnterClick += new EventHandler<EventArgs>(_view_OnEnterClick);
            SetAppVersion();
        }

        void _view_OnEnterClick(object sender, EventArgs e)
        {
            MainView mainView = new MainView();
            mainView.ShowDialog();
        }

        private void SetAppVersion()
        {
            _view.AppVersion = string.Concat("REVIZOR (v.", Assembly.GetExecutingAssembly().GetName().Version.ToString(), ")");
        }
    }

}
