using EntityLayer.Concrate;
using FluentValidation;

namespace BusinessLayer.ValidatoinRules
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı adresini Boş Geçemezsiniz");

            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu Boş Geçemezsiniz");

            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesajı Boş Geçemezsiniz");

            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen En Az 3 Karakter Girişi Yapın");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Lütfen En Az 100 Karakterden Fazla Karakter Girişi Yapmayın");

        }
    }
}
