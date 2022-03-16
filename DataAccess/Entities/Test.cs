using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Test : BaseEntity
    {
        public Test()
        {
            CreatedAt = DateTime.Now;
        }
        public string Company { get; set; }
        public string Address { get; set; }
        public string ContactPerson { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Ssid { get; set; }
        public string Pass { get; set; }
        public string Network { get; set; }
    }
}
