using EntityLayer.Concrate;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetList(string p);

        List<Content> GetList();

        List<Content> GetListByWriter(int id);

        List<Content> GetListByHeadingID(int id);

        void ContentAdd(Content content);

        Content GetByID(int id);

        void ContentDelete(Content content);

        void ContentUpdate(Content content);
    }
}
