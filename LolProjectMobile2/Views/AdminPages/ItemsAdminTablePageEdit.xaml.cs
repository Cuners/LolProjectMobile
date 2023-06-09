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
    public partial class ItemsAdminTablePageEdit : ContentPage
    {
        public ItemsAdminVM ItemsAdminVM { get; set; }
        public ItemsAdminTablePageEdit(ItemsAdminVM vM)
        {
            InitializeComponent();
            ItemsAdminVM = vM;
            BindingContext = ItemsAdminVM;
        }
    }
}