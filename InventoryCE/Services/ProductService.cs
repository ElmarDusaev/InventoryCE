using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using InventoryCE.Models;
using InventoryCE.Properties;
using InventoryCE.Common;
using InventoryCE.Repository;

namespace InventoryCE.Services
{
    public class ProductService
    {
        AppRest _product = new AppRest();
        ProductRepository _repository = new ProductRepository();

        public Product Get(string projectId, int page, int perPage)
        {
            return _product.Client.Get<Product>(string.Concat(Resources.APIProduct, "/?project=", projectId, "&page=", page, "&per_page=", perPage));
        }

        public int SaveHeader(Product product, string projectId, string projectName)
        {
            int productHeaderId = _repository.SaveHeader(product, projectId, projectName);
            return productHeaderId;
        }

        public void SaveDetail(int headerId, Product product)
        {
            _repository.SaveDetails(headerId, product.results);
        }

    }
}
