
using CAFSA.Domain.BaseEntity;

namespace CAFSA.Domain.Entities
{
    public class Users : Base
    {
        public int? peopleID { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public bool IsAdmin { get; set; } = false;

        public Personas? Personas { get; set; }
    }
}
