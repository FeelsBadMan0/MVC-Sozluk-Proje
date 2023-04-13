using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrate;
using System.Collections.Generic;

namespace BusinessLayer.Concrate
{
    public class MessageManeger : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManeger(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public Message GetByID(int id)
        {
            return _messageDal.Get(x => x.MessageID == id);
        }

        public List<Message> GetListInbox(string p)
        {
            return _messageDal.List(x => x.ReceiverMail == p);
        }

        public List<Message> GetListSendbox(string p)
        {
            return _messageDal.List(x => x.SenderMail == p);
        }

        public void MessageAdd(Message message)
        {
            _messageDal.Insert(message);
        }

        public void MessageDelete(Message message)
        {
            throw new System.NotImplementedException();
        }

        public void MessageUpdate(Message message)
        {
            throw new System.NotImplementedException();
        }
    }
}
