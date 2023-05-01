using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete {
    public class Context: DbContext {
        // prop tanımla, birer tablo olarak sql de karsilik bulsun
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}
// Context sınıfı ne yapacak: buraya yazılmış Dbset türündeki türleri sql e tablo olarak yansıtacak.
