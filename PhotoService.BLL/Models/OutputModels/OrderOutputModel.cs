namespace PhotoService.BLL.Models.OutputModels;

public class OrderOutputModel
{
    public int Id { get; set; }
    
    public int CustomerId { get; set; }
   
    public DateTime? СreationDate { get; set; }
   
    public string? Comment { get; set; }
   
    public int ServiceId { get; set; }
   
    public string? Status { get; set; }
    
    public string? ServiceTitle { get; set; }
    public string? ExecutorName { get; set; }
    public string? ServicePrice { get; set; }
    public string? CancellationReason { get; set; }
    
}