using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Paqueteria.ViewModels
{
    public class ProgramarPedidoViewModel
    {
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [DisplayName("Descripciòn del pedido")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [DisplayName("Costo del pedido")]
        public float Costo { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Calle { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int Numero { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Colonia { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int Municipio { get; set; }
        public List<SelectListItem> Municipios { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int Id_repartidor { get; set; }
        public List<SelectListItem> Repartidores { get; set; }
        public int Estatus { get; set; }
    }
}
