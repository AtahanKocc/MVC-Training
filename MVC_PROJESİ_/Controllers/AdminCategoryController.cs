using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_PROJESİ_.Controllers
{
    public class AdminCategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        
        // GET: AdminCategory
        public ActionResult Index()
        {
            var categoryvalues = cm.GetList();
            return View(categoryvalues);
        }
        // yeni bir kategori eklemek için bir HTTP Get talebi için bir view'a yönlendirir. Bu view, kullanıcının yeni bir kategori eklemek için gerekli bilgileri girmesi için bir form sunar.
        [HttpGet]
        public ActionResult AddCategory() {
            return View();
        }
        // AddCategory metodu, yeni bir kategori eklemek için bir HTTP Post talebi alır. 
        [HttpPost]
        public ActionResult AddCategory(Category p) {
          CategoryValidator categoryvalidator = new CategoryValidator();
          ValidationResult results = categoryvalidator.Validate(p);
            if (results.IsValid) {
                cm.CategoryAdd(p);
                return RedirectToAction("Index");
            } 
            else {
                foreach (var item in results.Errors) {
                    ModelState.AddModelError(item.PropertyName,
                        item.ErrorMessage);
                }
            }
            return View();
        }
        public ActionResult DeleteCategory(int id) {
            var categoryvalue = cm.GetByID(id); // id e gore getir.   
            cm.CategoryDelete(categoryvalue);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditCategory(int id) {
            var categoryvalue = cm.GetByID(id);
            return View(categoryvalue);
        }
    }
}