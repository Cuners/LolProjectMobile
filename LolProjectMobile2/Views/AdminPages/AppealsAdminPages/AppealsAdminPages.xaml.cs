﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LolProjectMobile2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppealsAdminPages : ContentPage
    {
        public AppealsAdminPages()
        {
            InitializeComponent();
            BindingContext = new AppealAdminVMList() { Navigation=this.Navigation};
        }
    }
}