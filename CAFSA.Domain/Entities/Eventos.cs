

using CAFSA.Domain.BaseEntity;

namespace CAFSA.Domain.Entities
{
    public class Eventos : Base
    {
        public string? NameEvent { get; set; }
        public DateTime DateInitEvent { get; set; }
        public string? TypeEvent { get; set; }
    }
}
