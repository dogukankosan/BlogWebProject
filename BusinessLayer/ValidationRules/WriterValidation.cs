using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
	public class WriterValidation : AbstractValidator<Writer>
	{
        public WriterValidation()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı soyadı boş geçilemez.");
			RuleFor(x => x.WriterName).NotNull().WithMessage("Yazar adı soyadı boş geçilemez.");
			RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapın.");
			RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girişi yapın.");
			RuleFor(x => x.WriterName)
			.Matches(@"^[a-zA-Z\s]+$").WithMessage("Yazar adı soyadı sadece harf karakterinden oluşmalıdır.");
			RuleFor(x => x.WriterMail).NotNull().NotEmpty().WithMessage("Yazar mail boş geçilemez.");
			RuleFor(x => x.WriterMail).EmailAddress().WithMessage("Geçerli bir mail adresi giriniz.");
			RuleFor(x => x.WriterMail).MinimumLength(6).WithMessage("Mail adresi en az 6 karakterden oluşmalıdır.");
			RuleFor(x => x.WriterMail).MaximumLength(50).WithMessage("Mail adresi en fazla 50 karakterden oluşmalıdır.");
			RuleFor(x => x.WriterPassword).NotNull().NotEmpty().WithMessage("Şifre boş geçilemez.");
			RuleFor(x => x.WriterPassword).MaximumLength(50).WithMessage("Şifre en fazla 50 karakterden oluşmalıdır.");
			RuleFor(x => x.WriterPassword).MinimumLength(3).WithMessage("Şifre en az 3 karakterden oluşmalıdır.");	
		}
    }
}