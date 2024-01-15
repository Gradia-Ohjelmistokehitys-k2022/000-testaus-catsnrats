using Warehouse;


namespace WareHouse
{

    public class WareHouse
    {

        private List<Stock> _stockOfItems;
        public void WareHouseSimulator()
        {
            _stockOfItems = new();
            Stock item1 = new("Hat", 2);
            Stock item2 = new("Shoes", 3);
            Stock item3 = new("Jacket", 5);

            _stockOfItems.Add(item1);
            _stockOfItems.Add(item2);
            _stockOfItems.Add(item3);
        }

        public WareHouse()
        {

        }

        public void AddToStocks(string itemName, int itemCount)
        {
            Stock stock = new(itemName, itemCount);
            _stockOfItems.Add(stock);
        }

        public bool InStock(string itemName)
        {
            return _stockOfItems.Any(item => item.ItemName == itemName && item.Quantity > 0);
        }

        public void TakeFromStock(string itemName, int quantity)
        {
            Stock? stock = null;
            if (InStock(itemName))
            {

                stock = _stockOfItems.FirstOrDefault(item => item.Quantity > 0);
                stock.Quantity -= quantity;
            }
            else
            {
                throw new Exception("Oversold " + stock.ItemName);
            }
        }

        public int StockCount(string itemName)
        {
            var matches = _stockOfItems.Where(item => item.ItemName == itemName);
            return matches.Count();
        }

    }

}

