namespace EdynamicsLog.Application.Features.Products.Queries.GetAllProductsBySearch
{
    public class GetAllProductsSearchViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MainImage { get; set; }
        public decimal Rate { get; set; }
        public decimal Price { get; set; }
        public decimal PriceDiscount { get; set; }
        public int DiscountPercentage { get; set; }
        public int IdCategory { get; set; }
        public int IdStore { get; set; }
        public int Stock { get; set; }
        public Domain.Common.Enums.Status Status { get; set; }
    }
}
