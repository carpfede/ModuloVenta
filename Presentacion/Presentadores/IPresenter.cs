using Presentacion.Interfaces;

namespace Presentacion.Presentadores
{
    public interface IPresenter<TView>
        where TView : IView
    {
        void SetView(TView view);
    }
}