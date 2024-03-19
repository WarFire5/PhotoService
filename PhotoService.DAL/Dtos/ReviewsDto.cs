namespace PhotoService.DAL.DTO;

public class ReviewsDto
{
    public int Id { get; set; }
    public int Mark { get; set; }
    public string? Review { get; set; }
    public OrdersDto Order { get; set; }
    public string Status { get; set; }
    public bool IsDeleted { get; set; }
}