namespace PhotoService.DAL.DTO;

public class ServicesDto
{
    public int Id { get; set; }
    public UsersDto? Executor { get; set; }
    public TypesDto? Type { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Price { get; set; }
    public bool IsDeleted { get; set; }
}