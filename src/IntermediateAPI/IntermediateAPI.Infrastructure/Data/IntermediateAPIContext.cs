using IntermediateAPI.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Mvp24Hours.Infrastructure.Data;

namespace IntermediateAPI.Infrastructure.Data
{
    public class IntermediateAPIContext : Mvp24HoursContext
    {
        #region [ Ctor ]

        public IntermediateAPIContext()
            : base()
        {
        }

        public IntermediateAPIContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override bool CanApplyEntityLog => false;

        protected override object EntityLogBy => null;

        #endregion

        #region [ Sets ]

        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductCategory> ProductCategory { get; set; }

        #endregion
    }
}
