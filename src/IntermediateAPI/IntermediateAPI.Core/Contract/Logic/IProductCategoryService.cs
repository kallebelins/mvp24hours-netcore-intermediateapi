using IntermediateAPI.Core.Entity;
using Mvp24Hours.Core.Contract.Logic;

namespace IntermediateAPI.Core.Contract.Logic
{
    public interface IProductCategoryService : IQueryService<ProductCategory>, ICommandService<ProductCategory>
    {
    }
}
