namespace Inheritance;

public class Bird : Animal
{
    public Bird()
    {
        IsAlive = true;
        LegCount = 2;
        LandSeaAir = "Air";
        Age = 0;
    }
    public string WingColor { get; set; }
    public bool CanFly { get; set; } = true;
    public bool DoMigrate { get; set; } = true;
    public double BeakLength { get; set; }
}