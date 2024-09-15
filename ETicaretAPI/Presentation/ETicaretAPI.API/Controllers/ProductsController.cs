using ETicaretAPI.Application.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;

        readonly private IOrderWriteRepository _ordertWriteRepository;


        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository, IOrderWriteRepository ordertWriteRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
            _ordertWriteRepository = ordertWriteRepository;
        }

        [HttpGet]

        public async Task Get()
        {
            await _ordertWriteRepository.AddAsync(new() { Description = "bla bla", Address = "Ankara, Çankayaa" });
            await _ordertWriteRepository.AddAsync(new() { Description = "bla bla2", Address = "Ankara, Mamak" });
            await _ordertWriteRepository.SaveAsync();

        }
    }
}
