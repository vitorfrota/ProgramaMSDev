using System.Collections.Generic;
using System.IO;

namespace Aula09.Model
{
    internal class Product
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        private const string Path = "Database/Produto.csv";

        public Product() // construtor da classe
        {
            string folder = Path.Split('/')[0];

            if (!Directory.Exists(folder))
            { // se o diretório não existir, cria um
                Directory.CreateDirectory(folder);
            }

            if (!File.Exists(Path)) // se o arquivo não existir
            {
                File.Create(Path);
            }
        }

          public List<Product> List()
        {
            List<Product> Products = new();

            string[] rows = File.ReadAllLines(Path);

            foreach (string row in rows)
            {
                string[] properties = row.Split(';');

                Product product = new();
                product.Code = int.Parse(properties[0]);
                product.Name = properties[1];
                product.Price = float.Parse(properties[2]);

                Products.Add(product);
            }

            return Products;
        }
    }
}
