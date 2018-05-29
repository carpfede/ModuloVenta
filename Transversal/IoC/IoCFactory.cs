using System;

namespace Transversal.IoC
{
    /// <summary>
    /// IoCFactory  implementation 
    /// </summary>
    public sealed class IoCFactory
    {
        #region Singleton

        private readonly static Lazy<IoCFactory> _instance = new Lazy<IoCFactory>(() => new IoCFactory());

        /// <summary>
        /// Get singleton instance of IoCFactory
        /// </summary>
        public static IoCFactory Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        #endregion

        #region Members

        IContainer _CurrentContainer;

        /// <summary>
        /// Get current configured IContainer
        /// <remarks>
        /// At this moment only IoCUnityContainer existss
        /// </remarks>
        /// </summary>
        public IContainer CurrentContainer
        {
            get
            {
                if (_CurrentContainer == null)
                    throw new InvalidOperationException("Set the container before using");
                return _CurrentContainer;
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Only for singleton pattern, remove before field init IL anotation
        /// </summary>
        static IoCFactory() { }
        IoCFactory()
        {
           
        }

        public void SetContainer(IContainer container)
        {
            _CurrentContainer = container;
        }

        #endregion

    }
}
