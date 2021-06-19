using System;

namespace DiplomaTest
{
    public class ProductsForBillOfLading
    {
        public string ProductName { get; set; }
        public int Quantity{ get; set; }
        public DateTime DeliveryDate { get; set; }
        public int OrderId { get; set; }
        public int CommodityExpertId { get; set; }
    }
}
