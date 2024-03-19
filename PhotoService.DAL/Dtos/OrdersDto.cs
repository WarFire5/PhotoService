namespace PhotoService.DAL.DTO;

public class OrdersDto
{
    public int Id { get; set; }
    public UsersDto Customer { get; set; }
    public DateTime CreationDate { get; set; }
    public string Comment { get; set; }
    public ServicesDto Service { get; set; }
    public string? CanceledReason { get; set; }
    public string Status { get; set; }
    public bool IsDeleted { get; set; }
}