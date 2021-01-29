using IntermediateAPI.Core.Contract.Logic;
using Mvp24Hours.Infrastructure.Helpers;

namespace IntermediateAPI.Application
{
    /// <summary>
    /// 
    /// </summary>
    public class FacadeService
    {
        #region [ Services ]
        public static IProductService ProductService
        {
            get { return HttpContextHelper.GetService<IProductService>(); }
        }
        public static IProductCategoryService ProductCategoryService
        {
            get { return HttpContextHelper.GetService<IProductCategoryService>(); }
        }
        #endregion
    }
}
