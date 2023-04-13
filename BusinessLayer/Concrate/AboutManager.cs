using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrate;
using System.Collections.Generic;

namespace BusinessLayer.Concrate
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void AboutAdd(About about)
        {
            _aboutDal.Insert(about);
        }

        public void AboutDelete(About about)
        {
            _aboutDal.Delete(about);
        }

        public void AboutUpdate(About about)
        {
            _aboutDal.Update(about);
        }

        public About GetByID(int id)
        {
            return _aboutDal.Get(x => x.AboutID == id);
        }

        public List<About> GetList()
        {
            return _aboutDal.List();
        }
    }
}
