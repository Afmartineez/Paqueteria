using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Paqueteria.Models;
using Paqueteria.Models.dbModels;
using Paqueteria.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Paqueteria.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly paqueteriaContext _dbcontext;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ILogger<HomeController> logger, paqueteriaContext dbcontext, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _dbcontext = dbcontext;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> PedidosPendientes()
        {
            ApplicationUser user = await _userManager.GetUserAsync(User);
            List<Vpedido> pedidos = _dbcontext.Vpedidos.Where(x => x.IdVendedor == user.Id && x.Estatus <= 2).ToList();
            PedidosPendientesViewModel ppvm = new PedidosPendientesViewModel
            {
                Pendientes = pedidos
            };
            return View(ppvm);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> cambiarEstatus([FromBody] PedidoEstatus pedido)
        {
            Pedido ped = _dbcontext.Pedidos.Find(pedido.idpedido);
            if (ped == null)
            {
                return BadRequest("No existe el pedido");
            }
            Estatus est = _dbcontext.Estatuses.Find(pedido.estatus);
            if (est == null)
            {
                return BadRequest("No existe el estatus");
            }

            try
            {
                ped.Estatus = pedido.estatus;
                _dbcontext.Update(ped);
                await _dbcontext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }

            return Ok();
        }

        [Authorize]

        public async Task<IActionResult> Historial()
        {
            ApplicationUser user = await _userManager.GetUserAsync(User);
            List<Vpedido> historial = _dbcontext.Vpedidos.Where(x => x.IdVendedor == user.Id && x.Estatus > 2).ToList();
            PedidosPendientesViewModel ppvm = new PedidosPendientesViewModel
            {
                Pendientes = historial
            };
            return View(ppvm);
        }

        [HttpDelete]
        [Authorize]
        public async Task<IActionResult> eliminarHistorial()
        {
            ApplicationUser user = await _userManager.GetUserAsync(User);
            List<Pedido> historial = _dbcontext.Pedidos.Where(x => x.IdVendedor == user.Id && x.Estatus > 2).ToList();
             _dbcontext.RemoveRange(historial);
            await _dbcontext.SaveChangesAsync();
            return Ok("Tu historial se ha eliminado");
        }


        [Authorize]

        public IActionResult ProgramarPedido()
        {
            List<Municipio> Municipios = _dbcontext.Municipios.ToList();
            List<SelectListItem> lstMunicipios = new List<SelectListItem>();

            foreach (Municipio mun in Municipios)
            {
                lstMunicipios.Add(new SelectListItem { Value = mun.IdMunicipio.ToString(), Text = mun.Descripcion });
            };

            List<Repartidore> Repartidores = _dbcontext.Repartidores.ToList();
            List<SelectListItem> lstRepartidores = new List<SelectListItem>();

            foreach (Repartidore rep in Repartidores)
            {
                lstRepartidores.Add(new SelectListItem { Value = rep.IdRepartidor.ToString(), Text = rep.IdRepartidor.ToString() + " " + rep.Nombre + " " + rep.Paterno + " " + rep.Materno });
            };

            ProgramarPedidoViewModel ppvm = new ProgramarPedidoViewModel
            {
                Municipios = lstMunicipios,
                Repartidores = lstRepartidores,

            };
            return View(ppvm);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> ProgramarPedido(ProgramarPedidoViewModel ppvm)
        {
            bool programado = false;
            if (ModelState.IsValid)
            {
                try
                {
                    ApplicationUser user = await _userManager.GetUserAsync(User);
                    if (user != null)
                    {
                        Pedido pedido = new Pedido
                        {
                            Descripcion = ppvm.Descripcion,
                            Costo = ppvm.Costo,
                            Calle = ppvm.Calle,
                            Numero = ppvm.Numero,
                            Colonia = ppvm.Colonia,
                            Municipio = ppvm.Municipio,
                            IdVendedor = user.Id,
                            IdRepartidor = ppvm.Id_repartidor,
                            Estatus = 1
                        };

                        _dbcontext.Pedidos.Add(pedido);
                        _dbcontext.SaveChanges();
                         programado = true;
                    }
                }
                catch (Exception e)
                {
                    return StatusCode(500, e.Message);
                }

                return RedirectToAction(nameof(ProgramarPedido));
            }
            else
            {
                return RedirectToAction(nameof(ProgramarPedido));
            };


            return View(ppvm);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
