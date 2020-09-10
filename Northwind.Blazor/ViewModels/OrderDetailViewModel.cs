namespace Northwind.Blazor.ViewModels
{
    public class OrderDetailViewModel
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }

        public decimal Total
        {
            get
            {
                var total = UnitPrice * Quantity;

                if(Discount > 0)
                {
                    total *= (decimal) Discount;
                }

                return total;
            }
        }
    }
}
