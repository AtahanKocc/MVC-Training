using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract {
    public interface IWriterDal: IRepository<Writer> {

    }
}


/*
 * 
 IWriterDal adında bir arayüz tanımlar. Bu arayüz, Writer sınıfı nesneleri için veritabanı işlemleri yapmak için gereken yöntemleri içerir. 
 */