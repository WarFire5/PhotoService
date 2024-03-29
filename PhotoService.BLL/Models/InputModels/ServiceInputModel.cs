using PhotoService.DAL.DTO;

namespace PhotoService.BLL.Models.InputModels;

public class ServiceInputModel
{
    public int Id { get; set; }
    public int ExecutorId { get; set; }
    public int Type { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Price { get; set; }
    public bool IsDeleted { get; set; }
    
    public string ExecutorName { get; set; }
    public string TypeName { get; set; }
    
}