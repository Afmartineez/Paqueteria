using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Paqueteria.Models.dbModels
{
    public class ApplicationUser : IdentityUser<int>
    {
        public ApplicationUser()
        {
            Pedidos = new HashSet<Pedido>();

        }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public string Telefono { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        public string Colonia { get; set; }
        public int Municipio { get; set; }
        public int TipoUsuario { get; set; }

        [ForeignKey(nameof(Municipio))]
        [InverseProperty(nameof(dbModels.Municipio.Users))]
        public virtual Municipio MunicipioNavigation { get; set; }

        [InverseProperty(nameof(Pedido.IdVendedorNavigation))]
        public virtual ICollection<Pedido> Pedidos { get; set; }


    }
}
