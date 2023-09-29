using Newtonsoft.Json;

namespace Homework_Sz_M.Models
{
    public class Supplier
    {
        [JsonProperty("SupplierID")]
        public int SupplierID { get; set; }
        [JsonProperty("CompanyName")]
        public string CompanyName { get; set;}
    }
}
