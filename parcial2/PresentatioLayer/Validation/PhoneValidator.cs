using FluentValidation;
using CommonLayer.Entities;

public class PhoneValidator : AbstractValidator<Phone>
{
    public PhoneValidator()
    {
        RuleFor(phone => phone.Model).NotEmpty().WithMessage("El modelo no puede estar vacío.");
        RuleFor(phone => phone.Brand).NotEmpty().WithMessage("La marca no puede estar vacía.");
        RuleFor(phone => phone.Price).GreaterThan(0).WithMessage("El precio debe ser mayor que cero.");
    }
}

