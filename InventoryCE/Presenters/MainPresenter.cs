using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using InventoryCE.Views.Menu;

namespace InventoryCE.Presenters
{
    public class MainPresenter
    {
        private IMainView _view;

        public MainPresenter(IMainView view)
        {
            view = _view;
        }
    }
}
