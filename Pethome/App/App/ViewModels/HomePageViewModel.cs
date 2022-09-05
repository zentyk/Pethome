﻿using Pethome.Datos;
using Pethome.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Pethome.ViewModels
{
    public class HomePageViewModel : BaseViewModel
    {
        #region VARIABLES
        List<CarruselList> _listamusica;
        #endregion
        #region CONSTRUCTOR
        public HomePageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            MostrarMusica();
        }

        #endregion
        #region OBJETOS
        public List<CarruselList> Listamusica
        {
            get { return _listamusica; }
            set { SetValue(ref _listamusica, value); }
        }
        #endregion
        #region PROCESOS
        public async Task MostrarMusica()
        {
            var funcion = new DCarrousel();
            Listamusica = await funcion.adoption();
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        //public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}