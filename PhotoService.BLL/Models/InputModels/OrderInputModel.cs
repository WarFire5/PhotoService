using PhotoService.DAL.DTO;

namespace PhotoService.BLL.Models.InputModels;

public class OrderInputModel
{
    public int Id { get; set; }
    public UsersDto Customer { get; set; }
    public DateTime CreationDate { get; set; }
    public string Comment { get; set; }
    public ServicesDto Service { get; set; }
    public int ServiceId { get; set; }
    public string? CanceledReason { get; set; }
    public string Status { get; set; }
    public bool IsDeleted { get; set; }
}