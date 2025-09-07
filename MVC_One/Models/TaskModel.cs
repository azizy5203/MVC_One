using MVC_One.Enums;
namespace MVC_One.Models;
public class TaskModel
{
    public int Id { get; set; }
    public string Name { get; set; } = "New Task Default Name";
    public int Progress { get; set; } = 0;
    public EnumTaskStatus Status
    {
        get
        {
            if (Progress == 0) return EnumTaskStatus.New;
            else if (Progress > 0 && Progress < 100) return EnumTaskStatus.InProgress;
            else if (Progress == 100) return EnumTaskStatus.Completed;
            else return EnumTaskStatus.Pending;
        }

        set { }
    }

    public bool IsOverdue { get; set; } = false;

}
