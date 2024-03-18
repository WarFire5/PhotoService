using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoService.DAL.Dtos
{
    public class ServicesDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsDelete { get; set; }
        public OrdersDto Orders { get; set; }
        public UsersDto Users { get; set; }
        public TypesDto Types { get; set; }
    }

}
