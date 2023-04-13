using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccesLayer.Abstract
{
    public interface IRepository<T>
    {
        //Doğru kullanım <T> burada verdiğimiz Entity clasını gösteriyor. Tüm Entityler için teker teker Interface yazmamıza gerek kalmıyor
        List<T> List();

        void Insert(T p);

        T Get(Expression<Func<T, bool>> filter);

        void Delete(T p);

        void Update(T p);

        List<T> List(Expression<Func<T, bool>> filter);
    }
}
