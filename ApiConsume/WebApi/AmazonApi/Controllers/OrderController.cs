using AutoMapper;
using Business.Abstract;
using DtoLayer.Dtos;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AmazonApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
       private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public OrderController(IOrderService orderService, IMapper autoMapper)
        {
            _orderService = orderService;
            _mapper = autoMapper;
        }
        [HttpGet]
        public IActionResult Index()
        { var values = _orderService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddOrder(AddOrderDto addOrder) 
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Order>(addOrder);
            _orderService.TInsert(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateOrder(UpdateOrderDto updateOrder)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Order>(updateOrder);
            _orderService.TUpdate(values);
            return Ok();
        }
    }
}