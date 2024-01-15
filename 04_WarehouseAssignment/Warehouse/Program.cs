
using Warehouse;

namespace WareHouse

{
    internal class Program
    {
        // Tee ohjelmaan yksikkötestit.
        static void Main(string[] args)
        {
          
            WareHouse wareHouse = new();
            wareHouse.WareHouseSimulator();
        }
    }
}