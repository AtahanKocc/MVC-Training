﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract {
    public interface IWriterService {
        List<Writer> GetList();
        void WriterAdd(Writer writer); // Writer sınıfından writer parametresi alacaksın
        void WriterDelete(Writer writer);
        void WriterUpdate(Writer writer);

        Writer GetByID(int id);
    }
}
