using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace UvicMyAccess.Models
{
    public class Class:Base
    {
        public string ClassName { get; set; }
        public DateTime ClassStartDate { get; set; }
        public DateTime ClassEndDate { get; set; }
        public Dictionary<DateTime, List<SpecialDateInfo>> SpecialDates { get; set; }
    }

    public class SpecialDateInfo
    {
        public enum SpecialDateType { Holiday = 0, Exam = 1, Other = 4 }
        public SpecialDateType Type { get; set; }
        public string Description { get; set; }

    }
}
