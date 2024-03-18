using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoService.DAL.Dtos
{
    public class UsersDto
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public int Phone { get; set; }
        public string Dossier { get; set; }
        public int Rating { get; set; }
        public bool IsBlocked { get; set; }
        public bool IsDelete { get; set; }
        public RolesDto Roles { get; set; }
        public AplicationsDto Aplications { get; set; }
        public List<ServicesDto> Services { get; set; }
        public List<OrdersDto> Orders { get; set; }
        public List<ComplainsDto>Complains { get; set; }
        public TypesDto Types { get; set; }
    }
}
