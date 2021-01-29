using IntermediateAPI.Core.Contract.Logic;
using IntermediateAPI.Core.Entity;
using IntermediateAPI.Core.Requirements.Specifications.Category;
using Mvp24Hours.Business.Logic;
using Mvp24Hours.Core.Contract.Data;
using Mvp24Hours.Infrastructure.Validations;

namespace IntermediateAPI.Application.Logic
{
    public partial class ProductCategoryService : RepositoryService<ProductCategory, IUnitOfWork>, IProductCategoryService
    {
        public override int Remove(ProductCategory entity)
        {
            var validator = new ValidatorEntityNotify<ProductCategory>()
                .AddSpecification<IsNotSpecialCategorySpecification>()
                .AddSpecification<CategoryHasNotProductSpecification>();

            if (!validator.Validate(entity))
                return 0;

            return base.Remove(entity);
        }
    }
}
