using Pethome.Datos;
using Pethome.Models;
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
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
       
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
