using Aula09.Model;
using System;
using System.Collections.Generic;

namespace Aula09.View
{
	internal class ProductView
	{
		 public void List(List<Product> products)
		{
			foreach (Product product in products)
			{
				Console.WriteLine($"Code: {product.Code}");
				Console.WriteLine($"Name: {product.Name}");
				Console.WriteLine($"Price: {product.Price}");
			}
		}
	}
}
