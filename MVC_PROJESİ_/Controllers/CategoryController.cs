using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityLayer.Concrete;
using DataAccessLayer.EntityFramework;
using BusinessLayer.FluentValidation;
using System.ComponentModel.DataAnnotations;
using FluentValidation.Results;


namespace MVC_PROJESİ_.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm = new CategoryManager(new EfCategoryDal()); // business layerdaki sınıfı cagirdik
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryList() 
            {
            var categoryvalues = cm.GetList();
            return View(categoryvalues); // view dondururken category icindeki degerleri getir
        }
        [HttpGet]
        public ActionResult AddCategory() {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category p) {
            // cm.CategoryAddBL(p);
            CategoryValidator categoryValidator = new CategoryValidator(); // categoryValidator isminde nesne türettim
            FluentValidation.Results.ValidationResult results = categoryValidator.Validate(p); // categoryValidator gelen bilgilere göre kontrol yap
            
            if (results.IsValid) { // results ın doğrulanmıs olması gerekir
                cm.CategoryAdd(p); // business layer
                return RedirectToAction("GetCategoryList"); // doğruysa getCategoryList aksiyonuna yonlendir
            } 
            else {
                foreach (var item in results.Errors) {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                    return View();
                }
            }
            return RedirectToAction("GetCategoryList"); // doğruysa getCategoryList aksiyonuna yonlendir
        }
    }
}