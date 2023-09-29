using Homework_Sz_M.Abstractions.Services;
using Homework_Sz_M.Model;
using Newtonsoft.Json;
using Microsoft.Extensions.Http;
using Homework_Sz_M.Models;
using Homework_Sz_M.Models.Dto.GetData;

namespace Homework_Sz_M.Services
{
    public class DataService : IDataService 
    {
        private readonly HttpClient _httpClient;

        public DataService(IHttpClientFactory httpClientFactory) 
        {
            _httpClient = httpClientFactory.CreateClient();
            _httpClient.BaseAddress = new Uri("https://services.odata.org/V4/Northwind/Northwind.svc/");
        }
        public async Task<List<Product>> GetAllProductsDataAsync()
        {
            HttpResponseMessage resp = await _httpClient.GetAsync("Products");
            resp.EnsureSuccessStatusCode();

            var json = await resp.Content.ReadAsStringAsync();
            dynamic data = JsonConvert.DeserializeObject<dynamic>(json);

            if (data != null)
            {
                var products = JsonConvert.DeserializeObject<List<Product>>(data.value.ToString());
                return products;
            }
            else
            {
                return null;
            }
        }

        public async Task<DetailsOrderDetail> GetOrderAmountForSupplier(int supplierID)
        {
            HttpResponseMessage resp = await _httpClient.GetAsync($"Order_Details?$top=10000&$filter=Product/Supplier/SupplierID eq {supplierID}");
            resp.EnsureSuccessStatusCode();

            var json = await resp.Content.ReadAsStringAsync();
            dynamic data = JsonConvert.DeserializeObject<dynamic>(json);

            if (data != null)
            {
                var products = JsonConvert.DeserializeObject<List<OrderDetail>>(data.value.ToString());
                var totalAmount = CalculateTotalAmount(products);
                DetailsOrderDetail orderDetail = new DetailsOrderDetail
                {
                    OrderID = supplierID,
                    TotalAmount = totalAmount
                };
                return orderDetail;
            }
            else
            {
                return null;
            }
        }

        private decimal CalculateTotalAmount(List<OrderDetail> orderDetails)
        {
            decimal total = 0;

            foreach (var order in orderDetails)
            {
                total += (order.UnitPrice * order.Quantity) * (1 - order.Discount);    
            }
            return total;
        }


        
    }
}
