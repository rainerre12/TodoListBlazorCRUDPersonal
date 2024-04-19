using Microsoft.EntityFrameworkCore;
using TodoListBlazorCRUD.Domain.Entities;

namespace TodoListBlazorCRUD.Infastructure.Context
{
    public class TodoListBlazorCRUDContext : DbContext
    {
        public TodoListBlazorCRUDContext(DbContextOptions<TodoListBlazorCRUDContext> options) : base(options)
        {
            
        }

        public DbSet<Objective> objectives { get; set; }
        public DbSet<Note> Notes { get; set; }
    }
}
