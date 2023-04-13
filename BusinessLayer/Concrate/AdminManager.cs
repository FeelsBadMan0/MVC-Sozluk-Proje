﻿using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Concrate
{
    public class AdminManager : IAdminService
    {
        IAdminDal _admindal;

        public AdminManager(IAdminDal admindal)
        {
            _admindal = admindal;
        }

        public void AdminAdd(Admin admin)
        {
            _admindal.Insert(admin);
        }

        public void AdminDelete(Admin admin)
        {
            throw new NotImplementedException();
        }

        public void AdminUpdate(Admin admin)
        {
            _admindal.Update(admin);
        }

        public Admin GetByID(int id)
        {
            return _admindal.Get(x => x.AdminID == id);
        }

        public List<Admin> GetList()
        {
            return _admindal.List();
        }
    }
}