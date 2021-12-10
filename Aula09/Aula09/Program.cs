using Aula09.Controller;

namespace Aula09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductController productController = new();
            productController.List();
        }
    }
}
