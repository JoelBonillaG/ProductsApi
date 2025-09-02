namespace ProductsApi.DTOs
{
    public class CreateProductDto
    {
        public required string Name { get; set; }
        public required decimal Price { get; set; }
        public required bool IsAvailable { get; set; }
    }

}
