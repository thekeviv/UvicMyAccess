using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace UvicMyAccess.Models
{
    public class Attendence:Base
    {
        public Guid StudentId { get; set; }
        public Guid ClassId { get; set; }
        public DateTime Date { get; set; }

    }
}
