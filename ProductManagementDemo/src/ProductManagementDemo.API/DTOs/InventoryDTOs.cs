namespace ProductManagementDemo.API.DTOs
{
    public class InventoryStatusDto
    {
        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public bool InStock => Quantity > 0;
    }
}
