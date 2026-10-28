namespace StroyPlan.Core.Models
{
    public enum TaskStatus
    {
        New,          
        InProgress,   
        OnReview,     
        Completed,    
        Postponed     
    }

    public enum Priority
    {
        High,         
        Medium,       
        Low           
    }

    public enum BuildStage
    {
        Preparation,  
        Foundation,   
        Walls,        
        Roof,         
        Finishing,    
        Engineering   
    }

    public enum UserRole
    {
        Worker,       
        Foreman,      
        Engineer,     
        Manager       
    }
}