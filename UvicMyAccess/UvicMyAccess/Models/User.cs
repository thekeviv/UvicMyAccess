using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace UvicMyAccess.Models
{
    public class User:Base
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int StudentId { get; set; }

        public enum TypeOfUser { Student = 1, Instructor = 2 }

        public TypeOfUser UserType { get; set; }
    }
}
