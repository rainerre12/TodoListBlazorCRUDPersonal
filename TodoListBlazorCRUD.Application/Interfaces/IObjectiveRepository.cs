using TodoListBlazorCRUD.Domain.Entities;

namespace TodoListBlazorCRUD.Application.Interfaces
{
    public interface IObjectiveRepository
    {
        Task AddAsync(Objective objective);

        Task<List<Objective>> GetAllAsync();

        Task<Objective>? GetByIdAsync(int id);

        Task UpdateAsync(Objective objective);

        Task DeleteByIDAsync(int id);
    }
}
