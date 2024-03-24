using PhotoService.DAL.DTO;

namespace PhotoService.BLL.IClients;

public interface IRoleClient
{
    public RolesDto GetRoleByEmail(string mail);
}