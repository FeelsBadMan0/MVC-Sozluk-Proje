using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Concrate
{
    public class ContentManager : IContentService
    {
        IContentDal _contentdal;

        public ContentManager(IContentDal contentdal)
        {
            _contentdal = contentdal;
        }

        public void ContentAdd(Content content)
        {
            _contentdal.Insert(content);
        }

        public void ContentDelete(Content content)
        {
            throw new NotImplementedException();
        }

        public void ContentUpdate(Content content)
        {
            throw new NotImplementedException();
        }

        public Content GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Content> GetList(string p)
        {
            return _contentdal.List(x => x.ContentValue.Contains(p));
        }

        public List<Content> GetList()
        {
            return _contentdal.List();
        }

        public List<Content> GetListByHeadingID(int id)
        {
            return _contentdal.List(x => x.HeadingID == id);
        }

        public List<Content> GetListByWriter(int id)
        {
            return _contentdal.List(x => x.WriterID == id);
        }
    }
}
