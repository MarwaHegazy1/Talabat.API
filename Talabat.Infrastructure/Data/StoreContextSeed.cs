using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Talabat.Core.Entities;

namespace Talabat.Infrastructure.Data
{
	public static class StoreContextSeed
	{
		public async static Task SeedAsyunc(StoreContext _dbContext)
		{
			if (!_dbContext.ProductBrands.Any())
			{
				var brandsData = File.ReadAllText("../Talabat.Infrastructure/Data/DataSeed/brands.json");
				var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);

				if (brands?.Count > 0)
				{
					foreach (var brand in brands)
					{
						{
							_dbContext.Set<ProductBrand>().Add(brand);
						}
						await _dbContext.SaveChangesAsync();
					}
				}
			}

			if (!_dbContext.ProductCategories.Any())
			{
				var categoriesData = File.ReadAllText("../Talabat.Infrastructure/Data/DataSeed/categories.json");
				var categories = JsonSerializer.Deserialize<List<ProductCategory>>(categoriesData);

				if (categories?.Count > 0)
				{
					foreach (var category in categories)
					{
						{
							_dbContext.Set<ProductCategory>().Add(category);
						}
						await _dbContext.SaveChangesAsync();
					}
				}
			}

			if (!_dbContext.Products.Any())
			{
				var ProductsData = File.ReadAllText("../Talabat.Infrastructure/Data/DataSeed/products.json");
				var Products = JsonSerializer.Deserialize<List<Product>>(ProductsData);

				if (Products?.Count > 0)
				{
					foreach (var Product in Products)
					{
						{
							_dbContext.Set<Product>().Add(Product);
						}
						await _dbContext.SaveChangesAsync();
					}
				}
			}
		}
	}
}
