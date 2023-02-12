using Commons.Models.Area;
using Commons.Models.Status;

namespace Commons.Models.Incidencia
{
    public class IncidenciaDto
    {
        public string Id { get; set; } = null!;
        public AreaDto Area{ get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string CreateUserId { get; set; } = null!;
        public DateTime DateCreate { get; set; }
        public StatusDto Status { get; set; } = null!;
    }
}
