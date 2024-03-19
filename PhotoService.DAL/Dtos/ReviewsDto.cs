using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoService.DAL.Dtos
{
    public class ReviewsDto
    {
        public int Id { get; set; }
        public int Mark { get; set;}
        public string Review {  get; set;}
        public bool IsDelete { get; set;}
        public string Status { get; set;}
        public OrdersDto Orders { get; set;}
    }
}
