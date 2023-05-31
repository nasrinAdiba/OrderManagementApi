using System.ComponentModel.DataAnnotations;

namespace OrderManagementApi.Model
{
    public class OrderInfo
    {
        public int Id { get; set; }
        [Display(Name = "Item Name")]
        public string ItemName { get; set; }
        [Display(Name = "Unit Price")]
        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }

        public int Discount { get; set; }
        [Display(Name = "Order Invoice No")]
        public string OrderInvoiceNo { get; set; }
        [Display(Name = "Order Date & Time")]
        public DateTime OrderDateTime { get; set; }
        [Display(Name = "Total Price")]
        public decimal TotalPrice { get; set; }
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }
        [Display(Name = "Customer Address")]
        public string CustomerAddress { get; set; }
        [Display(Name = "Shipping Address")]
        public string ShippingAddress { get; set; }
        [Display(Name = "Shipping Date")]
        public DateTime ShippingDate { get; set; }
    }
}
