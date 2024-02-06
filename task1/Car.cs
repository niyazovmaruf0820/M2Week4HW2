namespace task1;

public class Car : IVehicle
{
    public int Gazolineamount { get; set; }
    public Car(int gazolineamount)
    {
        Gazolineamount += gazolineamount;
    }
    public void Drive()
    {
        if (Gazolineamount > 0) System.Console.WriteLine("Driving");
    }

    public bool Refuel(int gazoline)
    {
        Gazolineamount += gazoline;
        return true;
    }
}
