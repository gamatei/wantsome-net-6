namespace StockManager
{
    public interface ICurrencyConverter
    {
        double Convert(double pricePerUnit, string currency);
    }
}