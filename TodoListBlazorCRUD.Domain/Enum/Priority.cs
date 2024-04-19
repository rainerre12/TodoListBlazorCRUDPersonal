using System.Runtime.Serialization;

namespace TodoListBlazorCRUD.Domain.Enum
{
    public enum Priority
    {
        [EnumMember(Value = "Low Priority")]
        LowPriority = 1,

        [EnumMember(Value ="Middle Priority")]
        MiddlePriority,

        [EnumMember(Value = "High Priority")]
        HighPriority

    }
}
