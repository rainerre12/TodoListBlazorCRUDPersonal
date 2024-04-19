using Microsoft.EntityFrameworkCore;
using TodoListBlazorCRUD.Application.Interfaces;
using TodoListBlazorCRUD.Domain.Entities;
using TodoListBlazorCRUD.Infastructure.Context;

namespace TodoListBlazorCRUD.Infastructure.Repositories
{
    public class ObjectiveRepository : IObjectiveRepository
    {
        private readonly TodoListBlazorCRUDContext context;
        public ObjectiveRepository(IDbContextFactory<TodoListBlazorCRUDContext> factory)
        {
            context = factory.CreateDbContext();
        }

        public async Task AddAsync(Objective objective)
        {
            context.objectives.Add(objective);
            await context.SaveChangesAsync();
        }

        public async Task DeleteByIDAsync(int id)
        {
            var objective = await GetByIdAsync(id);
            if(objective is not null)
            {
                context.objectives.Remove(objective);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<Objective>> GetAllAsync()
        {
            var objectives = await context.objectives.ToListAsync();
            return objectives;
        }

        public async Task<Objective>? GetByIdAsync(int id)
        {
            var objectives = await context.objectives.FirstOrDefaultAsync(x => x.Id == id);
            return objectives;
        }

        public async Task UpdateAsync(Objective objective)
        {
            context.Entry(objective).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
    }
}
