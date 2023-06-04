using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract {
    public interface IRepository <T> {
        List<T> List(); // T den gelen degeri listele
        void Insert(T p);
       
        //sildirecegimiz degeri bulduracagız
        T Get(Expression<Func<T, bool>> filter);  
        void Update(T p);
        void Delete(T p);

        // sartlı listeleme icin metot
        List<T> List(Expression<Func<T,bool>> filter ); // benim istedigim ifadedeki degerleri getirecek
    }
}
