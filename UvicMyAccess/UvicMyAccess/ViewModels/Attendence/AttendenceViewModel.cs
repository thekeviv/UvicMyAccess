using System;
using System.Collections.Generic;
using System.Text;

namespace UvicMyAccess.ViewModels
{
    public class AttendenceViewModel
    {
        private string userName;
        public string UserName { get { return userName; } }
        private bool classesRegistered = false;
        public bool ClassesRegistered { get { return classesRegistered; } }
        public AttendenceViewModel(string _userName)
        {
            userName = _userName;
        }
    }
}
