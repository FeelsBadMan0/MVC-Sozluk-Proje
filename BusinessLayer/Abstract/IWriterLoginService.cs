using EntityLayer.Concrate;

namespace BusinessLayer.Abstract
{
    public interface IWriterLoginService
    {
        Writer GetWriter(string username, string password);
    }
}
