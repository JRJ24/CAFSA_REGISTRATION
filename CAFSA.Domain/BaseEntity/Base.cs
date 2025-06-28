

namespace CAFSA.Domain.BaseEntity
{
    public class Base
    {
        public required int Id { get; set; }    
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
    }
}
