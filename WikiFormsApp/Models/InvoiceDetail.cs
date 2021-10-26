
namespace WikiAPI.Models
{
    public class InvoiceDetail
    {
        public int detId { get; set; }
        public Product product { get; set; }
        public decimal detQuantity { get; set; }
        public decimal detTotal { get; set; }
    }
}