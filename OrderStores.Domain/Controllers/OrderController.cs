using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderStores.Domain.Repository;
using OrderStores.Domain.Interfaces;
using OrderStores.Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace OrderStores.Domain.Controllers
{
    public class OrderController : Controller
    {
       // [Route("api/[controller]")]
        //[ApiController]
        private readonly IUnitOfWork _unitOfWork;
        public OrderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/<Books>
        [HttpGet(nameof(GetOrders))]
        public async Task<IActionResult> GetOrders() => Ok(await _unitOfWork.Orders.GetAll());

        [HttpGet(nameof(GetOrderByName))]
        public async Task<IActionResult> GetOrderByName([FromQuery] string Genre) => Ok(await _unitOfWork.Orders.GetOrdersByOrderName(Genre));
        public IActionResult Index()
        {
            return View();
        }
    }
}
