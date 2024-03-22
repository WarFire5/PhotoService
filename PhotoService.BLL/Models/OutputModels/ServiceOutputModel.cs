namespace PhotoService.BLL.Models.OutputModels;

public class ServiceOutputModel
{
    public int Id { get; set; }
    
    public string? Name { get; set; }
    
    public string? Description { get; set; }
    
    public string? ExecutorName { get; set; } //Будут тянуться из списка Исполнителя
    
    public int Rating { get; set; } //Будут тянуться из Отзывов
    
    public string? ServiceType  { get; set; }
    
    public int Cost  { get; set; }
}