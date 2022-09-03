using System.Threading.Tasks;
using System.Windows.Input;

namespace Pethome.ViewModels
{
    public interface IVMpatron
    {
        ICommand ProcesoAsyncommand { get; }
        ICommand ProcesoSimpcommand { get; }
        string Texto { get; set; }

        Task ProcesoAsyncrono();
        void ProcesoSimple();
    }
}