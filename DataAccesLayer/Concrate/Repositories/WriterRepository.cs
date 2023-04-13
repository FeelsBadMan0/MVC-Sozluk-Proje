using DataAccesLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccesLayer.Concrate.Repositories
{
    public class WriterRepository : IWriterDal
    {
        public void Delete(Writer p)
        {
            throw new NotImplementedException();
        }

        public Writer Get(Expression<Func<Writer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Writer p)
        {
            throw new NotImplementedException();
        }

        public List<Writer> List()
        {
            throw new NotImplementedException();
        }

        public List<Writer> List(Expression<Func<Writer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Writer p)
        {
            throw new NotImplementedException();
        }
    }
}
