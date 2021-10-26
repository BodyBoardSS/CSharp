
namespace WikiAPI.Models
{
    public class Address
    {
        public int addId { get; set; }

        public string address { get; set; }
        
        
        public Person person { get; set; }
    }
}