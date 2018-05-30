using Datos;
using Dominio.Repositorios;
using Presentacion.Interfaces;
using Presentacion.Presentadores;
using Presentacion.Vistas;
using System;
using Transversal.IoC;
using Unity;
using Unity.Lifetime;

namespace Presentacion.IoC
{
    public class IoCUnityContainer : IContainer, IDisposable
    {
        bool _disposed;
        private IUnityContainer _container;

        #region Constructors
        public IoCUnityContainer()
        {
            ConfigureContainer();
        }

        private void ConfigureContainer()
        {
            _container = new UnityContainer();
            _container.RegisterType<IniciarSesionPresentador>();
            _container.RegisterType<IIniciarSesion, IniciarSesionView>();
            _container.RegisterType(typeof(IRepository<>), typeof(Repository<>), new ContainerControlledLifetimeManager());
        }
        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                if (_container != null)
                    _container.Dispose();
            }

            _disposed = true;
        }

        #endregion

        #region IContainers Methods
        public void RegisterType(Type type)
        {
            _container.RegisterType(type);
        }

        public TService Resolve<TService>()
        {
            return _container.Resolve<TService>();
        }

        public object Resolve(Type type)
        {
            return _container.Resolve(type);
        }
        #endregion
    }
}
