namespace WebMVC.Entity
{
    public class OrderDetail
    {
        public int OrderID { get; set; }
        public int DetailID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}
