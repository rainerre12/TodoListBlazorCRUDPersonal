using System.ComponentModel.DataAnnotations;

namespace TodoListBlazorCRUD.Domain.Entities
{
    public class Objective
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? Title { get; set; }
        public DateTime? DueDate { get; set; }
        public int Priority { get; set; }
        public bool IsDone { get; set; }
    }
}
