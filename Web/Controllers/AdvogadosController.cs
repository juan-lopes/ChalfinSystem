using AutoMapper;
using Dominio.Advogado;
using Repositorio.Implementacao.Advogado;
using System.Collections.Generic;
using System.Web.Mvc;
using Web.ViewModels;

namespace Web.Controllers
{
    public class AdvogadosController : Controller
    {
        private readonly AdvogadoRepositorio<Advogado> _advogadoRepositorio = new AdvogadoRepositorio<Advogado>();

        // GET: Advogados
        public ActionResult Index()
        {
            var advogadoViewModel = Mapper.Map<IEnumerable<Advogado>, IEnumerable<AdvogadoViewModel>>(_advogadoRepositorio.ListarAdvogados());
            return View(advogadoViewModel);
        }

        // GET: Advogados/Details/5
        public ActionResult Details(int id)
        {
            var advogado = _advogadoRepositorio.SelecionarAdvogado(id);
            var advogadoViewModel = Mapper.Map<Advogado, AdvogadoViewModel>(advogado);
            return View(advogadoViewModel);
        }

        // GET: Advogados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Advogados/Create
        [HttpPost]
        public ActionResult Create(AdvogadoViewModel advogado)
        {
            if(ModelState.IsValid)
            {
                var advogadoDomain = Mapper.Map<AdvogadoViewModel, Advogado>(advogado);
                _advogadoRepositorio.AdicionarAdvogado(advogadoDomain);

                return RedirectToAction("Index");
            }
            return View(advogado);
        }

        // GET: Advogados/Edit/5
        public ActionResult Edit(int id)
        {
            var advogado = _advogadoRepositorio.SelecionarAdvogado(id);
            var advogadoViewModel = Mapper.Map<Advogado, AdvogadoViewModel>(advogado);
            return View(advogadoViewModel);
        }

        // POST: Advogados/Edit/5
        [HttpPost]
        public ActionResult Edit(AdvogadoViewModel advogado)
        {
            if (ModelState.IsValid)
            {
                var advogadoDomain = Mapper.Map<AdvogadoViewModel, Advogado>(advogado);
                _advogadoRepositorio.AtualizarAdvogado(advogadoDomain);

                return RedirectToAction("Index");
            }
            return View(advogado);
        }

        // GET: Advogados/Delete/5
        public ActionResult Delete(int id)
        {
            var advogado = _advogadoRepositorio.SelecionarAdvogado(id);
            var advogadoViewModel = Mapper.Map<Advogado, AdvogadoViewModel>(advogado);
            return View(advogadoViewModel);
        }

        // POST: Advogados/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var advogado = _advogadoRepositorio.SelecionarAdvogado(id);
            _advogadoRepositorio.ExcluirAdvogado(advogado);

            return RedirectToAction("Index");
        }
    }
}
