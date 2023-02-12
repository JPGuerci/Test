namespace Commons.Models.Incidencia
{
    public class IncidenciaInsertDto
    {
        public string AreaId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string CreateUserId { get; set; } = null!;
    }
}
