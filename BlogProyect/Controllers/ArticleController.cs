using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Model.Domain;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProyect.Controllers
{
    public class ArticleController : Controller
    {
        private IArticleTypeService _ArticleTypeService; 
        private IArticleService _ArticleService;
        public ArticleController(IArticleTypeService articleType, IArticleService articleService)
        {
            _ArticleTypeService = articleType;
            _ArticleService = articleService;
        }

        // GET: ArticleController
        public ActionResult Index()
        {
            return View(_ArticleService.Read());
        }

        public ActionResult Details(int id)
        {
            Article article = _ArticleService.Read(id);
            return View(article);
        }

        public ActionResult Create()
        {
            var articleTypes = _ArticleTypeService.Read();
            var selectListItem = new List<SelectListItem>(
                articleTypes.Select(
                    e => new SelectListItem { 
                        Text = e.Name,
                        Value = e.Id.ToString()
                    }
                )
            );
            ViewBag.ArticleTypes = new SelectList(selectListItem, "Value", "Text");

            return View();
        }

        // POST: ArticleController/Create
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(
            [Bind(new string[] { "Title", "Body", "ArticleTypeId" })] 
            Article entity
        )
        {
            entity.CreatedAt = DateTime.Now;    
            try
            {
                _ArticleService.Create(entity);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            Article article = _ArticleService.Read(id);
            var articleTypes = _ArticleTypeService.Read();
            var selectListItem = new List<SelectListItem>(
                articleTypes.Select(
                    e => new SelectListItem
                    {
                        Text = e.Name,
                        Value = e.Id.ToString()
                    }
                )
            );
            ViewBag.ArticleTypes = new SelectList(selectListItem, "Value", "Text");
            return View(article);
        }

        // POST: ArticleController/Edit/5
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, 
            [Bind(new string[] { "Id","Title", "Body", "ArticleTypeId" })] 
            Article entity
        )
        {
            try
            {
                _ArticleService.Update(entity, id);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // POST: ArticleController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _ArticleService.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Delete(int id)
        {
            Article article = _ArticleService.Read(id);
            return View(article);
        }
    }
}
