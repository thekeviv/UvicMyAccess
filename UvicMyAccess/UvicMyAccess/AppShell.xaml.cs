﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;
using UvicMyAccess.Views;

namespace UvicMyAccess
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        Dictionary<string, Type> routes = new Dictionary<string, Type>();
        public Dictionary<string, Type> Routes { get { return routes; } }
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
            BindingContext = this;
        }

        void RegisterRoutes()
        {
            routes.Add("loginpage", typeof(LoginPage));
            routes.Add("attendencehomepage", typeof(AttendenceHomePage));
            routes.Add("attendencecreatenewclass", typeof(CreateNewClass));
            routes.Add("attendencejoinnewclass", typeof(JoinNewClass));
            foreach (var item in routes)
            {
                Routing.RegisterRoute(item.Key, item.Value);
            }
        }
    }
}
