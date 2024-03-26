using PhotoService.DAL.DTO;

namespace PhotoService.BLL.Models.OutputModels;

public class ServiceOutputModel
{
    public int Id { get; set; }
    public UsersDto? Executor { get; set; }
    public TypesDto? Type { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Price { get; set; }
    public bool IsDeleted { get; set; }
    
    public string ExecutorName { get; set; }
    public string TypeName { get; set; }
}