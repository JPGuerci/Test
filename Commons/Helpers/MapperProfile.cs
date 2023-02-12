using AutoMapper;
using Commons.Models.Area;
using Commons.Models.Incidencia;
using Commons.Models.Status;
using Repository.Models;

namespace Commons.Helpers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            #region Incidencia
            CreateMap<Issue, IncidenciaDto>().ReverseMap();
            CreateMap<IncidenciaInsertDto, Issue>().ReverseMap();
            #endregion
            #region Area
            CreateMap<Area, AreaDto>().ReverseMap();
            #endregion
            #region StatusIssue
            CreateMap<StatusIssue, StatusDto>().ReverseMap();
            #endregion
        }
    }
}
