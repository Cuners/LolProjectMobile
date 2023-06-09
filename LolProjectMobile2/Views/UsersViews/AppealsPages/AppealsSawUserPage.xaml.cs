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
    public partial class AppealsSawUserPage : ContentPage
    {
        public AppealsSawUserPage()
        {
            InitializeComponent();
            BindingContext = new AppealUserVM() { Navigation = this.Navigation };
        }
    }
}