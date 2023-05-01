﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete {
    public class CategoryManager : ICategoryService {

        ICategoryDal _categoryDal; // fieldım var
        
        public CategoryManager(ICategoryDal categoryDal) { 
           _categoryDal= categoryDal;
        }

        public void CategoryAdd(Category category) {
            _categoryDal.Insert(category);
        }

        public List<Category> GetList() {
            return _categoryDal.List();
        }
    }
}


/* Sınıfın içinde, bir ICategoryDal nesnesi olan _categoryDal adlı bir alan (field) tanımlanır. CategoryManager sınıfı, ICategoryDal arayüzünü uygulayan nesneleri kullanarak kategori işlemlerini gerçekleştirecek.

Ardından, CategoryManager sınıfının kurucu yöntemi (constructor) tanımlanır ve bir ICategoryDal nesnesi alır. Kurucu yöntemi, _categoryDal alanını verilen ICategoryDal nesnesiyle başlatır.

GetList() yöntemi, ICategoryDal nesnesinin List() yöntemini çağırarak, tüm kategorilerin bir listesini döndürür. Bu yöntem, kategori listesi alma işlemini gerçekleştirir ve bu işlem, ICategoryService arayüzünü uygulayan bir sınıf için zorunlu olan bir yöntemdir.

Bu kodun amacı, 
kategori yönetimi işlemlerini gerçekleştirmek için bir CategoryManager sınıfı sağlamak 
ve bu işlemleri ICategoryDal arayüzünü uygulayan nesneler kullanarak yapmaktır. */
