using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoService.DAL.Dtos
{
    public class OrdersDto
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string Comment { get; set; }
        public bool IsDelete { get; set; }
        public string Status { get; set; }
        public ReviewsDto Reviews { get; set; }
        public ServicesDto Services { get; set; }
        public UsersDto Users { get; set; }
    }
}
