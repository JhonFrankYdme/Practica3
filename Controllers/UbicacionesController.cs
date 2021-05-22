using Microsoft.AspNetCore.Mvc;
using pokemon001.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace pokemon001.Controllers
{
    public class UbicacionesController : Controller
    {
        private readonly PokemonContext _context;
        public UbicacionesController(PokemonContext context) {
            _context = context;
        }

        public IActionResult Regiones() {
            var regiones = _context.Regiones.Include(x => x.Pueblos).OrderBy(r => r.Nombre).ToList();
            return View(regiones);
        }

        public IActionResult Pueblos() {
            var pueblos = _context.Pueblos.Include(x => x.Region).OrderBy(r => r.Nombre).ToList();
            return View(pueblos);
        }

        public IActionResult Entrenadores() {
            var entrenadores = _context.Entrenadores.Include(x => x.Pueblo).OrderBy(r => r.Nombre).ToList();
            return View(entrenadores);
        }

        public IActionResult NuevoPueblo() {
            ViewBag.Regiones = _context.Regiones.ToList().Select(r => new SelectListItem(r.Nombre, r.Id.ToString()));
            return View();
        }

        [HttpPost]
        public IActionResult NuevoPueblo(Pueblo r) {
            if (ModelState.IsValid) {
                _context.Add(r);
                _context.SaveChanges();
                return RedirectToAction("NuevoPuebloConfirmacion");
            }
            return View(r);
        }

        public IActionResult NuevoPuebloConfirmacion() {
            return View();
        }

        public IActionResult NuevaRegion() {
            return View();
        }

        [HttpPost]
        public IActionResult NuevaRegion(Region r) {
            if (ModelState.IsValid) {
                _context.Add(r);
                _context.SaveChanges();
                return RedirectToAction("NuevaRegionConfirmacion");
            }
            return View(r);
        }

        public IActionResult NuevaRegionConfirmacion() {
            return View();
        }

        [HttpPost]
        public IActionResult BorrarRegion(int id) {
            var region = _context.Regiones.Find(id);
            _context.Remove(region);
            _context.SaveChanges();

            return RedirectToAction("Regiones");
        }

        public IActionResult BorrarPueblo(int id) {
            var pueblo = _context.Pueblos.Find(id);
            _context.Remove(pueblo);
            _context.SaveChanges();

            return RedirectToAction("Pueblos");
        }



        public IActionResult BorrarEntrenador(int id) {
            var entrenador = _context.Entrenadores.Find(id);
            _context.Remove(entrenador);
            _context.SaveChanges();

            return RedirectToAction("Entrenadores");
        }



        public IActionResult EditarRegion(int id) {
            var region = _context.Regiones.Find(id);
            return View(region);
        }

        [HttpPost]
        public IActionResult EditarRegion(Region r) {
            if (ModelState.IsValid) {
                var region = _context.Regiones.Find(r.Id);
                region.Nombre = r.Nombre;
                _context.SaveChanges();
                return RedirectToAction("EditarRegionConfirmacion");
            }
            return View(r);
        }

        public IActionResult EditarRegionConfirmacion() {
            return View();
        }






//--------------


 public IActionResult EditarPueblo(int id) {
            var pueblo = _context.Pueblos.Find(id);
            return View(pueblo);
        }

        [HttpPost]
        public IActionResult EditarPueblo(Pueblo r) {
            if (ModelState.IsValid) {
                var pueblo = _context.Pueblos.Find(r.Id);
                pueblo.Nombre = r.Nombre;
                _context.SaveChanges();
                return RedirectToAction("EditarPuebloConfirmacion");
            }
            return View(r);
        }

        public IActionResult EditarPuebloConfirmacion() {
            return View();
        }





        public IActionResult NuevoEntrenador() {
            ViewBag.Pueblos = _context.Pueblos.ToList().Select(r => new SelectListItem(r.Nombre, r.Id.ToString()));
            return View();
        }

        [HttpPost]
        public IActionResult NuevoEntrenador(Entrenador r) {
            if (ModelState.IsValid) {
                _context.Add(r);
                _context.SaveChanges();
                return RedirectToAction("NuevoEntrenadorConfirmacion");
            }
            return View(r);
        }

        public IActionResult NuevoEntrenadorConfirmacion() {
            return View();
        }



public IActionResult EditarEntrenador(int id) {
            var entrenador = _context.Entrenadores.Find(id);
            return View(entrenador);
        }

        [HttpPost]
        public IActionResult EditarEntrenador(Entrenador r) {
            if (ModelState.IsValid) {
                var entrenador = _context.Entrenadores.Find(r.Id);
                entrenador.Nombre = r.Nombre;
                _context.SaveChanges();
                return RedirectToAction("EditarEntrenadorConfirmacion");
            }
            return View(r);
        }

        public IActionResult EditarEntrenadorConfirmacion() {
            return View();
        }








        
    }
}