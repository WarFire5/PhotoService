using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoService.DAL.Dtos
{
    public class ComplainsDto
    {
        public int Id { get; set; }
        public string Complein {  get; set; }
        public bool IsDelete { get; set; }
        public string Status { get; set; }
        public UsersDto Users { get; set; }
    }
}
