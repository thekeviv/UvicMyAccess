using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace UvicMyAccess.Models
{
    public class UserClass:Base
    {
        public Guid UserId { get; set; }

        public Guid ClassId { get; set; }
    }
}
