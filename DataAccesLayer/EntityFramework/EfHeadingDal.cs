﻿using DataAccesLayer.Abstract;
using DataAccesLayer.Concrate.Repositories;
using EntityLayer.Concrate;

namespace DataAccesLayer.EntityFramework
{
    public class EfHeadingDal : GenericRepository<Heading>, IHeadingDal
    {
    }
}
