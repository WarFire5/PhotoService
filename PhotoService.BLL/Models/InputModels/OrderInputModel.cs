namespace PhotoService.BLL.Models.InputModels;

public class OrderInputModel
{
   public int CustomerId { get; set; }
   
   public string? СreationDate { get; set; }
   
   public string? Comment { get; set; }
   
   public int ServiceId { get; set; }
   
   public string? Status { get; set; }
   
}