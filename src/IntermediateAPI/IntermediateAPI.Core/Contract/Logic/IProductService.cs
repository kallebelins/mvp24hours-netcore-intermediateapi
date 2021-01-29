using IntermediateAPI.Core.Entity;
using Mvp24Hours.Core.Contract.Logic;

namespace IntermediateAPI.Core.Contract.Logic
{
    public interface IProductService : IQueryService<Product>, ICommandService<Product>
    {
    }
}
