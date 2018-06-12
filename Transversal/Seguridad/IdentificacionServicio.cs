namespace Transversal.Seguridad
{
    public class IdentificacionServicio
    {
        #region Singleton

        static IdentificacionServicio() { }

        private IdentificacionServicio() { }

        public static IdentificacionServicio Instance { get; } = new IdentificacionServicio();

        #endregion

        public IUsuarioPersonalizado UserIdentification { get; set; }

        public void SetUserIdentification(IUsuarioPersonalizado userIdentification)
        {
            UserIdentification = userIdentification;
        }

        public static IUsuarioPersonalizado User => Instance.UserIdentification;
    }
}
