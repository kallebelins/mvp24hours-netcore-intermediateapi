using Mvp24Hours.Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace IntermediateAPI.Core.Entity
{
    [DataContract(IsReference = false)]
    public partial class Product : EntityBaseLog<int, int>
    {
        #region [ Primitive members ]

        [DataMember]
        [Required]
        public int ProductCategoryId { get; set; }

        [DataMember]
        [Required]
        [StringLength(50)]
        public virtual string Name { get; set; }

        [DataMember]
        [StringLength(50)]
        public virtual string Description { get; set; }

        [DataMember]
        [Required]
        [DataType(DataType.Currency)]
        public decimal? UnitPrice { get; set; }

        #endregion

        #region [ Object members ]
        /// <summary>
        /// Gets or sets instance of the ProductCategory entity
        /// </summary>
        [DataMember]
        [ForeignKey(nameof(ProductCategoryId))]
        public virtual ProductCategory Category { get; set; }
        #endregion

        #region [ Collections members ]

        #endregion
    }

}
