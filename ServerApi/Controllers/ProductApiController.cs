﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerApi.Models;
using ServerApi.Repository;

namespace ServerApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductApiController : ControllerBase
	{
		private readonly IProductRepository _productRepository;
		public ProductApiController(IProductRepository productRepository)
		{
			_productRepository = productRepository;
		}

		[HttpGet]
		public async Task<IActionResult> GetProducts()
		{
			try
			{
				var products = await _productRepository.GetProductsAsync();
				return Ok(products);
			}
			catch (Exception ex)
			{
				// Handle exception
				return StatusCode(500, "Internal server error");
			}
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetProductById(int id)
		{
			try
			{
				var product = await _productRepository.GetProductByIdAsync(id);
				if (product == null)
					return NotFound();
				return Ok(product);
			}
			catch (Exception ex)
			{
				// Handle exception
				return StatusCode(500, "Internal server error");
			}
		}
		[HttpPost]
		public async Task<IActionResult> AddProduct([FromBody] ProductDto product)
		{
			try
			{
				await _productRepository.AddProductAsync(product);
				return CreatedAtAction(nameof(GetProductById), new { id = product.MaHH }, product);
			}
			catch (Exception ex)
			{
				// Handle exception
				return StatusCode(500, "Internal server error");
			}
		}
		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateProduct(int id, [FromBody] ProductDto product)
		{
			try
			{
                if (id != Convert.ToInt32(product.MaHH))
                    return BadRequest();
                await _productRepository.UpdateProductAsync(product);
				return NoContent();
			}
			catch (Exception ex)
			{
				// Handle exception
				return StatusCode(500, "Internal server error");
			}
		}
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteProduct(int id)
		{
			try
			{
				await _productRepository.DeleteProductAsync(id);
				return NoContent();
			}
			catch (Exception ex)
			{
				// Handle exception
				return StatusCode(500, "Internal server error");
			}
		}
	}
}
