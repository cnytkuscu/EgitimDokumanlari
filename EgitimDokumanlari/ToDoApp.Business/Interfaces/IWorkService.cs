using ToDoApp.DTO.WorkDTOs;

namespace ToDoApp.Business.Interfaces
{
    public interface IWorkService
    {
        Task<List<WorkListDTO>> GetAll();

        Task Create(WorkCreateDTO dto);

        Task<WorkListDTO> GetById(object id);

        Task Remove(object id);

        Task Update(WorkUpdateDTO dto);


    }
}
