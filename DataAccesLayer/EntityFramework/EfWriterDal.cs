using DataAccesLayer.Abstract;
using DataAccesLayer.Concrate.Repositories;
using EntityLayer.Concrate;

namespace DataAccesLayer.EntityFramework
{
    public class EfWriterDal : GenericRepository<Writer>, IWriterDal
    {
    }
}
