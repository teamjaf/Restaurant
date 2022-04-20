using Mango.Services.ProductAPI.Models.Dtos;

namespace Mango.Services.ProductAPI.Repository;

public interface iProductRepository
{
     Task<IEnumerable<ProductDto>> GetProducts();
     Task<ProductDto> GetProductByID(int productId);
     Task<ProductDto> CreateUpdateProduct(ProductDto productDto);
     Task<bool> DeleteProduct(int productId);
}