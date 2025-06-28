using CAFSA.Domain.BaseEntity;

namespace CAFSA.Domain.Entities
{
    public class Personas : Base
    {
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? PhoneFathers { get; set; }
        public DateTime dateOfBirth { get; set; }
        public DateTime dateOfCongregation { get; set; } = DateTime.Now;

        public Users? Users { get; set; }
    }
}
