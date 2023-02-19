namespace Basket.API.Models
{
    public class ShoppingCart
    {
        public ShoppingCart(string userName)
        {
            UserName = userName;
        }
        public ShoppingCart() 
        {
        }
        public string UserName { get; set; }
        public List<ShoppingCartItem> Items { get; set; }=new List<ShoppingCartItem>();
        public decimal TotalPrice { get
            {
                decimal totalPrice = 0;
                foreach (var item in Items)
                {
                    totalPrice += item.Price;
                }
                return totalPrice;
            } }
    }
}
