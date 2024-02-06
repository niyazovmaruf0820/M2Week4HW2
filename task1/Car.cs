namespace task1;

public class Car : IVehicle
{
    public int gazolineamount { get; set; }
    public void Drive()
    {
        if (gazolineamount > 0) System.Console.WriteLine("Driving");
    }

    public bool Refuel(int gazoline)
    {
        gazolineamount += gazoline;
        return true;
    }
}
