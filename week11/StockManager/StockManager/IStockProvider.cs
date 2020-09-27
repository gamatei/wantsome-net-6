using System.Collections.Generic;

namespace StockManager
{
    public interface IStockProvider
    {
        List<StockElement> GetStock();
    }
}