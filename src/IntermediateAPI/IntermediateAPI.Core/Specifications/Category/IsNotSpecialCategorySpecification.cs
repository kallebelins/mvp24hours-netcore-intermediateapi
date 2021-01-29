using IntermediateAPI.Core.Entity;
using Mvp24Hours.Core.Contract.Domain.Specifications;
using System;
using System.Linq.Expressions;

namespace IntermediateAPI.Core.Requirements.Specifications.Category
{
    public class IsNotSpecialCategorySpecification : ISpecificationValidator<ProductCategory>, ISpecificationQuery<ProductCategory>
    {
        public string KeyValidation => "IsNotSpecialCategory";

        public string MessageValidation => "Special category.";

        public Expression<Func<ProductCategory, bool>> IsSatisfiedByExpression => (x) => x.Id != 1;
    }
}
