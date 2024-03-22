namespace PhotoService.DAL.DTO;

public class ComplainsDto
{
    public int Id { get; set; }
    public UsersDto Author { get; set; }
    public string Complain { get; set; }
    public UsersDto Recipient { get; set; }
    public string Status { get; set; }
    public bool IsDeleted { get; set; }
}