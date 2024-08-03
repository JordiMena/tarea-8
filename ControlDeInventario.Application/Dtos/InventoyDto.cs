namespace ControlDelInventario.Application.Dtos
{
    public class InventoryDto : DtoBase
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
    }
}
