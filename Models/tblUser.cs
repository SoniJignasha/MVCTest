using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTest.Models
{
    public class tblUser
    {
        public int userId { get; set; }
        public string? userName { get; set; }
        public string? address { get; set; }
        public string?  email { get; set; }
        public string?  password { get; set; }
    }
}