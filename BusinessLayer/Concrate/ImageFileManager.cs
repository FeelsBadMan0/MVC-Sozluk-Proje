using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrate;
using System.Collections.Generic;

namespace BusinessLayer.Concrate
{
    public class ImageFileManager : IImageFileService
    {
        IImageFileDal _imagefileDal;

        public ImageFileManager(IImageFileDal imagefileDal)
        {
            _imagefileDal = imagefileDal;
        }

        public List<ImageFile> GetList()
        {
            return _imagefileDal.List();
        }
    }
}
