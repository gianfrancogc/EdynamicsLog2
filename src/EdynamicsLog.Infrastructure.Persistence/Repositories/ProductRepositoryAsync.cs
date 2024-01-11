using EdynamicsLog.Application.Interfaces.Repositories;
using EdynamicsLog.Domain.Common;
using EdynamicsLog.Domain.Entities;
using EdynamicsLog.Infrastructure.Persistence.Contexts;
using EdynamicsLog.Infrastructure.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdynamicsLog.Infrastructure.Persistence.Repositories
{
    public class ProductRepositoryAsync : GenericRepositoryAsync<Product>, IProductRepositoryAsync
    {
        private readonly DbSet<Product> _products;

        public ProductRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            _products = dbContext.Set<Product>();
        }

        public Task<bool> IsUniqueBarcodeAsync(string barcode)
        {
            return _products
                .AllAsync(p => p.Barcode != barcode);
        }

        public async Task<IReadOnlyList<Product>> GetPagedReponseSearchAsync(int pageNumber, int pageSize, string search)
        {
            return await _products
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<IReadOnlyList<Product>> GetPagedReponseSearchByCategoryAsync(int idCategory, int pageNumber, int pageSize)
        {
            return await _products
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
