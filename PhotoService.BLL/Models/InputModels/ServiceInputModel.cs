namespace PhotoService.BLL.Models.InputModels;

public class ServiceInputModel
{
    public string? Name { get; set; }
    
    public string? Description { get; set; }
    
    public string? ExecutorName { get; set; }
    
    public int Rating { get; set; }
    
    public string? ServiceType  { get; set; }
    
    public int Cost  { get; set; }
    
}