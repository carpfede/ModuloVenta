using Aplicacion.Servicios;
using System.Collections.Generic;

namespace Presentacion.Dto

{
    public class CategoriaMenuDto
    {
        public string Nombre { get; set; }
        public List<MenuItemBase> Items { get; set; }

        public CategoriaMenuDto(string nombre, List<MenuItemBase> items)
        {
            Nombre = nombre;
            Items = items;
        }
    }
}
