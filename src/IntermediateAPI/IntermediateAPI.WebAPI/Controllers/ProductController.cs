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
    public class ProductController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("")]
        public IList<Product> Get(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return FacadeService.ProductService.List();
            }
            else
            {
                return FacadeService.ProductService.GetBy(x => x.Name.Contains(name));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id:int}")]
        public Product GetId(int id)
        {
            return FacadeService.ProductService.GetById(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("")]
        public IActionResult Post([FromBody] Product model)
        {
            FacadeService.ProductService.Add(model);
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
        public IActionResult Put(int id, [FromBody] Product model)
        {
            model.Id = id;
            FacadeService.ProductService.Modify(model);
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
            FacadeService.ProductService.Remove(id);
            return NoContent();
        }
    }
}
