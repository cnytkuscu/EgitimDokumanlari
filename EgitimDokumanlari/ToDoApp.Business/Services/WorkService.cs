using ToDoApp.Business.Interfaces;
using ToDoApp.DataAccess.UnitOfWork;
using ToDoApp.DTO.WorkDTOs;
using ToDoApp.Entities.Domains;

namespace ToDoApp.Business.Services
{
    public class WorkService : IWorkService
    {
        private readonly IUoW _uow;

        public WorkService(IUoW uow)
        {
            _uow = uow;
        }

        public async Task Create(WorkCreateDTO dto)
        {

            await _uow.GetRepository<Work>().Create(new()
            {
                Definition = dto.Definition,
                IsCompleted = dto.IsCompleted,
            });

            await _uow.SaveChanges();
        }

        public async Task<List<WorkListDTO>> GetAll()
        {
            var list = await _uow.GetRepository<Work>().GetAll();

            var workList = new List<WorkListDTO>();

            if (list != null && list.Count > 0)
            {
                foreach (var item in list)
                {
                    workList.Add(new()
                    {
                        Id = item.Id,
                        Definition = item.Definition,
                        IsCompleted = item.IsCompleted,
                    });
                }

            }

            return workList;

        }

        public async Task<WorkListDTO> GetById(object id)
        {
            var data = await _uow.GetRepository<Work>().GetById(id);
            return new()
            {
                Definition = data.Definition,
                Id = data.Id,
                IsCompleted = data.IsCompleted
            };
        }

        public async Task Remove(object id)
        {
            var data = await _uow.GetRepository<Work>().GetById(id);

            if (data != null) _uow.GetRepository<Work>().Remove(data);
            await _uow.SaveChanges();
        }

        public async Task Update(WorkUpdateDTO dto)
        {
            var data = await _uow.GetRepository<Work>().GetById(dto.Id);

            if (data != null) _uow.GetRepository<Work>().Update(data);
            await _uow.SaveChanges();
        }
    }
}
