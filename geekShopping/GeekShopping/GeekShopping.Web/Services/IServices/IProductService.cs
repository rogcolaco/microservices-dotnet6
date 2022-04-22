using GeekShopping.Web.Models;

namespace GeekShopping.Web.Services.IServices {
    public interface IProductService {
        Task<IEnumerable<ProductModel>> FindlAllProducts(string token);
        Task<ProductModel> FindlProductById(long id, string token);
        Task<ProductModel> CreateProduct(ProductModel model, string token);
        Task<ProductModel> UpdateProduct(ProductModel model, string token);
        Task<bool> DeleteProductById(long id, string token);

    }
}
