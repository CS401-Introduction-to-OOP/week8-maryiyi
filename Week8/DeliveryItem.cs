namespace Week8;

public abstract class DeliveryItem
{
    private string TrackingNumber { get; set; }
    protected double Weight { get; set; }

    public DeliveryItem(string trackingNumber, double weight)
    {
        TrackingNumber = trackingNumber;
        Weight = weight;
    }

    public abstract double CalculateCost();

    public virtual void PrintInfo()
    {
        Console.WriteLine($"{TrackingNumber}, {Weight}");
    }
}