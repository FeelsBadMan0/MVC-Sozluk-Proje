﻿using EntityLayer.Concrate;
using FluentValidation;

namespace BusinessLayer.ValidatoinRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail adresini boş geçemezsiniz");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Adını Boş Geçemezsiniz");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adını Boş Geçemezsiniz");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen En Az 3 Karakter Girişi Yapın");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("Lütfen En Az 3 Karakter Girişi Yapın");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Lütfen 50 Karakterden Fazla Değer Girişi Yapmayın");
        }
    }
}
