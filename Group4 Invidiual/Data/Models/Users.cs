using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group4_Invidiual.Data.Models
{
    public class Users
    {
        public int AppUserid { get; set; }
        public bool IsHidden { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
