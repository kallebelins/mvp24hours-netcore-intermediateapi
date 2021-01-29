using IntermediateAPI.Application;
using IntermediateAPI.Core.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace IntermediateAPI.API.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("")]
        public IList<ProductCategory> Get(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return FacadeService.ProductCategoryService.List();
            }
            else
            {
                return FacadeService.ProductCategoryService.GetBy(x => x.Name.Contains(name));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id:int}")]
        public ProductCategory GetId(int id)
        {
            return FacadeService.ProductCategoryService.GetById(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("")]
        public IActionResult Post([FromBody] ProductCategory model)
        {
            FacadeService.ProductCategoryService.Add(model);
            return CreatedAtAction(nameof(Post), new { Id = model.Id }, model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult Put(int id, [FromBody] ProductCategory model)
        {
            model.Id = id;
            FacadeService.ProductCategoryService.Modify(model);
            return NoContent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete(int id)
        {
            FacadeService.ProductCategoryService.Remove(id);
            return NoContent();
        }
    }
}
