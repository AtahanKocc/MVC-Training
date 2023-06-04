using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;

namespace DataAccessLayer.Concrete {
    public class WriterManager : IWriterService {

        // constructor metot olusturmalıyız
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal) {
            _writerDal = writerDal;
        }

        public Writer GetByID(int id) {
            return _writerDal.Get(x => x.WriterID == id);
        }

        public List<Writer> GetList() {
           return _writerDal.List();
        }

        public void WriterAdd(Writer writer) {
            _writerDal.Insert(writer);
        }

        public void WriterDelete(Writer writer) {
            _writerDal.Delete(writer);
        }

        public void WriterUpdate(Writer writer) {
            _writerDal.Update(writer);
        }
    }
}
