using Homework_Sz_M.Model;
using Homework_Sz_M.Models;
using Homework_Sz_M.Models.Dto.GetData;

namespace Homework_Sz_M.Abstractions.Services
{
    public interface IDataService
    {
        Task<List<Product>> GetAllProductsDataAsync();
        Task<DetailsOrderDetail> GetOrderAmountForSupplier(int supplierID);
        Task<List<Supplier>> GetAllSupliers();
    }
}
