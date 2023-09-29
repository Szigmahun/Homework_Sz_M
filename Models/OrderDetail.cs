using Newtonsoft.Json;

namespace Homework_Sz_M.Models
{
    public class OrderDetail
    {
        [JsonProperty("OrderID")]
        public int OrderID { get; set; }
        [JsonProperty("ProductID")]
        public int ProductID { get; set; }
        [JsonProperty("UnitPrice")]
        public decimal UnitPrice { get; set; }
        [JsonProperty("Quantity")]
        public int Quantity { get; set; }
        [JsonProperty("Discount")]
        public decimal Discount { get; set; }
    }
}

