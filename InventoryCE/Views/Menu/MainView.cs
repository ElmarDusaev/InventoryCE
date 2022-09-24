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
using InventoryCE.Views.Menu;


namespace InventoryCE.Views.Main
{
    public partial class MainView : Form, IMainView
    {

        public MainView()
        {
            InitializeComponent();
            var _presenter = new MainPresenter(this);
        }



    }

}