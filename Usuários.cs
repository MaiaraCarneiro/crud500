using CRUD.Models.Contexto;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    public class UsuariosController : Controller
    {

        private readonly Contexto _contexto;

        public UsuariosController(Contexto contexto)
       
        [HttpGet]
        public IActionResult Create()
        {
            var Usuario = new Personagem();

            return View(personagem);
        }

        [HttpPost]
        public IActionResult Create(Usuario personagem)
        {
            if (ModelState.IsValid)
            {
                _contexto.Usuario.Add(personagem);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(personagem);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var usuario = _contexto.Usuario.Find(Id);

            return View(personagem);
        }

        [HttpPost]
        public IActionResult Edit(Usuario personagem)
        {
            if (ModelState.IsValid)
            {
                _contexto.Usuario.Update(personagem);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View(usuario);
            }
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var usuario = _contexto.Usuario.Find(Id);

            return View(usuario);
        }

        [HttpPost]
        public IActionResult Delete(Usuario _personagem)
        {
            var personagem = _contexto.Usuario.Find(_personagem.Id);
            if (personagem != null)
            {
                _contexto.Usuario.Remove(personagem);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(personagem);
        }
    }
