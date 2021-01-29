using IntermediateAPI.Core.Entity;
using Mvp24Hours.Core.Contract.Domain.Specifications;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace IntermediateAPI.Core.Requirements.Specifications.Category
{
    public class CategoryHasNotProductSpecification : ISpecificationValidator<ProductCategory>, ISpecificationQuery<ProductCategory>
    {
        public string KeyValidation => "CategoryHasNotProduct";

        public string MessageValidation => "Category has products.";

        public Expression<Func<ProductCategory, bool>> IsSatisfiedByExpression => (x) => !x.Products.Any();
    }
}
