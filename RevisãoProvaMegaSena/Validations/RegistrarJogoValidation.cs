using FluentValidation;
using RevisãoProvaMegaSena.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RevisãoProvaMegaSena.Validations
{
    public class RegistrarJogoValidation : AbstractValidator<MegaSena>
    {
        public RegistrarJogoValidation()
        {
           RuleFor(n => n.Numero1).LessThan(1).WithMessage("Numero nao pode ser menor que 1")
                .GreaterThan(60).WithMessage("Numero nao pode ser maior que 60")
                .NotEmpty().WithMessage("Não pode estar vazio")
                .NotNull();

            RuleFor(n => n.Numero2).LessThan(1).WithMessage("Numero nao pode ser menor que 1")
            .GreaterThan(60).WithMessage("Numero nao pode ser maior que 60")
            .NotEmpty().WithMessage("Não pode estar vazio")
            .NotNull();
           
            RuleFor(n => n.Numero3).LessThan(1).WithMessage("Numero nao pode ser menor que 1")
            .GreaterThan(60).WithMessage("Numero nao pode ser maior que 60")
            .NotEmpty().WithMessage("Não pode estar vazio")
            .NotNull();

            RuleFor(n => n.Numero4).LessThan(1).WithMessage("Numero nao pode ser menor que 1")
            .GreaterThan(60).WithMessage("Numero nao pode ser maior que 60")
            .NotEmpty().WithMessage("Não pode estar vazio")
            .NotNull();

            RuleFor(n => n.Numero5).LessThan(1).WithMessage("Numero nao pode ser menor que 1")
            .GreaterThan(60).WithMessage("Numero nao pode ser maior que 60")
            .NotEmpty().WithMessage("Não pode estar vazio")
            .NotNull();

            RuleFor(n => n.Numero6).LessThan(1).WithMessage("Numero nao pode ser menor que 1")
            .GreaterThan(60).WithMessage("Numero nao pode ser maior que 60")
            .NotEmpty().WithMessage("Não pode estar vazio")
            .NotNull();
        }
    }
}
 
