using EdynamicsLog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EdynamicsLog.Application.Interfaces.Repositories
{
    public interface IProductRepositoryAsync : IGenericRepositoryAsync<Product>
    {
        Task<bool> IsUniqueBarcodeAsync(string barcode);
        Task<IReadOnlyList<Product>> GetPagedReponseSearchAsync(int pageNumber, int pageSize, string search);
        Task<IReadOnlyList<Product>> GetPagedReponseSearchByCategoryAsync(int idCategory, int pageNumber, int pageSize);
    }
}
