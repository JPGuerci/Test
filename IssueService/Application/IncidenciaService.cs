using AutoMapper;
using Commons.Models.Area;
using Commons.Models.Incidencia;
using Commons.Models.Status;
using Repository.Interface.Common;
using Repository.Models;

namespace IncidenciaService.Application
{
    public class IncidenciaService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public IncidenciaService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IncidenciaDto GetById(string Id)
        {
            Issue Incidencia = _unitOfWork.Repository<Issue>().GetByIdAsync(Id);
            IncidenciaDto Result = _mapper.Map<IncidenciaDto>(Incidencia);
            Result.Area= _mapper.Map<AreaDto>(Incidencia.Area); 
            Result.Status= _mapper.Map<StatusDto>(Incidencia.Status);
            return Result;
        }
        public string Add(IncidenciaInsertDto Issue)
        {
            Issue NewIncidencia = _mapper.Map<Issue>(Issue);
            NewIncidencia.Id = Guid.NewGuid().ToString();
            NewIncidencia.DateCreate = DateTime.Now;
            NewIncidencia.StatusId = "Test";//REVISAR

            _unitOfWork.Repository<Issue>().AddAsync(NewIncidencia);

            return NewIncidencia.Id;
        }
        public void Update(IncidenciaUpdateDto Issue)
        {
            Issue IncidenciaToUpdate = _unitOfWork.Repository<Issue>().GetByIdAsync(Issue.Id);
            IncidenciaToUpdate.Name= Issue.Name;
            IncidenciaToUpdate.Description=Issue.Description;
            IncidenciaToUpdate.StatusId = Issue.StatusId;

            _unitOfWork.Repository<Issue>().UpdateAsync(IncidenciaToUpdate);
        }
        public void Delete(string Id)
        {
            Issue IncidenciaToDelete = _unitOfWork.Repository<Issue>().GetByIdAsync(Id);
            _unitOfWork.Repository<Issue>().DeleteAsync(IncidenciaToDelete);
        }
    }
}
