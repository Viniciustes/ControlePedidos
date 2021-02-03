using Interface.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CidadeController : BaseController
    {
        public CidadeController(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Response(await _serviceProvider.GetService<IRepositoryCidade>().Get());
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Response(await _serviceProvider.GetService<IRepositoryCidade>().GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Find(int id)
        {
            return (Response());
        }

        //[HttpPost]
        //public async Task<IActionResult> Post([FromBody] EmpresaViewModel empresaViewModel)
        //{
        //    return (Response());
        //}

        //[HttpPut]
        //public async Task<IActionResult> Put([FromBody] EmpresaViewModel empresaViewModel)
        //{
        //    return (Response());
        //}

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Response(await _serviceProvider.GetService<IRepositoryCidade>().Remove(id));
        }
    }
}