using System.ComponentModel.DataAnnotations;
using TodoListBlazorCRUD.Domain.Enum;

namespace TodoListBlazorCRUD.Domain.Entities
{
    public class Note
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        [Required]
        [StringLength(100)]
        public string? Description { get; set; }
        public bool IsDeleted { get; set; }
        Priority Priority { get; set; }
    }
}
