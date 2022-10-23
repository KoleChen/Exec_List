using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_List
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Product> product = new List<Product>
			{
				new Product{ ProductId = 1, ProductName = "糖果", ProductPrice = 10, ProductNumber = 10},
				new Product{ ProductId = 2, ProductName = "餅乾", ProductPrice = 20, ProductNumber = 15}
			};

			product.Add(new Product { ProductId = 3, ProductName = "巧克力", ProductPrice = 30, ProductNumber = 20 });

			Console.WriteLine("您購買的商品為:");

			foreach (var a in product)
			{
				Console.WriteLine($"{a.ProductId}. {a.ProductName} {a.ProductPrice}元 {a.ProductNumber}個");
			}
		}
	}
	class Product
	{
		public int ProductId 
		{ 
			get;
			set; 
		}
		public string ProductName 
		{ 
			get; 
			set; 
		}
		public decimal ProductPrice 
		{ 
			get; 
			set; 
		}
		public int ProductNumber 
		{ 
			get; 
			set; 
		}
	}
}
