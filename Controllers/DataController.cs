using Homework_Sz_M.Abstractions.Services;
using Homework_Sz_M.Model;
using Homework_Sz_M.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Homework_Sz_M.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly IDataService _dataService;

        public DataController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet(nameof(GetData))]
        public async Task<IActionResult> GetData()
        {
            var result = await _dataService.GetAllProductsDataAsync();

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet(nameof(GetOrderAmountForSupplier))]
        public async Task<IActionResult> GetOrderAmountForSupplier(int supplierID)
        {
            var result = await _dataService.GetOrderAmountForSupplier(supplierID);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}
