using DataAccesLayer.Abstract;
using DataAccesLayer.Concrate.Repositories;
using EntityLayer.Concrate;

namespace DataAccesLayer.EntityFramework
{
    public class EfAdminDal : GenericRepository<Admin>, IAdminDal
    {
    }
}
