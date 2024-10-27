namespace CRUDApiProject.Domain.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
