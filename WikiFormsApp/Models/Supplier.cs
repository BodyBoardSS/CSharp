
namespace WikiAPI.Models
{
    public class Supplier
    {
        public int supId { get; set; }
        public string supTradename { get; set; }
        public int supPerId { get; set; }
        public Person person { get; set; }
    }
}