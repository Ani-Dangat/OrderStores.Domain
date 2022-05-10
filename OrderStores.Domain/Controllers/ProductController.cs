using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderStores.Domain.Interfaces;
using OrderStores.Domain.Models;
namespace OrderStores.Domain.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpPost(nameof(CreateProduct))]
        public IActionResult CreateProduct(Product product)
        {
            var result = _unitOfWork.Products.Add(product);
            _unitOfWork.Complete();
            if (result is not null) return Ok("Product Created");
            else return BadRequest("Error in Creating the Product");
        }

        [HttpPut(nameof(UpdateProduct))]
        public IActionResult UpdateProduct(Product product)
        {
            _unitOfWork.Products.Update(product);
            _unitOfWork.Complete();
            return Ok("Product Updated");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
