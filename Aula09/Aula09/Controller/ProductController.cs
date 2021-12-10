using Aula09.Model;
using Aula09.View;

namespace Aula09.Controller
{
    internal class ProductController
    {
        public void List()
        {
            Product product = new();

            ProductView productView = new();
            productView.List(product.List());
        }
    }
}
