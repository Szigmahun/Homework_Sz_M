using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Homework_Sz_M.Model
{
    public class Product
    {
        [JsonProperty("ProductID")]
        public int ProductID { get; set; }

        [JsonProperty("ProductName")]
        public string ProductName { get; set; }

        //[JsonProperty("SupplierID")]
        //public int SupplierID { get; set; }
        //
        //[JsonProperty("CategoryID")]
        //public int CategoryID { get; set; }
        //[JsonProperty("QuantityPerUnit")]
        //public string QuantityPerUnit { get; set; }
        //[JsonProperty("UnitPrice")]
        //public decimal UnitPrice { get; set; }
        //[JsonProperty("UnitsInStock")]
        //public int UnitsInStock { get; set; }
        //[JsonProperty("ReorderLevel")]
        //public int ReorderLevel { get; set; }
        //[JsonProperty("Discontinued")]
        //public bool Discontinued { get; set; }


    }
}
