using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LolProjectMobile2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppealsAdminEditPage : ContentPage
    {
        public AppealAdminVM AppealAdminVM { get; set; }
        public AppealsAdminEditPage(AppealAdminVM vm)
        {
            InitializeComponent();
            AppealAdminVM = vm;
            BindingContext = AppealAdminVM;
        }
    }
}