using Presentacion.Interfaces;

namespace Presentacion.Presentadores
{
    public class MenuPrincipalPresentador
    {
        private readonly IMenuPrincipal _view;

        public MenuPrincipalPresentador(IMenuPrincipal view)
        {
            _view = view;
        }
    }
}
