
namespace WikiAPI.Models
{
    public class Supplier
    {
        public int supId { get; set; }
        public string supName { get; set; }
        public string supLasname { get; set; }
        public string supTradename { get; set; }
        public string supAddress { get; set; }
        public City city { get; set; }
        public Document document { get; set; }
    }
}