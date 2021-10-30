
namespace WikiAPI.Models
{
    public class Person
    {
        public int perId { get; set; }
        public string perName { get; set; }
        public string perLastname { get; set; }
        public int perCtyId { get; set; }
        public int perPetId { get; set; }

        public City city { get; set; }
        public PersonType personType { get; set; }
    }
}