using System;

namespace StroyPlan.Core.Models
{
    public class Task
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now;

        public Priority Priority { get; set; } = Priority.Medium;
        public BuildStage Stage { get; set; } = BuildStage.Preparation;
        public TaskStatus Status { get; set; } = TaskStatus.New;

       
        public Guid AssigneeId { get; set; } 
        public Guid ObjectId { get; set; }   
    }
}