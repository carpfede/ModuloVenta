using Dominio.Enums;

namespace Dominio.Dto
{
    public class ToastDto
    {
        public EToastColor Color { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
    }
}
