using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoService.DAL.Dtos
{
    public class AplicationsDto
    {
        public int Id {get; set;}
        public string URL { get; set;}
        public string ExecutorType { get; set;}
        public string CompanyTitle { get; set;}
        public int INN { get; set;}
        public int OGRN { get; set;}
        public bool IsDenied { get; set;}
        public string ReasonDenied { get; set;}
        public UsersDto Users { get; set;}
    }
}
