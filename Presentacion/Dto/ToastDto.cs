using Dominio.Enums;

namespace Presentacion.Dto
{
    public class ToastDto
    {
        public EToastColor Color { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
    }
}
