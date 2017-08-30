using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VMTrail.Models
{
    public class Req
    {
        public List<Employeee> Employees { get; set; }

        public List<authuser> authusers { get; set; }
    }
}