using IntermediateAPI.Core.Contract.Logic;
using IntermediateAPI.Core.Entity;
using IntermediateAPI.Core.Specifications.Category;
using Mvp24Hours.Business.Logic;
using Mvp24Hours.Core.Contract.Data;
using Mvp24Hours.Infrastructure.Validations;

namespace IntermediateAPI.Application.Logic
{
    public partial class ProductService : RepositoryService<Product, IUnitOfWork>, IProductService
    {
        public override int Add(Product entity)
        {
            var validator = new ValidatorEntityNotify<Product>()
                .AddSpecification<SpecialCategoryAllowsOneProductSpecification>();

            if (!validator.Validate(entity))
                return 0;

            return base.Add(entity);
        }

    }
}
