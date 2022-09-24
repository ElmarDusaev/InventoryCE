using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using InventoryCE.Common;
using InventoryCE.Services;
using InventoryCE.Views;
using InventoryCE.Models;
using System.Windows.Forms;
using InventoryCE.Properties;
using System.Text.RegularExpressions;
using InventoryCE.Views.Login;
using System.Reflection;
using InventoryCE.Views.UserIdentity;

namespace InventoryCE.Presenters
{
    public class LoginPresenter
    {
        ILogin _view;
        

        public LoginPresenter(ILogin view)
        {
            _view = view;
            

            _view.OnButtonLoadClick += new EventHandler<EventArgs>(_view_ButtonLoadClick);
            _view.OnNextClick += new EventHandler<EventArgs>(_view_NextClick);

            SetAppVersion();
        }

        private void SetAppVersion()
        {
            _view.AppVersion = string.Concat("REVIZOR (v.", Assembly.GetExecutingAssembly().GetName().Version.ToString(), ")");
        }


        void _view_NextClick(object sender, EventArgs e)
        {
            _view.ActivateButtons = false;

            using (WaitCursor cursor = new WaitCursor())
            {
                if (!string.IsNullOrEmpty(_view.ProjectId))
                {
                    try
                    {
                        SyncService _synService = new SyncService();
                        TerminalService _terminalService = new TerminalService();

                        var sync = _synService.Get(_view.ProjectId);
                        var terminal = _terminalService.Get(_view.ProjectId);

                        SaveProducts();
                    }
                    catch (Exception ex)
                    {
                        ShowError(ex.Message);
                    }
                    finally
                    {
                        _view.ActivateButtons = true;
                    }

                }
                else ShowError("Выберите проект");
            }

            UserIdentityView userIdentityView = new UserIdentityView(_view.ProjectId);
            userIdentityView.ShowDialog();
        }

        private void SaveProducts()
        {
            ProductService _productService = new ProductService();
            int limit = int.Parse(Resources.ProoductsLimit);
            var productsCountes = _productService.Get(_view.ProjectId, 1, 1);
            int total = productsCountes.count;
            var pages = (int)Math.Ceiling((double)productsCountes.count / limit);
            int loaded = 0;
            _view.MaxProgress = productsCountes.count;


            var headerId = _productService.SaveHeader(productsCountes, _view.ProjectId, _view.ProjectName);

            for (int i = 1; i <= pages; i++)
            {
                var products = _productService.Get(_view.ProjectId, i, limit);
                _productService.SaveDetail(headerId, products);
                loaded += products.results.Count();
                _view.LoadProducts = string.Concat(total, " / ", loaded);
                _view.Progress = loaded;
            }
        }

        void _view_ButtonLoadClick(object sender, EventArgs e)
        {
            using (WaitCursor cursor = new WaitCursor())
            {
                var result = Validate();
                if (result.Success)
                {
                    try
                    {
                        ProjecService _projectService = new ProjecService(_view.ServiceIp);
                        var data = _projectService.Get();
                        _view.ProjectDataSource = data.results;
                    }
                    catch (Exception ex)
                    {
                        _view.ProjectDataSource = null;
                        ShowError(Resources.ErrorCanNotLoadData);
                    }
                }
            }
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, Resources.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
        }

        private ValidationResult Validate()
        {
            if (string.IsNullOrEmpty(_view.ServiceIp)) return new ValidationResult { Success = true, Message = string.Empty };

            ValidationResult result = new ValidationResult() { Success = true };
            var serviceIp = _view.ServiceIp;

            var validationIpResult = ValidateIp(serviceIp);

            if (!string.IsNullOrEmpty(validationIpResult))
            {
                result.Success = false;
                result.Message = validationIpResult;
            }

            return result;
        }

        private string ValidateIp(string ipStr)
        {
            string result = string.Empty;
            string ip = ipStr.Split(':').FirstOrDefault();

            const string regexPattern = @"^([\d]{1,3}\.){3}[\d]{1,3}$";
            var regex = new Regex(regexPattern);
            if (string.IsNullOrEmpty(ip))
            {
                result = Resources.ErrorLoginIPAddressIsNull;
            }
            if (!regex.IsMatch(ip) || ip.Split('.').SingleOrDefault(s => int.Parse(s) > 255) != null)
                result = Resources.ErrorLoginInvalidIpAddress;

            return result;

        }
    }
}
