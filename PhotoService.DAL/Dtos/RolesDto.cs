using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoService.DAL.Dtos
{
    public class RolesDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<UsersDto> Users { get; set; }
    }
}
