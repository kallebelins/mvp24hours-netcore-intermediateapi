using IntermediateAPI.Core.Entity;
using Mvp24Hours.Core.Contract.Domain.Specifications;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace IntermediateAPI.Core.Specifications.Category
{
    public class SpecialCategoryAllowsOneProductSpecification : ISpecificationValidator<Product>, ISpecificationQuery<Product>
    {
        public string KeyValidation => "CategoryAllowsOnlyOneProduct";

        public string MessageValidation => "This category allows only one product.";

        public Expression<Func<Product, bool>> IsSatisfiedByExpression => (x) => (x.ProductCategoryId == 1 && !x.Category.Products.Any());
    }
}
