namespace PhotoService.BLL.Models.OutputModels;

public class OrderOutputModel
{
    public int Id { get; set; }
    
    public int CustomerId { get; set; }
   
    public string? СreationDate { get; set; }
   
    public string? Comment { get; set; }
   
    public int ServiceId { get; set; }
   
    public string? Status { get; set; }
}