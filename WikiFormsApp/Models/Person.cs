
namespace WikiAPI.Models
{
    public class Person
    {
        public int perId { get; set; }
        public string perName { get; set; }
        public string perLastname { get; set; }
        public Document document { get; set; }
    }
}