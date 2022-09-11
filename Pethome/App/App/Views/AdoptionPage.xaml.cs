using Pethome.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pethome.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdoptionPage : ContentPage
    {
        public AdoptionPage()
        {
            InitializeComponent();
            BindingContext = new AdoptionPageViewModel(Navigation);
        }
        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {

        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}