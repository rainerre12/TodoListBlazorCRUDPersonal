using System.ComponentModel.DataAnnotations;
using TodoListBlazorCRUD.Domain.Enum;

namespace TodoListBlazorCRUD.Domain.Entities
{
    public class Objective
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please provide a title")]
        [StringLength(50)]
        public string? Title { get; set; }

        [Required(ErrorMessage ="Please provide a due date")]
        public DateTime? DueDate { get; set; }

        [EnumDataType(typeof(Priority),ErrorMessage ="Please select a Priority")]
        public Priority Priority { get; set; }

        public bool IsDone { get; set; }
    }
}
