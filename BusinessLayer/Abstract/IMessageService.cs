using EntityLayer.Concrate;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IMessageService
    {
        List<Message> GetListInbox(string p);

        List<Message> GetListSendbox(string P);

        void MessageAdd(Message message);

        Message GetByID(int id);

        void MessageDelete(Message message);

        void MessageUpdate(Message message);
    }
}
