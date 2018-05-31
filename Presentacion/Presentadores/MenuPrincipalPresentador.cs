using Presentacion.Interfaces;

namespace Presentacion.Presentadores
{
    public class MenuPrincipalPresentador : IPresenter<IMenuPrincipal>
    {
        private IMenuPrincipal _view;

        public void SetView(IMenuPrincipal view)
        {
            _view = view;
        }
    }
}
