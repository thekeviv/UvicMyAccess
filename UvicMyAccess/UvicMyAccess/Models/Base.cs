using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace UvicMyAccess.Models
{
    public class Base
    {
        [PrimaryKey, AutoIncrement]
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }

        public Base()
        {
            this.Id = Guid.NewGuid();
        }
    }
}
