using Talabat.Core.Entities;

namespace Talabat.APIs.Dtos
{
	public class ProductToReturnDto
	{
        public int Id { get; set; }
        public string Name { get; set; }
		public string Description { get; set; }
		public string PictureUrl { get; set; }
		public decimal Price { get; set; }

		public int ProductBrandId { get; set; }
		public string Brand { get; set; }

		public int ProductCategoryId { get; set; }
		public string Category { get; set; }
	}
}
