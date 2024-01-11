using EdynamicsLog.Application.Interfaces.Repositories;
using FluentValidation;
using System.Threading;
using System.Threading.Tasks;

namespace EdynamicsLog.Application.Features.Products.Commands.CreateProduct
{
    public class CreateCompanyCommandValidator : AbstractValidator<CreateProductCommand>
    {
        private readonly IProductRepositoryAsync productRepository;

        public CreateCompanyCommandValidator(IProductRepositoryAsync productRepository)
        {
            this.productRepository = productRepository;

            RuleFor(p => p.Barcode)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(8000).WithMessage("{PropertyName} must not exceed 50 characters.")
                .MustAsync(IsUniqueBarcode).WithMessage("{PropertyName} already exists.");

            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(8000).WithMessage("{PropertyName} must not exceed 50 characters.");

        }

        private async Task<bool> IsUniqueBarcode(string barcode, CancellationToken cancellationToken)
        {
            return await productRepository.IsUniqueBarcodeAsync(barcode);
        }
    }
}
