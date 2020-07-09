using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SwaggerExample.WebApi.Dto;

namespace SwaggerExample.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class ExampleController : ControllerBase
    {

        public ExampleController()
        {
            
        }

        /// <summary>
        /// Get something
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get()
        {
            return Ok(await Task.FromResult("Got"));
        }

        /// <summary>
        /// Get something by id
        /// </summary>
        /// <param name="id"> ID to get</param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetWithId/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await Task.FromResult($"Got {id}"));
        }

        /// <summary>
        /// Post something using a model from request body
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Post")]
        public async Task<IActionResult> Post([FromBody]PostExampleDto model)
        {
            return Ok(await Task.FromResult($"{model.Prop1}, {model.Prop2} posted"));
        }

        /// <summary>
        /// Delete something by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("DeleteWithId/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await Task.FromResult($"{id} deleted"));
        }

        /// <summary>
        /// Put something using a model from request body
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("Put")]
        public async Task<IActionResult> Put([FromBody]PutExampleDto model)
        {
            return Ok(await Task.FromResult($"{model.Prop1}, {model.Prop2} put"));
        }


        /// <summary>
        /// Patch something using a model from request body
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPatch]
        [Route("Patch")]
        public async Task<IActionResult> Patch([FromBody]PatchExampleDto model)
        {
            return Ok(await Task.FromResult($"{model.Prop1}, {model.Prop2} patch"));
        }
    }
}
