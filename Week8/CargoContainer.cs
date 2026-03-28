namespace Week8;

public class CargoContainer<T> where T: DeliveryItem
{
    private List<T> _items = new List<T>();
    public void AddItem(T item)
    {
        _items.Add(item);
    }

    public double GetTotalCost()
    {
        double result = 0;
        foreach (var i in _items)
        {
            result += i.CalculateCost();
        }

        return result;

    }
    
}