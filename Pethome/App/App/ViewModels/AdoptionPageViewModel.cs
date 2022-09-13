using Pethome.Datos;
using Pethome.Models;
using Pethome.Views.Menu;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Pethome.ViewModels
{
    public class AdoptionPageViewModel : BaseViewModel
    {
        #region VARIABLES
        List<AdoptionList> _adoptionlist;
        #endregion
        #region CONSTRUCTOR
        public AdoptionPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            Adoption();
        }

        #endregion
        #region OBJETOS
        public List<AdoptionList> Adoptionlist
        {
            get { return _adoptionlist; }
            set { SetValue(ref _adoptionlist, value); }
        }
        #endregion
        #region PROCESOS
        private async Task Adoption()
        {
            var fun = new DAdoption();
            Adoptionlist = await fun.adoptionList();
        }

        public async Task ReturnCommand()
        {
            await Navigation.PopAsync();
        }
        //public void ProcesoSimple()
        //{

        //}
        #endregion
        #region COMANDOS
       
        //public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        public ICommand returncommand => new Command(async () => await ReturnCommand());
        #endregion
    }
}
