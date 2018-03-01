using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductDemo.Data;

namespace ProductDemo.Controllers
{
    public class ProductsRepoController : Controller
    {
        private readonly IProductRepository _repo;

        public ProductsRepoController(IProductRepository repo)
        {
            _repo = repo;
        }
        // GET: ProductsRepo
        public async Task<ActionResult> Index()
        {
            return View(await _repo.GetProducts());
        }

        // GET: ProductsRepo/Details/5
        public async Task<ActionResult> Details(int id)
        {
            return View(await _repo.GetProduct(id));
        }

        // GET: ProductsRepo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductsRepo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsRepo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductsRepo/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsRepo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductsRepo/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}