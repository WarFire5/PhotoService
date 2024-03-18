using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoService.DAL.Dtos
{
    public class TypesDto
    {
        public int Id{ get; set; }
        public string Title { get; set; }
        public bool IsDelete { get; set; }
        public List<ServicesDto> Services { get; set; }
        public UsersDto Users { get; set; }
    }
}
