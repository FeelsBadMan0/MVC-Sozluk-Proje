using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrate;

namespace BusinessLayer.Concrate
{
    public class WriterLoginMenager : IWriterLoginService
    {
        IWriterDal _writerDal;

        public WriterLoginMenager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public Writer GetWriter(string username, string password)
        {
            return _writerDal.Get(x => x.WriterMail == username && x.WriterPassword == password);
        }
    }
}
