﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Streetsata.Restaurant.ProductAPI.DbContexts;
using Streetsata.Restaurant.ProductAPI.Models;
using Streetsata.Restaurant.ProductAPI.Models.Dto;

namespace Streetsata.Restaurant.ProductAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;

        public ProductRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<ProductDto> CreateUpdateProduct(ProductDto productDto)
        {
            Product? product = _mapper.Map<ProductDto, Product>(productDto);

            if (product.ProductId > 0)
                _db.Products.Update(product);
            else
                _db.Products.Add(product);

            await _db.SaveChangesAsync();

            return _mapper.Map<Product, ProductDto>(product);
        }

        public async Task<bool> DeleteProduct(int productId)
        {
            try
            {
                Product? product = await _db.Products.FirstOrDefaultAsync(u => u.ProductId == productId);
                if (product == null) { return false; }
                _db.Products.Remove(product);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<ProductDto> GetProductByIdAsync(int id)
        {
            Product? product = await _db.Products.Where(x => x.ProductId == id).FirstOrDefaultAsync();

            return _mapper.Map<ProductDto>(product);
        }

        public async Task<IEnumerable<ProductDto>> GetProductsAsync()
        {
            List<Product> productList = await _db.Products.ToListAsync();

            return _mapper.Map<List<ProductDto>>(productList);
        }
    }
}
