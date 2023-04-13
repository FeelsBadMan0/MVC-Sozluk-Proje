using EntityLayer.Concrate;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IImageFileService
    {
        List<ImageFile> GetList();
    }
}
